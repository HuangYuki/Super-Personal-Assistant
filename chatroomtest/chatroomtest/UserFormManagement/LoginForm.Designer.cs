namespace chatroomtest.UserFormManagement
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.secretTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "密碼:";
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(64, 25);
			this.accountTextBox.MaxLength = 10;
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(135, 22);
			this.accountTextBox.TabIndex = 2;
			// 
			// secretTextBox
			// 
			this.secretTextBox.Location = new System.Drawing.Point(64, 64);
			this.secretTextBox.MaxLength = 10;
			this.secretTextBox.Name = "secretTextBox";
			this.secretTextBox.Size = new System.Drawing.Size(135, 22);
			this.secretTextBox.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(64, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 35);
			this.button1.TabIndex = 4;
			this.button1.Text = "用戶登入";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(200, 122);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 35);
			this.button2.TabIndex = 5;
			this.button2.Text = "非用戶註冊";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 192);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.secretTextBox);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.TextBox secretTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}