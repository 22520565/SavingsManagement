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
            tabControl = new System.Windows.Forms.TabControl();
            customerTabPage = new System.Windows.Forms.TabPage();
            cbCustomerRememberInfo = new System.Windows.Forms.CheckBox();
            btnCustomerLogin = new System.Windows.Forms.Button();
            cbCustomerShowPassword = new System.Windows.Forms.CheckBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            txtCustomerPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtCustomerUsername = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            staffTabPage = new System.Windows.Forms.TabPage();
            cbStaffRemeberInfo = new System.Windows.Forms.CheckBox();
            btnStaffLogin = new System.Windows.Forms.Button();
            cbStaffShowPassword = new System.Windows.Forms.CheckBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            txtStaffPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtStaffUsername = new System.Windows.Forms.TextBox();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            tabControl.SuspendLayout();
            customerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            staffTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(customerTabPage);
            tabControl.Controls.Add(staffTabPage);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(618, 528);
            tabControl.TabIndex = 0;
            // 
            // customerTabPage
            // 
            customerTabPage.Controls.Add(cbCustomerRememberInfo);
            customerTabPage.Controls.Add(btnCustomerLogin);
            customerTabPage.Controls.Add(cbCustomerShowPassword);
            customerTabPage.Controls.Add(pictureBox3);
            customerTabPage.Controls.Add(pictureBox2);
            customerTabPage.Controls.Add(label2);
            customerTabPage.Controls.Add(txtCustomerPassword);
            customerTabPage.Controls.Add(label1);
            customerTabPage.Controls.Add(txtCustomerUsername);
            customerTabPage.Controls.Add(pictureBox1);
            customerTabPage.Location = new System.Drawing.Point(4, 29);
            customerTabPage.Name = "customerTabPage";
            customerTabPage.Padding = new System.Windows.Forms.Padding(3);
            customerTabPage.Size = new System.Drawing.Size(610, 495);
            customerTabPage.TabIndex = 0;
            customerTabPage.Text = "Customer";
            customerTabPage.UseVisualStyleBackColor = true;
            // 
            // cbCustomerRememberInfo
            // 
            cbCustomerRememberInfo.AutoSize = true;
            cbCustomerRememberInfo.Location = new System.Drawing.Point(470, 405);
            cbCustomerRememberInfo.Margin = new System.Windows.Forms.Padding(2);
            cbCustomerRememberInfo.Name = "cbCustomerRememberInfo";
            cbCustomerRememberInfo.Size = new System.Drawing.Size(129, 24);
            cbCustomerRememberInfo.TabIndex = 24;
            cbCustomerRememberInfo.Text = "Remember me";
            cbCustomerRememberInfo.UseVisualStyleBackColor = true;
            cbCustomerRememberInfo.CheckedChanged += cbRememberInfo_CheckedChanged;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.AutoSize = true;
            btnCustomerLogin.BackColor = System.Drawing.SystemColors.Control;
            btnCustomerLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCustomerLogin.Location = new System.Drawing.Point(263, 447);
            btnCustomerLogin.Margin = new System.Windows.Forms.Padding(2);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new System.Drawing.Size(130, 42);
            btnCustomerLogin.TabIndex = 22;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            btnCustomerLogin.Click += btnLogin_Click;
            btnCustomerLogin.MouseEnter += btnLogin_MouseEnter;
            btnCustomerLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // cbCustomerShowPassword
            // 
            cbCustomerShowPassword.AutoSize = true;
            cbCustomerShowPassword.Location = new System.Drawing.Point(187, 405);
            cbCustomerShowPassword.Margin = new System.Windows.Forms.Padding(2);
            cbCustomerShowPassword.Name = "cbCustomerShowPassword";
            cbCustomerShowPassword.Size = new System.Drawing.Size(134, 24);
            cbCustomerShowPassword.TabIndex = 21;
            cbCustomerShowPassword.Text = "Show password";
            cbCustomerShowPassword.UseVisualStyleBackColor = true;
            cbCustomerShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.padlock;
            pictureBox3.Location = new System.Drawing.Point(17, 343);
            pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(38, 38);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.user;
            pictureBox2.Location = new System.Drawing.Point(17, 278);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(38, 38);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            label2.Location = new System.Drawing.Point(60, 347);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 32);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCustomerPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtCustomerPassword.Location = new System.Drawing.Point(187, 346);
            txtCustomerPassword.Margin = new System.Windows.Forms.Padding(2);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new System.Drawing.Size(412, 39);
            txtCustomerPassword.TabIndex = 17;
            txtCustomerPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(59, 282);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 32);
            label1.TabIndex = 16;
            label1.Text = "Username";
            // 
            // txtCustomerUsername
            // 
            txtCustomerUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCustomerUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtCustomerUsername.Location = new System.Drawing.Point(187, 280);
            txtCustomerUsername.Margin = new System.Windows.Forms.Padding(2);
            txtCustomerUsername.Name = "txtCustomerUsername";
            txtCustomerUsername.Size = new System.Drawing.Size(412, 39);
            txtCustomerUsername.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = Resources.Users;
            pictureBox1.InitialImage = Resources.user;
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(604, 241);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // staffTabPage
            // 
            staffTabPage.Controls.Add(cbStaffRemeberInfo);
            staffTabPage.Controls.Add(btnStaffLogin);
            staffTabPage.Controls.Add(cbStaffShowPassword);
            staffTabPage.Controls.Add(pictureBox6);
            staffTabPage.Controls.Add(pictureBox7);
            staffTabPage.Controls.Add(label3);
            staffTabPage.Controls.Add(txtStaffPassword);
            staffTabPage.Controls.Add(label4);
            staffTabPage.Controls.Add(txtStaffUsername);
            staffTabPage.Controls.Add(pictureBox8);
            staffTabPage.Location = new System.Drawing.Point(4, 29);
            staffTabPage.Name = "staffTabPage";
            staffTabPage.Padding = new System.Windows.Forms.Padding(3);
            staffTabPage.Size = new System.Drawing.Size(610, 495);
            staffTabPage.TabIndex = 1;
            staffTabPage.Text = "Staff";
            staffTabPage.UseVisualStyleBackColor = true;
            // 
            // cbStaffRemeberInfo
            // 
            cbStaffRemeberInfo.AutoSize = true;
            cbStaffRemeberInfo.Location = new System.Drawing.Point(470, 402);
            cbStaffRemeberInfo.Margin = new System.Windows.Forms.Padding(2);
            cbStaffRemeberInfo.Name = "cbStaffRemeberInfo";
            cbStaffRemeberInfo.Size = new System.Drawing.Size(129, 24);
            cbStaffRemeberInfo.TabIndex = 35;
            cbStaffRemeberInfo.Text = "Remember me";
            cbStaffRemeberInfo.UseVisualStyleBackColor = true;
            // 
            // btnStaffLogin
            // 
            btnStaffLogin.AutoSize = true;
            btnStaffLogin.BackColor = System.Drawing.SystemColors.Control;
            btnStaffLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnStaffLogin.Location = new System.Drawing.Point(263, 444);
            btnStaffLogin.Margin = new System.Windows.Forms.Padding(2);
            btnStaffLogin.Name = "btnStaffLogin";
            btnStaffLogin.Size = new System.Drawing.Size(130, 42);
            btnStaffLogin.TabIndex = 33;
            btnStaffLogin.Text = "Login";
            btnStaffLogin.UseVisualStyleBackColor = false;
            // 
            // cbStaffShowPassword
            // 
            cbStaffShowPassword.AutoSize = true;
            cbStaffShowPassword.Location = new System.Drawing.Point(187, 402);
            cbStaffShowPassword.Margin = new System.Windows.Forms.Padding(2);
            cbStaffShowPassword.Name = "cbStaffShowPassword";
            cbStaffShowPassword.Size = new System.Drawing.Size(134, 24);
            cbStaffShowPassword.TabIndex = 32;
            cbStaffShowPassword.Text = "Show password";
            cbStaffShowPassword.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Resources.padlock;
            pictureBox6.Location = new System.Drawing.Point(17, 340);
            pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(38, 38);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Resources.user;
            pictureBox7.Location = new System.Drawing.Point(17, 275);
            pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(38, 38);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            label3.Location = new System.Drawing.Point(60, 344);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 32);
            label3.TabIndex = 29;
            label3.Text = "Password";
            // 
            // txtStaffPassword
            // 
            txtStaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtStaffPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtStaffPassword.Location = new System.Drawing.Point(187, 343);
            txtStaffPassword.Margin = new System.Windows.Forms.Padding(2);
            txtStaffPassword.Name = "txtStaffPassword";
            txtStaffPassword.Size = new System.Drawing.Size(412, 39);
            txtStaffPassword.TabIndex = 28;
            txtStaffPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label4.Location = new System.Drawing.Point(59, 279);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 32);
            label4.TabIndex = 27;
            label4.Text = "Username";
            // 
            // txtStaffUsername
            // 
            txtStaffUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtStaffUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtStaffUsername.Location = new System.Drawing.Point(187, 277);
            txtStaffUsername.Margin = new System.Windows.Forms.Padding(2);
            txtStaffUsername.Name = "txtStaffUsername";
            txtStaffUsername.Size = new System.Drawing.Size(412, 39);
            txtStaffUsername.TabIndex = 26;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox8.Image = Resources.Users;
            pictureBox8.InitialImage = Resources.user;
            pictureBox8.Location = new System.Drawing.Point(3, 3);
            pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(604, 241);
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(618, 528);
            Controls.Add(tabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            tabControl.ResumeLayout(false);
            customerTabPage.ResumeLayout(false);
            customerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            staffTabPage.ResumeLayout(false);
            staffTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage customerTabPage;
        private System.Windows.Forms.TabPage staffTabPage;
        private System.Windows.Forms.CheckBox cbCustomerRememberInfo;
        private System.Windows.Forms.Button btnCustomerLogin;
        private System.Windows.Forms.CheckBox cbCustomerShowPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbStaffRemeberInfo;
        private System.Windows.Forms.Button btnStaffLogin;
        private System.Windows.Forms.CheckBox cbStaffShowPassword;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}