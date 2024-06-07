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
            staffGenderCbx = new System.Windows.Forms.ComboBox();
            staffChangeInfoButton = new System.Windows.Forms.Button();
            staffUsernameTextBox = new System.Windows.Forms.TextBox();
            customerUsernameLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            staffPositionTextBox = new System.Windows.Forms.TextBox();
            customerGenderLabel = new System.Windows.Forms.Label();
            staffNameTextBox = new System.Windows.Forms.TextBox();
            customerNameLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // staffGenderCbx
            // 
            staffGenderCbx.FormattingEnabled = true;
            staffGenderCbx.Items.AddRange(new object[] { "Male", "Female" });
            staffGenderCbx.Location = new System.Drawing.Point(767, 29);
            staffGenderCbx.Name = "staffGenderCbx";
            staffGenderCbx.Size = new System.Drawing.Size(213, 28);
            staffGenderCbx.TabIndex = 35;
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
            staffUsernameTextBox.Location = new System.Drawing.Point(142, 91);
            staffUsernameTextBox.Name = "staffUsernameTextBox";
            staffUsernameTextBox.Size = new System.Drawing.Size(351, 27);
            staffUsernameTextBox.TabIndex = 32;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(19, 94);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(78, 20);
            customerUsernameLabel.TabIndex = 33;
            customerUsernameLabel.Text = "Username:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(549, 94);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(64, 20);
            customerPhoneNumberLabel.TabIndex = 30;
            customerPhoneNumberLabel.Text = "Position:";
            // 
            // staffPositionTextBox
            // 
            staffPositionTextBox.Location = new System.Drawing.Point(652, 91);
            staffPositionTextBox.Name = "staffPositionTextBox";
            staffPositionTextBox.Size = new System.Drawing.Size(271, 27);
            staffPositionTextBox.TabIndex = 31;
            // 
            // customerGenderLabel
            // 
            customerGenderLabel.AutoSize = true;
            customerGenderLabel.Location = new System.Drawing.Point(701, 32);
            customerGenderLabel.Name = "customerGenderLabel";
            customerGenderLabel.Size = new System.Drawing.Size(60, 20);
            customerGenderLabel.TabIndex = 29;
            customerGenderLabel.Text = "Gender:";
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
            // StaffChangeInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(992, 317);
            Controls.Add(staffGenderCbx);
            Controls.Add(staffChangeInfoButton);
            Controls.Add(staffUsernameTextBox);
            Controls.Add(customerUsernameLabel);
            Controls.Add(customerPhoneNumberLabel);
            Controls.Add(staffPositionTextBox);
            Controls.Add(customerGenderLabel);
            Controls.Add(staffNameTextBox);
            Controls.Add(customerNameLabel);
            Name = "StaffChangeInfo";
            Text = "StaffChangeInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox staffGenderCbx;
        private System.Windows.Forms.Button staffChangeInfoButton;
        private System.Windows.Forms.TextBox staffUsernameTextBox;
        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.TextBox staffPositionTextBox;
        private System.Windows.Forms.Label customerGenderLabel;
        private System.Windows.Forms.TextBox staffNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
    }
}