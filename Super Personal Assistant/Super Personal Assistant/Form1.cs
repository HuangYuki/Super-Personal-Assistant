using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Super_Personal_Assistant
{
    public partial class Form1 : Form
    {
        private DateTime selectedDate;
        
        //init
        public Form1()
        {
            InitializeComponent();
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
        }

        //點擊兩下 小圖示
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
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
            //通知小視窗
            notifyIcon.ShowBalloonTip(1000, "哈囉", "我只是縮小而已，還沒關閉", ToolTipIcon.Warning);
            notifyIcon.ShowBalloonTip(1000, "哈囉", "點我右鍵關閉", ToolTipIcon.Info);
        }

        //右鍵小圖示，關閉程式
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //click新增按鈕
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            Schedule ss = new Schedule();
            ss.SetDate(selectedDate);
            ss.SetTask(textBox1.Text);
            DateItem di = new DateItem();
            di.Date = selectedDate;
            di.BackColor1 = Color.Yellow;
            monthCalendar.AddDateInfo(di);
            
            notifyIcon.ShowBalloonTip(1000, "新增活動", selectedDate.Year.ToString() + "/" + 
                selectedDate.Month.ToString() + "/" +
                selectedDate.Day.ToString() + "/" +
                " : " + textBox1.Text, ToolTipIcon.Info);
            
        }

        private void monthCalendar_DayClick(object sender, DayClickEventArgs e)
        {
            selectedDate = Schedule.StringToDate(e.Date);
        }


    }
}
