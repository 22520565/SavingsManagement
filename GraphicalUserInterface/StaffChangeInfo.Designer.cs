namespace GraphicalUserInterface
{
    partial class StaffChangeInfo
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
            staffChangeInfoButton = new System.Windows.Forms.Button();
            staffUsernameTextBox = new System.Windows.Forms.TextBox();
            customerUsernameLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            staffPositionTextBox = new System.Windows.Forms.TextBox();
            staffNameTextBox = new System.Windows.Forms.TextBox();
            customerNameLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbMale = new System.Windows.Forms.RadioButton();
            rbFemale = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // staffChangeInfoButton
            // 
            staffChangeInfoButton.AutoSize = true;
            staffChangeInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            staffChangeInfoButton.Location = new System.Drawing.Point(749, 196);
            staffChangeInfoButton.Name = "staffChangeInfoButton";
            staffChangeInfoButton.Size = new System.Drawing.Size(104, 30);
            staffChangeInfoButton.TabIndex = 34;
            staffChangeInfoButton.Text = "Save Change";
            staffChangeInfoButton.UseVisualStyleBackColor = true;
            staffChangeInfoButton.Click += staffChangeInfoButton_Click;
            // 
            // staffUsernameTextBox
            // 
            staffUsernameTextBox.Location = new System.Drawing.Point(151, 105);
            staffUsernameTextBox.Name = "staffUsernameTextBox";
            staffUsernameTextBox.Size = new System.Drawing.Size(351, 27);
            staffUsernameTextBox.TabIndex = 32;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(18, 108);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(78, 20);
            customerUsernameLabel.TabIndex = 33;
            customerUsernameLabel.Text = "Username:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(563, 109);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(64, 20);
            customerPhoneNumberLabel.TabIndex = 30;
            customerPhoneNumberLabel.Text = "Position:";
            // 
            // staffPositionTextBox
            // 
            staffPositionTextBox.Location = new System.Drawing.Point(652, 105);
            staffPositionTextBox.Name = "staffPositionTextBox";
            staffPositionTextBox.Size = new System.Drawing.Size(271, 27);
            staffPositionTextBox.TabIndex = 31;
            // 
            // staffNameTextBox
            // 
            staffNameTextBox.Location = new System.Drawing.Point(90, 26);
            staffNameTextBox.Name = "staffNameTextBox";
            staffNameTextBox.Size = new System.Drawing.Size(569, 27);
            staffNameTextBox.TabIndex = 27;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(18, 29);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(52, 20);
            customerNameLabel.TabIndex = 28;
            customerNameLabel.Text = "Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(690, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 70);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbMale.Location = new System.Drawing.Point(37, 32);
            rbMale.Name = "rbMale";
            rbMale.Size = new System.Drawing.Size(72, 27);
            rbMale.TabIndex = 30;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbFemale.Location = new System.Drawing.Point(140, 32);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new System.Drawing.Size(93, 27);
            rbFemale.TabIndex = 31;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // StaffChangeInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(992, 317);
            Controls.Add(groupBox1);
            Controls.Add(staffChangeInfoButton);
            Controls.Add(staffUsernameTextBox);
            Controls.Add(customerUsernameLabel);
            Controls.Add(customerPhoneNumberLabel);
            Controls.Add(staffPositionTextBox);
            Controls.Add(staffNameTextBox);
            Controls.Add(customerNameLabel);
            Name = "StaffChangeInfo";
            Text = "StaffChangeInfo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button staffChangeInfoButton;
        private System.Windows.Forms.TextBox staffUsernameTextBox;
        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.TextBox staffPositionTextBox;
        private System.Windows.Forms.TextBox staffNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
    }
}