using ACS.SPiiPlusNET;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace mpu过载测试
{
    public partial class Form1 : Form
    {
        private Api ch = null;

        private bool m_connect = false;

        private PlotModel mode = null;
        private LineSeries LineSeries = null;
        private LineSeries MpuLineSeries = null;

        //从站号
        private int m_slavenum = 0;

        public Form1()
        {
            InitializeComponent();
            ch = new Api();

            var model = new PlotModel { Title = "电流值曲线" };
            LineSeries = new LineSeries();
            model.Series.Add(LineSeries);
            currentPlotView.Model = model;

            var model1 = new PlotModel { Title = "MPU使用率" };
            MpuLineSeries = new LineSeries();
            model1.Series.Add(MpuLineSeries);
            mpuPlotView.Model = model1;
        }

        private void UpdateLog(string log, string funcname = "")
        {
            logRichTextBox.Text += $"{DateTime.Now} {funcname}: {log}\n";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ch.OpenCommEthernetTCP("10.0.0.100", 701);
                //ch.OpenCommSimulator();
                int axis = (int)ch.GetAxesCount();
                for (int i = 0; i < axis; i++)
                {
                    axisComboBox.Items.Add(i);
                }
                axisComboBox.SelectedIndex = 0;
                int buffer = (int)ch.GetBuffersCount();

                UpdateLog("连接成功", "connectButton_Click");
                m_connect = true;
                timer2.Start();//test

                m_slavenum = Convert.ToInt32(slaveTextBox.Text);
            }
            catch (ACSException ex)
            {
                UpdateLog(ex.Message);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!m_connect) { return; }
            Axis axis = (Axis)axisComboBox.SelectedIndex;
            ch.Enable(axis);
            double speed = Convert.ToDouble(velTextBox.Text);
            ch.SetVelocity(axis, speed);
            ch.SetAcceleration(axis, speed * 10);
            ch.SetDeceleration(axis, speed * 10);
            ch.SetKillDeceleration(axis, speed * 100);
            ch.SetJerk(axis, speed * 100);
            timer1.Start();
            timer2.Start();
            UpdateLog($"开始测试", "CreateBuffer");
        }

        private void disConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                timer2.Stop();
                ch.CloseComm();
                UpdateLog("断开连接，停止测试", "disConnectButton_Click");
                m_connect = false;
            }
            catch (ACSException ex)
            {
                UpdateLog(ex.Message);
            }
        }

        private void intervalTextBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            UpdateLog("更改时间，自动停止检测，请重新开始", "intervalTextBox_TextChanged");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!m_connect) { return; }
            UpdateState();
            UpdateLines();
        }

        private double xx = 0;

        private void UpdateLines()
        {
            double currentY = Convert.ToDouble(ch.Transaction($"?GETSP({m_slavenum},GETSPA({m_slavenum},\"axes[{axisComboBox.SelectedIndex}].command\"))"));
            LineSeries.Points.Add(new DataPoint(xx, currentY));

            double mpuY = Convert.ToDouble(ch.Transaction($"?USAGE"));
            MpuLineSeries.Points.Add(new DataPoint(xx, mpuY));

            xx++;
            this.currentPlotView.Model.InvalidatePlot(true);
            this.mpuPlotView.Model.InvalidatePlot(true);
            Thread.Sleep(50);
        }

        private void UpdateState()
        {
            try
            {
                logRichTextBox.Select(logRichTextBox.TextLength, 0);
                logRichTextBox.ScrollToCaret();
            }
            catch
            {
                timer1.Stop();
                timer2.Stop();
                //ch.CloseComm();
                UpdateLog("控制器与上位机通讯中断", "timer2_Tick");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            UpdateState();
            ch.Kill((Axis)axisComboBox.SelectedIndex);
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!m_connect) { return; }
            Axis axis = (Axis)axisComboBox.SelectedIndex;
            double posA = Convert.ToDouble(Pos1TextBox.Text);
            double posB = Convert.ToDouble(Pos2TextBox.Text);
            double pos = 0;
            if (posA == ch.GetFPosition(axis))
                pos = posB;
            else if (posB == ch.GetFPosition(axis))
                pos = posA;
            if ("1" == ch.Transaction($"?MST({axisComboBox.SelectedIndex}).#INPOS").Trim())
                ch.ToPoint(MotionFlags.ACSC_NONE, axis, pos);
        }
    }
}