namespace Super_Personal_Assistant
{
    partial class RegisterForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secretTextBox = new System.Windows.Forms.TextBox();
            this.sentButton = new System.Windows.Forms.Button();
            this.secretNoticelabel = new System.Windows.Forms.Label();
            this.accountNoticelabel = new System.Windows.Forms.Label();
            this.nameNoticelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 26);
            this.nameTextBox.MaxLength = 10;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "帳號:";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(103, 70);
            this.accountTextBox.MaxLength = 10;
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(142, 22);
            this.accountTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "密碼:";
            // 
            // secretTextBox
            // 
            this.secretTextBox.Location = new System.Drawing.Point(103, 113);
            this.secretTextBox.MaxLength = 10;
            this.secretTextBox.Name = "secretTextBox";
            this.secretTextBox.Size = new System.Drawing.Size(142, 22);
            this.secretTextBox.TabIndex = 5;
            // 
            // sentButton
            // 
            this.sentButton.Location = new System.Drawing.Point(170, 160);
            this.sentButton.Name = "sentButton";
            this.sentButton.Size = new System.Drawing.Size(75, 23);
            this.sentButton.TabIndex = 6;
            this.sentButton.Text = "確認送出";
            this.sentButton.UseVisualStyleBackColor = true;
            this.sentButton.Click += new System.EventHandler(this.clickSentButton);
            // 
            // secretNoticelabel
            // 
            this.secretNoticelabel.AutoSize = true;
            this.secretNoticelabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.secretNoticelabel.ForeColor = System.Drawing.Color.Red;
            this.secretNoticelabel.Location = new System.Drawing.Point(251, 113);
            this.secretNoticelabel.Name = "secretNoticelabel";
            this.secretNoticelabel.Size = new System.Drawing.Size(214, 17);
            this.secretNoticelabel.TabIndex = 9;
            this.secretNoticelabel.Text = "請輸入a-z,0-9,10個字元以內的密碼";
            // 
            // accountNoticelabel
            // 
            this.accountNoticelabel.AutoSize = true;
            this.accountNoticelabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountNoticelabel.ForeColor = System.Drawing.Color.Red;
            this.accountNoticelabel.Location = new System.Drawing.Point(251, 72);
            this.accountNoticelabel.Name = "accountNoticelabel";
            this.accountNoticelabel.Size = new System.Drawing.Size(240, 17);
            this.accountNoticelabel.TabIndex = 8;
            this.accountNoticelabel.Text = "請輸入a-z,0-9,10個字元以內的帳號名稱";
            // 
            // nameNoticelabel
            // 
            this.nameNoticelabel.AutoSize = true;
            this.nameNoticelabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameNoticelabel.ForeColor = System.Drawing.Color.Red;
            this.nameNoticelabel.Location = new System.Drawing.Point(251, 31);
            this.nameNoticelabel.Name = "nameNoticelabel";
            this.nameNoticelabel.Size = new System.Drawing.Size(214, 17);
            this.nameNoticelabel.TabIndex = 7;
            this.nameNoticelabel.Text = "請輸入a-z,0-9,10個字元以內的姓名";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 215);
            this.Controls.Add(this.secretNoticelabel);
            this.Controls.Add(this.accountNoticelabel);
            this.Controls.Add(this.nameNoticelabel);
            this.Controls.Add(this.sentButton);
            this.Controls.Add(this.secretTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secretTextBox;
        private System.Windows.Forms.Button sentButton;
        private System.Windows.Forms.Label secretNoticelabel;
        private System.Windows.Forms.Label accountNoticelabel;
        private System.Windows.Forms.Label nameNoticelabel;
    }
}