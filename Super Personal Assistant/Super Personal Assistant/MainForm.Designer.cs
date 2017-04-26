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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "2017/3/11",
            "亂花錢",
            "0",
            "300",
            "不要問"}, "(無)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.friendTabPage = new System.Windows.Forms.TabPage();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.calendarTabPage = new System.Windows.Forms.TabPage();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.monthCalendar = new Pabo.Calendar.MonthCalendar();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.accountListView = new System.Windows.Forms.ListView();
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.calendarTabPage.SuspendLayout();
            this.accountTabPage.SuspendLayout();
            this.iconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.friendTabPage);
            this.TabControl.Controls.Add(this.messageTabPage);
            this.TabControl.Controls.Add(this.calendarTabPage);
            this.TabControl.Controls.Add(this.accountTabPage);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(444, 263);
            this.TabControl.TabIndex = 0;
            // 
            // friendTabPage
            // 
            this.friendTabPage.Location = new System.Drawing.Point(4, 22);
            this.friendTabPage.Name = "friendTabPage";
            this.friendTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendTabPage.Size = new System.Drawing.Size(436, 237);
            this.friendTabPage.TabIndex = 0;
            this.friendTabPage.Text = "好友";
            this.friendTabPage.UseVisualStyleBackColor = true;
            // 
            // messageTabPage
            // 
            this.messageTabPage.Location = new System.Drawing.Point(4, 22);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messageTabPage.Size = new System.Drawing.Size(436, 237);
            this.messageTabPage.TabIndex = 1;
            this.messageTabPage.Text = "訊息";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // calendarTabPage
            // 
            this.calendarTabPage.Controls.Add(this.addActivityButton);
            this.calendarTabPage.Controls.Add(this.label);
            this.calendarTabPage.Controls.Add(this.monthCalendar);
            this.calendarTabPage.Location = new System.Drawing.Point(4, 22);
            this.calendarTabPage.Name = "calendarTabPage";
            this.calendarTabPage.Size = new System.Drawing.Size(436, 237);
            this.calendarTabPage.TabIndex = 2;
            this.calendarTabPage.Text = "行事曆";
            this.calendarTabPage.UseVisualStyleBackColor = true;
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(335, 204);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(69, 23);
            this.addActivityButton.TabIndex = 3;
            this.addActivityButton.Text = "新增";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.LavenderBlush;
            this.label.Location = new System.Drawing.Point(288, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(144, 192);
            this.label.TabIndex = 2;
            // 
            // monthCalendar
            // 
            this.monthCalendar.ActiveMonth.Month = 4;
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
            this.monthCalendar.Size = new System.Drawing.Size(274, 224);
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.TodayColor = System.Drawing.Color.DarkGreen;
            this.monthCalendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar_DayClick);
            // 
            // accountTabPage
            // 
            this.accountTabPage.Controls.Add(this.button1);
            this.accountTabPage.Controls.Add(this.AddAccountButton);
            this.accountTabPage.Controls.Add(this.accountListView);
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Size = new System.Drawing.Size(436, 237);
            this.accountTabPage.TabIndex = 3;
            this.accountTabPage.Text = "帳戶";
            this.accountTabPage.UseVisualStyleBackColor = true;
            // 
            // accountListView
            // 
            this.accountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.DateColumnHeader,
            this.NameColumnHeader,
            this.columnHeader5});
            this.accountListView.FullRowSelect = true;
            this.accountListView.GridLines = true;
            this.accountListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.accountListView.Location = new System.Drawing.Point(0, 3);
            this.accountListView.Name = "accountListView";
            this.accountListView.Size = new System.Drawing.Size(316, 203);
            this.accountListView.TabIndex = 1;
            this.accountListView.UseCompatibleStateImageBehavior = false;
            this.accountListView.View = System.Windows.Forms.View.Details;
            this.accountListView.SelectedIndexChanged += new System.EventHandler(this.accountListView_SelectedIndexChanged);
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "Id";
            this.IdColumnHeader.Width = 30;
            // 
            // DateColumnHeader
            // 
            this.DateColumnHeader.Text = "日期";
            this.DateColumnHeader.Width = 89;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "摘要";
            this.NameColumnHeader.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "支出";
            this.columnHeader5.Width = 64;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
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
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(341, 49);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(75, 23);
            this.AddAccountButton.TabIndex = 2;
            this.AddAccountButton.Text = "新增";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(341, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "編輯";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 263);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "超牛個人助理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.calendarTabPage.ResumeLayout(false);
            this.accountTabPage.ResumeLayout(false);
            this.iconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage friendTabPage;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.TabPage calendarTabPage;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip iconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button addActivityButton;
        private Pabo.Calendar.MonthCalendar monthCalendar;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.ListView accountListView;
        private System.Windows.Forms.ColumnHeader DateColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader IdColumnHeader;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button button1;
    }
}

