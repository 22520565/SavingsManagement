namespace GraphicalUserInterface {
	partial class OTPAuthentication {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPAuthentication));
            txtOTP = new System.Windows.Forms.TextBox();
            linkBackToLogin = new System.Windows.Forms.LinkLabel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnOTPAuth = new System.Windows.Forms.Button();
            lbEmail = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            linkResendOTP = new System.Windows.Forms.LinkLabel();
            panelStep1 = new System.Windows.Forms.Panel();
            panelStep2 = new System.Windows.Forms.Panel();
            panelStep3 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtOTP
            // 
            txtOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtOTP.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtOTP.Location = new System.Drawing.Point(106, 325);
            txtOTP.Margin = new System.Windows.Forms.Padding(2);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new System.Drawing.Size(488, 40);
            txtOTP.TabIndex = 3;
            // 
            // linkBackToLogin
            // 
            linkBackToLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkBackToLogin.Image = Properties.Resources.left_arrow_109618;
            linkBackToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            linkBackToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkBackToLogin.LinkColor = System.Drawing.Color.Black;
            linkBackToLogin.Location = new System.Drawing.Point(275, 529);
            linkBackToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new System.Drawing.Size(172, 31);
            linkBackToLogin.TabIndex = 60;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "Back to login";
            linkBackToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            linkBackToLogin.VisitedLinkColor = System.Drawing.Color.Black;
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(128, 222);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(190, 28);
            label2.TabIndex = 59;
            label2.Text = "We sent a code to";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(205, 161);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(297, 47);
            label1.TabIndex = 58;
            label1.Text = "Password reset";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.email1;
            pictureBox1.Location = new System.Drawing.Point(320, 59);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(64, 64);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // btnOTPAuth
            // 
            btnOTPAuth.AutoSize = true;
            btnOTPAuth.BackColor = System.Drawing.Color.Black;
            btnOTPAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOTPAuth.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOTPAuth.ForeColor = System.Drawing.Color.White;
            btnOTPAuth.Location = new System.Drawing.Point(205, 384);
            btnOTPAuth.Margin = new System.Windows.Forms.Padding(2);
            btnOTPAuth.Name = "btnOTPAuth";
            btnOTPAuth.Size = new System.Drawing.Size(308, 66);
            btnOTPAuth.TabIndex = 56;
            btnOTPAuth.Text = "Continue";
            btnOTPAuth.UseVisualStyleBackColor = false;
            btnOTPAuth.Click += btnOTPAuth_Click;
            btnOTPAuth.MouseEnter += btnOTPAuth_MouseEnter;
            btnOTPAuth.MouseLeave += btnOTPAuth_MouseLeave;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbEmail.Location = new System.Drawing.Point(322, 222);
            lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(74, 28);
            lbEmail.TabIndex = 61;
            lbEmail.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(159, 484);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(234, 25);
            label3.TabIndex = 62;
            label3.Text = "Didn't receive the email?";
            // 
            // linkResendOTP
            // 
            linkResendOTP.AutoSize = true;
            linkResendOTP.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            linkResendOTP.Location = new System.Drawing.Point(394, 484);
            linkResendOTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkResendOTP.Name = "linkResendOTP";
            linkResendOTP.Size = new System.Drawing.Size(157, 25);
            linkResendOTP.TabIndex = 63;
            linkResendOTP.TabStop = true;
            linkResendOTP.Text = "Click to resend";
            linkResendOTP.VisitedLinkColor = System.Drawing.Color.Blue;
            linkResendOTP.LinkClicked += linkResendOTP_LinkClicked;
            // 
            // panelStep1
            // 
            panelStep1.BackColor = System.Drawing.Color.WhiteSmoke;
            panelStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelStep1.Location = new System.Drawing.Point(31, 716);
            panelStep1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panelStep1.Name = "panelStep1";
            panelStep1.Size = new System.Drawing.Size(187, 12);
            panelStep1.TabIndex = 64;
            // 
            // panelStep2
            // 
            panelStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelStep2.Location = new System.Drawing.Point(255, 716);
            panelStep2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panelStep2.Name = "panelStep2";
            panelStep2.Size = new System.Drawing.Size(187, 12);
            panelStep2.TabIndex = 65;
            // 
            // panelStep3
            // 
            panelStep3.BackColor = System.Drawing.Color.WhiteSmoke;
            panelStep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelStep3.Location = new System.Drawing.Point(478, 716);
            panelStep3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panelStep3.Name = "panelStep3";
            panelStep3.Size = new System.Drawing.Size(187, 12);
            panelStep3.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(101, 290);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 28);
            label4.TabIndex = 67;
            label4.Text = "OTP";
            // 
            // OTPAuthentication
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(700, 788);
            Controls.Add(label4);
            Controls.Add(panelStep3);
            Controls.Add(panelStep2);
            Controls.Add(panelStep1);
            Controls.Add(linkResendOTP);
            Controls.Add(label3);
            Controls.Add(txtOTP);
            Controls.Add(lbEmail);
            Controls.Add(linkBackToLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnOTPAuth);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "OTPAuthentication";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "OTPAuthentication";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOTP;
		private System.Windows.Forms.LinkLabel linkBackToLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnOTPAuth;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkResendOTP;
		private System.Windows.Forms.Panel panelStep1;
		private System.Windows.Forms.Panel panelStep2;
		private System.Windows.Forms.Panel panelStep3;
		private System.Windows.Forms.Label label4;
	}
}