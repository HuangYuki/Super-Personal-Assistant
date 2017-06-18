using Pabo.Calendar;
using Super_Personal_Assistant.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Server.Class;

namespace Super_Personal_Assistant
{
    public partial class MainForm : Form
    {
		ClientAccount _myAccount;
		ClientSocket _clientsocket;
		StrHandler msgHandler;
		ConectionSetting createConnection;
		List<String> friendRequestList = new List<string>();  //存放好友邀請
		List<String> friendAccountList = new List<string>();  //存放好友帳號
		List<String> messageList = new List<string>();  //存放聊天列表
		String _userAccount = "";  //目前使用的用戶帳號
		String _userPassword = "";  //目前使用的用戶密碼
		String chatInputTemp = "";  //要寄出的聊天訊息暫存
		String chatFriend = "";  //要聊天的好友
		String newFriend = "";  //要新增的好友暫存
		String friendAccountTemp = "";  //暫存欲加入好友帳號

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
            //傳輸
            List<string> tmp = _schedule.saveData(_myAccount.Account);
            for(int i = 0; i< tmp.Count; i++)
            {
                sentData(tmp[i]);
            }

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
            //傳輸
            List<string> tmp = _schedule.saveData(_myAccount.Account);
            for (int i = 0; i < tmp.Count; i++)
            {
                sentData(tmp[i]);
            }
            eventListView.SelectedItems.Clear();
            


        }

        public void AddAccount(AccountItem account)
        {
            //新增一筆account(不是UI)
            _account.addNewAccountItem(account);
            //傳輸
            List<string> tmp = _account.saveData(_myAccount.Account);
            for (int i = 0; i < tmp.Count; i++)
            {
                sentData(tmp[i]);
            }
            ShowAccounts();

            //顯示總價
            totalMoneyLabel.Text = "$" + _account.getMoneyTotal().ToString();            
        }

        public void EditAccount(int id, int cost, String name)
        {
            _account.changeAccountItem(id, cost, name);
            //傳輸
            List<string> tmp = _account.saveData(_myAccount.Account);
            for (int i = 0; i < tmp.Count; i++)
            {
                sentData(tmp[i]);
            }
            ShowAccounts();
            accountListView.SelectedItems.Clear();

            //顯示總價
            totalMoneyLabel.Text = "$" + _account.getMoneyTotal().ToString();
        }

        ////顯示選取日期的活動
        private void ShowAccounts()
        {
            int listAmount = accountListView.Items.Count;
            for (int listIndex = 0; listIndex < listAmount; listIndex++)
                accountListView.Items.RemoveAt(0);

            List<AccountItem> accountItems = _account.getList();
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
            //_schedule.recieveData();
            //_account.recieveData();

			_myAccount = new ClientAccount();
			msgHandler = this.addMsg;
			createConnection = new ConectionSetting();
			secretTextBox.PasswordChar = '*';  //輸入密碼時顯示為"*"

            this.mainPage.Parent = this.mainTabControl;  //隱藏登入分頁
            this.friendTabPage.Parent = null; //顯示好友分頁
            this.calendarTabPage.Parent = null; //顯示行事曆分頁
            this.accountTabPage.Parent = null; //顯示記帳分頁
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
            //傳輸
            List<string> tmp = _schedule.saveData(_myAccount.Account);
            for (int i = 0; i < tmp.Count; i++)
            {
                sentData(tmp[i]);
            }
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

        private void TagHasTaskDay()
        {
            List<Activity> allTask = _schedule.getList();
            foreach(Activity task in allTask)
            {
                DateItem di = new DateItem();
                di.Date = task.Date;
                di.BackColor1 = Color.Yellow;
                monthCalendar.AddDateInfo(di);
            }
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

            //傳輸
            List<string> tmp = _account.saveData(_myAccount.Account);
            for (int i = 0; i < tmp.Count; i++)
            {
                sentData(tmp[i]);
            }

            ShowAccounts();

            //顯示總價
            totalMoneyLabel.Text = _account.getMoneyTotal().ToString();
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

		private void logInButton_Click(object sender, EventArgs e)
		{
			_userAccount = accountTextBox.Text;
			_userPassword = secretTextBox.Text;
			if (_userAccount == "" || _userPassword == "" || !accountTextBox.Text.IsNaturalNumber() || !secretTextBox.Text.IsNaturalNumber())
			{
				MessageBox.Show("帳戶或密碼格式不符！！！");
			}
			else
			{
				string dataString = "1" + "_" + _userAccount + "_" + _userPassword;
				sentData(dataString);
			}
		}

		public void sentData(string userData)  //傳送訊息到Server
		{

			if (_clientsocket == null)
			{
				_clientsocket = ClientSocket.connect(ConectionSetting.serverIp);
				_clientsocket.newListener(processMsgComeIn);
			}
			_clientsocket.send(userData);

			foreach (Control item in Controls)
			{
				item.Text = item is TextBox ? "" : item.Text; //如果是textbox那就清空否則保持原狀
			}
		}

		public String processMsgComeIn(String msg)
		{
			this.Invoke(msgHandler, new Object[] { msg });
			return "OK";
		}

		public String addMsg(String msg)  //Server回傳的訊息
		{
            if (msg[0] == '1')  //判斷登入是否成功
            {
                if (msg != "1_FALSE")
                {
                    MessageBox.Show("登入成功");
                    _myAccount.Account = _userAccount;
                    _myAccount.Passward = _userPassword;
                    _myAccount.Name = seperateGetData(msg)[1];

                    this.mainPage.Parent = null;  //隱藏登入分頁
                    this.friendTabPage.Parent = this.mainTabControl; //顯示好友分頁
                    this.calendarTabPage.Parent = this.mainTabControl; //顯示行事曆分頁
                    this.accountTabPage.Parent = this.mainTabControl; //顯示記帳分頁

                    mainTabControl.SelectedTab = friendTabPage;

                    userLabel.Text = userLabel.Text + " " + _myAccount.Name;
                }
                else
                {
                    MessageBox.Show("登入失敗");
                }
            }
            else if (msg[0] == '2')
            {
                if (msg == "2_OK")  //歷史訊息傳輸結束之後載入到聊天室中
                {
                    loadingHistoryMessage();
                    sendMessageTextBox.Enabled = true;
                }
                else  //接收歷史訊息並加到List中
                {
                    messageList.Add(seperateGetData(msg)[1]);
                }
            }
            else if (msg[0] == '3')  //判斷好友新增
            {
                if (msg == "3_OK")  //該user存在
                {
                    MessageBox.Show(_userAccount + "邀請已寄出");

                    friendAccountList.Add(newFriend);  // 成功送出好友後先新增到好友列表

                    friendDataGridView.Rows.Clear();
                    for (int i = 0; i < friendAccountList.Count; i++)
                    {
                        String[] row = new String[] { friendAccountList[i] };
                        friendDataGridView.Rows.Add(row);
                        friendDataGridView.AutoResizeColumns();
                    }
                }
                else if (msg == "3_FALSE") //該user account不存在
                {
                    MessageBox.Show("邀請寄送失敗");
                }
                else if (msg == "3_EXIST")
                {
                    MessageBox.Show("好友已存在！");
                }
                else if (msg[0] == '3' && msg[1] == '1')  //對方已有自己好友
                {

                }
                else  //已收到該user好友邀請
                {
                    friendRequestList.Add(seperateGetData(msg)[1]);
                    MessageBox.Show(_userAccount + "收到邀請");

                    initilizeRequestRow();
                }
            }
            else if (msg[0] == '4')
            {
                if (msg == "4_OK")
                {
                    MessageBox.Show("收到訊息");
                }
                else if (msg == "4_FALSE")
                {
                    MessageBox.Show("接收訊息失敗");
                }
                else if (msg == "4_NOTFOUND")
                {
                    MessageBox.Show("該用戶不在線上");
                }
                else  //接收對方訊息 4_朋友帳號_訊息內容
                {
                    messageList.Add(seperateGetData(msg)[2]);
                    chatInputTemp = chatFriend + " : " + seperateGetData(msg)[2];
                    messageList.Add(chatInputTemp);
                    chatroomRichTextBox.Text += chatInputTemp + "\n";
                    chatInputTemp = "";
                }
            }
            else if (msg[0] == '5')
            {
                if (msg == "5_OK")
                {
                    ShowAccounts();
                    totalMoneyLabel.Text = _account.getMoneyTotal().ToString();
                }
                else
                {
                    _account.recieveData(msg);

                }
            }
            else if (msg[0] == '6')
            {
                if (msg == "6_OK")
                {
                    TagHasTaskDay();
                    ShowSelectedDateActivities(selectedDate);
                }
                else {
                    _schedule.recieveData(msg);

                }
            }
            else if (msg[0] == '9') //朋友初始化
            {
                if (msg == "9_OK")
                {
                    friendDataGridView.Rows.Clear();
                    for (int i = 0; i < friendAccountList.Count; i++)
                    {
                        String[] row = new String[] { friendAccountList[i] };
                        friendDataGridView.Rows.Add(row);
                        friendDataGridView.AutoResizeColumns();
                    }
                }
                else
                {
                    Console.WriteLine("assa");
                    friendAccountList.Add(seperateGetData(msg)[1]);
                }
            }
			return "OK";
		}

		public String[] seperateGetData(string data) //分離資料
		{
			char space = '_';
			string[] words = null;

			words = data.Split(space);

			return words;
		}

		private void sendInvitebutton_Click(object sender, EventArgs e)
		{
			string _friendaccount = friendAccountTextBox.Text;

			if (_friendaccount == "" || !friendAccountTextBox.Text.IsNaturalNumber())
			{
				MessageBox.Show("帳戶格式不符！！！");
			}
			else
			{
				friendAccountTemp = _friendaccount;
				string dataString = "3" + "_" + _friendaccount;
				newFriend = _friendaccount;
				sentData(dataString);

				friendAccountTextBox.Clear();
			}
		}

		private void sendMessageTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				chatInputTemp = sendMessageTextBox.Text;
				//MessageBox.Show(chatInputTemp);
				messageList.Add(chatInputTemp);
				chatroomRichTextBox.Text += "You : " + chatInputTemp + "\n";
				sentData("4_" + _myAccount.Account + "_" + chatFriend + "_" + chatInputTemp);  //要改成朋友帳號
				sendMessageTextBox.Clear();  //清空訊息欄
				SendKeys.Send("{BACKSPACE}"); //解決清空之後的跳行錯誤
				chatInputTemp = "";  //清空聊天暫存
			}
		}

		public void loadingHistoryMessage()
		{
			for (int i = 0; i < messageList.Count; i++)
			{
				chatroomRichTextBox.Text += messageList[i] + "\n";
			}
		}

		public void initilizeRequestRow()   //更新好友邀請列表
		{
			friendRequestdataGridView.Rows.Clear();
			for (int i = 0; i < friendRequestList.Count; i++)
			{
				String[] row = new String[] { friendRequestList[i], "接受邀請", "拒絕邀請" };
				friendRequestdataGridView.Rows.Add(row);
				friendRequestdataGridView.AutoResizeColumns();
			}
		}

		private void friendRequestdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				sentData("3_" + friendRequestList[e.RowIndex]);  //接受對方邀請並傳給server
				newFriend = friendRequestList[e.RowIndex];

				//friendAccountList.Add(friendRequestList[e.RowIndex]);  //新增好友到好友列表
				//更新好友列表
				friendDataGridView.Rows.Clear();
				for (int i = 0; i < friendAccountList.Count; i++)
				{
					String[] row = new String[] { friendAccountList[i] };
					friendDataGridView.Rows.Add(row);
					friendDataGridView.AutoResizeColumns();
				}

				friendRequestList.RemoveAt(e.RowIndex);  //從好友邀請list中刪除
				initilizeRequestRow();
			}
		}

		private void friendDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.ColumnIndex == 0 && e.RowIndex >= 0)
			{
				chatroomRichTextBox.Clear();
				//Console.WriteLine("123");
				sentData("2_" + _myAccount.Account + "_" + friendAccountList[e.RowIndex]);
				chatFriend = friendAccountList[e.RowIndex];  //點選的好友帳號名稱
				sendMessageTextBox.Enabled = false;  //點選好友時先讓server將聊天歷史紀錄loading完後再讓使用者聊天
				messageList.Clear(); //先清空先前的訊息列表
			}
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			RegisterForm reg = new RegisterForm();
			reg.ShowDialog();
		}
	}
}
