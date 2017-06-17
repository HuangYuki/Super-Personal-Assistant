namespace chatroomtest
{
	partial class chatRoomManagement
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.friendTabControl = new System.Windows.Forms.TabControl();
            this.friendTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFriendTabPage = new System.Windows.Forms.TabPage();
            this.sendInvitebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.friendAccountTextBox = new System.Windows.Forms.TextBox();
            this.friendRequestTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friendTabControl.SuspendLayout();
            this.friendTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addFriendTabPage.SuspendLayout();
            this.friendRequestTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputTextBox.Location = new System.Drawing.Point(183, 268);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(480, 109);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(183, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 271);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "使用者:";
            // 
            // friendTabControl
            // 
            this.friendTabControl.Controls.Add(this.friendTabPage);
            this.friendTabControl.Controls.Add(this.addFriendTabPage);
            this.friendTabControl.Controls.Add(this.friendRequestTabPage);
            this.friendTabControl.Location = new System.Drawing.Point(3, 26);
            this.friendTabControl.Name = "friendTabControl";
            this.friendTabControl.SelectedIndex = 0;
            this.friendTabControl.Size = new System.Drawing.Size(183, 351);
            this.friendTabControl.TabIndex = 4;
            // 
            // friendTabPage
            // 
            this.friendTabPage.Controls.Add(this.dataGridView1);
            this.friendTabPage.Location = new System.Drawing.Point(4, 22);
            this.friendTabPage.Name = "friendTabPage";
            this.friendTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendTabPage.Size = new System.Drawing.Size(175, 325);
            this.friendTabPage.TabIndex = 0;
            this.friendTabPage.Text = "Friend";
            this.friendTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(163, 316);
            this.dataGridView1.TabIndex = 0;
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
            this.addFriendTabPage.Size = new System.Drawing.Size(175, 325);
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
            this.friendRequestTabPage.Controls.Add(this.dataGridView2);
            this.friendRequestTabPage.Location = new System.Drawing.Point(4, 22);
            this.friendRequestTabPage.Name = "friendRequestTabPage";
            this.friendRequestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendRequestTabPage.Size = new System.Drawing.Size(175, 325);
            this.friendRequestTabPage.TabIndex = 2;
            this.friendRequestTabPage.Text = "Friend Request";
            this.friendRequestTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(175, 325);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // chatRoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 378);
            this.Controls.Add(this.friendTabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "chatRoomManagement";
            this.Text = "chatRoomManagement";
            this.Load += new System.EventHandler(this.chatRoomManagement_Load);
            this.friendTabControl.ResumeLayout(false);
            this.friendTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addFriendTabPage.ResumeLayout(false);
            this.addFriendTabPage.PerformLayout();
            this.friendRequestTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl friendTabControl;
		private System.Windows.Forms.TabPage friendTabPage;
		private System.Windows.Forms.TabPage addFriendTabPage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.Button sendInvitebutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox friendAccountTextBox;
		private System.Windows.Forms.TabPage friendRequestTabPage;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}