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
			groupBox1.SuspendLayout();
			panelAvt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// staffChangeInfoButton
			// 
			staffChangeInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			staffChangeInfoButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			staffChangeInfoButton.Location = new System.Drawing.Point(837, 259);
			staffChangeInfoButton.Name = "staffChangeInfoButton";
			staffChangeInfoButton.Padding = new System.Windows.Forms.Padding(5);
			staffChangeInfoButton.Size = new System.Drawing.Size(124, 46);
			staffChangeInfoButton.TabIndex = 34;
			staffChangeInfoButton.Text = "Save";
			staffChangeInfoButton.UseVisualStyleBackColor = true;
			staffChangeInfoButton.Click += staffChangeInfoButton_Click;
			// 
			// staffUsernameTextBox
			// 
			staffUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffUsernameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffUsernameTextBox.Location = new System.Drawing.Point(340, 148);
			staffUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffUsernameTextBox.Name = "staffUsernameTextBox";
			staffUsernameTextBox.Size = new System.Drawing.Size(271, 31);
			staffUsernameTextBox.TabIndex = 32;
			// 
			// customerUsernameLabel
			// 
			customerUsernameLabel.AutoSize = true;
			customerUsernameLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerUsernameLabel.Location = new System.Drawing.Point(340, 120);
			customerUsernameLabel.Name = "customerUsernameLabel";
			customerUsernameLabel.Size = new System.Drawing.Size(103, 23);
			customerUsernameLabel.TabIndex = 33;
			customerUsernameLabel.Text = "Username:";
			// 
			// customerPhoneNumberLabel
			// 
			customerPhoneNumberLabel.AutoSize = true;
			customerPhoneNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerPhoneNumberLabel.Location = new System.Drawing.Point(656, 120);
			customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
			customerPhoneNumberLabel.Size = new System.Drawing.Size(87, 23);
			customerPhoneNumberLabel.TabIndex = 30;
			customerPhoneNumberLabel.Text = "Position:";
			// 
			// staffPositionTextBox
			// 
			staffPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffPositionTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffPositionTextBox.Location = new System.Drawing.Point(656, 148);
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
			btnCancel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnCancel.Location = new System.Drawing.Point(656, 259);
			btnCancel.Name = "btnCancel";
			btnCancel.Padding = new System.Windows.Forms.Padding(5);
			btnCancel.Size = new System.Drawing.Size(124, 46);
			btnCancel.TabIndex = 36;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// panelAvt
			// 
			panelAvt.Controls.Add(lbStaffName);
			panelAvt.Controls.Add(lbCustomerName);
			panelAvt.Controls.Add(pictureBox1);
			panelAvt.Location = new System.Drawing.Point(23, 23);
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
			// StaffChangeInfo
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(992, 317);
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
	}
}