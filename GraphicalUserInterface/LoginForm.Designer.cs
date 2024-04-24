namespace Gui
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
            pictureBox1.Location = new System.Drawing.Point(160, 16);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            txtUsername.Location = new System.Drawing.Point(190, 287);
            txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(412, 39);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(71, 289);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 32);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            label2.Location = new System.Drawing.Point(72, 354);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 32);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtPassword.Location = new System.Drawing.Point(190, 353);
            txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(412, 39);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(29, 285);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(38, 38);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new System.Drawing.Point(29, 350);
            pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(38, 38);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new System.Drawing.Point(190, 412);
            cbShowPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new System.Drawing.Size(134, 24);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // linkLabel_ForgotPassword
            // 
            linkLabel_ForgotPassword.AutoSize = true;
            linkLabel_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            linkLabel_ForgotPassword.Location = new System.Drawing.Point(78, 471);
            linkLabel_ForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
            linkLabel_ForgotPassword.Size = new System.Drawing.Size(201, 32);
            linkLabel_ForgotPassword.TabIndex = 8;
            linkLabel_ForgotPassword.TabStop = true;
            linkLabel_ForgotPassword.Text = "Forgot password?";
            linkLabel_ForgotPassword.LinkClicked += linkLabel_ForgotPassword_LinkClicked;
            // 
            // linkLabel_SignUp
            // 
            linkLabel_SignUp.AutoSize = true;
            linkLabel_SignUp.Font = new System.Drawing.Font("Segoe UI", 14F);
            linkLabel_SignUp.Location = new System.Drawing.Point(434, 471);
            linkLabel_SignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            linkLabel_SignUp.Name = "linkLabel_SignUp";
            linkLabel_SignUp.Size = new System.Drawing.Size(98, 32);
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
            btnLogin.Location = new System.Drawing.Point(255, 544);
            btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(130, 42);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new System.Drawing.Point(0, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(80, 80);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // cbRememberInfo
            // 
            cbRememberInfo.AutoSize = true;
            cbRememberInfo.Location = new System.Drawing.Point(387, 412);
            cbRememberInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbRememberInfo.Name = "cbRememberInfo";
            cbRememberInfo.Size = new System.Drawing.Size(224, 24);
            cbRememberInfo.TabIndex = 13;
            cbRememberInfo.Text = "Remember login information";
            cbRememberInfo.UseVisualStyleBackColor = true;
            cbRememberInfo.CheckedChanged += cbRememberInfo_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.Control;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.Location = new System.Drawing.Point(590, 10);
            btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(40, 40);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(640, 624);
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
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_Login";
            Load += LoginForm_Load;
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