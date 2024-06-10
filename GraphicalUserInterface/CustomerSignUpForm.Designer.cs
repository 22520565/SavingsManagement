namespace GraphicalUserInterface
{
    partial class CustomerSignUpForm
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
		private void InitializeComponent() {
			txtUsername = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			txtConfirmPassword = new System.Windows.Forms.TextBox();
			txtEmail = new System.Windows.Forms.TextBox();
			btnSignUp = new System.Windows.Forms.Button();
			label5 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label6 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			cbShowPassword = new System.Windows.Forms.CheckBox();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			panel3 = new System.Windows.Forms.Panel();
			cbShowConfirmPassword = new System.Windows.Forms.CheckBox();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label2 = new System.Windows.Forms.Label();
			panel4 = new System.Windows.Forms.Panel();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			linkLabel_Login = new System.Windows.Forms.LinkLabel();
			panel5 = new System.Windows.Forms.Panel();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			label7 = new System.Windows.Forms.Label();
			txtOTP = new System.Windows.Forms.TextBox();
			confirmOTPBtn = new System.Windows.Forms.Button();
			getOTPBtn = new System.Windows.Forms.Button();
			panel6 = new System.Windows.Forms.Panel();
			typeAccountComboBox = new System.Windows.Forms.ComboBox();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			label8 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// txtUsername
			// 
			txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtUsername.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtUsername.Location = new System.Drawing.Point(13, 36);
			txtUsername.Margin = new System.Windows.Forms.Padding(2);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new System.Drawing.Size(387, 34);
			txtUsername.TabIndex = 3;
			// 
			// txtPassword
			// 
			txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtPassword.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtPassword.Location = new System.Drawing.Point(13, 37);
			txtPassword.Margin = new System.Windows.Forms.Padding(2);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(387, 34);
			txtPassword.TabIndex = 5;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// txtConfirmPassword
			// 
			txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtConfirmPassword.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtConfirmPassword.Location = new System.Drawing.Point(13, 37);
			txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
			txtConfirmPassword.Name = "txtConfirmPassword";
			txtConfirmPassword.Size = new System.Drawing.Size(387, 34);
			txtConfirmPassword.TabIndex = 7;
			txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// txtEmail
			// 
			txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtEmail.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtEmail.Location = new System.Drawing.Point(13, 36);
			txtEmail.Margin = new System.Windows.Forms.Padding(2);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new System.Drawing.Size(387, 34);
			txtEmail.TabIndex = 9;
			// 
			// btnSignUp
			// 
			btnSignUp.AutoSize = true;
			btnSignUp.BackColor = System.Drawing.Color.Black;
			btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
			btnSignUp.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnSignUp.ForeColor = System.Drawing.Color.White;
			btnSignUp.Location = new System.Drawing.Point(161, 630);
			btnSignUp.Margin = new System.Windows.Forms.Padding(2);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.Size = new System.Drawing.Size(246, 53);
			btnSignUp.TabIndex = 12;
			btnSignUp.Text = "Create Account";
			btnSignUp.UseVisualStyleBackColor = false;
			btnSignUp.Click += btnSignUp_Click;
			btnSignUp.MouseEnter += btnSignUp_MouseEnter;
			btnSignUp.MouseLeave += btnSignUp_MouseLeave;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.Location = new System.Drawing.Point(208, 12);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(134, 40);
			label5.TabIndex = 15;
			label5.Text = "Sign Up";
			// 
			// panel1
			// 
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(txtUsername);
			panel1.Location = new System.Drawing.Point(70, 67);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(417, 83);
			panel1.TabIndex = 35;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.user1;
			pictureBox2.Location = new System.Drawing.Point(13, 11);
			pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(16, 16);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 29;
			pictureBox2.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label6.Location = new System.Drawing.Point(42, 8);
			label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(98, 23);
			label6.TabIndex = 26;
			label6.Text = "Username";
			// 
			// panel2
			// 
			panel2.Controls.Add(cbShowPassword);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(txtPassword);
			panel2.Location = new System.Drawing.Point(70, 246);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(417, 83);
			panel2.TabIndex = 36;
			// 
			// cbShowPassword
			// 
			cbShowPassword.BackgroundImage = Properties.Resources.show;
			cbShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			cbShowPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbShowPassword.ForeColor = System.Drawing.Color.Transparent;
			cbShowPassword.Location = new System.Drawing.Point(370, 42);
			cbShowPassword.Margin = new System.Windows.Forms.Padding(2);
			cbShowPassword.Name = "cbShowPassword";
			cbShowPassword.Size = new System.Drawing.Size(24, 24);
			cbShowPassword.TabIndex = 38;
			cbShowPassword.UseVisualStyleBackColor = true;
			cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.padlock;
			pictureBox1.Location = new System.Drawing.Point(13, 11);
			pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(16, 16);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 29;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label1.Location = new System.Drawing.Point(42, 8);
			label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(94, 23);
			label1.TabIndex = 26;
			label1.Text = "Password";
			// 
			// panel3
			// 
			panel3.Controls.Add(cbShowConfirmPassword);
			panel3.Controls.Add(pictureBox3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(txtConfirmPassword);
			panel3.Location = new System.Drawing.Point(70, 334);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(417, 83);
			panel3.TabIndex = 37;
			// 
			// cbShowConfirmPassword
			// 
			cbShowConfirmPassword.BackgroundImage = Properties.Resources.show;
			cbShowConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			cbShowConfirmPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbShowConfirmPassword.ForeColor = System.Drawing.Color.Transparent;
			cbShowConfirmPassword.Location = new System.Drawing.Point(370, 42);
			cbShowConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
			cbShowConfirmPassword.Name = "cbShowConfirmPassword";
			cbShowConfirmPassword.Size = new System.Drawing.Size(24, 24);
			cbShowConfirmPassword.TabIndex = 39;
			cbShowConfirmPassword.UseVisualStyleBackColor = true;
			cbShowConfirmPassword.CheckedChanged += cbShowConfirmPassword_CheckedChanged;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.padlock;
			pictureBox3.Location = new System.Drawing.Point(13, 11);
			pictureBox3.Margin = new System.Windows.Forms.Padding(2);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(16, 16);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox3.TabIndex = 29;
			pictureBox3.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label2.Location = new System.Drawing.Point(42, 8);
			label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(168, 23);
			label2.TabIndex = 26;
			label2.Text = "Confirm password";
			// 
			// panel4
			// 
			panel4.Controls.Add(pictureBox4);
			panel4.Controls.Add(label3);
			panel4.Controls.Add(txtEmail);
			panel4.Location = new System.Drawing.Point(70, 156);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(417, 83);
			panel4.TabIndex = 36;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.email;
			pictureBox4.Location = new System.Drawing.Point(13, 11);
			pictureBox4.Margin = new System.Windows.Forms.Padding(2);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(16, 16);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox4.TabIndex = 29;
			pictureBox4.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label3.Location = new System.Drawing.Point(42, 8);
			label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(60, 23);
			label3.TabIndex = 26;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Cambria", 12F);
			label4.Location = new System.Drawing.Point(136, 694);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(226, 23);
			label4.TabIndex = 38;
			label4.Text = "Already have an account?";
			// 
			// linkLabel_Login
			// 
			linkLabel_Login.AutoSize = true;
			linkLabel_Login.Font = new System.Drawing.Font("Cambria", 12F);
			linkLabel_Login.LinkColor = System.Drawing.Color.Blue;
			linkLabel_Login.Location = new System.Drawing.Point(368, 694);
			linkLabel_Login.Name = "linkLabel_Login";
			linkLabel_Login.Size = new System.Drawing.Size(63, 23);
			linkLabel_Login.TabIndex = 39;
			linkLabel_Login.TabStop = true;
			linkLabel_Login.Text = "Log in";
			linkLabel_Login.LinkClicked += linkLabel_Login_LinkClicked;
			// 
			// panel5
			// 
			panel5.Controls.Add(pictureBox5);
			panel5.Controls.Add(label7);
			panel5.Controls.Add(txtOTP);
			panel5.Location = new System.Drawing.Point(70, 513);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(283, 88);
			panel5.TabIndex = 40;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = Properties.Resources.security_shield__1_1;
			pictureBox5.Location = new System.Drawing.Point(13, 8);
			pictureBox5.Margin = new System.Windows.Forms.Padding(2);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(30, 30);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox5.TabIndex = 29;
			pictureBox5.TabStop = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label7.Location = new System.Drawing.Point(42, 8);
			label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(46, 23);
			label7.TabIndex = 26;
			label7.Text = "OTP";
			// 
			// txtOTP
			// 
			txtOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtOTP.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOTP.Location = new System.Drawing.Point(13, 45);
			txtOTP.Margin = new System.Windows.Forms.Padding(2);
			txtOTP.Name = "txtOTP";
			txtOTP.Size = new System.Drawing.Size(258, 34);
			txtOTP.TabIndex = 3;
			// 
			// confirmOTPBtn
			// 
			confirmOTPBtn.AutoSize = true;
			confirmOTPBtn.Font = new System.Drawing.Font("Cambria", 12F);
			confirmOTPBtn.Location = new System.Drawing.Point(359, 555);
			confirmOTPBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			confirmOTPBtn.Name = "confirmOTPBtn";
			confirmOTPBtn.Size = new System.Drawing.Size(130, 38);
			confirmOTPBtn.TabIndex = 41;
			confirmOTPBtn.Text = "Confirm OTP";
			confirmOTPBtn.UseVisualStyleBackColor = true;
			confirmOTPBtn.Click += confirmOTPBtn_Click;
			// 
			// getOTPBtn
			// 
			getOTPBtn.AutoSize = true;
			getOTPBtn.Font = new System.Drawing.Font("Cambria", 12F);
			getOTPBtn.Location = new System.Drawing.Point(359, 513);
			getOTPBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			getOTPBtn.Name = "getOTPBtn";
			getOTPBtn.Size = new System.Drawing.Size(128, 38);
			getOTPBtn.TabIndex = 42;
			getOTPBtn.Text = "Get OTP";
			getOTPBtn.UseVisualStyleBackColor = true;
			getOTPBtn.Click += getOTPBtn_Click;
			// 
			// panel6
			// 
			panel6.Controls.Add(typeAccountComboBox);
			panel6.Controls.Add(pictureBox6);
			panel6.Controls.Add(label8);
			panel6.Location = new System.Drawing.Point(70, 424);
			panel6.Name = "panel6";
			panel6.Size = new System.Drawing.Size(417, 83);
			panel6.TabIndex = 43;
			// 
			// typeAccountComboBox
			// 
			typeAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			typeAccountComboBox.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			typeAccountComboBox.FormattingEnabled = true;
			typeAccountComboBox.Items.AddRange(new object[] { "Customer", "Staff" });
			typeAccountComboBox.Location = new System.Drawing.Point(13, 40);
			typeAccountComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			typeAccountComboBox.Name = "typeAccountComboBox";
			typeAccountComboBox.Size = new System.Drawing.Size(387, 35);
			typeAccountComboBox.TabIndex = 30;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = Properties.Resources.user1;
			pictureBox6.Location = new System.Drawing.Point(13, 11);
			pictureBox6.Margin = new System.Windows.Forms.Padding(2);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new System.Drawing.Size(16, 16);
			pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox6.TabIndex = 29;
			pictureBox6.TabStop = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label8.Location = new System.Drawing.Point(42, 8);
			label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(127, 23);
			label8.TabIndex = 26;
			label8.Text = "Type Account";
			// 
			// CustomerSignUpForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(555, 740);
			ControlBox = false;
			Controls.Add(panel6);
			Controls.Add(getOTPBtn);
			Controls.Add(confirmOTPBtn);
			Controls.Add(panel5);
			Controls.Add(linkLabel_Login);
			Controls.Add(label4);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(label5);
			Controls.Add(btnSignUp);
			Margin = new System.Windows.Forms.Padding(2);
			Name = "CustomerSignUpForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbShowPassword;
		private System.Windows.Forms.CheckBox cbShowConfirmPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel_Login;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button confirmOTPBtn;
        private System.Windows.Forms.Button getOTPBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox typeAccountComboBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
    }
}