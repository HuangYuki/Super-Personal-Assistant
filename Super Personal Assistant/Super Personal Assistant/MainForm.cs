using Pabo.Calendar;
using Super_Personal_Assistant.Class;
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
    public partial class MainForm : Form
    {
        public const int SCHEDULE = 0;
        public const int ACCOUNT = 1;

        private DateTime selectedDate;
        private Schedule _schedule = new Schedule();
        private List<Account> _account = new List<Account>();

        //=之後要分到別的SCRIPT去===================
        public void AddActivity(Activity a)
        {
            //新增活動(不是UI)
            _schedule.addNewActivity(a);

            //標示到日曆物件上
            DateItem di = new DateItem();
            di.Date = new DateTime(a.Date.Year, a.Date.Month, a.Date.Day);
            di.BackColor1 = Color.Yellow;
            monthCalendar.AddDateInfo(di);

            //提醒使用者創建成功
            notifyIcon.ShowBalloonTip(1000, "新增活動", a.Date.Year.ToString() + "/" +
                 a.Date.Month.ToString() + "/" +
                 a.Date.Day.ToString() + "-" +
                 a.Date.Hour + ":" +
                 a.Date.Minute, ToolTipIcon.Info);

        }

        public void AddAccount(Account account)
        {
            //(不是UI)
            _account.Add(account);

            //標示到ListView
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = (accountListView.Items.Count + 1).ToString();

            ListViewItem.ListViewSubItem lvSubItem = new ListViewItem.ListViewSubItem();
            lvSubItem.Text = account.Date.ToShortDateString();
            lvItem.SubItems.Add(lvSubItem);

            lvSubItem = new ListViewItem.ListViewSubItem();
            lvSubItem.Text = account.ItemName;
            lvItem.SubItems.Add(lvSubItem);

            lvSubItem = new ListViewItem.ListViewSubItem();
            lvSubItem.Text = account.Cost.ToString();
            lvItem.SubItems.Add(lvSubItem);

            accountListView.Items.Add(lvItem);

        }


        //================================================
        //init
        public MainForm()
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

        //click新增行程按鈕
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            InputForm addForm = new InputForm(selectedDate, _schedule.Count());
            addForm.Owner = this;
            addForm.SetType(SCHEDULE);
            addForm.ShowDialog();

            List<Activity> a = _schedule.checkHasActivity(selectedDate);
            if (a != null)
            {
                label.Text = "";
                for (int i = 0; i < a.Count; i++)
                    label.Text += a[i].Date.ToShortTimeString() + "  -" + a[i].Title + " \n " + a[i].Body + "\n\n";
            }
        }

        //所點選的日期改變
        private void monthCalendar_DayClick(object sender, DayClickEventArgs e)
        {
            label.Text = "";
            selectedDate = Activity.StringToDate(e.Date);
            List<Activity> a = _schedule.checkHasActivity(selectedDate);
            if (a != null)
            {
                for (int i=0;i<a.Count;i++)
                    label.Text += a[i].Date.ToShortTimeString() + "  -" + a[i].Title + " \n " + a[i].Body + "\n\n";
            }
        }


        //Clock
        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            Activity a = _schedule.TimeOut(DateTime.Now);
            if (a != null)
            {
                notifyIcon.ShowBalloonTip(1000, "活動", a.Title + " : " + a.Body, ToolTipIcon.Info);
            }

        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            InputForm a = new InputForm(DateTime.Now,0);
            a.Owner = this;
            a.SetType(ACCOUNT);
            a.ShowDialog();
        }

        private void accountListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
