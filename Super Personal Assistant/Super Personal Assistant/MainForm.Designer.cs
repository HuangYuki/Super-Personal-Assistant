namespace Super_Personal_Assistant
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.friendTabPage = new System.Windows.Forms.TabPage();
            this.chatroomTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.sendMessageTextBox = new System.Windows.Forms.TextBox();
            this.deleteFriendButton = new System.Windows.Forms.Button();
            this.friendListGroupBox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FriendIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addFriendButton = new System.Windows.Forms.Button();
            this.calendarTabPage = new System.Windows.Forms.TabPage();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.eventListView = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bodyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addActivityButton = new System.Windows.Forms.Button();
            this.monthCalendar = new Pabo.Calendar.MonthCalendar();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.totalMoneyLabel = new System.Windows.Forms.Label();
            this.moneyTitleLabel = new System.Windows.Forms.Label();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.editAccountButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accountListView = new System.Windows.Forms.ListView();
            this.DateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoneyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTabControl.SuspendLayout();
            this.friendTabPage.SuspendLayout();
            this.friendListGroupBox.SuspendLayout();
            this.calendarTabPage.SuspendLayout();
            this.accountTabPage.SuspendLayout();
            this.iconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainPage);
            this.mainTabControl.Controls.Add(this.friendTabPage);
            this.mainTabControl.Controls.Add(this.calendarTabPage);
            this.mainTabControl.Controls.Add(this.accountTabPage);
            this.mainTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(584, 336);
            this.mainTabControl.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(576, 310);
            this.mainPage.TabIndex = 4;
            this.mainPage.Text = "主頁";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // friendTabPage
            // 
            this.friendTabPage.Controls.Add(this.chatroomTextBox);
            this.friendTabPage.Controls.Add(this.sendMessageButton);
            this.friendTabPage.Controls.Add(this.sendMessageTextBox);
            this.friendTabPage.Controls.Add(this.deleteFriendButton);
            this.friendTabPage.Controls.Add(this.friendListGroupBox);
            this.friendTabPage.Controls.Add(this.addFriendButton);
            this.friendTabPage.Location = new System.Drawing.Point(4, 22);
            this.friendTabPage.Name = "friendTabPage";
            this.friendTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendTabPage.Size = new System.Drawing.Size(576, 310);
            this.friendTabPage.TabIndex = 0;
            this.friendTabPage.Text = "好友";
            this.friendTabPage.UseVisualStyleBackColor = true;
            // 
            // chatroomTextBox
            // 
            this.chatroomTextBox.Location = new System.Drawing.Point(211, 6);
            this.chatroomTextBox.Multiline = true;
            this.chatroomTextBox.Name = "chatroomTextBox";
            this.chatroomTextBox.Size = new System.Drawing.Size(362, 237);
            this.chatroomTextBox.TabIndex = 8;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(511, 249);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(62, 55);
            this.sendMessageButton.TabIndex = 7;
            this.sendMessageButton.Text = "送出";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // sendMessageTextBox
            // 
            this.sendMessageTextBox.Location = new System.Drawing.Point(211, 249);
            this.sendMessageTextBox.Multiline = true;
            this.sendMessageTextBox.Name = "sendMessageTextBox";
            this.sendMessageTextBox.Size = new System.Drawing.Size(294, 55);
            this.sendMessageTextBox.TabIndex = 6;
            // 
            // deleteFriendButton
            // 
            this.deleteFriendButton.Enabled = false;
            this.deleteFriendButton.Location = new System.Drawing.Point(113, 279);
            this.deleteFriendButton.Name = "deleteFriendButton";
            this.deleteFriendButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFriendButton.TabIndex = 4;
            this.deleteFriendButton.Text = "刪除好友";
            this.deleteFriendButton.UseVisualStyleBackColor = true;
            // 
            // friendListGroupBox
            // 
            this.friendListGroupBox.Controls.Add(this.listView1);
            this.friendListGroupBox.Location = new System.Drawing.Point(3, 3);
            this.friendListGroupBox.Name = "friendListGroupBox";
            this.friendListGroupBox.Size = new System.Drawing.Size(205, 270);
            this.friendListGroupBox.TabIndex = 2;
            this.friendListGroupBox.TabStop = false;
            this.friendListGroupBox.Text = "好友清單";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FriendIdColumnHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("新細明體", 12F);
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 249);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FriendIdColumnHeader
            // 
            this.FriendIdColumnHeader.Text = "好友帳號";
            this.FriendIdColumnHeader.Width = 200;
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(23, 279);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(75, 23);
            this.addFriendButton.TabIndex = 1;
            this.addFriendButton.Text = "新增好友";
            this.addFriendButton.UseVisualStyleBackColor = true;
            // 
            // calendarTabPage
            // 
            this.calendarTabPage.Controls.Add(this.deleteTaskButton);
            this.calendarTabPage.Controls.Add(this.editTaskButton);
            this.calendarTabPage.Controls.Add(this.eventListView);
            this.calendarTabPage.Controls.Add(this.addActivityButton);
            this.calendarTabPage.Controls.Add(this.monthCalendar);
            this.calendarTabPage.Location = new System.Drawing.Point(4, 22);
            this.calendarTabPage.Name = "calendarTabPage";
            this.calendarTabPage.Size = new System.Drawing.Size(576, 310);
            this.calendarTabPage.TabIndex = 2;
            this.calendarTabPage.Text = "行事曆";
            this.calendarTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Enabled = false;
            this.deleteTaskButton.Location = new System.Drawing.Point(503, 279);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(65, 23);
            this.deleteTaskButton.TabIndex = 6;
            this.deleteTaskButton.Text = "刪除";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Enabled = false;
            this.editTaskButton.Location = new System.Drawing.Point(432, 279);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(65, 23);
            this.editTaskButton.TabIndex = 5;
            this.editTaskButton.Text = "編輯";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.timeColumnHeader,
            this.titleColumnHeader,
            this.bodyColumnHeader});
            this.eventListView.FullRowSelect = true;
            this.eventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eventListView.Location = new System.Drawing.Point(356, 3);
            this.eventListView.MultiSelect = false;
            this.eventListView.Name = "eventListView";
            this.eventListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventListView.ShowItemToolTips = true;
            this.eventListView.Size = new System.Drawing.Size(217, 270);
            this.eventListView.TabIndex = 4;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.DisplayIndex = 3;
            // 
            // timeColumnHeader
            // 
            this.timeColumnHeader.DisplayIndex = 0;
            this.timeColumnHeader.Text = "時間";
            this.timeColumnHeader.Width = 70;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.DisplayIndex = 1;
            this.titleColumnHeader.Text = "標題";
            this.titleColumnHeader.Width = 80;
            // 
            // bodyColumnHeader
            // 
            this.bodyColumnHeader.DisplayIndex = 2;
            this.bodyColumnHeader.Text = "內容";
            this.bodyColumnHeader.Width = 100;
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(361, 279);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(65, 23);
            this.addActivityButton.TabIndex = 3;
            this.addActivityButton.Text = "新增";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.ActiveMonth.Month = 5;
            this.monthCalendar.ActiveMonth.Year = 2017;
            this.monthCalendar.Culture = new System.Globalization.CultureInfo("zh-TW");
            this.monthCalendar.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar.ImageList = null;
            this.monthCalendar.Location = new System.Drawing.Point(8, 3);
            this.monthCalendar.MaxDate = new System.DateTime(2027, 4, 17, 22, 56, 33, 260);
            this.monthCalendar.MinDate = new System.DateTime(2007, 4, 17, 22, 56, 33, 260);
            this.monthCalendar.Month.BackgroundImage = null;
            this.monthCalendar.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Size = new System.Drawing.Size(342, 304);
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.TodayColor = System.Drawing.Color.DarkGreen;
            this.monthCalendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar_DayClick);
            // 
            // accountTabPage
            // 
            this.accountTabPage.Controls.Add(this.totalMoneyLabel);
            this.accountTabPage.Controls.Add(this.moneyTitleLabel);
            this.accountTabPage.Controls.Add(this.deleteAccountButton);
            this.accountTabPage.Controls.Add(this.editAccountButton);
            this.accountTabPage.Controls.Add(this.addAccountButton);
            this.accountTabPage.Controls.Add(this.accountListView);
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Size = new System.Drawing.Size(576, 310);
            this.accountTabPage.TabIndex = 3;
            this.accountTabPage.Text = "帳戶";
            this.accountTabPage.UseVisualStyleBackColor = true;
            // 
            // totalMoneyLabel
            // 
            this.totalMoneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalMoneyLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalMoneyLabel.Location = new System.Drawing.Point(406, 115);
            this.totalMoneyLabel.Name = "totalMoneyLabel";
            this.totalMoneyLabel.Size = new System.Drawing.Size(166, 32);
            this.totalMoneyLabel.TabIndex = 6;
            this.totalMoneyLabel.Text = "$0";
            this.totalMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyTitleLabel
            // 
            this.moneyTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyTitleLabel.AutoSize = true;
            this.moneyTitleLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.moneyTitleLabel.Location = new System.Drawing.Point(430, 67);
            this.moneyTitleLabel.Name = "moneyTitleLabel";
            this.moneyTitleLabel.Size = new System.Drawing.Size(114, 32);
            this.moneyTitleLabel.TabIndex = 5;
            this.moneyTitleLabel.Text = "總金額";
            this.moneyTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Enabled = false;
            this.deleteAccountButton.Location = new System.Drawing.Point(492, 274);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(80, 28);
            this.deleteAccountButton.TabIndex = 4;
            this.deleteAccountButton.Text = "刪除";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // editAccountButton
            // 
            this.editAccountButton.Enabled = false;
            this.editAccountButton.Location = new System.Drawing.Point(406, 274);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(80, 28);
            this.editAccountButton.TabIndex = 3;
            this.editAccountButton.Text = "編輯";
            this.editAccountButton.UseVisualStyleBackColor = true;
            this.editAccountButton.Click += new System.EventHandler(this.editAccountButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(406, 216);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(166, 52);
            this.addAccountButton.TabIndex = 2;
            this.addAccountButton.Text = "新增";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // accountListView
            // 
            this.accountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateColumnHeader,
            this.NameColumnHeader,
            this.MoneyColumnHeader});
            this.accountListView.FullRowSelect = true;
            this.accountListView.GridLines = true;
            this.accountListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.accountListView.Location = new System.Drawing.Point(3, 3);
            this.accountListView.MultiSelect = false;
            this.accountListView.Name = "accountListView";
            this.accountListView.Size = new System.Drawing.Size(397, 304);
            this.accountListView.TabIndex = 1;
            this.accountListView.UseCompatibleStateImageBehavior = false;
            this.accountListView.View = System.Windows.Forms.View.Details;
            this.accountListView.SelectedIndexChanged += new System.EventHandler(this.accountListView_SelectedIndexChanged);
            // 
            // DateColumnHeader
            // 
            this.DateColumnHeader.Text = "日期";
            this.DateColumnHeader.Width = 62;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "摘要";
            this.NameColumnHeader.Width = 261;
            // 
            // MoneyColumnHeader
            // 
            this.MoneyColumnHeader.Text = "收支";
            this.MoneyColumnHeader.Width = 69;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "超牛個人助理";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // iconContextMenuStrip
            // 
            this.iconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.iconContextMenuStrip.Name = "contextMenuStrip1";
            this.iconContextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem.Text = "關閉";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // notificationTimer
            // 
            this.notificationTimer.Enabled = true;
            this.notificationTimer.Interval = 60000;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "超牛個人助理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.mainTabControl.ResumeLayout(false);
            this.friendTabPage.ResumeLayout(false);
            this.friendTabPage.PerformLayout();
            this.friendListGroupBox.ResumeLayout(false);
            this.calendarTabPage.ResumeLayout(false);
            this.accountTabPage.ResumeLayout(false);
            this.accountTabPage.PerformLayout();
            this.iconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage friendTabPage;
        private System.Windows.Forms.TabPage calendarTabPage;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip iconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button addActivityButton;
        private Pabo.Calendar.MonthCalendar monthCalendar;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.ListView accountListView;
        private System.Windows.Forms.ColumnHeader DateColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader MoneyColumnHeader;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button editAccountButton;
        private System.Windows.Forms.Timer notificationTimer;
        private System.Windows.Forms.TabPage mainPage;
        internal System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button deleteFriendButton;
        private System.Windows.Forms.GroupBox friendListGroupBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FriendIdColumnHeader;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader timeColumnHeader;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.TextBox chatroomTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox sendMessageTextBox;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader bodyColumnHeader;
        private System.Windows.Forms.Label totalMoneyLabel;
        private System.Windows.Forms.Label moneyTitleLabel;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
    }
}

