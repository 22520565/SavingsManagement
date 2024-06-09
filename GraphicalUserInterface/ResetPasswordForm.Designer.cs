namespace GraphicalUserInterface
{
    partial class ResetPasswordForm
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
			pictureBox1 = new System.Windows.Forms.PictureBox();
			panel3 = new System.Windows.Forms.Panel();
			cbShowConfirmPassword = new System.Windows.Forms.CheckBox();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label2 = new System.Windows.Forms.Label();
			txtConfirmPassword = new System.Windows.Forms.TextBox();
			panel2 = new System.Windows.Forms.Panel();
			cbShowPassword = new System.Windows.Forms.CheckBox();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			txtPassword = new System.Windows.Forms.TextBox();
			btnConfirmPassword = new System.Windows.Forms.Button();
			panelStep3 = new System.Windows.Forms.Panel();
			panelStep2 = new System.Windows.Forms.Panel();
			panelStep1 = new System.Windows.Forms.Panel();
			linkBackToLogin = new System.Windows.Forms.LinkLabel();
			label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.password;
			pictureBox1.Location = new System.Drawing.Point(241, 36);
			pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(64, 64);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			panel3.Controls.Add(cbShowConfirmPassword);
			panel3.Controls.Add(pictureBox3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(txtConfirmPassword);
			panel3.Location = new System.Drawing.Point(89, 286);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(362, 83);
			panel3.TabIndex = 39;
			// 
			// cbShowConfirmPassword
			// 
			cbShowConfirmPassword.BackgroundImage = Properties.Resources.show;
			cbShowConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			cbShowConfirmPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbShowConfirmPassword.ForeColor = System.Drawing.Color.Transparent;
			cbShowConfirmPassword.Location = new System.Drawing.Point(321, 42);
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
			// txtConfirmPassword
			// 
			txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtConfirmPassword.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtConfirmPassword.Location = new System.Drawing.Point(13, 37);
			txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
			txtConfirmPassword.Name = "txtConfirmPassword";
			txtConfirmPassword.Size = new System.Drawing.Size(341, 34);
			txtConfirmPassword.TabIndex = 7;
			txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(cbShowPassword);
			panel2.Controls.Add(pictureBox2);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(txtPassword);
			panel2.Location = new System.Drawing.Point(89, 197);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(362, 83);
			panel2.TabIndex = 38;
			// 
			// cbShowPassword
			// 
			cbShowPassword.BackgroundImage = Properties.Resources.show;
			cbShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			cbShowPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbShowPassword.ForeColor = System.Drawing.Color.Transparent;
			cbShowPassword.Location = new System.Drawing.Point(321, 42);
			cbShowPassword.Margin = new System.Windows.Forms.Padding(2);
			cbShowPassword.Name = "cbShowPassword";
			cbShowPassword.Size = new System.Drawing.Size(24, 24);
			cbShowPassword.TabIndex = 38;
			cbShowPassword.UseVisualStyleBackColor = true;
			cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.padlock;
			pictureBox2.Location = new System.Drawing.Point(13, 11);
			pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(16, 16);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 29;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label1.Location = new System.Drawing.Point(42, 8);
			label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(137, 23);
			label1.TabIndex = 26;
			label1.Text = "New Password";
			// 
			// txtPassword
			// 
			txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtPassword.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtPassword.Location = new System.Drawing.Point(13, 37);
			txtPassword.Margin = new System.Windows.Forms.Padding(2);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(341, 34);
			txtPassword.TabIndex = 5;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnConfirmPassword
			// 
			btnConfirmPassword.AutoSize = true;
			btnConfirmPassword.BackColor = System.Drawing.Color.Black;
			btnConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			btnConfirmPassword.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnConfirmPassword.ForeColor = System.Drawing.Color.White;
			btnConfirmPassword.Location = new System.Drawing.Point(185, 388);
			btnConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
			btnConfirmPassword.Name = "btnConfirmPassword";
			btnConfirmPassword.Size = new System.Drawing.Size(187, 46);
			btnConfirmPassword.TabIndex = 48;
			btnConfirmPassword.Text = "Confirm";
			btnConfirmPassword.UseVisualStyleBackColor = false;
			btnConfirmPassword.Click += btnConfirmPassword_Click;
			btnConfirmPassword.MouseEnter += btnConfirmPassword_MouseEnter;
			btnConfirmPassword.MouseLeave += btnConfirmPassword_MouseLeave;
			// 
			// panelStep3
			// 
			panelStep3.BackColor = System.Drawing.Color.WhiteSmoke;
			panelStep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelStep3.Location = new System.Drawing.Point(379, 573);
			panelStep3.Name = "panelStep3";
			panelStep3.Size = new System.Drawing.Size(150, 10);
			panelStep3.TabIndex = 72;
			// 
			// panelStep2
			// 
			panelStep2.BackColor = System.Drawing.Color.WhiteSmoke;
			panelStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelStep2.Location = new System.Drawing.Point(204, 573);
			panelStep2.Name = "panelStep2";
			panelStep2.Size = new System.Drawing.Size(150, 10);
			panelStep2.TabIndex = 71;
			// 
			// panelStep1
			// 
			panelStep1.BackColor = System.Drawing.Color.WhiteSmoke;
			panelStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelStep1.Location = new System.Drawing.Point(25, 573);
			panelStep1.Name = "panelStep1";
			panelStep1.Size = new System.Drawing.Size(150, 10);
			panelStep1.TabIndex = 70;
			// 
			// linkBackToLogin
			// 
			linkBackToLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			linkBackToLogin.Image = Properties.Resources.left_arrow_109618;
			linkBackToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			linkBackToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			linkBackToLogin.LinkColor = System.Drawing.Color.Black;
			linkBackToLogin.Location = new System.Drawing.Point(210, 446);
			linkBackToLogin.Name = "linkBackToLogin";
			linkBackToLogin.Size = new System.Drawing.Size(138, 25);
			linkBackToLogin.TabIndex = 73;
			linkBackToLogin.TabStop = true;
			linkBackToLogin.Text = "Back to login";
			linkBackToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			linkBackToLogin.VisitedLinkColor = System.Drawing.Color.Black;
			linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.Location = new System.Drawing.Point(132, 112);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(295, 40);
			label3.TabIndex = 74;
			label3.Text = "Set new password";
			// 
			// ResetPasswordForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(560, 630);
			Controls.Add(label3);
			Controls.Add(linkBackToLogin);
			Controls.Add(panelStep3);
			Controls.Add(panelStep2);
			Controls.Add(panelStep1);
			Controls.Add(btnConfirmPassword);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(pictureBox1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Margin = new System.Windows.Forms.Padding(2);
			Name = "ResetPasswordForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "ResetPasswordForm";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbShowConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConfirmPassword;
		private System.Windows.Forms.Panel panelStep3;
		private System.Windows.Forms.Panel panelStep2;
		private System.Windows.Forms.Panel panelStep1;
		private System.Windows.Forms.LinkLabel linkBackToLogin;
		private System.Windows.Forms.Label label3;
	}
}