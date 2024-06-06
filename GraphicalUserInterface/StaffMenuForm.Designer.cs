using DataAccess;
using System.Globalization;

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
            System.Windows.Forms.Label customerWithdrawContentLabel;
            System.Windows.Forms.Label customerWithdrawAmountLabel;
            System.Windows.Forms.Label customerWithdrawCicNumberLabel;
            System.Windows.Forms.Label customerWithdrawNameLabel;
            System.Windows.Forms.Label customerWithdrawIdLabel;
            System.Windows.Forms.Label customerWithdrawBalanceLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            staffusernametxt = new System.Windows.Forms.TextBox();
            customerUsernameLabel = new System.Windows.Forms.Label();
            staffIdtxt = new System.Windows.Forms.TextBox();
            customerIdLabel = new System.Windows.Forms.Label();
            staffChangePasswordButton = new System.Windows.Forms.Button();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            staffpositiontxt = new System.Windows.Forms.TextBox();
            staffgendertxt = new System.Windows.Forms.TextBox();
            customerGenderLabel = new System.Windows.Forms.Label();
            staffnametxt = new System.Windows.Forms.TextBox();
            customerNameLabel = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataGridViewDeposit = new System.Windows.Forms.DataGridView();
            customerDepositAmountNumeric = new System.Windows.Forms.NumericUpDown();
            customerDepositIdTextBox = new System.Windows.Forms.TextBox();
            customerDepositButton = new System.Windows.Forms.Button();
            customerDepositContentTextBox = new System.Windows.Forms.TextBox();
            customerDepositContentLabel = new System.Windows.Forms.Label();
            customerDepositAmountLabel = new System.Windows.Forms.Label();
            customerDepositCicNumberTextBox = new System.Windows.Forms.TextBox();
            customerDepositCicNumberLabel = new System.Windows.Forms.Label();
            customerDepositNameTextBox = new System.Windows.Forms.TextBox();
            customerDepositNameLabel = new System.Windows.Forms.Label();
            customerDepositIdLabel = new System.Windows.Forms.Label();
            groupBox8 = new System.Windows.Forms.GroupBox();
            customerPrintButton = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            dataGridViewWithdraw = new System.Windows.Forms.DataGridView();
            customerWithdrawBalanceTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawAmountNumeric = new System.Windows.Forms.NumericUpDown();
            customerWithdrawIdTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawButton = new System.Windows.Forms.Button();
            customerWithdrawContentTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawCicNumberTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawNameTextBox = new System.Windows.Forms.TextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            tabPageManageCustomers = new System.Windows.Forms.TabPage();
            dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            groupBox6 = new System.Windows.Forms.GroupBox();
            customerSearchTextBox = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            enableCustomerBtn = new System.Windows.Forms.Button();
            clearScreenCustomerBtn = new System.Windows.Forms.Button();
            disableCustomerBtn = new System.Windows.Forms.Button();
            saveCustomerBtn = new System.Windows.Forms.Button();
            addCustomerBtn = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            customerBalanceTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            customerDisableCheckBox = new System.Windows.Forms.CheckBox();
            customerBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            customerMaleCheckBox = new System.Windows.Forms.CheckBox();
            customerHashedPasswordTextBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            customerUsernameTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            customerEmailTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            customerAddressTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            customerCicNumberTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            customerNameTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            customerIdTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tabPageManageStaffs = new System.Windows.Forms.TabPage();
            dataGridViewStaff = new System.Windows.Forms.DataGridView();
            groupBox7 = new System.Windows.Forms.GroupBox();
            staffSearchTextBox = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            enableStaffBtn = new System.Windows.Forms.Button();
            clearScreenStaffBtn = new System.Windows.Forms.Button();
            disableStaffBtn = new System.Windows.Forms.Button();
            saveStaffBtn = new System.Windows.Forms.Button();
            addStaffBtn = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            staffDisableCheckBox = new System.Windows.Forms.CheckBox();
            staffMaleCheckBox = new System.Windows.Forms.CheckBox();
            staffPermissionIdComboBox = new System.Windows.Forms.ComboBox();
            label16 = new System.Windows.Forms.Label();
            staffHashedPasswordTextBox = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            staffUsernameTextBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            staffPositionTextBox = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            staffNameTextBox = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            staffIdTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            tabPageChangeRegulations = new System.Windows.Forms.TabPage();
            label19 = new System.Windows.Forms.Label();
            saveRate = new System.Windows.Forms.Button();
            ratetxt = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            monthtxt = new System.Windows.Forms.TextBox();
            label18 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            data_rate = new System.Windows.Forms.DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            withdrawPrintButton = new System.Windows.Forms.Button();
            customerWithdrawContentLabel = new System.Windows.Forms.Label();
            customerWithdrawAmountLabel = new System.Windows.Forms.Label();
            customerWithdrawCicNumberLabel = new System.Windows.Forms.Label();
            customerWithdrawNameLabel = new System.Windows.Forms.Label();
            customerWithdrawIdLabel = new System.Windows.Forms.Label();
            customerWithdrawBalanceLabel = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).BeginInit();
            groupBox8.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWithdraw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).BeginInit();
            groupBox9.SuspendLayout();
            tabPageManageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageManageStaffs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPageChangeRegulations.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_rate).BeginInit();
            SuspendLayout();
            // 
            // customerWithdrawContentLabel
            // 
            customerWithdrawContentLabel.AutoSize = true;
            customerWithdrawContentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawContentLabel.Location = new System.Drawing.Point(84, 256);
            customerWithdrawContentLabel.Name = "customerWithdrawContentLabel";
            customerWithdrawContentLabel.Size = new System.Drawing.Size(91, 26);
            customerWithdrawContentLabel.TabIndex = 5;
            customerWithdrawContentLabel.Text = "Content:";
            // 
            // customerWithdrawAmountLabel
            // 
            customerWithdrawAmountLabel.AutoSize = true;
            customerWithdrawAmountLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawAmountLabel.Location = new System.Drawing.Point(84, 210);
            customerWithdrawAmountLabel.Name = "customerWithdrawAmountLabel";
            customerWithdrawAmountLabel.Size = new System.Drawing.Size(185, 26);
            customerWithdrawAmountLabel.TabIndex = 4;
            customerWithdrawAmountLabel.Text = "Withdraw amount:";
            // 
            // customerWithdrawCicNumberLabel
            // 
            customerWithdrawCicNumberLabel.AutoSize = true;
            customerWithdrawCicNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawCicNumberLabel.Location = new System.Drawing.Point(84, 128);
            customerWithdrawCicNumberLabel.Name = "customerWithdrawCicNumberLabel";
            customerWithdrawCicNumberLabel.Size = new System.Drawing.Size(138, 26);
            customerWithdrawCicNumberLabel.TabIndex = 2;
            customerWithdrawCicNumberLabel.Text = "CIC Number:";
            // 
            // customerWithdrawNameLabel
            // 
            customerWithdrawNameLabel.AutoSize = true;
            customerWithdrawNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawNameLabel.Location = new System.Drawing.Point(84, 86);
            customerWithdrawNameLabel.Name = "customerWithdrawNameLabel";
            customerWithdrawNameLabel.Size = new System.Drawing.Size(72, 26);
            customerWithdrawNameLabel.TabIndex = 1;
            customerWithdrawNameLabel.Text = "Name:";
            // 
            // customerWithdrawIdLabel
            // 
            customerWithdrawIdLabel.AutoSize = true;
            customerWithdrawIdLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawIdLabel.Location = new System.Drawing.Point(84, 40);
            customerWithdrawIdLabel.Name = "customerWithdrawIdLabel";
            customerWithdrawIdLabel.Size = new System.Drawing.Size(138, 26);
            customerWithdrawIdLabel.TabIndex = 0;
            customerWithdrawIdLabel.Text = "Customer ID:";
            // 
            // customerWithdrawBalanceLabel
            // 
            customerWithdrawBalanceLabel.AutoSize = true;
            customerWithdrawBalanceLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawBalanceLabel.Location = new System.Drawing.Point(84, 167);
            customerWithdrawBalanceLabel.Name = "customerWithdrawBalanceLabel";
            customerWithdrawBalanceLabel.Size = new System.Drawing.Size(90, 26);
            customerWithdrawBalanceLabel.TabIndex = 3;
            customerWithdrawBalanceLabel.Text = "Balance:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPageManageCustomers);
            tabControl1.Controls.Add(tabPageManageStaffs);
            tabControl1.Controls.Add(tabPageChangeRegulations);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1262, 755);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(staffusernametxt);
            tabPage1.Controls.Add(customerUsernameLabel);
            tabPage1.Controls.Add(staffIdtxt);
            tabPage1.Controls.Add(customerIdLabel);
            tabPage1.Controls.Add(staffChangePasswordButton);
            tabPage1.Controls.Add(customerPhoneNumberLabel);
            tabPage1.Controls.Add(staffpositiontxt);
            tabPage1.Controls.Add(staffgendertxt);
            tabPage1.Controls.Add(customerGenderLabel);
            tabPage1.Controls.Add(staffnametxt);
            tabPage1.Controls.Add(customerNameLabel);
            tabPage1.Location = new System.Drawing.Point(4, 35);
            tabPage1.Margin = new System.Windows.Forms.Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2);
            tabPage1.Size = new System.Drawing.Size(1254, 716);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // staffusernametxt
            // 
            staffusernametxt.Location = new System.Drawing.Point(886, 93);
            staffusernametxt.Name = "staffusernametxt";
            staffusernametxt.ReadOnly = true;
            staffusernametxt.Size = new System.Drawing.Size(336, 34);
            staffusernametxt.TabIndex = 30;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(770, 99);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(110, 26);
            customerUsernameLabel.TabIndex = 31;
            customerUsernameLabel.Text = "Username:";
            // 
            // staffIdtxt
            // 
            staffIdtxt.Location = new System.Drawing.Point(78, 29);
            staffIdtxt.Name = "staffIdtxt";
            staffIdtxt.ReadOnly = true;
            staffIdtxt.Size = new System.Drawing.Size(365, 34);
            staffIdtxt.TabIndex = 22;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(38, 32);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(42, 26);
            customerIdLabel.TabIndex = 23;
            customerIdLabel.Text = "ID:";
            // 
            // staffChangePasswordButton
            // 
            staffChangePasswordButton.AutoSize = true;
            staffChangePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            staffChangePasswordButton.Location = new System.Drawing.Point(969, 209);
            staffChangePasswordButton.Name = "staffChangePasswordButton";
            staffChangePasswordButton.Size = new System.Drawing.Size(188, 36);
            staffChangePasswordButton.TabIndex = 32;
            staffChangePasswordButton.Text = "Change Password";
            staffChangePasswordButton.UseVisualStyleBackColor = true;
            staffChangePasswordButton.Click += staffChangePasswordButton_Click;
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(334, 99);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(94, 26);
            customerPhoneNumberLabel.TabIndex = 28;
            customerPhoneNumberLabel.Text = "Position:";
            // 
            // staffpositiontxt
            // 
            staffpositiontxt.Location = new System.Drawing.Point(434, 93);
            staffpositiontxt.Name = "staffpositiontxt";
            staffpositiontxt.ReadOnly = true;
            staffpositiontxt.Size = new System.Drawing.Size(271, 34);
            staffpositiontxt.TabIndex = 29;
            // 
            // staffgendertxt
            // 
            staffgendertxt.Location = new System.Drawing.Point(121, 93);
            staffgendertxt.Name = "staffgendertxt";
            staffgendertxt.ReadOnly = true;
            staffgendertxt.Size = new System.Drawing.Size(162, 34);
            staffgendertxt.TabIndex = 26;
            // 
            // customerGenderLabel
            // 
            customerGenderLabel.AutoSize = true;
            customerGenderLabel.Location = new System.Drawing.Point(38, 96);
            customerGenderLabel.Name = "customerGenderLabel";
            customerGenderLabel.Size = new System.Drawing.Size(86, 26);
            customerGenderLabel.TabIndex = 27;
            customerGenderLabel.Text = "Gender:";
            // 
            // staffnametxt
            // 
            staffnametxt.Location = new System.Drawing.Point(557, 29);
            staffnametxt.Name = "staffnametxt";
            staffnametxt.ReadOnly = true;
            staffnametxt.Size = new System.Drawing.Size(569, 34);
            staffnametxt.TabIndex = 24;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(485, 32);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(72, 26);
            customerNameLabel.TabIndex = 25;
            customerNameLabel.Text = "Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewDeposit);
            tabPage2.Controls.Add(customerDepositAmountNumeric);
            tabPage2.Controls.Add(customerDepositIdTextBox);
            tabPage2.Controls.Add(customerDepositButton);
            tabPage2.Controls.Add(customerDepositContentTextBox);
            tabPage2.Controls.Add(customerDepositContentLabel);
            tabPage2.Controls.Add(customerDepositAmountLabel);
            tabPage2.Controls.Add(customerDepositCicNumberTextBox);
            tabPage2.Controls.Add(customerDepositCicNumberLabel);
            tabPage2.Controls.Add(customerDepositNameTextBox);
            tabPage2.Controls.Add(customerDepositNameLabel);
            tabPage2.Controls.Add(customerDepositIdLabel);
            tabPage2.Controls.Add(groupBox8);
            tabPage2.Location = new System.Drawing.Point(4, 35);
            tabPage2.Margin = new System.Windows.Forms.Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(2);
            tabPage2.Size = new System.Drawing.Size(1254, 716);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deposit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeposit
            // 
            dataGridViewDeposit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewDeposit.Location = new System.Drawing.Point(2, 374);
            dataGridViewDeposit.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewDeposit.Name = "dataGridViewDeposit";
            dataGridViewDeposit.RowHeadersWidth = 62;
            dataGridViewDeposit.Size = new System.Drawing.Size(1250, 340);
            dataGridViewDeposit.TabIndex = 8;
            // 
            // customerDepositAmountNumeric
            // 
            customerDepositAmountNumeric.DecimalPlaces = 2;
            customerDepositAmountNumeric.Enabled = false;
            customerDepositAmountNumeric.Location = new System.Drawing.Point(363, 174);
            customerDepositAmountNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            customerDepositAmountNumeric.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            customerDepositAmountNumeric.Name = "customerDepositAmountNumeric";
            customerDepositAmountNumeric.Size = new System.Drawing.Size(303, 34);
            customerDepositAmountNumeric.TabIndex = 6;
            customerDepositAmountNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // customerDepositIdTextBox
            // 
            customerDepositIdTextBox.Location = new System.Drawing.Point(363, 41);
            customerDepositIdTextBox.MaxLength = 10;
            customerDepositIdTextBox.Name = "customerDepositIdTextBox";
            customerDepositIdTextBox.Size = new System.Drawing.Size(303, 34);
            customerDepositIdTextBox.TabIndex = 0;
            customerDepositIdTextBox.Enter += customerDepositIdTextBox_Enter;
            customerDepositIdTextBox.Leave += customerDepositIdTextBox_Leave;
            // 
            // customerDepositButton
            // 
            customerDepositButton.AutoSize = true;
            customerDepositButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerDepositButton.Enabled = false;
            customerDepositButton.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositButton.Location = new System.Drawing.Point(601, 325);
            customerDepositButton.Name = "customerDepositButton";
            customerDepositButton.Size = new System.Drawing.Size(93, 36);
            customerDepositButton.TabIndex = 5;
            customerDepositButton.Text = "Deposit";
            customerDepositButton.UseVisualStyleBackColor = true;
            customerDepositButton.Click += customerDepositButton_Click;
            // 
            // customerDepositContentTextBox
            // 
            customerDepositContentTextBox.Enabled = false;
            customerDepositContentTextBox.Location = new System.Drawing.Point(68, 262);
            customerDepositContentTextBox.Name = "customerDepositContentTextBox";
            customerDepositContentTextBox.Size = new System.Drawing.Size(598, 34);
            customerDepositContentTextBox.TabIndex = 4;
            customerDepositContentTextBox.TextChanged += customerDepositContentTextBox_TextChanged;
            // 
            // customerDepositContentLabel
            // 
            customerDepositContentLabel.AutoSize = true;
            customerDepositContentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositContentLabel.Location = new System.Drawing.Point(68, 222);
            customerDepositContentLabel.Name = "customerDepositContentLabel";
            customerDepositContentLabel.Size = new System.Drawing.Size(91, 26);
            customerDepositContentLabel.TabIndex = 4;
            customerDepositContentLabel.Text = "Content:";
            // 
            // customerDepositAmountLabel
            // 
            customerDepositAmountLabel.AutoSize = true;
            customerDepositAmountLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositAmountLabel.Location = new System.Drawing.Point(68, 176);
            customerDepositAmountLabel.Name = "customerDepositAmountLabel";
            customerDepositAmountLabel.Size = new System.Drawing.Size(165, 26);
            customerDepositAmountLabel.TabIndex = 3;
            customerDepositAmountLabel.Text = "Deposit amount:";
            // 
            // customerDepositCicNumberTextBox
            // 
            customerDepositCicNumberTextBox.Location = new System.Drawing.Point(363, 128);
            customerDepositCicNumberTextBox.Name = "customerDepositCicNumberTextBox";
            customerDepositCicNumberTextBox.ReadOnly = true;
            customerDepositCicNumberTextBox.Size = new System.Drawing.Size(303, 34);
            customerDepositCicNumberTextBox.TabIndex = 2;
            // 
            // customerDepositCicNumberLabel
            // 
            customerDepositCicNumberLabel.AutoSize = true;
            customerDepositCicNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositCicNumberLabel.Location = new System.Drawing.Point(68, 132);
            customerDepositCicNumberLabel.Name = "customerDepositCicNumberLabel";
            customerDepositCicNumberLabel.Size = new System.Drawing.Size(138, 26);
            customerDepositCicNumberLabel.TabIndex = 2;
            customerDepositCicNumberLabel.Text = "CIC Number:";
            // 
            // customerDepositNameTextBox
            // 
            customerDepositNameTextBox.Location = new System.Drawing.Point(363, 86);
            customerDepositNameTextBox.Name = "customerDepositNameTextBox";
            customerDepositNameTextBox.ReadOnly = true;
            customerDepositNameTextBox.Size = new System.Drawing.Size(303, 34);
            customerDepositNameTextBox.TabIndex = 1;
            // 
            // customerDepositNameLabel
            // 
            customerDepositNameLabel.AutoSize = true;
            customerDepositNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositNameLabel.Location = new System.Drawing.Point(68, 90);
            customerDepositNameLabel.Name = "customerDepositNameLabel";
            customerDepositNameLabel.Size = new System.Drawing.Size(72, 26);
            customerDepositNameLabel.TabIndex = 1;
            customerDepositNameLabel.Text = "Name:";
            // 
            // customerDepositIdLabel
            // 
            customerDepositIdLabel.AutoSize = true;
            customerDepositIdLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositIdLabel.Location = new System.Drawing.Point(68, 44);
            customerDepositIdLabel.Name = "customerDepositIdLabel";
            customerDepositIdLabel.Size = new System.Drawing.Size(138, 26);
            customerDepositIdLabel.TabIndex = 0;
            customerDepositIdLabel.Text = "Customer ID:";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(customerPrintButton);
            groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox8.Location = new System.Drawing.Point(2, 2);
            groupBox8.Margin = new System.Windows.Forms.Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new System.Windows.Forms.Padding(2);
            groupBox8.Size = new System.Drawing.Size(1250, 372);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            // 
            // customerPrintButton
            // 
            customerPrintButton.AutoSize = true;
            customerPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerPrintButton.Enabled = false;
            customerPrintButton.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerPrintButton.Location = new System.Drawing.Point(485, 323);
            customerPrintButton.Name = "customerPrintButton";
            customerPrintButton.Size = new System.Drawing.Size(67, 36);
            customerPrintButton.TabIndex = 5;
            customerPrintButton.Text = "Print";
            customerPrintButton.UseVisualStyleBackColor = true;
            customerPrintButton.Click += customerPrintButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewWithdraw);
            tabPage3.Controls.Add(customerWithdrawBalanceTextBox);
            tabPage3.Controls.Add(customerWithdrawBalanceLabel);
            tabPage3.Controls.Add(customerWithdrawAmountNumeric);
            tabPage3.Controls.Add(customerWithdrawIdTextBox);
            tabPage3.Controls.Add(customerWithdrawButton);
            tabPage3.Controls.Add(customerWithdrawContentTextBox);
            tabPage3.Controls.Add(customerWithdrawContentLabel);
            tabPage3.Controls.Add(customerWithdrawAmountLabel);
            tabPage3.Controls.Add(customerWithdrawCicNumberTextBox);
            tabPage3.Controls.Add(customerWithdrawCicNumberLabel);
            tabPage3.Controls.Add(customerWithdrawNameTextBox);
            tabPage3.Controls.Add(customerWithdrawNameLabel);
            tabPage3.Controls.Add(customerWithdrawIdLabel);
            tabPage3.Controls.Add(groupBox9);
            tabPage3.Location = new System.Drawing.Point(4, 35);
            tabPage3.Margin = new System.Windows.Forms.Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1254, 716);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Withdraw";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWithdraw
            // 
            dataGridViewWithdraw.BackgroundColor = System.Drawing.Color.White;
            dataGridViewWithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWithdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewWithdraw.Location = new System.Drawing.Point(0, 410);
            dataGridViewWithdraw.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewWithdraw.Name = "dataGridViewWithdraw";
            dataGridViewWithdraw.RowHeadersWidth = 62;
            dataGridViewWithdraw.Size = new System.Drawing.Size(1254, 306);
            dataGridViewWithdraw.TabIndex = 9;
            // 
            // customerWithdrawBalanceTextBox
            // 
            customerWithdrawBalanceTextBox.Location = new System.Drawing.Point(379, 164);
            customerWithdrawBalanceTextBox.Name = "customerWithdrawBalanceTextBox";
            customerWithdrawBalanceTextBox.ReadOnly = true;
            customerWithdrawBalanceTextBox.Size = new System.Drawing.Size(303, 34);
            customerWithdrawBalanceTextBox.TabIndex = 3;
            // 
            // customerWithdrawAmountNumeric
            // 
            customerWithdrawAmountNumeric.DecimalPlaces = 2;
            customerWithdrawAmountNumeric.Enabled = false;
            customerWithdrawAmountNumeric.Location = new System.Drawing.Point(379, 208);
            customerWithdrawAmountNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            customerWithdrawAmountNumeric.Name = "customerWithdrawAmountNumeric";
            customerWithdrawAmountNumeric.Size = new System.Drawing.Size(303, 34);
            customerWithdrawAmountNumeric.TabIndex = 4;
            // 
            // customerWithdrawIdTextBox
            // 
            customerWithdrawIdTextBox.Location = new System.Drawing.Point(379, 37);
            customerWithdrawIdTextBox.MaxLength = 0;
            customerWithdrawIdTextBox.Name = "customerWithdrawIdTextBox";
            customerWithdrawIdTextBox.Size = new System.Drawing.Size(303, 34);
            customerWithdrawIdTextBox.TabIndex = 7;
            customerWithdrawIdTextBox.Enter += customerWithdrawIdTextBox_Enter;
            customerWithdrawIdTextBox.Leave += customerWithdrawIdTextBox_Leave;
            // 
            // customerWithdrawButton
            // 
            customerWithdrawButton.AutoSize = true;
            customerWithdrawButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerWithdrawButton.Enabled = false;
            customerWithdrawButton.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawButton.Location = new System.Drawing.Point(617, 359);
            customerWithdrawButton.Name = "customerWithdrawButton";
            customerWithdrawButton.Size = new System.Drawing.Size(113, 36);
            customerWithdrawButton.TabIndex = 6;
            customerWithdrawButton.Text = "Withdraw";
            customerWithdrawButton.UseVisualStyleBackColor = true;
            customerWithdrawButton.Click += customerWithdrawButton_Click;
            // 
            // customerWithdrawContentTextBox
            // 
            customerWithdrawContentTextBox.Enabled = false;
            customerWithdrawContentTextBox.Location = new System.Drawing.Point(84, 296);
            customerWithdrawContentTextBox.Name = "customerWithdrawContentTextBox";
            customerWithdrawContentTextBox.Size = new System.Drawing.Size(598, 34);
            customerWithdrawContentTextBox.TabIndex = 5;
            customerWithdrawContentTextBox.TextChanged += customerWithdrawContentTextBox_TextChanged;
            // 
            // customerWithdrawCicNumberTextBox
            // 
            customerWithdrawCicNumberTextBox.Location = new System.Drawing.Point(379, 124);
            customerWithdrawCicNumberTextBox.Name = "customerWithdrawCicNumberTextBox";
            customerWithdrawCicNumberTextBox.ReadOnly = true;
            customerWithdrawCicNumberTextBox.Size = new System.Drawing.Size(303, 34);
            customerWithdrawCicNumberTextBox.TabIndex = 2;
            // 
            // customerWithdrawNameTextBox
            // 
            customerWithdrawNameTextBox.Location = new System.Drawing.Point(379, 82);
            customerWithdrawNameTextBox.Name = "customerWithdrawNameTextBox";
            customerWithdrawNameTextBox.ReadOnly = true;
            customerWithdrawNameTextBox.Size = new System.Drawing.Size(303, 34);
            customerWithdrawNameTextBox.TabIndex = 1;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(withdrawPrintButton);
            groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox9.Location = new System.Drawing.Point(0, 0);
            groupBox9.Margin = new System.Windows.Forms.Padding(2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new System.Windows.Forms.Padding(2);
            groupBox9.Size = new System.Drawing.Size(1254, 410);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            // 
            // tabPageManageCustomers
            // 
            tabPageManageCustomers.Controls.Add(dataGridViewCustomer);
            tabPageManageCustomers.Controls.Add(groupBox6);
            tabPageManageCustomers.Controls.Add(groupBox2);
            tabPageManageCustomers.Controls.Add(groupBox1);
            tabPageManageCustomers.Location = new System.Drawing.Point(4, 35);
            tabPageManageCustomers.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageCustomers.Name = "tabPageManageCustomers";
            tabPageManageCustomers.Size = new System.Drawing.Size(1254, 716);
            tabPageManageCustomers.TabIndex = 5;
            tabPageManageCustomers.Text = "Customer Management";
            tabPageManageCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCustomer.Location = new System.Drawing.Point(0, 451);
            dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new System.Drawing.Size(1254, 265);
            dataGridViewCustomer.TabIndex = 3;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(customerSearchTextBox);
            groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox6.Location = new System.Drawing.Point(0, 373);
            groupBox6.Margin = new System.Windows.Forms.Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(2);
            groupBox6.Size = new System.Drawing.Size(1254, 78);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Search";
            // 
            // customerSearchTextBox
            // 
            customerSearchTextBox.Location = new System.Drawing.Point(45, 32);
            customerSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new System.Drawing.Size(710, 34);
            customerSearchTextBox.TabIndex = 0;
            customerSearchTextBox.TextChanged += customerSearchTextBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(enableCustomerBtn);
            groupBox2.Controls.Add(clearScreenCustomerBtn);
            groupBox2.Controls.Add(disableCustomerBtn);
            groupBox2.Controls.Add(saveCustomerBtn);
            groupBox2.Controls.Add(addCustomerBtn);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(0, 281);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(1254, 92);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control button";
            // 
            // enableCustomerBtn
            // 
            enableCustomerBtn.AutoSize = true;
            enableCustomerBtn.Location = new System.Drawing.Point(456, 38);
            enableCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            enableCustomerBtn.Name = "enableCustomerBtn";
            enableCustomerBtn.Size = new System.Drawing.Size(102, 43);
            enableCustomerBtn.TabIndex = 4;
            enableCustomerBtn.Text = "Enable";
            enableCustomerBtn.UseVisualStyleBackColor = true;
            enableCustomerBtn.Click += enableCustomerBtn_Click;
            // 
            // clearScreenCustomerBtn
            // 
            clearScreenCustomerBtn.AutoSize = true;
            clearScreenCustomerBtn.Location = new System.Drawing.Point(587, 38);
            clearScreenCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            clearScreenCustomerBtn.Name = "clearScreenCustomerBtn";
            clearScreenCustomerBtn.Size = new System.Drawing.Size(167, 43);
            clearScreenCustomerBtn.TabIndex = 3;
            clearScreenCustomerBtn.Text = "Clear Screen";
            clearScreenCustomerBtn.UseVisualStyleBackColor = true;
            clearScreenCustomerBtn.Click += clearScreenCustomerBtn_Click;
            // 
            // disableCustomerBtn
            // 
            disableCustomerBtn.AutoSize = true;
            disableCustomerBtn.Location = new System.Drawing.Point(308, 38);
            disableCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            disableCustomerBtn.Name = "disableCustomerBtn";
            disableCustomerBtn.Size = new System.Drawing.Size(110, 43);
            disableCustomerBtn.TabIndex = 2;
            disableCustomerBtn.Text = "Disable";
            disableCustomerBtn.UseVisualStyleBackColor = true;
            disableCustomerBtn.Click += disableCustomerBtn_Click;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.AutoSize = true;
            saveCustomerBtn.Location = new System.Drawing.Point(174, 38);
            saveCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new System.Drawing.Size(90, 43);
            saveCustomerBtn.TabIndex = 1;
            saveCustomerBtn.Text = "Save";
            saveCustomerBtn.UseVisualStyleBackColor = true;
            saveCustomerBtn.Click += saveCustomerBtn_Click;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.AutoSize = true;
            addCustomerBtn.Location = new System.Drawing.Point(45, 38);
            addCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new System.Drawing.Size(90, 43);
            addCustomerBtn.TabIndex = 0;
            addCustomerBtn.Text = "Add";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customerBalanceTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(customerDisableCheckBox);
            groupBox1.Controls.Add(customerBirthDateTimePicker);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(customerMaleCheckBox);
            groupBox1.Controls.Add(customerHashedPasswordTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(customerUsernameTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(customerEmailTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(customerAddressTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(customerPhoneNumberTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(customerCicNumberTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(customerNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(customerIdTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(1254, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // customerBalanceTextBox
            // 
            customerBalanceTextBox.Location = new System.Drawing.Point(981, 170);
            customerBalanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerBalanceTextBox.Name = "customerBalanceTextBox";
            customerBalanceTextBox.Size = new System.Drawing.Size(255, 34);
            customerBalanceTextBox.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(881, 175);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(96, 26);
            label10.TabIndex = 20;
            label10.Text = "Balance: ";
            // 
            // customerDisableCheckBox
            // 
            customerDisableCheckBox.AutoSize = true;
            customerDisableCheckBox.Location = new System.Drawing.Point(881, 231);
            customerDisableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            customerDisableCheckBox.Name = "customerDisableCheckBox";
            customerDisableCheckBox.Size = new System.Drawing.Size(103, 30);
            customerDisableCheckBox.TabIndex = 19;
            customerDisableCheckBox.Text = "Disable";
            customerDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerBirthDateTimePicker
            // 
            customerBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            customerBirthDateTimePicker.Location = new System.Drawing.Point(513, 105);
            customerBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            customerBirthDateTimePicker.Name = "customerBirthDateTimePicker";
            customerBirthDateTimePicker.Size = new System.Drawing.Size(328, 34);
            customerBirthDateTimePicker.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(376, 107);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(136, 26);
            label9.TabIndex = 17;
            label9.Text = "Date of birth:";
            // 
            // customerMaleCheckBox
            // 
            customerMaleCheckBox.AutoSize = true;
            customerMaleCheckBox.Location = new System.Drawing.Point(881, 30);
            customerMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            customerMaleCheckBox.Name = "customerMaleCheckBox";
            customerMaleCheckBox.Size = new System.Drawing.Size(79, 30);
            customerMaleCheckBox.TabIndex = 16;
            customerMaleCheckBox.Text = "Male";
            customerMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerHashedPasswordTextBox
            // 
            customerHashedPasswordTextBox.Location = new System.Drawing.Point(550, 230);
            customerHashedPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerHashedPasswordTextBox.Name = "customerHashedPasswordTextBox";
            customerHashedPasswordTextBox.ReadOnly = true;
            customerHashedPasswordTextBox.Size = new System.Drawing.Size(291, 34);
            customerHashedPasswordTextBox.TabIndex = 15;
            customerHashedPasswordTextBox.KeyPress += customerHashedPasswordTextBox_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(376, 234);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(176, 26);
            label8.TabIndex = 14;
            label8.Text = "HashedPassword:";
            // 
            // customerUsernameTextBox
            // 
            customerUsernameTextBox.Location = new System.Drawing.Point(154, 230);
            customerUsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerUsernameTextBox.Name = "customerUsernameTextBox";
            customerUsernameTextBox.Size = new System.Drawing.Size(175, 34);
            customerUsernameTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(38, 234);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(116, 26);
            label7.TabIndex = 12;
            label7.Text = "Username: ";
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.Location = new System.Drawing.Point(462, 175);
            customerEmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.Size = new System.Drawing.Size(378, 34);
            customerEmailTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(376, 178);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 26);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Location = new System.Drawing.Point(138, 173);
            customerAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new System.Drawing.Size(190, 34);
            customerAddressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 175);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 26);
            label5.TabIndex = 8;
            label5.Text = "Address: ";
            // 
            // customerPhoneNumberTextBox
            // 
            customerPhoneNumberTextBox.Location = new System.Drawing.Point(1030, 102);
            customerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            customerPhoneNumberTextBox.Size = new System.Drawing.Size(206, 34);
            customerPhoneNumberTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(880, 107);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 26);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // customerCicNumberTextBox
            // 
            customerCicNumberTextBox.Location = new System.Drawing.Point(157, 102);
            customerCicNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerCicNumberTextBox.Name = "customerCicNumberTextBox";
            customerCicNumberTextBox.Size = new System.Drawing.Size(172, 34);
            customerCicNumberTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 105);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 26);
            label3.TabIndex = 4;
            label3.Text = "CicNumber:";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new System.Drawing.Point(450, 38);
            customerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new System.Drawing.Size(390, 34);
            customerNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(376, 41);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 26);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new System.Drawing.Point(78, 38);
            customerIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new System.Drawing.Size(250, 34);
            customerIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 43);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 26);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // tabPageManageStaffs
            // 
            tabPageManageStaffs.Controls.Add(dataGridViewStaff);
            tabPageManageStaffs.Controls.Add(groupBox7);
            tabPageManageStaffs.Controls.Add(groupBox4);
            tabPageManageStaffs.Controls.Add(groupBox3);
            tabPageManageStaffs.Location = new System.Drawing.Point(4, 35);
            tabPageManageStaffs.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageStaffs.Name = "tabPageManageStaffs";
            tabPageManageStaffs.Size = new System.Drawing.Size(1254, 716);
            tabPageManageStaffs.TabIndex = 3;
            tabPageManageStaffs.Text = "Staff Management";
            tabPageManageStaffs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewStaff.Location = new System.Drawing.Point(0, 421);
            dataGridViewStaff.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersWidth = 62;
            dataGridViewStaff.Size = new System.Drawing.Size(1254, 295);
            dataGridViewStaff.TabIndex = 3;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(staffSearchTextBox);
            groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox7.Location = new System.Drawing.Point(0, 339);
            groupBox7.Margin = new System.Windows.Forms.Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding(2);
            groupBox7.Size = new System.Drawing.Size(1254, 82);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Search";
            // 
            // staffSearchTextBox
            // 
            staffSearchTextBox.Location = new System.Drawing.Point(56, 38);
            staffSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffSearchTextBox.Name = "staffSearchTextBox";
            staffSearchTextBox.Size = new System.Drawing.Size(750, 34);
            staffSearchTextBox.TabIndex = 0;
            staffSearchTextBox.TextChanged += staffSearchTextBox_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(enableStaffBtn);
            groupBox4.Controls.Add(clearScreenStaffBtn);
            groupBox4.Controls.Add(disableStaffBtn);
            groupBox4.Controls.Add(saveStaffBtn);
            groupBox4.Controls.Add(addStaffBtn);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox4.Location = new System.Drawing.Point(0, 237);
            groupBox4.Margin = new System.Windows.Forms.Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(2);
            groupBox4.Size = new System.Drawing.Size(1254, 102);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Control Button";
            // 
            // enableStaffBtn
            // 
            enableStaffBtn.AutoSize = true;
            enableStaffBtn.Location = new System.Drawing.Point(497, 44);
            enableStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            enableStaffBtn.Name = "enableStaffBtn";
            enableStaffBtn.Size = new System.Drawing.Size(102, 43);
            enableStaffBtn.TabIndex = 4;
            enableStaffBtn.Text = "Enable";
            enableStaffBtn.UseVisualStyleBackColor = true;
            enableStaffBtn.Click += enableStaffBtn_Click;
            // 
            // clearScreenStaffBtn
            // 
            clearScreenStaffBtn.AutoSize = true;
            clearScreenStaffBtn.Location = new System.Drawing.Point(646, 44);
            clearScreenStaffBtn.Name = "clearScreenStaffBtn";
            clearScreenStaffBtn.Size = new System.Drawing.Size(160, 43);
            clearScreenStaffBtn.TabIndex = 3;
            clearScreenStaffBtn.Text = "ClearScreen";
            clearScreenStaffBtn.UseVisualStyleBackColor = true;
            clearScreenStaffBtn.Click += clearScreenStaffBtn_Click;
            // 
            // disableStaffBtn
            // 
            disableStaffBtn.AutoSize = true;
            disableStaffBtn.Location = new System.Drawing.Point(338, 44);
            disableStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            disableStaffBtn.Name = "disableStaffBtn";
            disableStaffBtn.Size = new System.Drawing.Size(110, 43);
            disableStaffBtn.TabIndex = 2;
            disableStaffBtn.Text = "Disable";
            disableStaffBtn.UseVisualStyleBackColor = true;
            disableStaffBtn.Click += disableStaffBtn_Click;
            // 
            // saveStaffBtn
            // 
            saveStaffBtn.AutoSize = true;
            saveStaffBtn.Location = new System.Drawing.Point(196, 44);
            saveStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            saveStaffBtn.Name = "saveStaffBtn";
            saveStaffBtn.Size = new System.Drawing.Size(90, 43);
            saveStaffBtn.TabIndex = 1;
            saveStaffBtn.Text = "Save";
            saveStaffBtn.UseVisualStyleBackColor = true;
            saveStaffBtn.Click += saveStaffBtn_Click;
            // 
            // addStaffBtn
            // 
            addStaffBtn.AutoSize = true;
            addStaffBtn.Location = new System.Drawing.Point(56, 44);
            addStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.Size = new System.Drawing.Size(90, 43);
            addStaffBtn.TabIndex = 0;
            addStaffBtn.Text = "Add";
            addStaffBtn.UseVisualStyleBackColor = true;
            addStaffBtn.Click += addStaffBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(staffDisableCheckBox);
            groupBox3.Controls.Add(staffMaleCheckBox);
            groupBox3.Controls.Add(staffPermissionIdComboBox);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(staffHashedPasswordTextBox);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(staffUsernameTextBox);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(staffPositionTextBox);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(staffNameTextBox);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(staffIdTextBox);
            groupBox3.Controls.Add(label11);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(0, 0);
            groupBox3.Margin = new System.Windows.Forms.Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(2);
            groupBox3.Size = new System.Drawing.Size(1254, 237);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Staff Information";
            // 
            // staffDisableCheckBox
            // 
            staffDisableCheckBox.AutoSize = true;
            staffDisableCheckBox.Location = new System.Drawing.Point(917, 104);
            staffDisableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            staffDisableCheckBox.Name = "staffDisableCheckBox";
            staffDisableCheckBox.Size = new System.Drawing.Size(103, 30);
            staffDisableCheckBox.TabIndex = 13;
            staffDisableCheckBox.Text = "Disable";
            staffDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffMaleCheckBox
            // 
            staffMaleCheckBox.AutoSize = true;
            staffMaleCheckBox.Location = new System.Drawing.Point(917, 41);
            staffMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            staffMaleCheckBox.Name = "staffMaleCheckBox";
            staffMaleCheckBox.Size = new System.Drawing.Size(79, 30);
            staffMaleCheckBox.TabIndex = 12;
            staffMaleCheckBox.Text = "Male";
            staffMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffPermissionIdComboBox
            // 
            staffPermissionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            staffPermissionIdComboBox.FormattingEnabled = true;
            staffPermissionIdComboBox.Location = new System.Drawing.Point(553, 101);
            staffPermissionIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            staffPermissionIdComboBox.Name = "staffPermissionIdComboBox";
            staffPermissionIdComboBox.Size = new System.Drawing.Size(302, 34);
            staffPermissionIdComboBox.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(399, 103);
            label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(141, 26);
            label16.TabIndex = 10;
            label16.Text = "PermissionId:";
            // 
            // staffHashedPasswordTextBox
            // 
            staffHashedPasswordTextBox.Location = new System.Drawing.Point(573, 168);
            staffHashedPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffHashedPasswordTextBox.Name = "staffHashedPasswordTextBox";
            staffHashedPasswordTextBox.ReadOnly = true;
            staffHashedPasswordTextBox.Size = new System.Drawing.Size(633, 34);
            staffHashedPasswordTextBox.TabIndex = 9;
            staffHashedPasswordTextBox.KeyPress += staffHashedPasswordTextBox_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(399, 170);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(176, 26);
            label15.TabIndex = 8;
            label15.Text = "HashedPassword:";
            // 
            // staffUsernameTextBox
            // 
            staffUsernameTextBox.Location = new System.Drawing.Point(150, 168);
            staffUsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffUsernameTextBox.Name = "staffUsernameTextBox";
            staffUsernameTextBox.Size = new System.Drawing.Size(203, 34);
            staffUsernameTextBox.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(40, 170);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(110, 26);
            label14.TabIndex = 6;
            label14.Text = "Username:";
            // 
            // staffPositionTextBox
            // 
            staffPositionTextBox.Location = new System.Drawing.Point(138, 101);
            staffPositionTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffPositionTextBox.Name = "staffPositionTextBox";
            staffPositionTextBox.Size = new System.Drawing.Size(216, 34);
            staffPositionTextBox.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(40, 103);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(94, 26);
            label13.TabIndex = 4;
            label13.Text = "Position:";
            // 
            // staffNameTextBox
            // 
            staffNameTextBox.Location = new System.Drawing.Point(479, 39);
            staffNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffNameTextBox.Name = "staffNameTextBox";
            staffNameTextBox.Size = new System.Drawing.Size(375, 34);
            staffNameTextBox.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(399, 44);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(78, 26);
            label12.TabIndex = 2;
            label12.Text = "Name: ";
            // 
            // staffIdTextBox
            // 
            staffIdTextBox.Location = new System.Drawing.Point(81, 42);
            staffIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffIdTextBox.Name = "staffIdTextBox";
            staffIdTextBox.Size = new System.Drawing.Size(273, 34);
            staffIdTextBox.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(40, 45);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(38, 26);
            label11.TabIndex = 0;
            label11.Text = "Id:";
            // 
            // tabPageChangeRegulations
            // 
            tabPageChangeRegulations.Controls.Add(label19);
            tabPageChangeRegulations.Controls.Add(saveRate);
            tabPageChangeRegulations.Controls.Add(ratetxt);
            tabPageChangeRegulations.Controls.Add(label17);
            tabPageChangeRegulations.Controls.Add(monthtxt);
            tabPageChangeRegulations.Controls.Add(label18);
            tabPageChangeRegulations.Controls.Add(groupBox5);
            tabPageChangeRegulations.Location = new System.Drawing.Point(4, 35);
            tabPageChangeRegulations.Margin = new System.Windows.Forms.Padding(2);
            tabPageChangeRegulations.Name = "tabPageChangeRegulations";
            tabPageChangeRegulations.Size = new System.Drawing.Size(1254, 716);
            tabPageChangeRegulations.TabIndex = 4;
            tabPageChangeRegulations.Text = "Change regulations";
            tabPageChangeRegulations.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(1179, 109);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(31, 26);
            label19.TabIndex = 12;
            label19.Text = "%";
            // 
            // saveRate
            // 
            saveRate.Location = new System.Drawing.Point(956, 220);
            saveRate.Name = "saveRate";
            saveRate.Size = new System.Drawing.Size(116, 42);
            saveRate.TabIndex = 11;
            saveRate.Text = "Save";
            saveRate.UseVisualStyleBackColor = true;
            saveRate.Click += saveRate_Click;
            // 
            // ratetxt
            // 
            ratetxt.Location = new System.Drawing.Point(1031, 106);
            ratetxt.Name = "ratetxt";
            ratetxt.Size = new System.Drawing.Size(142, 34);
            ratetxt.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(829, 114);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(196, 26);
            label17.TabIndex = 9;
            label17.Text = "AnnualInterestRate:";
            // 
            // monthtxt
            // 
            monthtxt.Location = new System.Drawing.Point(652, 106);
            monthtxt.Name = "monthtxt";
            monthtxt.ReadOnly = true;
            monthtxt.Size = new System.Drawing.Size(125, 34);
            monthtxt.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(477, 114);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(169, 26);
            label18.TabIndex = 7;
            label18.Text = "PeriodInMonths:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(data_rate);
            groupBox5.Location = new System.Drawing.Point(8, 25);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(442, 237);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "InterestRate";
            // 
            // data_rate
            // 
            data_rate.AllowUserToAddRows = false;
            data_rate.AllowUserToDeleteRows = false;
            data_rate.AllowUserToResizeColumns = false;
            data_rate.AllowUserToResizeRows = false;
            data_rate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            data_rate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            data_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            data_rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_rate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            data_rate.Location = new System.Drawing.Point(6, 27);
            data_rate.Name = "data_rate";
            data_rate.ReadOnly = true;
            data_rate.RowHeadersVisible = false;
            data_rate.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            data_rate.RowsDefaultCellStyle = dataGridViewCellStyle1;
            data_rate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            data_rate.Size = new System.Drawing.Size(426, 198);
            data_rate.TabIndex = 2;
            data_rate.CellClick += data_rate_CellClick;
            // 
            // withdrawPrintButton
            // 
            withdrawPrintButton.AutoSize = true;
            withdrawPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            withdrawPrintButton.Enabled = false;
            withdrawPrintButton.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            withdrawPrintButton.Location = new System.Drawing.Point(504, 359);
            withdrawPrintButton.Name = "withdrawPrintButton";
            withdrawPrintButton.Size = new System.Drawing.Size(67, 36);
            withdrawPrintButton.TabIndex = 10;
            withdrawPrintButton.Text = "Print";
            withdrawPrintButton.UseVisualStyleBackColor = true;
            withdrawPrintButton.Click += withdrawPrintButton_Click;
            // 
            // StaffMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 755);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "StaffMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StaffMenuForm";
            FormClosing += StaffMenuForm_FormClosing;
            Load += StaffMenuForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWithdraw).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            tabPageManageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageManageStaffs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPageChangeRegulations.ResumeLayout(false);
            tabPageChangeRegulations.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_rate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageManageStaffs;
        private System.Windows.Forms.TabPage tabPageChangeRegulations;
        private System.Windows.Forms.TabPage tabPageManageCustomers;
        private System.Windows.Forms.Button customerDepositButton;
        private System.Windows.Forms.TextBox customerDepositContentTextBox;
        private System.Windows.Forms.Label customerDepositContentLabel;
        private System.Windows.Forms.TextBox customerDepositAmountTextBox;
        private System.Windows.Forms.Label customerDepositAmountLabel;
        private System.Windows.Forms.TextBox customerDepositCicNumberTextBox;
        private System.Windows.Forms.Label customerDepositCicNumberLabel;
        private System.Windows.Forms.TextBox customerDepositNameTextBox;
        private System.Windows.Forms.Label customerDepositNameLabel;
        private System.Windows.Forms.Label customerDepositIdLabel;
        private System.Windows.Forms.TextBox customerDepositIdTextBox;
        private System.Windows.Forms.NumericUpDown customerDepositAmountNumeric;
        private System.Windows.Forms.NumericUpDown customerWithdrawAmountNumeric;
        private System.Windows.Forms.TextBox customerWithdrawIdTextBox;
        private System.Windows.Forms.Button customerWithdrawButton;
        private System.Windows.Forms.TextBox customerWithdrawContentTextBox;
        private System.Windows.Forms.Label customerWithdrawContentLabel;
        private System.Windows.Forms.Label customerWithdrawAmountLabel;
        private System.Windows.Forms.TextBox customerWithdrawCicNumberTextBox;
        private System.Windows.Forms.Label customerWithdrawCicNumberLabel;
        private System.Windows.Forms.TextBox customerWithdrawNameTextBox;
        private System.Windows.Forms.Label customerWithdrawNameLabel;
        private System.Windows.Forms.Label customerWithdrawIdLabel;
        private System.Windows.Forms.TextBox customerWithdrawBalanceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox customerHashedPasswordTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerUsernameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerCicNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker customerBirthDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox customerMaleCheckBox;
        private System.Windows.Forms.CheckBox customerDisableCheckBox;
        private System.Windows.Forms.Button clearScreenCustomerBtn;
        private System.Windows.Forms.Button disableCustomerBtn;
        private System.Windows.Forms.Button saveCustomerBtn;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.TextBox customerBalanceTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox staffNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox staffIdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox staffDisableCheckBox;
        private System.Windows.Forms.CheckBox staffMaleCheckBox;
        private System.Windows.Forms.ComboBox staffPermissionIdComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox staffHashedPasswordTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox staffUsernameTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox staffPositionTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button clearScreenStaffBtn;
        private System.Windows.Forms.Button disableStaffBtn;
        private System.Windows.Forms.Button saveStaffBtn;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button enableCustomerBtn;
        private System.Windows.Forms.Button enableStaffBtn;
        private System.Windows.Forms.TextBox staffusernametxt;
        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.TextBox staffIdtxt;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Button staffChangePasswordButton;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.TextBox staffpositiontxt;
        private System.Windows.Forms.TextBox staffgendertxt;
        private System.Windows.Forms.Label customerGenderLabel;
        private System.Windows.Forms.TextBox staffnametxt;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Button saveRate;
        private System.Windows.Forms.TextBox ratetxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox monthtxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView data_rate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox staffSearchTextBox;
        private System.Windows.Forms.DataGridView dataGridViewDeposit;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridViewWithdraw;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button customerPrintButton;
        private System.Windows.Forms.Button withdrawPrintButton;
    }
}