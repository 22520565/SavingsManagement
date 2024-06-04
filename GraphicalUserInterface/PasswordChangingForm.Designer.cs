namespace GraphicalUserInterface
{
    partial class PasswordChangingForm
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
            txtOldPass = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnConfirm = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtConfrimNew = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtNewPass = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new System.Drawing.Point(296, 35);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '*';
            txtOldPass.Size = new System.Drawing.Size(197, 27);
            txtOldPass.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(66, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 31);
            label1.TabIndex = 1;
            label1.Text = "Password:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnConfirm.Location = new System.Drawing.Point(193, 253);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(173, 53);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Change";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(66, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(167, 31);
            label2.TabIndex = 4;
            label2.Text = "New Password:";
            // 
            // txtConfrimNew
            // 
            txtConfrimNew.Location = new System.Drawing.Point(296, 196);
            txtConfrimNew.Name = "txtConfrimNew";
            txtConfrimNew.PasswordChar = '*';
            txtConfrimNew.Size = new System.Drawing.Size(197, 27);
            txtConfrimNew.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(66, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(202, 31);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password:";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new System.Drawing.Point(296, 113);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new System.Drawing.Size(195, 27);
            txtNewPass.TabIndex = 5;
            // 
            // changePass
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(577, 329);
            Controls.Add(label3);
            Controls.Add(txtNewPass);
            Controls.Add(label2);
            Controls.Add(txtConfrimNew);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(txtOldPass);
            Name = "changePass";
            Text = "changePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfrimNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPass;
    }
}