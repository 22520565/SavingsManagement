namespace GraphicalUserInterface
{
    partial class StaffMenuForm
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            clearButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            editButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            customerBalanceTextBox = new System.Windows.Forms.TextBox();
            customerEmailTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            customerDisableCheckBox = new System.Windows.Forms.CheckBox();
            customerIdTextBox = new System.Windows.Forms.TextBox();
            customerBalanceLabel = new System.Windows.Forms.Label();
            customerHashedPasswordLabel = new System.Windows.Forms.Label();
            customerHashedPasswordTextBox = new System.Windows.Forms.TextBox();
            customerUsernameTextBox = new System.Windows.Forms.TextBox();
            customerAddressTextBox = new System.Windows.Forms.TextBox();
            customerCicNumberTextBox = new System.Windows.Forms.TextBox();
            customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            customerMaleCheckBox = new System.Windows.Forms.CheckBox();
            customerBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            customerNameTextBox = new System.Windows.Forms.TextBox();
            customerUsernameLabel = new System.Windows.Forms.Label();
            customerAddressLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            birthDayLabel = new System.Windows.Forms.Label();
            customerCicNumberLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            tabPageManageStaffs = new System.Windows.Forms.TabPage();
            tabPageChangeRegulations = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPageManageStaffs);
            tabControl1.Controls.Add(tabPageChangeRegulations);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1578, 944);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 47);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1570, 893);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 47);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1570, 893);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recharge";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 47);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1570, 893);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Withdraw";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridViewCustomer);
            tabPage4.Controls.Add(panel2);
            tabPage4.Controls.Add(panel1);
            tabPage4.Location = new System.Drawing.Point(4, 47);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(1570, 893);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Customer Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCustomer.Location = new System.Drawing.Point(0, 462);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new System.Drawing.Size(1570, 431);
            dataGridViewCustomer.TabIndex = 3;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(addButton);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 378);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1570, 84);
            panel2.TabIndex = 1;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Location = new System.Drawing.Point(496, 22);
            clearButton.Margin = new System.Windows.Forms.Padding(4);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(182, 48);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear Screen";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new System.Drawing.Point(170, 22);
            deleteButton.Margin = new System.Windows.Forms.Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(118, 48);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Disable";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Location = new System.Drawing.Point(337, 22);
            editButton.Margin = new System.Windows.Forms.Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(118, 48);
            editButton.TabIndex = 12;
            editButton.Text = "Save";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new System.Drawing.Point(15, 22);
            addButton.Margin = new System.Windows.Forms.Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(118, 48);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(customerBalanceTextBox);
            panel1.Controls.Add(customerEmailTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(customerDisableCheckBox);
            panel1.Controls.Add(customerIdTextBox);
            panel1.Controls.Add(customerBalanceLabel);
            panel1.Controls.Add(customerHashedPasswordLabel);
            panel1.Controls.Add(customerHashedPasswordTextBox);
            panel1.Controls.Add(customerUsernameTextBox);
            panel1.Controls.Add(customerAddressTextBox);
            panel1.Controls.Add(customerCicNumberTextBox);
            panel1.Controls.Add(customerPhoneNumberTextBox);
            panel1.Controls.Add(customerMaleCheckBox);
            panel1.Controls.Add(customerBirthDatePicker);
            panel1.Controls.Add(customerNameTextBox);
            panel1.Controls.Add(customerUsernameLabel);
            panel1.Controls.Add(customerAddressLabel);
            panel1.Controls.Add(customerPhoneNumberLabel);
            panel1.Controls.Add(birthDayLabel);
            panel1.Controls.Add(customerCicNumberLabel);
            panel1.Controls.Add(customerNameLabel);
            panel1.Controls.Add(customerIdLabel);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1570, 378);
            panel1.TabIndex = 2;
            // 
            // customerBalanceTextBox
            // 
            customerBalanceTextBox.BackColor = System.Drawing.Color.White;
            customerBalanceTextBox.Location = new System.Drawing.Point(1105, 253);
            customerBalanceTextBox.Name = "customerBalanceTextBox";
            customerBalanceTextBox.Size = new System.Drawing.Size(150, 45);
            customerBalanceTextBox.TabIndex = 14;
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.BackColor = System.Drawing.Color.White;
            customerEmailTextBox.Location = new System.Drawing.Point(161, 178);
            customerEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.Size = new System.Drawing.Size(978, 45);
            customerEmailTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 176);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 38);
            label1.TabIndex = 13;
            label1.Text = "Email: ";
            // 
            // customerDisableCheckBox
            // 
            customerDisableCheckBox.AutoSize = true;
            customerDisableCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            customerDisableCheckBox.Location = new System.Drawing.Point(1376, 255);
            customerDisableCheckBox.Margin = new System.Windows.Forms.Padding(4);
            customerDisableCheckBox.Name = "customerDisableCheckBox";
            customerDisableCheckBox.Size = new System.Drawing.Size(134, 42);
            customerDisableCheckBox.TabIndex = 11;
            customerDisableCheckBox.Text = "Disable";
            customerDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new System.Drawing.Point(94, 13);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new System.Drawing.Size(150, 45);
            customerIdTextBox.TabIndex = 10;
            // 
            // customerBalanceLabel
            // 
            customerBalanceLabel.AutoSize = true;
            customerBalanceLabel.Location = new System.Drawing.Point(980, 248);
            customerBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerBalanceLabel.Name = "customerBalanceLabel";
            customerBalanceLabel.Size = new System.Drawing.Size(118, 38);
            customerBalanceLabel.TabIndex = 9;
            customerBalanceLabel.Text = "Balance:";
            // 
            // customerHashedPasswordLabel
            // 
            customerHashedPasswordLabel.AutoSize = true;
            customerHashedPasswordLabel.Location = new System.Drawing.Point(439, 260);
            customerHashedPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerHashedPasswordLabel.Name = "customerHashedPasswordLabel";
            customerHashedPasswordLabel.Size = new System.Drawing.Size(240, 38);
            customerHashedPasswordLabel.TabIndex = 8;
            customerHashedPasswordLabel.Text = "Hashed password:";
            // 
            // customerHashedPasswordTextBox
            // 
            customerHashedPasswordTextBox.BackColor = System.Drawing.Color.White;
            customerHashedPasswordTextBox.Location = new System.Drawing.Point(717, 253);
            customerHashedPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerHashedPasswordTextBox.Name = "customerHashedPasswordTextBox";
            customerHashedPasswordTextBox.Size = new System.Drawing.Size(205, 45);
            customerHashedPasswordTextBox.TabIndex = 8;
            customerHashedPasswordTextBox.KeyPress += customerHashedPasswordTextBox_KeyPress;
            // 
            // customerUsernameTextBox
            // 
            customerUsernameTextBox.BackColor = System.Drawing.Color.White;
            customerUsernameTextBox.Location = new System.Drawing.Point(180, 253);
            customerUsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerUsernameTextBox.Name = "customerUsernameTextBox";
            customerUsernameTextBox.Size = new System.Drawing.Size(218, 45);
            customerUsernameTextBox.TabIndex = 7;
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.BackColor = System.Drawing.Color.White;
            customerAddressTextBox.Location = new System.Drawing.Point(161, 116);
            customerAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new System.Drawing.Size(978, 45);
            customerAddressTextBox.TabIndex = 6;
            // 
            // customerCicNumberTextBox
            // 
            customerCicNumberTextBox.BackColor = System.Drawing.Color.White;
            customerCicNumberTextBox.Location = new System.Drawing.Point(180, 64);
            customerCicNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerCicNumberTextBox.Name = "customerCicNumberTextBox";
            customerCicNumberTextBox.Size = new System.Drawing.Size(243, 45);
            customerCicNumberTextBox.TabIndex = 3;
            // 
            // customerPhoneNumberTextBox
            // 
            customerPhoneNumberTextBox.BackColor = System.Drawing.Color.White;
            customerPhoneNumberTextBox.Location = new System.Drawing.Point(1221, 63);
            customerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            customerPhoneNumberTextBox.Size = new System.Drawing.Size(214, 45);
            customerPhoneNumberTextBox.TabIndex = 5;
            // 
            // customerMaleCheckBox
            // 
            customerMaleCheckBox.AutoSize = true;
            customerMaleCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            customerMaleCheckBox.Location = new System.Drawing.Point(1437, 14);
            customerMaleCheckBox.Margin = new System.Windows.Forms.Padding(4);
            customerMaleCheckBox.Name = "customerMaleCheckBox";
            customerMaleCheckBox.Size = new System.Drawing.Size(104, 42);
            customerMaleCheckBox.TabIndex = 2;
            customerMaleCheckBox.Text = "Male";
            customerMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerBirthDatePicker
            // 
            customerBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            customerBirthDatePicker.Location = new System.Drawing.Point(668, 66);
            customerBirthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            customerBirthDatePicker.Name = "customerBirthDatePicker";
            customerBirthDatePicker.Size = new System.Drawing.Size(200, 45);
            customerBirthDatePicker.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.BackColor = System.Drawing.Color.White;
            customerNameTextBox.Location = new System.Drawing.Point(509, 12);
            customerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new System.Drawing.Size(515, 45);
            customerNameTextBox.TabIndex = 1;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(15, 253);
            customerUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(148, 38);
            customerUsernameLabel.TabIndex = 7;
            customerUsernameLabel.Text = "Username:";
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new System.Drawing.Point(15, 114);
            customerAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new System.Drawing.Size(122, 38);
            customerAddressLabel.TabIndex = 6;
            customerAddressLabel.Text = "Address:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(984, 66);
            customerPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(207, 38);
            customerPhoneNumberLabel.TabIndex = 5;
            customerPhoneNumberLabel.Text = "Phone number:";
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Location = new System.Drawing.Point(496, 66);
            birthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new System.Drawing.Size(143, 38);
            birthDayLabel.TabIndex = 4;
            birthDayLabel.Text = "Birth date:";
            // 
            // customerCicNumberLabel
            // 
            customerCicNumberLabel.AutoSize = true;
            customerCicNumberLabel.Location = new System.Drawing.Point(15, 66);
            customerCicNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerCicNumberLabel.Name = "customerCicNumberLabel";
            customerCicNumberLabel.Size = new System.Drawing.Size(169, 38);
            customerCicNumberLabel.TabIndex = 3;
            customerCicNumberLabel.Text = "CIC number:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(387, 12);
            customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(97, 38);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Name:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(15, 11);
            customerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(50, 38);
            customerIdLabel.TabIndex = 0;
            customerIdLabel.Text = "ID:";
            // 
            // tabPageManageStaffs
            // 
            tabPageManageStaffs.Location = new System.Drawing.Point(4, 47);
            tabPageManageStaffs.Name = "tabPageManageStaffs";
            tabPageManageStaffs.Size = new System.Drawing.Size(1570, 893);
            tabPageManageStaffs.TabIndex = 3;
            tabPageManageStaffs.Text = "Staff Management";
            tabPageManageStaffs.UseVisualStyleBackColor = true;
            // 
            // tabPageChangeRegulations
            // 
            tabPageChangeRegulations.Location = new System.Drawing.Point(4, 47);
            tabPageChangeRegulations.Name = "tabPageChangeRegulations";
            tabPageChangeRegulations.Size = new System.Drawing.Size(1570, 893);
            tabPageChangeRegulations.TabIndex = 4;
            tabPageChangeRegulations.Text = "Change regulations";
            tabPageChangeRegulations.UseVisualStyleBackColor = true;
            // 
            // StaffMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1578, 944);
            Controls.Add(tabControl1);
            Name = "StaffMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StaffMenuForm";
            FormClosing += StaffMenuForm_FormClosing;
            Load += StaffMenuForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageManageStaffs;
        private System.Windows.Forms.TabPage tabPageChangeRegulations;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label customerBalanceLabel;
        private System.Windows.Forms.Label customerHashedPasswordLabel;
        private System.Windows.Forms.TextBox customerHashedPasswordTextBox;
        private System.Windows.Forms.TextBox customerUsernameTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerCicNumberTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.CheckBox customerMaleCheckBox;
        private System.Windows.Forms.DateTimePicker customerBirthDatePicker;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Label customerCicNumberLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.CheckBox customerDisableCheckBox;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerBalanceTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}