namespace Super_Personal_Assistant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nameTabPage = new System.Windows.Forms.TabPage();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.calendarTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.dateItem1 = new Pabo.Calendar.DateItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.calendarTabPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nameTabPage);
            this.tabControl1.Controls.Add(this.messageTabPage);
            this.tabControl1.Controls.Add(this.calendarTabPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // nameTabPage
            // 
            this.nameTabPage.Location = new System.Drawing.Point(4, 22);
            this.nameTabPage.Name = "nameTabPage";
            this.nameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nameTabPage.Size = new System.Drawing.Size(440, 365);
            this.nameTabPage.TabIndex = 0;
            this.nameTabPage.Text = "好友";
            this.nameTabPage.UseVisualStyleBackColor = true;
            // 
            // messageTabPage
            // 
            this.messageTabPage.Location = new System.Drawing.Point(4, 22);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messageTabPage.Size = new System.Drawing.Size(440, 365);
            this.messageTabPage.TabIndex = 1;
            this.messageTabPage.Text = "訊息";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // calendarTabPage
            // 
            this.calendarTabPage.Controls.Add(this.label1);
            this.calendarTabPage.Controls.Add(this.monthCalendar1);
            this.calendarTabPage.Controls.Add(this.dateTimePicker1);
            this.calendarTabPage.Location = new System.Drawing.Point(4, 22);
            this.calendarTabPage.Name = "calendarTabPage";
            this.calendarTabPage.Size = new System.Drawing.Size(440, 365);
            this.calendarTabPage.TabIndex = 2;
            this.calendarTabPage.Text = "行事曆";
            this.calendarTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(288, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 192);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 4;
            this.monthCalendar1.ActiveMonth.Year = 2017;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("zh-TW");
            this.monthCalendar1.Dates.AddRange(new Pabo.Calendar.DateItem[] {
            this.dateItem1});
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = null;
            this.monthCalendar1.Location = new System.Drawing.Point(8, 3);
            this.monthCalendar1.MaxDate = new System.DateTime(2027, 4, 17, 22, 56, 33, 260);
            this.monthCalendar1.MinDate = new System.DateTime(2007, 4, 17, 22, 56, 33, 260);
            this.monthCalendar1.Month.BackgroundImage = null;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(274, 224);
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TodayColor = System.Drawing.Color.DarkGreen;
            this.monthCalendar1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.monthCalendar1_MonthChanged);
            // 
            // dateItem1
            // 
            this.dateItem1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateItem1.BackColor2 = System.Drawing.Color.Gray;
            this.dateItem1.BackgroundImage = null;
            this.dateItem1.BoldedDate = true;
            this.dateItem1.Date = new System.DateTime(2017, 4, 28, 0, 0, 0, 0);
            this.dateItem1.DateColor = System.Drawing.Color.Blue;
            this.dateItem1.Enabled = true;
            this.dateItem1.GradientMode = Pabo.Calendar.mcGradientMode.None;
            this.dateItem1.Image = null;
            this.dateItem1.ImageListIndex = -1;
            this.dateItem1.Pattern = Pabo.Calendar.mcDayInfoRecurrence.None;
            this.dateItem1.Range = new System.DateTime(2017, 4, 28, 0, 0, 0, 0);
            this.dateItem1.Tag = null;
            this.dateItem1.Text = "1";
            this.dateItem1.TextColor = System.Drawing.Color.Empty;
            this.dateItem1.Weekend = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "關閉";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.calendarTabPage.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nameTabPage;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.TabPage calendarTabPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Pabo.Calendar.MonthCalendar monthCalendar1;
        private Pabo.Calendar.DateItem dateItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

