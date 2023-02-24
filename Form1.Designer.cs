namespace mpu过载测试
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.Pos1TextBox = new System.Windows.Forms.TextBox();
            this.Pos2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.axisComboBox = new System.Windows.Forms.ComboBox();
            this.disConnectButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.led = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.velTextBox = new System.Windows.Forms.TextBox();
            this.currentPlotView = new OxyPlot.WindowsForms.PlotView();
            this.label11 = new System.Windows.Forms.Label();
            this.slaveTextBox = new System.Windows.Forms.TextBox();
            this.mpuPlotView = new OxyPlot.WindowsForms.PlotView();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(24, 24);
            this.connectButton.Margin = new System.Windows.Forms.Padding(6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(148, 80);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "连接";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(336, 24);
            this.StartButton.Margin = new System.Windows.Forms.Padding(6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(148, 80);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "开始测试";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Pos1TextBox
            // 
            this.Pos1TextBox.Location = new System.Drawing.Point(78, 182);
            this.Pos1TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Pos1TextBox.Name = "Pos1TextBox";
            this.Pos1TextBox.Size = new System.Drawing.Size(144, 35);
            this.Pos1TextBox.TabIndex = 3;
            this.Pos1TextBox.Text = "0";
            // 
            // Pos2TextBox
            // 
            this.Pos2TextBox.Location = new System.Drawing.Point(338, 182);
            this.Pos2TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Pos2TextBox.Name = "Pos2TextBox";
            this.Pos2TextBox.Size = new System.Drawing.Size(144, 35);
            this.Pos2TextBox.TabIndex = 4;
            this.Pos2TextBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "A点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "B点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "延时";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(598, 183);
            this.delayTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(144, 35);
            this.delayTextBox.TabIndex = 9;
            this.delayTextBox.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "轴号";
            // 
            // axisComboBox
            // 
            this.axisComboBox.FormattingEnabled = true;
            this.axisComboBox.Location = new System.Drawing.Point(78, 133);
            this.axisComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.axisComboBox.Name = "axisComboBox";
            this.axisComboBox.Size = new System.Drawing.Size(664, 32);
            this.axisComboBox.TabIndex = 13;
            // 
            // disConnectButton
            // 
            this.disConnectButton.Location = new System.Drawing.Point(180, 24);
            this.disConnectButton.Margin = new System.Windows.Forms.Padding(6);
            this.disConnectButton.Name = "disConnectButton";
            this.disConnectButton.Size = new System.Drawing.Size(148, 80);
            this.disConnectButton.TabIndex = 16;
            this.disConnectButton.Text = "断开连接";
            this.disConnectButton.UseVisualStyleBackColor = true;
            this.disConnectButton.Click += new System.EventHandler(this.disConnectButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "当前状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "当前行数";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Location = new System.Drawing.Point(598, 312);
            this.lineLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(106, 24);
            this.lineLabel.TabIndex = 21;
            this.lineLabel.Text = "当前行数";
            // 
            // led
            // 
            this.led.Location = new System.Drawing.Point(174, 302);
            this.led.Margin = new System.Windows.Forms.Padding(6);
            this.led.Name = "led";
            this.led.Size = new System.Drawing.Size(52, 46);
            this.led.TabIndex = 22;
            this.led.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(492, 24);
            this.stopButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(148, 80);
            this.stopButton.TabIndex = 23;
            this.stopButton.Text = "停止测试";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "速度";
            // 
            // velTextBox
            // 
            this.velTextBox.Location = new System.Drawing.Point(78, 248);
            this.velTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.velTextBox.Name = "velTextBox";
            this.velTextBox.Size = new System.Drawing.Size(144, 35);
            this.velTextBox.TabIndex = 24;
            this.velTextBox.Text = "50";
            // 
            // currentPlotView
            // 
            this.currentPlotView.Location = new System.Drawing.Point(26, 358);
            this.currentPlotView.Margin = new System.Windows.Forms.Padding(6);
            this.currentPlotView.Name = "currentPlotView";
            this.currentPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.currentPlotView.Size = new System.Drawing.Size(600, 600);
            this.currentPlotView.TabIndex = 28;
            this.currentPlotView.Text = "plotView1";
            this.currentPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.currentPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.currentPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "从站号";
            // 
            // slaveTextBox
            // 
            this.slaveTextBox.Location = new System.Drawing.Point(340, 250);
            this.slaveTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.slaveTextBox.Name = "slaveTextBox";
            this.slaveTextBox.Size = new System.Drawing.Size(140, 35);
            this.slaveTextBox.TabIndex = 30;
            this.slaveTextBox.Text = "0";
            // 
            // mpuPlotView
            // 
            this.mpuPlotView.Location = new System.Drawing.Point(762, 358);
            this.mpuPlotView.Margin = new System.Windows.Forms.Padding(6);
            this.mpuPlotView.Name = "mpuPlotView";
            this.mpuPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.mpuPlotView.Size = new System.Drawing.Size(600, 600);
            this.mpuPlotView.TabIndex = 31;
            this.mpuPlotView.Text = "mpuPlotView";
            this.mpuPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.mpuPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.mpuPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(762, 2);
            this.logRichTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(692, 346);
            this.logRichTextBox.TabIndex = 1;
            this.logRichTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 962);
            this.Controls.Add(this.mpuPlotView);
            this.Controls.Add(this.slaveTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.currentPlotView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.velTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.led);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.disConnectButton);
            this.Controls.Add(this.axisComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pos2TextBox);
            this.Controls.Add(this.Pos1TextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "老化测试程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox Pos1TextBox;
        private System.Windows.Forms.TextBox Pos2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox axisComboBox;
        private System.Windows.Forms.Button disConnectButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Button led;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox velTextBox;
        private OxyPlot.WindowsForms.PlotView currentPlotView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox slaveTextBox;
        private OxyPlot.WindowsForms.PlotView mpuPlotView;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

