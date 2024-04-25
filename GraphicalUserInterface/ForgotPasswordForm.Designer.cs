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
        private void InitializeComponent()
        {
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtResult = new System.Windows.Forms.TextBox();
            btnPasswordRetrieval = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.How_to_Password_Protect_Antivirus_Settings__Kaspersky_Daily;
            pictureBox1.Location = new System.Drawing.Point(185, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(440, 280);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(25, 365);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(237, 38);
            label1.TabIndex = 4;
            label1.Text = "Registered email: ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtEmail.Location = new System.Drawing.Point(268, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(491, 45);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label2.Location = new System.Drawing.Point(25, 448);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 38);
            label2.TabIndex = 6;
            label2.Text = "Result: ";
            // 
            // txtResult
            // 
            txtResult.BackColor = System.Drawing.SystemColors.Window;
            txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtResult.ForeColor = System.Drawing.SystemColors.WindowText;
            txtResult.Location = new System.Drawing.Point(268, 446);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new System.Drawing.Size(491, 45);
            txtResult.TabIndex = 5;
            // 
            // btnPasswordRetrieval
            // 
            btnPasswordRetrieval.AutoSize = true;
            btnPasswordRetrieval.BackColor = System.Drawing.SystemColors.Control;
            btnPasswordRetrieval.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPasswordRetrieval.Location = new System.Drawing.Point(287, 547);
            btnPasswordRetrieval.Name = "btnPasswordRetrieval";
            btnPasswordRetrieval.Size = new System.Drawing.Size(250, 48);
            btnPasswordRetrieval.TabIndex = 11;
            btnPasswordRetrieval.Text = "Password retrieval";
            btnPasswordRetrieval.UseVisualStyleBackColor = false;
            btnPasswordRetrieval.Click += btnPasswordRetrieval_Click;
            btnPasswordRetrieval.MouseEnter += btnPasswordRetrieval_MouseEnter;
            btnPasswordRetrieval.MouseLeave += btnPasswordRetrieval_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.help;
            pictureBox4.Location = new System.Drawing.Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(100, 100);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
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
            // Form_ForgotPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 650);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(pictureBox4);
            Controls.Add(btnPasswordRetrieval);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Name = "Form_ForgotPassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPasswordRetrieval;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnExit;
    }
}