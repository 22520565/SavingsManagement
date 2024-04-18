namespace GraphicalUserInterface
{
    partial class Form_Login
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtUsername = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            cbShowPassword = new System.Windows.Forms.CheckBox();
            linkLabel_ForgotPassword = new System.Windows.Forms.LinkLabel();
            linkLabel_SignUp = new System.Windows.Forms.LinkLabel();
            btnLogin = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            cbRememberInfo = new System.Windows.Forms.CheckBox();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users;
            pictureBox1.Location = new System.Drawing.Point(200, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(400, 300);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtUsername.Location = new System.Drawing.Point(237, 359);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(514, 45);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(89, 361);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 38);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            label2.Location = new System.Drawing.Point(90, 443);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 38);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtPassword.Location = new System.Drawing.Point(237, 441);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(514, 45);
            txtPassword.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new System.Drawing.Point(36, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(48, 48);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new System.Drawing.Point(36, 438);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(48, 48);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new System.Drawing.Point(237, 515);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new System.Drawing.Size(164, 29);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // linkLabel_ForgotPassword
            // 
            linkLabel_ForgotPassword.AutoSize = true;
            linkLabel_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            linkLabel_ForgotPassword.Location = new System.Drawing.Point(98, 589);
            linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
            linkLabel_ForgotPassword.Size = new System.Drawing.Size(235, 38);
            linkLabel_ForgotPassword.TabIndex = 8;
            linkLabel_ForgotPassword.TabStop = true;
            linkLabel_ForgotPassword.Text = "Forgot password?";
            linkLabel_ForgotPassword.LinkClicked += linkLabel_ForgotPassword_LinkClicked;
            // 
            // linkLabel_SignUp
            // 
            linkLabel_SignUp.AutoSize = true;
            linkLabel_SignUp.Font = new System.Drawing.Font("Segoe UI", 14F);
            linkLabel_SignUp.Location = new System.Drawing.Point(543, 589);
            linkLabel_SignUp.Name = "linkLabel_SignUp";
            linkLabel_SignUp.Size = new System.Drawing.Size(114, 38);
            linkLabel_SignUp.TabIndex = 9;
            linkLabel_SignUp.TabStop = true;
            linkLabel_SignUp.Text = "Sign Up";
            linkLabel_SignUp.LinkClicked += linkLabel_SignUp_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = System.Drawing.SystemColors.Control;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.Location = new System.Drawing.Point(319, 680);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(163, 48);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.login;
            pictureBox4.Location = new System.Drawing.Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(100, 100);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // cbRememberInfo
            // 
            cbRememberInfo.AutoSize = true;
            cbRememberInfo.Location = new System.Drawing.Point(484, 515);
            cbRememberInfo.Name = "cbRememberInfo";
            cbRememberInfo.Size = new System.Drawing.Size(267, 29);
            cbRememberInfo.TabIndex = 13;
            cbRememberInfo.Text = "Remember login information";
            cbRememberInfo.UseVisualStyleBackColor = true;
            cbRememberInfo.CheckedChanged += cbRememberInfo_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.Control;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.Location = new System.Drawing.Point(738, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(50, 50);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 780);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(cbRememberInfo);
            Controls.Add(pictureBox4);
            Controls.Add(btnLogin);
            Controls.Add(linkLabel_SignUp);
            Controls.Add(linkLabel_ForgotPassword);
            Controls.Add(cbShowPassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Form_Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_Login";
            Load += Form_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPassword;
        private System.Windows.Forms.LinkLabel linkLabel_SignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox cbRememberInfo;
        private System.Windows.Forms.Button btnExit;
    }
}