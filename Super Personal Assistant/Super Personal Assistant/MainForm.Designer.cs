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
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.accountLabel = new System.Windows.Forms.Label();
			this.logInButton = new System.Windows.Forms.Button();
			this.secretLabel = new System.Windows.Forms.Label();
			this.secretTextBox = new System.Windows.Forms.TextBox();
			this.friendTabPage = new System.Windows.Forms.TabPage();
			this.friendTabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.friendDataGridView = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.addFriendTabPage = new System.Windows.Forms.TabPage();
			this.sendInvitebutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.friendAccountTextBox = new System.Windows.Forms.TextBox();
			this.friendRequestTabPage = new System.Windows.Forms.TabPage();
			this.friendRequestdataGridView = new System.Windows.Forms.DataGridView();
			this.userLabel = new System.Windows.Forms.Label();
			this.chatroomRichTextBox = new System.Windows.Forms.RichTextBox();
			this.sendMessageTextBox = new System.Windows.Forms.TextBox();
			this.calendarTabPage = new System.Windows.Forms.TabPage();
			this.deleteTaskButton = new System.Windows.Forms.Button();
			this.editTaskButton = new System.Windows.Forms.Button();
			this.eventListView = new System.Windows.Forms.ListView();
			this.taskIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.accountIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MoneyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.iconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notificationTimer = new System.Windows.Forms.Timer(this.components);
			this.friendColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addFriendColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.mainTabControl.SuspendLayout();
			this.mainPage.SuspendLayout();
			this.friendTabPage.SuspendLayout();
			this.friendTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendDataGridView)).BeginInit();
			this.addFriendTabPage.SuspendLayout();
			this.friendRequestTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendRequestdataGridView)).BeginInit();
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
			this.mainPage.Controls.Add(this.accountTextBox);
			this.mainPage.Controls.Add(this.registerButton);
			this.mainPage.Controls.Add(this.accountLabel);
			this.mainPage.Controls.Add(this.logInButton);
			this.mainPage.Controls.Add(this.secretLabel);
			this.mainPage.Controls.Add(this.secretTextBox);
			this.mainPage.Location = new System.Drawing.Point(4, 22);
			this.mainPage.Name = "mainPage";
			this.mainPage.Padding = new System.Windows.Forms.Padding(3);
			this.mainPage.Size = new System.Drawing.Size(576, 310);
			this.mainPage.TabIndex = 4;
			this.mainPage.Text = "主頁";
			this.mainPage.UseVisualStyleBackColor = true;
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(194, 89);
			this.accountTextBox.MaxLength = 10;
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(135, 22);
			this.accountTextBox.TabIndex = 8;
			// 
			// registerButton
			// 
			this.registerButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.registerButton.Location = new System.Drawing.Point(330, 186);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(105, 35);
			this.registerButton.TabIndex = 11;
			this.registerButton.Text = "用戶註冊";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// accountLabel
			// 
			this.accountLabel.AutoSize = true;
			this.accountLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accountLabel.Location = new System.Drawing.Point(142, 90);
			this.accountLabel.Name = "accountLabel";
			this.accountLabel.Size = new System.Drawing.Size(46, 21);
			this.accountLabel.TabIndex = 6;
			this.accountLabel.Text = "帳號:";
			// 
			// logInButton
			// 
			this.logInButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.logInButton.Location = new System.Drawing.Point(194, 186);
			this.logInButton.Name = "logInButton";
			this.logInButton.Size = new System.Drawing.Size(84, 35);
			this.logInButton.TabIndex = 10;
			this.logInButton.Text = "用戶登入";
			this.logInButton.UseVisualStyleBackColor = true;
			this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
			// 
			// secretLabel
			// 
			this.secretLabel.AutoSize = true;
			this.secretLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.secretLabel.Location = new System.Drawing.Point(142, 125);
			this.secretLabel.Name = "secretLabel";
			this.secretLabel.Size = new System.Drawing.Size(46, 21);
			this.secretLabel.TabIndex = 7;
			this.secretLabel.Text = "密碼:";
			// 
			// secretTextBox
			// 
			this.secretTextBox.Location = new System.Drawing.Point(194, 128);
			this.secretTextBox.MaxLength = 10;
			this.secretTextBox.Name = "secretTextBox";
			this.secretTextBox.Size = new System.Drawing.Size(135, 22);
			this.secretTextBox.TabIndex = 9;
			// 
			// friendTabPage
			// 
			this.friendTabPage.Controls.Add(this.friendTabControl);
			this.friendTabPage.Controls.Add(this.userLabel);
			this.friendTabPage.Controls.Add(this.chatroomRichTextBox);
			this.friendTabPage.Controls.Add(this.sendMessageTextBox);
			this.friendTabPage.Location = new System.Drawing.Point(4, 22);
			this.friendTabPage.Name = "friendTabPage";
			this.friendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.friendTabPage.Size = new System.Drawing.Size(576, 310);
			this.friendTabPage.TabIndex = 0;
			this.friendTabPage.Text = "好友";
			this.friendTabPage.UseVisualStyleBackColor = true;
			// 
			// friendTabControl
			// 
			this.friendTabControl.Controls.Add(this.tabPage1);
			this.friendTabControl.Controls.Add(this.addFriendTabPage);
			this.friendTabControl.Controls.Add(this.friendRequestTabPage);
			this.friendTabControl.Location = new System.Drawing.Point(6, 33);
			this.friendTabControl.Name = "friendTabControl";
			this.friendTabControl.SelectedIndex = 0;
			this.friendTabControl.Size = new System.Drawing.Size(200, 269);
			this.friendTabControl.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.friendDataGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(192, 243);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Friend";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// friendDataGridView
			// 
			this.friendDataGridView.AllowUserToAddRows = false;
			this.friendDataGridView.AllowUserToDeleteRows = false;
			this.friendDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.friendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendDataGridView.ColumnHeadersVisible = false;
			this.friendDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
			this.friendDataGridView.Location = new System.Drawing.Point(6, 6);
			this.friendDataGridView.Name = "friendDataGridView";
			this.friendDataGridView.ReadOnly = true;
			this.friendDataGridView.RowHeadersVisible = false;
			this.friendDataGridView.RowTemplate.Height = 24;
			this.friendDataGridView.Size = new System.Drawing.Size(185, 312);
			this.friendDataGridView.TabIndex = 0;
			this.friendDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.friendDataGridView_CellContentDoubleClick);
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// addFriendTabPage
			// 
			this.addFriendTabPage.Controls.Add(this.sendInvitebutton);
			this.addFriendTabPage.Controls.Add(this.label2);
			this.addFriendTabPage.Controls.Add(this.friendAccountTextBox);
			this.addFriendTabPage.Location = new System.Drawing.Point(4, 22);
			this.addFriendTabPage.Name = "addFriendTabPage";
			this.addFriendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.addFriendTabPage.Size = new System.Drawing.Size(192, 243);
			this.addFriendTabPage.TabIndex = 1;
			this.addFriendTabPage.Text = "Add Friend";
			this.addFriendTabPage.UseVisualStyleBackColor = true;
			// 
			// sendInvitebutton
			// 
			this.sendInvitebutton.Location = new System.Drawing.Point(40, 128);
			this.sendInvitebutton.Name = "sendInvitebutton";
			this.sendInvitebutton.Size = new System.Drawing.Size(87, 23);
			this.sendInvitebutton.TabIndex = 2;
			this.sendInvitebutton.Text = "寄送好友邀請";
			this.sendInvitebutton.UseVisualStyleBackColor = true;
			this.sendInvitebutton.Click += new System.EventHandler(this.sendInvitebutton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(26, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "請輸入好友帳號";
			// 
			// friendAccountTextBox
			// 
			this.friendAccountTextBox.Location = new System.Drawing.Point(29, 73);
			this.friendAccountTextBox.Name = "friendAccountTextBox";
			this.friendAccountTextBox.Size = new System.Drawing.Size(113, 22);
			this.friendAccountTextBox.TabIndex = 0;
			// 
			// friendRequestTabPage
			// 
			this.friendRequestTabPage.Controls.Add(this.friendRequestdataGridView);
			this.friendRequestTabPage.Location = new System.Drawing.Point(4, 22);
			this.friendRequestTabPage.Name = "friendRequestTabPage";
			this.friendRequestTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.friendRequestTabPage.Size = new System.Drawing.Size(192, 243);
			this.friendRequestTabPage.TabIndex = 2;
			this.friendRequestTabPage.Text = "Friend Request";
			this.friendRequestTabPage.UseVisualStyleBackColor = true;
			// 
			// friendRequestdataGridView
			// 
			this.friendRequestdataGridView.AllowUserToAddRows = false;
			this.friendRequestdataGridView.AllowUserToDeleteRows = false;
			this.friendRequestdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.friendRequestdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendRequestdataGridView.ColumnHeadersVisible = false;
			this.friendRequestdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.friendColumn,
            this.addFriendColumn});
			this.friendRequestdataGridView.Location = new System.Drawing.Point(0, 0);
			this.friendRequestdataGridView.Name = "friendRequestdataGridView";
			this.friendRequestdataGridView.ReadOnly = true;
			this.friendRequestdataGridView.RowHeadersVisible = false;
			this.friendRequestdataGridView.RowTemplate.Height = 24;
			this.friendRequestdataGridView.Size = new System.Drawing.Size(197, 325);
			this.friendRequestdataGridView.TabIndex = 0;
			this.friendRequestdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.friendRequestdataGridView_CellContentClick);
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.userLabel.Location = new System.Drawing.Point(8, 6);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(87, 21);
			this.userLabel.TabIndex = 10;
			this.userLabel.Text = "使用者:";
			// 
			// chatroomRichTextBox
			// 
			this.chatroomRichTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.chatroomRichTextBox.Location = new System.Drawing.Point(211, 6);
			this.chatroomRichTextBox.Name = "chatroomRichTextBox";
			this.chatroomRichTextBox.ReadOnly = true;
			this.chatroomRichTextBox.Size = new System.Drawing.Size(359, 237);
			this.chatroomRichTextBox.TabIndex = 9;
			this.chatroomRichTextBox.Text = "";
			// 
			// sendMessageTextBox
			// 
			this.sendMessageTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.sendMessageTextBox.Location = new System.Drawing.Point(211, 249);
			this.sendMessageTextBox.Multiline = true;
			this.sendMessageTextBox.Name = "sendMessageTextBox";
			this.sendMessageTextBox.Size = new System.Drawing.Size(357, 55);
			this.sendMessageTextBox.TabIndex = 6;
			this.sendMessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendMessageTextBox_KeyDown);
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
            this.taskIdColumnHeader,
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
			// taskIdColumnHeader
			// 
			this.taskIdColumnHeader.Text = "ID";
			this.taskIdColumnHeader.Width = 0;
			// 
			// timeColumnHeader
			// 
			this.timeColumnHeader.Text = "時間";
			this.timeColumnHeader.Width = 70;
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "標題";
			this.titleColumnHeader.Width = 80;
			// 
			// bodyColumnHeader
			// 
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
			this.monthCalendar.ActiveMonth.Month = 6;
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
			this.monthCalendar.SelectionMode = Pabo.Calendar.mcSelectionMode.One;
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
            this.accountIdColumnHeader,
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
			// accountIdColumnHeader
			// 
			this.accountIdColumnHeader.Text = "ID";
			this.accountIdColumnHeader.Width = 0;
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
			this.iconContextMenuStrip.Size = new System.Drawing.Size(99, 26);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.closeToolStripMenuItem.Text = "關閉";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// notificationTimer
			// 
			this.notificationTimer.Enabled = true;
			this.notificationTimer.Interval = 60000;
			this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
			// 
			// friendColumn
			// 
			this.friendColumn.HeaderText = "好友帳號";
			this.friendColumn.Name = "friendColumn";
			this.friendColumn.ReadOnly = true;
			this.friendColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// addFriendColumn
			// 
			this.addFriendColumn.HeaderText = "新增好友";
			this.addFriendColumn.Name = "addFriendColumn";
			this.addFriendColumn.ReadOnly = true;
			this.addFriendColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.addFriendColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
			this.mainPage.ResumeLayout(false);
			this.mainPage.PerformLayout();
			this.friendTabPage.ResumeLayout(false);
			this.friendTabPage.PerformLayout();
			this.friendTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.friendDataGridView)).EndInit();
			this.addFriendTabPage.ResumeLayout(false);
			this.addFriendTabPage.PerformLayout();
			this.friendRequestTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.friendRequestdataGridView)).EndInit();
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
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader timeColumnHeader;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader bodyColumnHeader;
        private System.Windows.Forms.Label totalMoneyLabel;
        private System.Windows.Forms.Label moneyTitleLabel;
        private System.Windows.Forms.ColumnHeader taskIdColumnHeader;
        private System.Windows.Forms.ColumnHeader accountIdColumnHeader;
		private System.Windows.Forms.TextBox sendMessageTextBox;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Label accountLabel;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Label secretLabel;
		private System.Windows.Forms.TextBox secretTextBox;
		private System.Windows.Forms.RichTextBox chatroomRichTextBox;
		private System.Windows.Forms.TabControl friendTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView friendDataGridView;
		private System.Windows.Forms.DataGridViewButtonColumn Column2;
		private System.Windows.Forms.TabPage addFriendTabPage;
		private System.Windows.Forms.Button sendInvitebutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox friendAccountTextBox;
		private System.Windows.Forms.TabPage friendRequestTabPage;
		private System.Windows.Forms.DataGridView friendRequestdataGridView;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn friendColumn;
		private System.Windows.Forms.DataGridViewButtonColumn addFriendColumn;
	}
}

