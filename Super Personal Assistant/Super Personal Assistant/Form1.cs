using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Super_Personal_Assistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
        }


        private void monthCalendar1_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
           
        }

        //案關閉 縮小成小圖示
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            this.ShowInTaskbar = false;
            //提示工具
            notifyIcon1.ShowBalloonTip(1000, "哈囉", "我只是縮小而已，還沒關閉", ToolTipIcon.Info);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
