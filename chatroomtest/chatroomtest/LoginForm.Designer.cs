namespace chatroomtest
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.accountLabel = new System.Windows.Forms.Label();
			this.secretLabel = new System.Windows.Forms.Label();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.secretTextBox = new System.Windows.Forms.TextBox();
			this.logInButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.friendTabControl = new System.Windows.Forms.TabControl();
			this.friendTabPage = new System.Windows.Forms.TabPage();
			this.friendDataGridView = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addFriendTabPage = new System.Windows.Forms.TabPage();
			this.sendInvitebutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.friendAccountTextBox = new System.Windows.Forms.TextBox();
			this.friendRequestTabPage = new System.Windows.Forms.TabPage();
			this.friendRequestdataGridView = new System.Windows.Forms.DataGridView();
			this.friendColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addFriendColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.deleteFriendColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.userLabel = new System.Windows.Forms.Label();
			this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.friendTabControl.SuspendLayout();
			this.friendTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendDataGridView)).BeginInit();
			this.addFriendTabPage.SuspendLayout();
			this.friendRequestTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendRequestdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// accountLabel
			// 
			this.accountLabel.AutoSize = true;
			this.accountLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accountLabel.Location = new System.Drawing.Point(10, 7);
			this.accountLabel.Name = "accountLabel";
			this.accountLabel.Size = new System.Drawing.Size(46, 21);
			this.accountLabel.TabIndex = 0;
			this.accountLabel.Text = "帳號:";
			// 
			// secretLabel
			// 
			this.secretLabel.AutoSize = true;
			this.secretLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.secretLabel.Location = new System.Drawing.Point(10, 42);
			this.secretLabel.Name = "secretLabel";
			this.secretLabel.Size = new System.Drawing.Size(46, 21);
			this.secretLabel.TabIndex = 1;
			this.secretLabel.Text = "密碼:";
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(62, 6);
			this.accountTextBox.MaxLength = 10;
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(135, 22);
			this.accountTextBox.TabIndex = 2;
			// 
			// secretTextBox
			// 
			this.secretTextBox.Location = new System.Drawing.Point(62, 45);
			this.secretTextBox.MaxLength = 10;
			this.secretTextBox.Name = "secretTextBox";
			this.secretTextBox.Size = new System.Drawing.Size(135, 22);
			this.secretTextBox.TabIndex = 3;
			// 
			// logInButton
			// 
			this.logInButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.logInButton.Location = new System.Drawing.Point(62, 103);
			this.logInButton.Name = "logInButton";
			this.logInButton.Size = new System.Drawing.Size(84, 35);
			this.logInButton.TabIndex = 4;
			this.logInButton.Text = "用戶登入";
			this.logInButton.UseVisualStyleBackColor = true;
			this.logInButton.Click += new System.EventHandler(this.clickLogInButton);
			// 
			// registerButton
			// 
			this.registerButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.registerButton.Location = new System.Drawing.Point(198, 103);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(105, 35);
			this.registerButton.TabIndex = 5;
			this.registerButton.Text = "用戶註冊";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.clickRegisterButton);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(-2, -3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(780, 448);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.accountTextBox);
			this.tabPage1.Controls.Add(this.registerButton);
			this.tabPage1.Controls.Add(this.accountLabel);
			this.tabPage1.Controls.Add(this.logInButton);
			this.tabPage1.Controls.Add(this.secretLabel);
			this.tabPage1.Controls.Add(this.secretTextBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(772, 422);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "登入註冊頁";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.friendTabControl);
			this.tabPage2.Controls.Add(this.userLabel);
			this.tabPage2.Controls.Add(this.messageRichTextBox);
			this.tabPage2.Controls.Add(this.inputTextBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(772, 422);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "歡迎使用";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// friendTabControl
			// 
			this.friendTabControl.Controls.Add(this.friendTabPage);
			this.friendTabControl.Controls.Add(this.addFriendTabPage);
			this.friendTabControl.Controls.Add(this.friendRequestTabPage);
			this.friendTabControl.Location = new System.Drawing.Point(25, 38);
			this.friendTabControl.Name = "friendTabControl";
			this.friendTabControl.SelectedIndex = 0;
			this.friendTabControl.Size = new System.Drawing.Size(205, 348);
			this.friendTabControl.TabIndex = 8;
			// 
			// friendTabPage
			// 
			this.friendTabPage.Controls.Add(this.friendDataGridView);
			this.friendTabPage.Location = new System.Drawing.Point(4, 22);
			this.friendTabPage.Name = "friendTabPage";
			this.friendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.friendTabPage.Size = new System.Drawing.Size(197, 322);
			this.friendTabPage.TabIndex = 0;
			this.friendTabPage.Text = "Friend";
			this.friendTabPage.UseVisualStyleBackColor = true;
			// 
			// friendDataGridView
			// 
			this.friendDataGridView.AllowUserToAddRows = false;
			this.friendDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.friendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendDataGridView.ColumnHeadersVisible = false;
			this.friendDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
			this.friendDataGridView.Location = new System.Drawing.Point(6, 6);
			this.friendDataGridView.Name = "friendDataGridView";
			this.friendDataGridView.RowHeadersVisible = false;
			this.friendDataGridView.RowTemplate.Height = 24;
			this.friendDataGridView.Size = new System.Drawing.Size(185, 312);
			this.friendDataGridView.TabIndex = 0;
			this.friendDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.friendDataGridView_CellContentClick);
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			// 
			// addFriendTabPage
			// 
			this.addFriendTabPage.Controls.Add(this.sendInvitebutton);
			this.addFriendTabPage.Controls.Add(this.label2);
			this.addFriendTabPage.Controls.Add(this.friendAccountTextBox);
			this.addFriendTabPage.Location = new System.Drawing.Point(4, 22);
			this.addFriendTabPage.Name = "addFriendTabPage";
			this.addFriendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.addFriendTabPage.Size = new System.Drawing.Size(197, 322);
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
			this.friendRequestTabPage.Size = new System.Drawing.Size(197, 322);
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
            this.addFriendColumn,
            this.deleteFriendColumn});
			this.friendRequestdataGridView.Location = new System.Drawing.Point(0, 0);
			this.friendRequestdataGridView.Name = "friendRequestdataGridView";
			this.friendRequestdataGridView.ReadOnly = true;
			this.friendRequestdataGridView.RowHeadersVisible = false;
			this.friendRequestdataGridView.RowTemplate.Height = 24;
			this.friendRequestdataGridView.Size = new System.Drawing.Size(197, 325);
			this.friendRequestdataGridView.TabIndex = 0;
			this.friendRequestdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.friendRequestdataGridView_CellContentClick);
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
			// deleteFriendColumn
			// 
			this.deleteFriendColumn.HeaderText = "拒絕好友邀請";
			this.deleteFriendColumn.Name = "deleteFriendColumn";
			this.deleteFriendColumn.ReadOnly = true;
			this.deleteFriendColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.deleteFriendColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.userLabel.Location = new System.Drawing.Point(21, 11);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(94, 24);
			this.userLabel.TabIndex = 7;
			this.userLabel.Text = "使用者:";
			// 
			// messageRichTextBox
			// 
			this.messageRichTextBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.messageRichTextBox.Location = new System.Drawing.Point(268, 11);
			this.messageRichTextBox.Name = "messageRichTextBox";
			this.messageRichTextBox.Size = new System.Drawing.Size(483, 287);
			this.messageRichTextBox.TabIndex = 6;
			this.messageRichTextBox.Text = "";
			// 
			// inputTextBox
			// 
			this.inputTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.inputTextBox.Location = new System.Drawing.Point(268, 304);
			this.inputTextBox.Multiline = true;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(480, 70);
			this.inputTextBox.TabIndex = 5;
			this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 405);
			this.Controls.Add(this.tabControl1);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.friendTabControl.ResumeLayout(false);
			this.friendTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.friendDataGridView)).EndInit();
			this.addFriendTabPage.ResumeLayout(false);
			this.addFriendTabPage.PerformLayout();
			this.friendRequestTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.friendRequestdataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label accountLabel;
		private System.Windows.Forms.Label secretLabel;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.TextBox secretTextBox;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabControl friendTabControl;
		private System.Windows.Forms.TabPage friendTabPage;
		private System.Windows.Forms.DataGridView friendDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.TabPage addFriendTabPage;
		private System.Windows.Forms.Button sendInvitebutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox friendAccountTextBox;
		private System.Windows.Forms.TabPage friendRequestTabPage;
		private System.Windows.Forms.DataGridView friendRequestdataGridView;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.RichTextBox messageRichTextBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn friendColumn;
		private System.Windows.Forms.DataGridViewButtonColumn addFriendColumn;
		private System.Windows.Forms.DataGridViewButtonColumn deleteFriendColumn;
	}
}