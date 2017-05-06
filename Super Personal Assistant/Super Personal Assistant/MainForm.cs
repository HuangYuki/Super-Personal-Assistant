using Pabo.Calendar;
using Super_Personal_Assistant.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Super_Personal_Assistant
{
    public partial class MainForm : Form
    {
        public const int SCHEDULE = 0;
        public const int ACCOUNT_ADD = 1;
        public const int ACCOUNT_EDIT = 2;

        private DateTime selectedDate;
        private ScheduleManagement _schedule = new ScheduleManagement();
        private AccountItemManagement _account = new AccountItemManagement();

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

        public void AddAccount(AccountItem account)
        {
            //新增一筆account(不是UI)
            _account.addNewAccountItem(account);

            //標示到ListView
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = account.Id.ToString();

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

        public void EditAccount(int id,int cost ,String name)
        {
            
            _account.changeAccountItem(id, cost, name);
            //Name
            accountListView.SelectedItems[0].SubItems[2].Text = name;
            //Cost
            accountListView.SelectedItems[0].SubItems[3].Text = cost.ToString();

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
            InputForm a = new InputForm(DateTime.Now,accountListView.Items.Count + 1);
            a.Owner = this;
            a.SetType(ACCOUNT_ADD);
            a.ShowDialog();
        }

        private void accountListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count != 0)
                edirAccountButton.Enabled = true;
            else
                edirAccountButton.Enabled = false;

        }

        private void edirAccountButton_Click(object sender, EventArgs e)
        {
            String selectedAccountItemId =accountListView.SelectedItems[0].SubItems[0].Text;
            InputForm a = new InputForm(DateTime.Now, accountListView.SelectedItems[0].Index);
            a.Owner = this;
            a.SetType(ACCOUNT_EDIT);
            a.ShowDialog();
        }


        //testing use
        private void print(String s)
        {
            notifyIcon.ShowBalloonTip(1000, "test",s, ToolTipIcon.Info);
        }
    }
}
