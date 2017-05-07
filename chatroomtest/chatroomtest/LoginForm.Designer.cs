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
			this.logInSuccessLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// accountLabel
			// 
			this.accountLabel.AutoSize = true;
			this.accountLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accountLabel.Location = new System.Drawing.Point(12, 26);
			this.accountLabel.Name = "accountLabel";
			this.accountLabel.Size = new System.Drawing.Size(46, 21);
			this.accountLabel.TabIndex = 0;
			this.accountLabel.Text = "帳號:";
			// 
			// secretLabel
			// 
			this.secretLabel.AutoSize = true;
			this.secretLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.secretLabel.Location = new System.Drawing.Point(12, 61);
			this.secretLabel.Name = "secretLabel";
			this.secretLabel.Size = new System.Drawing.Size(46, 21);
			this.secretLabel.TabIndex = 1;
			this.secretLabel.Text = "密碼:";
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
			// logInButton
			// 
			this.logInButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.logInButton.Location = new System.Drawing.Point(64, 122);
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
			this.registerButton.Location = new System.Drawing.Point(200, 122);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(105, 35);
			this.registerButton.TabIndex = 5;
			this.registerButton.Text = "非用戶註冊";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.clickRegisterButton);
			// 
			// logInSuccessLabel
			// 
			this.logInSuccessLabel.AutoSize = true;
			this.logInSuccessLabel.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.logInSuccessLabel.ForeColor = System.Drawing.Color.Red;
			this.logInSuccessLabel.Location = new System.Drawing.Point(92, 73);
			this.logInSuccessLabel.Name = "logInSuccessLabel";
			this.logInSuccessLabel.Size = new System.Drawing.Size(165, 37);
			this.logInSuccessLabel.TabIndex = 7;
			this.logInSuccessLabel.Text = "登入成功";
			this.logInSuccessLabel.Visible = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 192);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.logInButton);
			this.Controls.Add(this.secretTextBox);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.secretLabel);
			this.Controls.Add(this.accountLabel);
			this.Controls.Add(this.logInSuccessLabel);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label accountLabel;
		private System.Windows.Forms.Label secretLabel;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.TextBox secretTextBox;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Label logInSuccessLabel;
	}
}