namespace GraphicalUserInterface
{
    partial class ForgotPasswordForm
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
			panel4 = new System.Windows.Forms.Panel();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			label3 = new System.Windows.Forms.Label();
			txtEmail = new System.Windows.Forms.TextBox();
			btnResetPassword = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			linkBackToLogin = new System.Windows.Forms.LinkLabel();
			panelStep3 = new System.Windows.Forms.Panel();
			panelStep2 = new System.Windows.Forms.Panel();
			panelStep1 = new System.Windows.Forms.Panel();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel4
			// 
			panel4.Controls.Add(pictureBox4);
			panel4.Controls.Add(label3);
			panel4.Controls.Add(txtEmail);
			panel4.Location = new System.Drawing.Point(70, 231);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(417, 83);
			panel4.TabIndex = 43;
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
			label3.Location = new System.Drawing.Point(42, 7);
			label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(60, 23);
			label3.TabIndex = 26;
			label3.Text = "Email";
			// 
			// txtEmail
			// 
			txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtEmail.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtEmail.Location = new System.Drawing.Point(13, 36);
			txtEmail.Margin = new System.Windows.Forms.Padding(2);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new System.Drawing.Size(402, 34);
			txtEmail.TabIndex = 9;
			// 
			// btnResetPassword
			// 
			btnResetPassword.AutoSize = true;
			btnResetPassword.BackColor = System.Drawing.Color.Black;
			btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			btnResetPassword.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnResetPassword.ForeColor = System.Drawing.Color.White;
			btnResetPassword.Location = new System.Drawing.Point(169, 330);
			btnResetPassword.Margin = new System.Windows.Forms.Padding(2);
			btnResetPassword.Name = "btnResetPassword";
			btnResetPassword.Size = new System.Drawing.Size(246, 53);
			btnResetPassword.TabIndex = 47;
			btnResetPassword.Text = "Reset password ";
			btnResetPassword.UseVisualStyleBackColor = false;
			btnResetPassword.Click += btnResetPassword_Click;
			btnResetPassword.MouseEnter += btnResetPassword_MouseEnter;
			btnResetPassword.MouseLeave += btnResetPassword_MouseLeave;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.key_9567357;
			pictureBox1.Location = new System.Drawing.Point(257, 37);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(64, 64);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 49;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.Location = new System.Drawing.Point(143, 116);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(291, 40);
			label1.TabIndex = 50;
			label1.Text = "Forgot password?";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.Location = new System.Drawing.Point(83, 166);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(391, 23);
			label2.TabIndex = 51;
			label2.Text = "No worries, we'll send you reset instructions";
			// 
			// linkBackToLogin
			// 
			linkBackToLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			linkBackToLogin.Image = Properties.Resources.left_arrow_109618;
			linkBackToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			linkBackToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			linkBackToLogin.LinkColor = System.Drawing.Color.Black;
			linkBackToLogin.Location = new System.Drawing.Point(222, 394);
			linkBackToLogin.Name = "linkBackToLogin";
			linkBackToLogin.Size = new System.Drawing.Size(138, 25);
			linkBackToLogin.TabIndex = 53;
			linkBackToLogin.TabStop = true;
			linkBackToLogin.Text = "Back to login";
			linkBackToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			linkBackToLogin.VisitedLinkColor = System.Drawing.Color.Black;
			linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
			// 
			// panelStep3
			// 
			panelStep3.BackColor = System.Drawing.Color.WhiteSmoke;
			panelStep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelStep3.Location = new System.Drawing.Point(379, 573);
			panelStep3.Name = "panelStep3";
			panelStep3.Size = new System.Drawing.Size(150, 10);
			panelStep3.TabIndex = 69;
			// 
			// panelStep2
			// 
			panelStep2.BackColor = System.Drawing.Color.WhiteSmoke;
			panelStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelStep2.Location = new System.Drawing.Point(204, 573);
			panelStep2.Name = "panelStep2";
			panelStep2.Size = new System.Drawing.Size(150, 10);
			panelStep2.TabIndex = 68;
			// 
			// panelStep1
			// 
			panelStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelStep1.Location = new System.Drawing.Point(25, 573);
			panelStep1.Name = "panelStep1";
			panelStep1.Size = new System.Drawing.Size(150, 10);
			panelStep1.TabIndex = 67;
			// 
			// ForgotPasswordForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			BackColor = System.Drawing.SystemColors.ButtonHighlight;
			ClientSize = new System.Drawing.Size(560, 630);
			Controls.Add(panelStep3);
			Controls.Add(panelStep2);
			Controls.Add(panelStep1);
			Controls.Add(linkBackToLogin);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(btnResetPassword);
			Controls.Add(panel4);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Margin = new System.Windows.Forms.Padding(2);
			Name = "ForgotPasswordForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "ForgotPasswordForm";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkBackToLogin;
		private System.Windows.Forms.Panel panelStep3;
		private System.Windows.Forms.Panel panelStep2;
		private System.Windows.Forms.Panel panelStep1;
	}
}