using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpu过载测试
{
    public delegate void GiveBuffer(params string[] str);

    public partial class ChangeBufferWindow : Form
    {
        public GiveBuffer give;
        public ChangeBufferWindow()
        {
            InitializeComponent();
        }
        public ChangeBufferWindow(int axis)
        {
            InitializeComponent();
            for (int i = 0; i < axis; i++)
            {
                axisComboBox.Items.Add(i);
            }
            if (axis != 0)
            {
                axisComboBox.SelectedIndex = 0;
            }
        }


        private void ChangeBufferWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] row = { axisComboBox.Text, Pos1TextBox.Text, Pos2TextBox.Text, delayTextBox.Text, speedTextBox.Text, TimesTextBox.Text };
            give(row);
        }
    }
}
