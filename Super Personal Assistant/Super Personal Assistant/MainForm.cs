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
        public const int SCHEDULE_ADD = 0;
        public const int SCHEDULE_EDIT = 1;
        public const int ACCOUNT_ADD = 2;
        public const int ACCOUNT_EDIT = 3;

        private DateTime selectedDate = DateTime.Today;
        private ScheduleManagement _schedule = new ScheduleManagement();
        private AccountItemManagement _account = new AccountItemManagement();

        //=之後要分到別的SCRIPT去===================
        public void AddActivity(Activity a)
        {
            //新增活動(不是UI)
            _schedule.addNewActivity(a);


            //確認是否已經標記過(如果沒有標記過，就標記在日曆物件)
            if (monthCalendar.Dates.IndexOf(new DateTime(a.Date.Year, a.Date.Month, a.Date.Day)) < 0)
            {
                //標示到日曆物件上
                DateItem di = new DateItem();
                di.Date = new DateTime(a.Date.Year, a.Date.Month, a.Date.Day);
                di.BackColor1 = Color.Yellow;
                monthCalendar.AddDateInfo(di);
            }

            //提醒使用者創建成功
            notifyIcon.ShowBalloonTip(1000, "新增活動", a.Date.Year.ToString() + "/" +
                 a.Date.Month.ToString() + "/" +
                 a.Date.Day.ToString() + "-" +
                 a.Date.Hour + ":" +
                 a.Date.Minute, ToolTipIcon.Info);

            ShowSelectedDateActivities(selectedDate);
        }

        public void EditActivity(int id, string title, string body)
        {
            _schedule.changeActivity(id, title, body);

            eventListView.SelectedItems.Clear();
            ShowSelectedDateActivities(selectedDate);
        }

        public void AddAccount(AccountItem account)
        {
            //新增一筆account(不是UI)
            _account.addNewAccountItem(account);

            ShowAccounts();

            //顯示總價
            totalMoneyLabel.Text = "$" + _account.getTotal().ToString();            
        }

        public void EditAccount(int id, int cost, String name)
        {
            _account.changeAccountItem(id, cost, name);

            ShowAccounts();
            accountListView.SelectedItems.Clear();

            //顯示總價
            totalMoneyLabel.Text = "$" + _account.getTotal().ToString();
        }

        ////顯示選取日期的活動
        private void ShowAccounts()
        {
            int listAmount = accountListView.Items.Count;
            for (int listIndex = 0; listIndex < listAmount; listIndex++)
                accountListView.Items.RemoveAt(0);

            List<AccountItem> accountItems = _account.GetAccountList();
            for (int listIndex = 0; listIndex < accountItems.Count; listIndex++)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = accountItems[listIndex].Id.ToString();

                ListViewItem.ListViewSubItem timelvSubItem = new ListViewItem.ListViewSubItem();
                timelvSubItem.Text = accountItems[listIndex].Date.ToShortDateString();
                lvItem.SubItems.Add(timelvSubItem);

                ListViewItem.ListViewSubItem titlelvSubItem = new ListViewItem.ListViewSubItem();
                titlelvSubItem.Text = accountItems[listIndex].ItemName;
                lvItem.SubItems.Add(titlelvSubItem);

                ListViewItem.ListViewSubItem bodylvSubItem = new ListViewItem.ListViewSubItem();
                bodylvSubItem.Text = accountItems[listIndex].Cost.ToString();
                lvItem.SubItems.Add(bodylvSubItem);

                accountListView.Items.Add(lvItem);
            }
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
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            this.ShowInTaskbar = false;
            //通知小視窗
            notifyIcon.ShowBalloonTip(1000, "超牛個人助理最小化", "點擊工具列圖示右鍵關閉", ToolTipIcon.Info);
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
            addForm.SetType(SCHEDULE_ADD);
            addForm.ShowDialog();
        }

        //click編輯行程按鈕
        private void editTaskButton_Click(object sender, EventArgs e)
        {
            int selectedEventItemId = Convert.ToInt32(eventListView.SelectedItems[0].SubItems[0].Text);
            InputForm a = new InputForm(selectedDate, selectedEventItemId);
            a.Owner = this;
            a.SetType(SCHEDULE_EDIT);
            a.ShowDialog();
        }

        //click刪除行程按鈕
        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            int selectedEventItemIndex = Convert.ToInt32(eventListView.SelectedItems[0].SubItems[0].Text);
            _schedule.deleteActivity(selectedEventItemIndex);

            ShowSelectedDateActivities(selectedDate);

            //確定該天行程已經清空
            if (eventListView.Items.Count == 0)
                //刪除該天的標記
                monthCalendar.Dates.RemoveAt(monthCalendar.Dates.IndexOf(selectedDate));

        }

        //所點選的日期改變
        private void monthCalendar_DayClick(object sender, DayClickEventArgs e)
        {
            selectedDate = Tool.StringToDate(e.Date);
            ShowSelectedDateActivities(selectedDate);
        }

        //顯示選取日期的活動
        private void ShowSelectedDateActivities(DateTime sDate)
        {
            int listAmount = eventListView.Items.Count;
            for (int listIndex = 0; listIndex < listAmount; listIndex++)
                eventListView.Items.RemoveAt(0);

            List<Activity> activities = _schedule.checkHasActivity(sDate);
            if (activities != null)
            {
                for (int listIndex = 0; listIndex < activities.Count; listIndex++)
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = activities[listIndex].Id.ToString();

                    ListViewItem.ListViewSubItem timelvSubItem = new ListViewItem.ListViewSubItem();
                    timelvSubItem.Text = activities[listIndex].Date.ToShortTimeString();
                    lvItem.SubItems.Add(timelvSubItem);

                    ListViewItem.ListViewSubItem titlelvSubItem = new ListViewItem.ListViewSubItem();
                    titlelvSubItem.Text = activities[listIndex].Title;
                    lvItem.SubItems.Add(titlelvSubItem);

                    ListViewItem.ListViewSubItem bodylvSubItem = new ListViewItem.ListViewSubItem();
                    bodylvSubItem.Text = activities[listIndex].Body;
                    lvItem.SubItems.Add(bodylvSubItem);

                    eventListView.Items.Add(lvItem);
                }
            }
        }

        //點選eventListView中的項目
        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListView.SelectedItems.Count != 0)
            {
                editTaskButton.Enabled = true;
                deleteTaskButton.Enabled = true;
            }
            else
            {
                editTaskButton.Enabled = false;
                deleteTaskButton.Enabled = false;
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

        //點擊新增記帳功能
        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            InputForm a = new InputForm(DateTime.Now);
            a.Owner = this;
            a.SetType(ACCOUNT_ADD);
            a.ShowDialog();
        }

        //點擊編輯記帳按鈕
        private void editAccountButton_Click(object sender, EventArgs e)
        {
            int selectedAccountItemIndex = Convert.ToInt32(accountListView.SelectedItems[0].SubItems[0].Text);
            InputForm a = new InputForm(DateTime.Now, selectedAccountItemIndex);
            a.Owner = this;
            a.SetType(ACCOUNT_EDIT);
            a.ShowDialog();
        }

        //點擊刪除記帳按鈕
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            int selectedAccountItemIndex = Convert.ToInt32(accountListView.SelectedItems[0].SubItems[0].Text);
            _account.deleteAccountItem(selectedAccountItemIndex);

            ShowAccounts();

            //顯示總價
            totalMoneyLabel.Text = _account.getTotal().ToString();
        }

        //點選accountListView中的項目
        private void accountListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count != 0)
            {
                editAccountButton.Enabled = true;
                deleteAccountButton.Enabled = true;
            }
            else
            {
                editAccountButton.Enabled = false;
                deleteAccountButton.Enabled = false;
            }
        }

        //testing use
        private void print(String s)
        {
            notifyIcon.ShowBalloonTip(1000, "test", s, ToolTipIcon.Info);
        }
    }
}
