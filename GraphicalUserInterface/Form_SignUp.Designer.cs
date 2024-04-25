namespace Gui
{
    partial class Form_SignUp
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
            label1 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnSignUp = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            cbShowPassword = new System.Windows.Forms.CheckBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(52, 342);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 38);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtUsername.Location = new System.Drawing.Point(327, 340);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(483, 45);
            txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label2.Location = new System.Drawing.Point(52, 442);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 38);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtPassword.Location = new System.Drawing.Point(327, 440);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(483, 45);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label3.Location = new System.Drawing.Point(52, 542);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(246, 38);
            label3.TabIndex = 8;
            label3.Text = "Confirm password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtConfirmPassword.Location = new System.Drawing.Point(327, 540);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(483, 45);
            txtConfirmPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label4.Location = new System.Drawing.Point(52, 642);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 38);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtEmail.Location = new System.Drawing.Point(327, 640);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(483, 45);
            txtEmail.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Frustrated_Head_GIF_by_swerk___Find___Share_on_GIPHY;
            pictureBox1.Location = new System.Drawing.Point(276, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(348, 300);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.AutoSize = true;
            btnSignUp.BackColor = System.Drawing.SystemColors.Control;
            btnSignUp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSignUp.Location = new System.Drawing.Point(385, 765);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(130, 48);
            btnSignUp.TabIndex = 12;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            btnSignUp.MouseEnter += btnSignUp_MouseEnter;
            btnSignUp.MouseLeave += btnSignUp_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.Control;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.Location = new System.Drawing.Point(816, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(50, 50);
            btnExit.TabIndex = 13;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new System.Drawing.Point(327, 714);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new System.Drawing.Size(164, 29);
            cbShowPassword.TabIndex = 14;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.sign_up;
            pictureBox4.Location = new System.Drawing.Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(100, 100);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // Form_SignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(878, 844);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(cbShowPassword);
            Controls.Add(btnExit);
            Controls.Add(btnSignUp);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "Form_SignUp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}