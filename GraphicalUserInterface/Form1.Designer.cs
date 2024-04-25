namespace GraphicalUserInterface
{
    using System.Drawing;
    using System.Windows.Forms;

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            customerIdNumeric = new NumericUpDown();
            customerBalanceNumeric = new NumericUpDown();
            customerBalanceLabel = new Label();
            customerHashedPasswordLabel = new Label();
            customerHashedPasswordTextBox = new TextBox();
            customerUsernameTextBox = new TextBox();
            customerAddressTextBox = new TextBox();
            customerCicNumberTextBox = new TextBox();
            customerPhoneNumberTextBox = new TextBox();
            customerMaleCheckBox = new CheckBox();
            customerBirthDatePicker = new DateTimePicker();
            customerNameTextBox = new TextBox();
            customerUsernameLabel = new Label();
            customerAddressLabel = new Label();
            customerPhoneNumberLabel = new Label();
            birthDayLabel = new Label();
            customerCicNumberLabel = new Label();
            customerNameLabel = new Label();
            customerIdLabel = new Label();
            panel2 = new Panel();
            cancelButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            addButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBalanceNumeric).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(customerIdNumeric);
            panel1.Controls.Add(customerBalanceNumeric);
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 185);
            panel1.TabIndex = 0;
            // 
            // customerIdNumeric
            // 
            customerIdNumeric.Enabled = false;
            customerIdNumeric.Location = new Point(45, 8);
            customerIdNumeric.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            customerIdNumeric.Name = "customerIdNumeric";
            customerIdNumeric.ReadOnly = true;
            customerIdNumeric.Size = new Size(232, 27);
            customerIdNumeric.TabIndex = 0;
            // 
            // customerBalanceNumeric
            // 
            customerBalanceNumeric.DecimalPlaces = 2;
            customerBalanceNumeric.Enabled = false;
            customerBalanceNumeric.Location = new Point(704, 138);
            customerBalanceNumeric.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            customerBalanceNumeric.Name = "customerBalanceNumeric";
            customerBalanceNumeric.ReadOnly = true;
            customerBalanceNumeric.Size = new Size(150, 27);
            customerBalanceNumeric.TabIndex = 9;
            customerBalanceNumeric.ThousandsSeparator = true;
            // 
            // customerBalanceLabel
            // 
            customerBalanceLabel.AutoSize = true;
            customerBalanceLabel.Location = new Point(634, 142);
            customerBalanceLabel.Name = "customerBalanceLabel";
            customerBalanceLabel.Size = new Size(64, 20);
            customerBalanceLabel.TabIndex = 9;
            customerBalanceLabel.Text = "Balance:";
            // 
            // customerHashedPasswordLabel
            // 
            customerHashedPasswordLabel.AutoSize = true;
            customerHashedPasswordLabel.Location = new Point(296, 138);
            customerHashedPasswordLabel.Name = "customerHashedPasswordLabel";
            customerHashedPasswordLabel.Size = new Size(129, 20);
            customerHashedPasswordLabel.TabIndex = 8;
            customerHashedPasswordLabel.Text = "Hashed password:";
            // 
            // customerHashedPasswordTextBox
            // 
            customerHashedPasswordTextBox.Location = new Point(431, 135);
            customerHashedPasswordTextBox.Name = "customerHashedPasswordTextBox";
            customerHashedPasswordTextBox.ReadOnly = true;
            customerHashedPasswordTextBox.Size = new Size(165, 27);
            customerHashedPasswordTextBox.TabIndex = 8;
            // 
            // customerUsernameTextBox
            // 
            customerUsernameTextBox.Location = new Point(96, 135);
            customerUsernameTextBox.Name = "customerUsernameTextBox";
            customerUsernameTextBox.ReadOnly = true;
            customerUsernameTextBox.Size = new Size(175, 27);
            customerUsernameTextBox.TabIndex = 7;
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Location = new Point(93, 93);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.ReadOnly = true;
            customerAddressTextBox.Size = new Size(783, 27);
            customerAddressTextBox.TabIndex = 6;
            // 
            // customerCicNumberTextBox
            // 
            customerCicNumberTextBox.Location = new Point(109, 51);
            customerCicNumberTextBox.Name = "customerCicNumberTextBox";
            customerCicNumberTextBox.ReadOnly = true;
            customerCicNumberTextBox.Size = new Size(195, 27);
            customerCicNumberTextBox.TabIndex = 3;
            // 
            // customerPhoneNumberTextBox
            // 
            customerPhoneNumberTextBox.Location = new Point(704, 50);
            customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            customerPhoneNumberTextBox.ReadOnly = true;
            customerPhoneNumberTextBox.Size = new Size(172, 27);
            customerPhoneNumberTextBox.TabIndex = 5;
            // 
            // customerMaleCheckBox
            // 
            customerMaleCheckBox.AutoSize = true;
            customerMaleCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            customerMaleCheckBox.Enabled = false;
            customerMaleCheckBox.Location = new Point(787, 12);
            customerMaleCheckBox.Name = "customerMaleCheckBox";
            customerMaleCheckBox.Size = new Size(64, 24);
            customerMaleCheckBox.TabIndex = 2;
            customerMaleCheckBox.Text = "Male";
            customerMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerBirthDatePicker
            // 
            customerBirthDatePicker.Enabled = false;
            customerBirthDatePicker.Location = new Point(412, 51);
            customerBirthDatePicker.Name = "customerBirthDatePicker";
            customerBirthDatePicker.Size = new Size(161, 27);
            customerBirthDatePicker.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(341, 10);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.ReadOnly = true;
            customerNameTextBox.Size = new Size(413, 27);
            customerNameTextBox.TabIndex = 1;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new Point(12, 135);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new Size(78, 20);
            customerUsernameLabel.TabIndex = 7;
            customerUsernameLabel.Text = "Username:";
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new Point(12, 91);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(65, 20);
            customerAddressLabel.TabIndex = 6;
            customerAddressLabel.Text = "Address:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new Point(590, 53);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new Size(108, 20);
            customerPhoneNumberLabel.TabIndex = 5;
            customerPhoneNumberLabel.Text = "Phone number:";
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Location = new Point(329, 53);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new Size(77, 20);
            birthDayLabel.TabIndex = 4;
            birthDayLabel.Text = "Birth date:";
            // 
            // customerCicNumberLabel
            // 
            customerCicNumberLabel.AutoSize = true;
            customerCicNumberLabel.Location = new Point(12, 53);
            customerCicNumberLabel.Name = "customerCicNumberLabel";
            customerCicNumberLabel.Size = new Size(89, 20);
            customerCicNumberLabel.TabIndex = 3;
            customerCicNumberLabel.Text = "CIC number:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(283, 10);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(52, 20);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Name:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(12, 9);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(27, 20);
            customerIdLabel.TabIndex = 0;
            customerIdLabel.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cancelButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(saveButton);
            panel2.Controls.Add(addButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 67);
            panel2.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Enabled = false;
            cancelButton.Location = new Point(539, 19);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(397, 19);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(258, 18);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 12;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Location = new Point(129, 18);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 18);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 545);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBalanceNumeric).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label customerNameLabel;
        private Label customerIdLabel;
        private Label customerCicNumberLabel;
        private Label customerAddressLabel;
        private Label customerPhoneNumberLabel;
        private Label customerUsernameLabel;
        private NumericUpDown customerIdNumeric;
        private TextBox customerNameTextBox;
        private CheckBox customerMaleCheckBox;
        private DateTimePicker customerBirthDatePicker;
        private Label birthDayLabel;
        private TextBox customerPhoneNumberTextBox;
        private TextBox customerCicNumberTextBox;
        private TextBox customerAddressTextBox;
        private TextBox customerUsernameTextBox;
        private Label customerHashedPasswordLabel;
        private TextBox customerHashedPasswordTextBox;
        private Label customerBalanceLabel;
        private NumericUpDown customerBalanceNumeric;
        private Button addButton;
        private Button saveButton;
        private Button editButton;
        private Button deleteButton;
        private Button cancelButton;
    }
}
