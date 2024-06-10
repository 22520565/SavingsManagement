namespace GraphicalUserInterface
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
		private void InitializeComponent() {
			tabControl = new System.Windows.Forms.TabControl();
			customerTabPage = new System.Windows.Forms.TabPage();
			linkLabel_ForgotPassword = new System.Windows.Forms.LinkLabel();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			linkLabel_SignUp = new System.Windows.Forms.LinkLabel();
			btnExit = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label2 = new System.Windows.Forms.Label();
			cbCustomerShowPassword = new System.Windows.Forms.CheckBox();
			txtCustomerPassword = new System.Windows.Forms.TextBox();
			panel1 = new System.Windows.Forms.Panel();
			txtCustomerUsername = new System.Windows.Forms.TextBox();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			cbCustomerRememberInfo = new System.Windows.Forms.CheckBox();
			btnCustomerLogin = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			staffTabPage = new System.Windows.Forms.TabPage();
			linkLabel1 = new System.Windows.Forms.LinkLabel();
			label8 = new System.Windows.Forms.Label();
			linkLabel2 = new System.Windows.Forms.LinkLabel();
			label4 = new System.Windows.Forms.Label();
			btnStaffExit = new System.Windows.Forms.Button();
			panel4 = new System.Windows.Forms.Panel();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			label3 = new System.Windows.Forms.Label();
			cbStaffShowPassword = new System.Windows.Forms.CheckBox();
			txtStaffPassword = new System.Windows.Forms.TextBox();
			panel3 = new System.Windows.Forms.Panel();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			label5 = new System.Windows.Forms.Label();
			txtStaffUsername = new System.Windows.Forms.TextBox();
			cbStaffRemeberInfo = new System.Windows.Forms.CheckBox();
			btnStaffLogin = new System.Windows.Forms.Button();
			pictureBox8 = new System.Windows.Forms.PictureBox();
			tabControl.SuspendLayout();
			customerTabPage.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			staffTabPage.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(customerTabPage);
			tabControl.Controls.Add(staffTabPage);
			tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			tabControl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			tabControl.Location = new System.Drawing.Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new System.Drawing.Size(968, 588);
			tabControl.TabIndex = 0;
			// 
			// customerTabPage
			// 
			customerTabPage.BackColor = System.Drawing.Color.Transparent;
			customerTabPage.Controls.Add(linkLabel_ForgotPassword);
			customerTabPage.Controls.Add(label6);
			customerTabPage.Controls.Add(label7);
			customerTabPage.Controls.Add(linkLabel_SignUp);
			customerTabPage.Controls.Add(btnExit);
			customerTabPage.Controls.Add(panel2);
			customerTabPage.Controls.Add(panel1);
			customerTabPage.Controls.Add(cbCustomerRememberInfo);
			customerTabPage.Controls.Add(btnCustomerLogin);
			customerTabPage.Controls.Add(pictureBox1);
			customerTabPage.Location = new System.Drawing.Point(4, 36);
			customerTabPage.Name = "customerTabPage";
			customerTabPage.Padding = new System.Windows.Forms.Padding(3);
			customerTabPage.Size = new System.Drawing.Size(960, 548);
			customerTabPage.TabIndex = 0;
			customerTabPage.Text = "Customer";
			// 
			// linkLabel_ForgotPassword
			// 
			linkLabel_ForgotPassword.AutoSize = true;
			linkLabel_ForgotPassword.Font = new System.Drawing.Font("Cambria", 10.8F);
			linkLabel_ForgotPassword.Location = new System.Drawing.Point(773, 307);
			linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
			linkLabel_ForgotPassword.Size = new System.Drawing.Size(149, 21);
			linkLabel_ForgotPassword.TabIndex = 46;
			linkLabel_ForgotPassword.TabStop = true;
			linkLabel_ForgotPassword.Text = "Forgot password?";
			linkLabel_ForgotPassword.LinkClicked += linkLabel_ForgotPassword_LinkClicked;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label6.Location = new System.Drawing.Point(569, 43);
			label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(345, 40);
			label6.TabIndex = 30;
			label6.Text = "Savings Management";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Cambria", 10.8F);
			label7.Location = new System.Drawing.Point(587, 474);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(188, 21);
			label7.TabIndex = 45;
			label7.Text = "Don't have an account?";
			// 
			// linkLabel_SignUp
			// 
			linkLabel_SignUp.AutoSize = true;
			linkLabel_SignUp.Font = new System.Drawing.Font("Cambria", 10.8F);
			linkLabel_SignUp.Location = new System.Drawing.Point(782, 474);
			linkLabel_SignUp.Name = "linkLabel_SignUp";
			linkLabel_SignUp.Size = new System.Drawing.Size(114, 21);
			linkLabel_SignUp.TabIndex = 44;
			linkLabel_SignUp.TabStop = true;
			linkLabel_SignUp.Text = "Register Now";
			linkLabel_SignUp.LinkClicked += linkLabel_SignUp_LinkClicked;
			// 
			// btnExit
			// 
			btnExit.AutoSize = true;
			btnExit.BackColor = System.Drawing.SystemColors.Control;
			btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			btnExit.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnExit.ForeColor = System.Drawing.Color.Black;
			btnExit.Location = new System.Drawing.Point(764, 385);
			btnExit.Margin = new System.Windows.Forms.Padding(2);
			btnExit.Name = "btnExit";
			btnExit.Padding = new System.Windows.Forms.Padding(5);
			btnExit.Size = new System.Drawing.Size(130, 53);
			btnExit.TabIndex = 4;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			btnExit.MouseEnter += btnExit_MouseEnter;
			btnExit.MouseLeave += btnExit_MouseLeave;
			// 
			// panel2
			// 
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(cbCustomerShowPassword);
			panel2.Controls.Add(txtCustomerPassword);
			panel2.Location = new System.Drawing.Point(561, 216);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(361, 83);
			panel2.TabIndex = 35;
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
			label2.Size = new System.Drawing.Size(94, 23);
			label2.TabIndex = 26;
			label2.Text = "Password";
			// 
			// cbCustomerShowPassword
			// 
			cbCustomerShowPassword.BackgroundImage = Properties.Resources.show;
			cbCustomerShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			cbCustomerShowPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCustomerShowPassword.ForeColor = System.Drawing.Color.Transparent;
			cbCustomerShowPassword.Location = new System.Drawing.Point(317, 43);
			cbCustomerShowPassword.Margin = new System.Windows.Forms.Padding(2);
			cbCustomerShowPassword.Name = "cbCustomerShowPassword";
			cbCustomerShowPassword.Size = new System.Drawing.Size(24, 24);
			cbCustomerShowPassword.TabIndex = 5;
			cbCustomerShowPassword.TabStop = false;
			cbCustomerShowPassword.UseVisualStyleBackColor = true;
			cbCustomerShowPassword.CheckedChanged += cbCustomerShowPassword_CheckedChanged;
			// 
			// txtCustomerPassword
			// 
			txtCustomerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtCustomerPassword.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCustomerPassword.Location = new System.Drawing.Point(13, 38);
			txtCustomerPassword.Margin = new System.Windows.Forms.Padding(2);
			txtCustomerPassword.Name = "txtCustomerPassword";
			txtCustomerPassword.Size = new System.Drawing.Size(335, 34);
			txtCustomerPassword.TabIndex = 2;
			txtCustomerPassword.UseSystemPasswordChar = true;
			// 
			// panel1
			// 
			panel1.Controls.Add(txtCustomerUsername);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(561, 127);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(361, 83);
			panel1.TabIndex = 34;
			// 
			// txtCustomerUsername
			// 
			txtCustomerUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtCustomerUsername.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCustomerUsername.Location = new System.Drawing.Point(13, 38);
			txtCustomerUsername.Margin = new System.Windows.Forms.Padding(2);
			txtCustomerUsername.Name = "txtCustomerUsername";
			txtCustomerUsername.Size = new System.Drawing.Size(335, 34);
			txtCustomerUsername.TabIndex = 1;
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label1.Location = new System.Drawing.Point(42, 8);
			label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(98, 23);
			label1.TabIndex = 26;
			label1.Text = "Username";
			// 
			// cbCustomerRememberInfo
			// 
			cbCustomerRememberInfo.AutoSize = true;
			cbCustomerRememberInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCustomerRememberInfo.Location = new System.Drawing.Point(574, 304);
			cbCustomerRememberInfo.Margin = new System.Windows.Forms.Padding(2);
			cbCustomerRememberInfo.Name = "cbCustomerRememberInfo";
			cbCustomerRememberInfo.Size = new System.Drawing.Size(158, 27);
			cbCustomerRememberInfo.TabIndex = 6;
			cbCustomerRememberInfo.Text = "Remember me";
			cbCustomerRememberInfo.UseVisualStyleBackColor = true;
			cbCustomerRememberInfo.CheckedChanged += cbCustomerRememberInfo_CheckedChanged;
			// 
			// btnCustomerLogin
			// 
			btnCustomerLogin.AutoSize = true;
			btnCustomerLogin.BackColor = System.Drawing.Color.Black;
			btnCustomerLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			btnCustomerLogin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnCustomerLogin.ForeColor = System.Drawing.Color.White;
			btnCustomerLogin.Location = new System.Drawing.Point(602, 385);
			btnCustomerLogin.Margin = new System.Windows.Forms.Padding(2);
			btnCustomerLogin.Name = "btnCustomerLogin";
			btnCustomerLogin.Padding = new System.Windows.Forms.Padding(5);
			btnCustomerLogin.Size = new System.Drawing.Size(130, 53);
			btnCustomerLogin.TabIndex = 3;
			btnCustomerLogin.Text = "Login";
			btnCustomerLogin.UseVisualStyleBackColor = false;
			btnCustomerLogin.Click += btnCustomerLogin_Click;
			btnCustomerLogin.MouseEnter += btnCustomerLogin_MouseEnter;
			btnCustomerLogin.MouseLeave += btnCustomerLogin_MouseLeave;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.bg1;
			pictureBox1.InitialImage = Properties.Resources.user;
			pictureBox1.Location = new System.Drawing.Point(-4, 0);
			pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(517, 548);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 14;
			pictureBox1.TabStop = false;
			// 
			// staffTabPage
			// 
			staffTabPage.BackColor = System.Drawing.Color.Transparent;
			staffTabPage.Controls.Add(linkLabel1);
			staffTabPage.Controls.Add(label8);
			staffTabPage.Controls.Add(linkLabel2);
			staffTabPage.Controls.Add(label4);
			staffTabPage.Controls.Add(btnStaffExit);
			staffTabPage.Controls.Add(panel4);
			staffTabPage.Controls.Add(panel3);
			staffTabPage.Controls.Add(cbStaffRemeberInfo);
			staffTabPage.Controls.Add(btnStaffLogin);
			staffTabPage.Controls.Add(pictureBox8);
			staffTabPage.Location = new System.Drawing.Point(4, 36);
			staffTabPage.Name = "staffTabPage";
			staffTabPage.Padding = new System.Windows.Forms.Padding(3);
			staffTabPage.Size = new System.Drawing.Size(960, 548);
			staffTabPage.TabIndex = 1;
			staffTabPage.Text = "Staff";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new System.Drawing.Font("Cambria", 10.8F);
			linkLabel1.Location = new System.Drawing.Point(247, 300);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new System.Drawing.Size(149, 21);
			linkLabel1.TabIndex = 49;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Forgot password?";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Cambria", 10.8F);
			label8.Location = new System.Drawing.Point(67, 488);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(188, 21);
			label8.TabIndex = 48;
			label8.Text = "Don't have an account?";
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Font = new System.Drawing.Font("Cambria", 10.8F);
			linkLabel2.Location = new System.Drawing.Point(262, 488);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new System.Drawing.Size(114, 21);
			linkLabel2.TabIndex = 47;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "Register Now";
			linkLabel2.LinkClicked += linkLabel2_LinkClicked;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.Location = new System.Drawing.Point(57, 42);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(345, 40);
			label4.TabIndex = 40;
			label4.Text = "Savings Management";
			// 
			// btnStaffExit
			// 
			btnStaffExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			btnStaffExit.BackColor = System.Drawing.SystemColors.Control;
			btnStaffExit.Cursor = System.Windows.Forms.Cursors.Hand;
			btnStaffExit.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnStaffExit.Location = new System.Drawing.Point(246, 374);
			btnStaffExit.Margin = new System.Windows.Forms.Padding(2);
			btnStaffExit.Name = "btnStaffExit";
			btnStaffExit.Padding = new System.Windows.Forms.Padding(5);
			btnStaffExit.Size = new System.Drawing.Size(130, 53);
			btnStaffExit.TabIndex = 6;
			btnStaffExit.Text = "Exit";
			btnStaffExit.UseVisualStyleBackColor = false;
			btnStaffExit.Click += btnStaffExit_Click;
			btnStaffExit.MouseEnter += btnStaffExit_MouseEnter;
			btnStaffExit.MouseLeave += btnStaffExit_MouseLeave;
			// 
			// panel4
			// 
			panel4.Controls.Add(pictureBox5);
			panel4.Controls.Add(label3);
			panel4.Controls.Add(cbStaffShowPassword);
			panel4.Controls.Add(txtStaffPassword);
			panel4.Location = new System.Drawing.Point(45, 206);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(361, 83);
			panel4.TabIndex = 37;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = Properties.Resources.padlock;
			pictureBox5.Location = new System.Drawing.Point(13, 11);
			pictureBox5.Margin = new System.Windows.Forms.Padding(2);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(16, 16);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox5.TabIndex = 29;
			pictureBox5.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label3.Location = new System.Drawing.Point(42, 8);
			label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(94, 23);
			label3.TabIndex = 26;
			label3.Text = "Password";
			// 
			// cbStaffShowPassword
			// 
			cbStaffShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			cbStaffShowPassword.BackgroundImage = Properties.Resources.show;
			cbStaffShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			cbStaffShowPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbStaffShowPassword.Location = new System.Drawing.Point(322, 39);
			cbStaffShowPassword.Margin = new System.Windows.Forms.Padding(2);
			cbStaffShowPassword.Name = "cbStaffShowPassword";
			cbStaffShowPassword.Size = new System.Drawing.Size(24, 24);
			cbStaffShowPassword.TabIndex = 3;
			cbStaffShowPassword.UseVisualStyleBackColor = true;
			cbStaffShowPassword.CheckedChanged += cbStaffShowPassword_CheckedChanged;
			// 
			// txtStaffPassword
			// 
			txtStaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtStaffPassword.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtStaffPassword.Location = new System.Drawing.Point(12, 33);
			txtStaffPassword.Margin = new System.Windows.Forms.Padding(2);
			txtStaffPassword.Name = "txtStaffPassword";
			txtStaffPassword.Size = new System.Drawing.Size(338, 34);
			txtStaffPassword.TabIndex = 2;
			txtStaffPassword.UseSystemPasswordChar = true;
			// 
			// panel3
			// 
			panel3.Controls.Add(pictureBox4);
			panel3.Controls.Add(label5);
			panel3.Controls.Add(txtStaffUsername);
			panel3.Location = new System.Drawing.Point(45, 117);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(361, 83);
			panel3.TabIndex = 36;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.user1;
			pictureBox4.Location = new System.Drawing.Point(13, 11);
			pictureBox4.Margin = new System.Windows.Forms.Padding(2);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(16, 16);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox4.TabIndex = 29;
			pictureBox4.TabStop = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			label5.Location = new System.Drawing.Point(42, 8);
			label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(98, 23);
			label5.TabIndex = 26;
			label5.Text = "Username";
			// 
			// txtStaffUsername
			// 
			txtStaffUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtStaffUsername.Font = new System.Drawing.Font("Cambria", 13.8F);
			txtStaffUsername.Location = new System.Drawing.Point(13, 33);
			txtStaffUsername.Margin = new System.Windows.Forms.Padding(2);
			txtStaffUsername.Name = "txtStaffUsername";
			txtStaffUsername.Size = new System.Drawing.Size(338, 34);
			txtStaffUsername.TabIndex = 1;
			// 
			// cbStaffRemeberInfo
			// 
			cbStaffRemeberInfo.AutoSize = true;
			cbStaffRemeberInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbStaffRemeberInfo.Location = new System.Drawing.Point(58, 297);
			cbStaffRemeberInfo.Margin = new System.Windows.Forms.Padding(2);
			cbStaffRemeberInfo.Name = "cbStaffRemeberInfo";
			cbStaffRemeberInfo.Size = new System.Drawing.Size(158, 27);
			cbStaffRemeberInfo.TabIndex = 4;
			cbStaffRemeberInfo.Text = "Remember me";
			cbStaffRemeberInfo.UseVisualStyleBackColor = true;
			cbStaffRemeberInfo.CheckedChanged += cbStaffRemeberInfo_CheckedChanged;
			// 
			// btnStaffLogin
			// 
			btnStaffLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			btnStaffLogin.BackColor = System.Drawing.Color.Black;
			btnStaffLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			btnStaffLogin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnStaffLogin.ForeColor = System.Drawing.Color.White;
			btnStaffLogin.Location = new System.Drawing.Point(78, 374);
			btnStaffLogin.Margin = new System.Windows.Forms.Padding(2);
			btnStaffLogin.Name = "btnStaffLogin";
			btnStaffLogin.Padding = new System.Windows.Forms.Padding(5);
			btnStaffLogin.Size = new System.Drawing.Size(130, 53);
			btnStaffLogin.TabIndex = 5;
			btnStaffLogin.Text = "Login";
			btnStaffLogin.UseVisualStyleBackColor = false;
			btnStaffLogin.Click += btnStaffLogin_Click;
			btnStaffLogin.MouseEnter += btnStaffLogin_MouseEnter;
			btnStaffLogin.MouseLeave += btnStaffLogin_MouseLeave;
			// 
			// pictureBox8
			// 
			pictureBox8.Image = Properties.Resources.bg2;
			pictureBox8.InitialImage = Properties.Resources.user;
			pictureBox8.Location = new System.Drawing.Point(448, 2);
			pictureBox8.Margin = new System.Windows.Forms.Padding(2);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new System.Drawing.Size(510, 544);
			pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox8.TabIndex = 25;
			pictureBox8.TabStop = false;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(968, 588);
			Controls.Add(tabControl);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Margin = new System.Windows.Forms.Padding(2);
			Name = "LoginForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Login";
			Load += LoginForm_Load;
			tabControl.ResumeLayout(false);
			customerTabPage.ResumeLayout(false);
			customerTabPage.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			staffTabPage.ResumeLayout(false);
			staffTabPage.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage customerTabPage;
        private System.Windows.Forms.TabPage staffTabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbStaffRemeberInfo;
        private System.Windows.Forms.Button btnStaffLogin;
        private System.Windows.Forms.CheckBox cbStaffShowPassword;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtCustomerUsername;
		private System.Windows.Forms.CheckBox cbCustomerRememberInfo;
		private System.Windows.Forms.Button btnCustomerLogin;
		private System.Windows.Forms.CheckBox cbCustomerShowPassword;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtCustomerPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnStaffExit;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel_SignUp;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}