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
		private void InitializeComponent() {
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
			btnCancel = new System.Windows.Forms.Button();
			panelAvt = new System.Windows.Forms.Panel();
			lbStaffName = new System.Windows.Forms.Label();
			lbCustomerName = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			staffBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			staffAddressTextBox = new System.Windows.Forms.TextBox();
			staffEmailTextBox = new System.Windows.Forms.TextBox();
			customerEmailLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			customerAddressLabel = new System.Windows.Forms.Label();
			staffPhoneNumberTextBox = new System.Windows.Forms.TextBox();
			customerBirthdayLabel = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			panelAvt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// staffChangeInfoButton
			// 
			staffChangeInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			staffChangeInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
			staffChangeInfoButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			staffChangeInfoButton.ForeColor = System.Drawing.Color.White;
			staffChangeInfoButton.Location = new System.Drawing.Point(837, 380);
			staffChangeInfoButton.Name = "staffChangeInfoButton";
			staffChangeInfoButton.Padding = new System.Windows.Forms.Padding(5);
			staffChangeInfoButton.Size = new System.Drawing.Size(124, 46);
			staffChangeInfoButton.TabIndex = 34;
			staffChangeInfoButton.Text = "Save";
			staffChangeInfoButton.UseVisualStyleBackColor = true;
			staffChangeInfoButton.Click += staffChangeInfoButton_Click;
			staffChangeInfoButton.MouseEnter += staffChangeInfoButton_MouseEnter;
			staffChangeInfoButton.MouseLeave += staffChangeInfoButton_MouseLeave;
			// 
			// staffUsernameTextBox
			// 
			staffUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffUsernameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffUsernameTextBox.Location = new System.Drawing.Point(340, 136);
			staffUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffUsernameTextBox.Name = "staffUsernameTextBox";
			staffUsernameTextBox.Size = new System.Drawing.Size(271, 31);
			staffUsernameTextBox.TabIndex = 32;
			// 
			// customerUsernameLabel
			// 
			customerUsernameLabel.AutoSize = true;
			customerUsernameLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerUsernameLabel.Location = new System.Drawing.Point(340, 108);
			customerUsernameLabel.Name = "customerUsernameLabel";
			customerUsernameLabel.Size = new System.Drawing.Size(103, 23);
			customerUsernameLabel.TabIndex = 33;
			customerUsernameLabel.Text = "Username:";
			// 
			// customerPhoneNumberLabel
			// 
			customerPhoneNumberLabel.AutoSize = true;
			customerPhoneNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerPhoneNumberLabel.Location = new System.Drawing.Point(656, 283);
			customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
			customerPhoneNumberLabel.Size = new System.Drawing.Size(87, 23);
			customerPhoneNumberLabel.TabIndex = 30;
			customerPhoneNumberLabel.Text = "Position:";
			// 
			// staffPositionTextBox
			// 
			staffPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffPositionTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffPositionTextBox.Location = new System.Drawing.Point(656, 311);
			staffPositionTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffPositionTextBox.Name = "staffPositionTextBox";
			staffPositionTextBox.Size = new System.Drawing.Size(305, 31);
			staffPositionTextBox.TabIndex = 31;
			// 
			// staffNameTextBox
			// 
			staffNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffNameTextBox.Location = new System.Drawing.Point(340, 51);
			staffNameTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffNameTextBox.Name = "staffNameTextBox";
			staffNameTextBox.Size = new System.Drawing.Size(271, 31);
			staffNameTextBox.TabIndex = 27;
			staffNameTextBox.TextChanged += staffNameTextBox_TextChanged;
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerNameLabel.Location = new System.Drawing.Point(340, 23);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(66, 23);
			customerNameLabel.TabIndex = 28;
			customerNameLabel.Text = "Name:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rbMale);
			groupBox1.Controls.Add(rbFemale);
			groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.Location = new System.Drawing.Point(656, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(305, 70);
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
			// btnCancel
			// 
			btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			btnCancel.BackColor = System.Drawing.Color.White;
			btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			btnCancel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnCancel.ForeColor = System.Drawing.Color.Black;
			btnCancel.Location = new System.Drawing.Point(656, 380);
			btnCancel.Name = "btnCancel";
			btnCancel.Padding = new System.Windows.Forms.Padding(5);
			btnCancel.Size = new System.Drawing.Size(124, 46);
			btnCancel.TabIndex = 36;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			btnCancel.MouseEnter += btnCancel_MouseEnter;
			btnCancel.MouseLeave += btnCancel_MouseLeave;
			// 
			// panelAvt
			// 
			panelAvt.Controls.Add(lbStaffName);
			panelAvt.Controls.Add(lbCustomerName);
			panelAvt.Controls.Add(pictureBox1);
			panelAvt.Location = new System.Drawing.Point(30, 44);
			panelAvt.Name = "panelAvt";
			panelAvt.Size = new System.Drawing.Size(270, 273);
			panelAvt.TabIndex = 37;
			// 
			// lbStaffName
			// 
			lbStaffName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			lbStaffName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lbStaffName.Location = new System.Drawing.Point(3, 224);
			lbStaffName.Name = "lbStaffName";
			lbStaffName.Size = new System.Drawing.Size(264, 27);
			lbStaffName.TabIndex = 38;
			lbStaffName.Text = "label1";
			lbStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCustomerName
			// 
			lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			lbCustomerName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lbCustomerName.Location = new System.Drawing.Point(16, 328);
			lbCustomerName.Name = "lbCustomerName";
			lbCustomerName.Size = new System.Drawing.Size(305, 27);
			lbCustomerName.TabIndex = 1;
			lbCustomerName.Text = "label1";
			lbCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.avt;
			pictureBox1.Location = new System.Drawing.Point(34, 28);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(185, 180);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// staffBirthDateTimePicker
			// 
			staffBirthDateTimePicker.Font = new System.Drawing.Font("Cambria", 12F);
			staffBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			staffBirthDateTimePicker.Location = new System.Drawing.Point(340, 224);
			staffBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
			staffBirthDateTimePicker.Name = "staffBirthDateTimePicker";
			staffBirthDateTimePicker.Size = new System.Drawing.Size(271, 31);
			staffBirthDateTimePicker.TabIndex = 45;
			// 
			// staffAddressTextBox
			// 
			staffAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffAddressTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffAddressTextBox.Location = new System.Drawing.Point(340, 311);
			staffAddressTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffAddressTextBox.Name = "staffAddressTextBox";
			staffAddressTextBox.Size = new System.Drawing.Size(271, 31);
			staffAddressTextBox.TabIndex = 43;
			// 
			// staffEmailTextBox
			// 
			staffEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffEmailTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffEmailTextBox.Location = new System.Drawing.Point(656, 136);
			staffEmailTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffEmailTextBox.Name = "staffEmailTextBox";
			staffEmailTextBox.Size = new System.Drawing.Size(305, 31);
			staffEmailTextBox.TabIndex = 41;
			// 
			// customerEmailLabel
			// 
			customerEmailLabel.AutoSize = true;
			customerEmailLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerEmailLabel.Location = new System.Drawing.Point(656, 108);
			customerEmailLabel.Name = "customerEmailLabel";
			customerEmailLabel.Size = new System.Drawing.Size(65, 23);
			customerEmailLabel.TabIndex = 42;
			customerEmailLabel.Text = "Email:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Cambria", 12F);
			label1.Location = new System.Drawing.Point(656, 195);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(144, 23);
			label1.TabIndex = 39;
			label1.Text = "Phone Number:";
			// 
			// customerAddressLabel
			// 
			customerAddressLabel.AutoSize = true;
			customerAddressLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerAddressLabel.Location = new System.Drawing.Point(340, 283);
			customerAddressLabel.Name = "customerAddressLabel";
			customerAddressLabel.Size = new System.Drawing.Size(85, 23);
			customerAddressLabel.TabIndex = 44;
			customerAddressLabel.Text = "Address:";
			// 
			// staffPhoneNumberTextBox
			// 
			staffPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffPhoneNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffPhoneNumberTextBox.Location = new System.Drawing.Point(656, 223);
			staffPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffPhoneNumberTextBox.Name = "staffPhoneNumberTextBox";
			staffPhoneNumberTextBox.Size = new System.Drawing.Size(305, 31);
			staffPhoneNumberTextBox.TabIndex = 40;
			// 
			// customerBirthdayLabel
			// 
			customerBirthdayLabel.AutoSize = true;
			customerBirthdayLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerBirthdayLabel.Location = new System.Drawing.Point(340, 196);
			customerBirthdayLabel.Name = "customerBirthdayLabel";
			customerBirthdayLabel.Size = new System.Drawing.Size(90, 23);
			customerBirthdayLabel.TabIndex = 38;
			customerBirthdayLabel.Text = "Birthday:";
			// 
			// StaffChangeInfo
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(992, 438);
			Controls.Add(staffBirthDateTimePicker);
			Controls.Add(staffAddressTextBox);
			Controls.Add(staffEmailTextBox);
			Controls.Add(customerEmailLabel);
			Controls.Add(label1);
			Controls.Add(customerAddressLabel);
			Controls.Add(staffPhoneNumberTextBox);
			Controls.Add(customerBirthdayLabel);
			Controls.Add(panelAvt);
			Controls.Add(btnCancel);
			Controls.Add(groupBox1);
			Controls.Add(staffChangeInfoButton);
			Controls.Add(staffUsernameTextBox);
			Controls.Add(customerUsernameLabel);
			Controls.Add(customerPhoneNumberLabel);
			Controls.Add(staffPositionTextBox);
			Controls.Add(staffNameTextBox);
			Controls.Add(customerNameLabel);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "StaffChangeInfo";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panelAvt.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel panelAvt;
		private System.Windows.Forms.Label lbCustomerName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbStaffName;
		private System.Windows.Forms.DateTimePicker staffBirthDateTimePicker;
		private System.Windows.Forms.TextBox staffAddressTextBox;
		private System.Windows.Forms.TextBox staffEmailTextBox;
		private System.Windows.Forms.Label customerEmailLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label customerAddressLabel;
		private System.Windows.Forms.TextBox staffPhoneNumberTextBox;
		private System.Windows.Forms.Label customerBirthdayLabel;
	}
}