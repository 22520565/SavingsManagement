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
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.Label customerWithdrawBalanceLabel;
			System.Windows.Forms.Label customerWithdrawContentLabel;
			System.Windows.Forms.Label customerWithdrawAmountLabel;
			System.Windows.Forms.Label customerWithdrawCicNumberLabel;
			System.Windows.Forms.Label customerWithdrawNameLabel;
			System.Windows.Forms.Label customerWithdrawIdLabel;
			tabControlStaffMenu = new System.Windows.Forms.TabControl();
			tabPageInformation = new System.Windows.Forms.TabPage();
			button1 = new System.Windows.Forms.Button();
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
			tabPageDeposit = new System.Windows.Forms.TabPage();
			dataGridViewDeposit = new System.Windows.Forms.DataGridView();
			tabPageWithdraw = new System.Windows.Forms.TabPage();
			dataGridViewWithdraw = new System.Windows.Forms.DataGridView();
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
			staffUsernameTextBox = new System.Windows.Forms.TextBox();
			label14 = new System.Windows.Forms.Label();
			staffPositionTextBox = new System.Windows.Forms.TextBox();
			label13 = new System.Windows.Forms.Label();
			staffNameTextBox = new System.Windows.Forms.TextBox();
			label12 = new System.Windows.Forms.Label();
			staffIdTextBox = new System.Windows.Forms.TextBox();
			label11 = new System.Windows.Forms.Label();
			tabPageFinancialReport = new System.Windows.Forms.TabPage();
			panel1 = new System.Windows.Forms.Panel();
			groupBox11 = new System.Windows.Forms.GroupBox();
			rbMonthly = new System.Windows.Forms.RadioButton();
			rbDaily = new System.Windows.Forms.RadioButton();
			dailyReportBtn = new System.Windows.Forms.Button();
			label22 = new System.Windows.Forms.Label();
			dailyReportDateTimePicker = new System.Windows.Forms.DateTimePicker();
			dataGridViewDailyReport = new System.Windows.Forms.DataGridView();
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
			groupBox10 = new System.Windows.Forms.GroupBox();
			label8 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			customerWithdrawBalanceTextBox = new System.Windows.Forms.TextBox();
			customerWithdrawAmountNumeric = new System.Windows.Forms.NumericUpDown();
			customerWithdrawIdTextBox = new System.Windows.Forms.TextBox();
			customerWithdrawCicNumberTextBox = new System.Windows.Forms.TextBox();
			customerWithdrawNameTextBox = new System.Windows.Forms.TextBox();
			amountWithdrawingErrorLabel = new System.Windows.Forms.Label();
			customerWithdrawContentTextBox = new System.Windows.Forms.TextBox();
			reportWithdrawBtn = new System.Windows.Forms.Button();
			withdrawPrintButton = new System.Windows.Forms.Button();
			customerWithdrawButton = new System.Windows.Forms.Button();
			panel3 = new System.Windows.Forms.Panel();
			customerDepositAmountNumeric = new System.Windows.Forms.NumericUpDown();
			customerDepositIdTextBox = new System.Windows.Forms.TextBox();
			customerDepositContentTextBox = new System.Windows.Forms.TextBox();
			customerDepositContentLabel = new System.Windows.Forms.Label();
			customerDepositAmountLabel = new System.Windows.Forms.Label();
			customerDepositCicNumberTextBox = new System.Windows.Forms.TextBox();
			customerDepositCicNumberLabel = new System.Windows.Forms.Label();
			customerDepositNameTextBox = new System.Windows.Forms.TextBox();
			customerDepositNameLabel = new System.Windows.Forms.Label();
			customerDepositIdLabel = new System.Windows.Forms.Label();
			reportDepositBtn = new System.Windows.Forms.Button();
			customerPrintButton = new System.Windows.Forms.Button();
			customerDepositButton = new System.Windows.Forms.Button();
			groupBox8 = new System.Windows.Forms.GroupBox();
			customerWithdrawBalanceLabel = new System.Windows.Forms.Label();
			customerWithdrawContentLabel = new System.Windows.Forms.Label();
			customerWithdrawAmountLabel = new System.Windows.Forms.Label();
			customerWithdrawCicNumberLabel = new System.Windows.Forms.Label();
			customerWithdrawNameLabel = new System.Windows.Forms.Label();
			customerWithdrawIdLabel = new System.Windows.Forms.Label();
			tabControlStaffMenu.SuspendLayout();
			tabPageInformation.SuspendLayout();
			tabPageDeposit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).BeginInit();
			tabPageWithdraw.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewWithdraw).BeginInit();
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
			tabPageFinancialReport.SuspendLayout();
			panel1.SuspendLayout();
			groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewDailyReport).BeginInit();
			tabPageChangeRegulations.SuspendLayout();
			groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)data_rate).BeginInit();
			groupBox10.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).BeginInit();
			groupBox8.SuspendLayout();
			SuspendLayout();
			// 
			// tabControlStaffMenu
			// 
			tabControlStaffMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			tabControlStaffMenu.Controls.Add(tabPageInformation);
			tabControlStaffMenu.Controls.Add(tabPageDeposit);
			tabControlStaffMenu.Controls.Add(tabPageWithdraw);
			tabControlStaffMenu.Controls.Add(tabPageManageCustomers);
			tabControlStaffMenu.Controls.Add(tabPageManageStaffs);
			tabControlStaffMenu.Controls.Add(tabPageFinancialReport);
			tabControlStaffMenu.Controls.Add(tabPageChangeRegulations);
			tabControlStaffMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			tabControlStaffMenu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			tabControlStaffMenu.Location = new System.Drawing.Point(0, 0);
			tabControlStaffMenu.Margin = new System.Windows.Forms.Padding(2);
			tabControlStaffMenu.Name = "tabControlStaffMenu";
			tabControlStaffMenu.SelectedIndex = 0;
			tabControlStaffMenu.Size = new System.Drawing.Size(1262, 755);
			tabControlStaffMenu.TabIndex = 0;
			tabControlStaffMenu.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
			// 
			// tabPageInformation
			// 
			tabPageInformation.Controls.Add(button1);
			tabPageInformation.Controls.Add(staffusernametxt);
			tabPageInformation.Controls.Add(customerUsernameLabel);
			tabPageInformation.Controls.Add(staffIdtxt);
			tabPageInformation.Controls.Add(customerIdLabel);
			tabPageInformation.Controls.Add(staffChangePasswordButton);
			tabPageInformation.Controls.Add(customerPhoneNumberLabel);
			tabPageInformation.Controls.Add(staffpositiontxt);
			tabPageInformation.Controls.Add(staffgendertxt);
			tabPageInformation.Controls.Add(customerGenderLabel);
			tabPageInformation.Controls.Add(staffnametxt);
			tabPageInformation.Controls.Add(customerNameLabel);
			tabPageInformation.Location = new System.Drawing.Point(4, 35);
			tabPageInformation.Margin = new System.Windows.Forms.Padding(2);
			tabPageInformation.Name = "tabPageInformation";
			tabPageInformation.Padding = new System.Windows.Forms.Padding(2);
			tabPageInformation.Size = new System.Drawing.Size(1254, 716);
			tabPageInformation.TabIndex = 0;
			tabPageInformation.Text = "Information";
			tabPageInformation.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			button1.Location = new System.Drawing.Point(692, 209);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(183, 33);
			button1.TabIndex = 33;
			button1.Text = "Change Infomation";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// staffusernametxt
			// 
			staffusernametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffusernametxt.Location = new System.Drawing.Point(886, 93);
			staffusernametxt.Name = "staffusernametxt";
			staffusernametxt.ReadOnly = true;
			staffusernametxt.Size = new System.Drawing.Size(336, 31);
			staffusernametxt.TabIndex = 30;
			// 
			// customerUsernameLabel
			// 
			customerUsernameLabel.AutoSize = true;
			customerUsernameLabel.Location = new System.Drawing.Point(770, 99);
			customerUsernameLabel.Name = "customerUsernameLabel";
			customerUsernameLabel.Size = new System.Drawing.Size(103, 23);
			customerUsernameLabel.TabIndex = 31;
			customerUsernameLabel.Text = "Username:";
			// 
			// staffIdtxt
			// 
			staffIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffIdtxt.Location = new System.Drawing.Point(78, 29);
			staffIdtxt.Name = "staffIdtxt";
			staffIdtxt.ReadOnly = true;
			staffIdtxt.Size = new System.Drawing.Size(365, 31);
			staffIdtxt.TabIndex = 22;
			// 
			// customerIdLabel
			// 
			customerIdLabel.AutoSize = true;
			customerIdLabel.Location = new System.Drawing.Point(38, 32);
			customerIdLabel.Name = "customerIdLabel";
			customerIdLabel.Size = new System.Drawing.Size(34, 23);
			customerIdLabel.TabIndex = 23;
			customerIdLabel.Text = "ID:";
			// 
			// staffChangePasswordButton
			// 
			staffChangePasswordButton.AutoSize = true;
			staffChangePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			staffChangePasswordButton.Location = new System.Drawing.Point(969, 209);
			staffChangePasswordButton.Name = "staffChangePasswordButton";
			staffChangePasswordButton.Size = new System.Drawing.Size(171, 33);
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
			customerPhoneNumberLabel.Size = new System.Drawing.Size(87, 23);
			customerPhoneNumberLabel.TabIndex = 28;
			customerPhoneNumberLabel.Text = "Position:";
			// 
			// staffpositiontxt
			// 
			staffpositiontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffpositiontxt.Location = new System.Drawing.Point(434, 93);
			staffpositiontxt.Name = "staffpositiontxt";
			staffpositiontxt.ReadOnly = true;
			staffpositiontxt.Size = new System.Drawing.Size(271, 31);
			staffpositiontxt.TabIndex = 29;
			// 
			// staffgendertxt
			// 
			staffgendertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffgendertxt.Location = new System.Drawing.Point(121, 93);
			staffgendertxt.Name = "staffgendertxt";
			staffgendertxt.ReadOnly = true;
			staffgendertxt.Size = new System.Drawing.Size(162, 31);
			staffgendertxt.TabIndex = 26;
			// 
			// customerGenderLabel
			// 
			customerGenderLabel.AutoSize = true;
			customerGenderLabel.Location = new System.Drawing.Point(38, 96);
			customerGenderLabel.Name = "customerGenderLabel";
			customerGenderLabel.Size = new System.Drawing.Size(77, 23);
			customerGenderLabel.TabIndex = 27;
			customerGenderLabel.Text = "Gender:";
			// 
			// staffnametxt
			// 
			staffnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffnametxt.Location = new System.Drawing.Point(557, 29);
			staffnametxt.Name = "staffnametxt";
			staffnametxt.ReadOnly = true;
			staffnametxt.Size = new System.Drawing.Size(569, 31);
			staffnametxt.TabIndex = 24;
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Location = new System.Drawing.Point(485, 32);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(66, 23);
			customerNameLabel.TabIndex = 25;
			customerNameLabel.Text = "Name:";
			// 
			// tabPageDeposit
			// 
			tabPageDeposit.Controls.Add(panel3);
			tabPageDeposit.Controls.Add(dataGridViewDeposit);
			tabPageDeposit.Location = new System.Drawing.Point(4, 35);
			tabPageDeposit.Margin = new System.Windows.Forms.Padding(2);
			tabPageDeposit.Name = "tabPageDeposit";
			tabPageDeposit.Padding = new System.Windows.Forms.Padding(2);
			tabPageDeposit.Size = new System.Drawing.Size(1254, 716);
			tabPageDeposit.TabIndex = 1;
			tabPageDeposit.Text = "Deposit";
			tabPageDeposit.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDeposit
			// 
			dataGridViewDeposit.BackgroundColor = System.Drawing.Color.White;
			dataGridViewDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewDeposit.Dock = System.Windows.Forms.DockStyle.Right;
			dataGridViewDeposit.Location = new System.Drawing.Point(681, 2);
			dataGridViewDeposit.Margin = new System.Windows.Forms.Padding(2);
			dataGridViewDeposit.Name = "dataGridViewDeposit";
			dataGridViewDeposit.RowHeadersWidth = 62;
			dataGridViewDeposit.Size = new System.Drawing.Size(571, 712);
			dataGridViewDeposit.TabIndex = 8;
			dataGridViewDeposit.CellContentClick += dataGridViewDeposit_CellContentClick;
			// 
			// tabPageWithdraw
			// 
			tabPageWithdraw.Controls.Add(panel2);
			tabPageWithdraw.Controls.Add(dataGridViewWithdraw);
			tabPageWithdraw.Location = new System.Drawing.Point(4, 35);
			tabPageWithdraw.Margin = new System.Windows.Forms.Padding(2);
			tabPageWithdraw.Name = "tabPageWithdraw";
			tabPageWithdraw.Size = new System.Drawing.Size(1254, 716);
			tabPageWithdraw.TabIndex = 2;
			tabPageWithdraw.Text = "Withdraw";
			tabPageWithdraw.UseVisualStyleBackColor = true;
			// 
			// dataGridViewWithdraw
			// 
			dataGridViewWithdraw.BackgroundColor = System.Drawing.Color.White;
			dataGridViewWithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewWithdraw.Dock = System.Windows.Forms.DockStyle.Right;
			dataGridViewWithdraw.Location = new System.Drawing.Point(679, 0);
			dataGridViewWithdraw.Margin = new System.Windows.Forms.Padding(2);
			dataGridViewWithdraw.Name = "dataGridViewWithdraw";
			dataGridViewWithdraw.RowHeadersWidth = 62;
			dataGridViewWithdraw.Size = new System.Drawing.Size(575, 716);
			dataGridViewWithdraw.TabIndex = 9;
			dataGridViewWithdraw.CellContentClick += dataGridViewWithdraw_CellContentClick;
			// 
			// tabPageManageCustomers
			// 
			tabPageManageCustomers.Controls.Add(groupBox8);
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
			customerSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerSearchTextBox.Location = new System.Drawing.Point(45, 32);
			customerSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
			customerSearchTextBox.Name = "customerSearchTextBox";
			customerSearchTextBox.Size = new System.Drawing.Size(710, 31);
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
			groupBox1.Controls.Add(customerDisableCheckBox);
			groupBox1.Controls.Add(customerBirthDateTimePicker);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(customerMaleCheckBox);
			groupBox1.Controls.Add(customerEmailTextBox);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(customerPhoneNumberTextBox);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(customerAddressTextBox);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(customerCicNumberTextBox);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(customerNameTextBox);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new System.Drawing.Point(0, 0);
			groupBox1.Margin = new System.Windows.Forms.Padding(2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(2);
			groupBox1.Size = new System.Drawing.Size(788, 281);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Information";
			// 
			// customerBalanceTextBox
			// 
			customerBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerBalanceTextBox.Location = new System.Drawing.Point(227, 91);
			customerBalanceTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerBalanceTextBox.Name = "customerBalanceTextBox";
			customerBalanceTextBox.Size = new System.Drawing.Size(194, 31);
			customerBalanceTextBox.TabIndex = 21;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(227, 63);
			label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(86, 23);
			label10.TabIndex = 20;
			label10.Text = "Balance: ";
			// 
			// customerDisableCheckBox
			// 
			customerDisableCheckBox.AutoSize = true;
			customerDisableCheckBox.Location = new System.Drawing.Point(470, 292);
			customerDisableCheckBox.Margin = new System.Windows.Forms.Padding(2);
			customerDisableCheckBox.Name = "customerDisableCheckBox";
			customerDisableCheckBox.Size = new System.Drawing.Size(96, 27);
			customerDisableCheckBox.TabIndex = 19;
			customerDisableCheckBox.Text = "Disable";
			customerDisableCheckBox.UseVisualStyleBackColor = true;
			// 
			// customerBirthDateTimePicker
			// 
			customerBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			customerBirthDateTimePicker.Location = new System.Drawing.Point(385, 63);
			customerBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
			customerBirthDateTimePicker.Name = "customerBirthDateTimePicker";
			customerBirthDateTimePicker.Size = new System.Drawing.Size(243, 31);
			customerBirthDateTimePicker.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(385, 35);
			label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(123, 23);
			label9.TabIndex = 17;
			label9.Text = "Date of birth:";
			// 
			// customerMaleCheckBox
			// 
			customerMaleCheckBox.AutoSize = true;
			customerMaleCheckBox.Location = new System.Drawing.Point(671, 64);
			customerMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
			customerMaleCheckBox.Name = "customerMaleCheckBox";
			customerMaleCheckBox.Size = new System.Drawing.Size(73, 27);
			customerMaleCheckBox.TabIndex = 16;
			customerMaleCheckBox.Text = "Male";
			customerMaleCheckBox.UseVisualStyleBackColor = true;
			// 
			// customerUsernameTextBox
			// 
			customerUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerUsernameTextBox.Location = new System.Drawing.Point(43, 178);
			customerUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerUsernameTextBox.Name = "customerUsernameTextBox";
			customerUsernameTextBox.Size = new System.Drawing.Size(378, 31);
			customerUsernameTextBox.TabIndex = 13;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(43, 150);
			label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(107, 23);
			label7.TabIndex = 12;
			label7.Text = "Username: ";
			// 
			// customerEmailTextBox
			// 
			customerEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerEmailTextBox.Location = new System.Drawing.Point(36, 149);
			customerEmailTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerEmailTextBox.Name = "customerEmailTextBox";
			customerEmailTextBox.Size = new System.Drawing.Size(295, 31);
			customerEmailTextBox.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(36, 121);
			label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(65, 23);
			label6.TabIndex = 10;
			label6.Text = "Email:";
			// 
			// customerAddressTextBox
			// 
			customerAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerAddressTextBox.Location = new System.Drawing.Point(36, 223);
			customerAddressTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerAddressTextBox.Name = "customerAddressTextBox";
			customerAddressTextBox.Size = new System.Drawing.Size(295, 31);
			customerAddressTextBox.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(36, 195);
			label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(89, 23);
			label5.TabIndex = 8;
			label5.Text = "Address: ";
			// 
			// customerPhoneNumberTextBox
			// 
			customerPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerPhoneNumberTextBox.Location = new System.Drawing.Point(385, 149);
			customerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
			customerPhoneNumberTextBox.Size = new System.Drawing.Size(243, 31);
			customerPhoneNumberTextBox.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(385, 121);
			label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(139, 23);
			label4.TabIndex = 6;
			label4.Text = "Phone Number";
			// 
			// customerCicNumberTextBox
			// 
			customerCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerCicNumberTextBox.Location = new System.Drawing.Point(385, 223);
			customerCicNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerCicNumberTextBox.Name = "customerCicNumberTextBox";
			customerCicNumberTextBox.Size = new System.Drawing.Size(243, 31);
			customerCicNumberTextBox.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(385, 195);
			label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(118, 23);
			label3.TabIndex = 4;
			label3.Text = "CIC Number:";
			// 
			// customerNameTextBox
			// 
			customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerNameTextBox.Location = new System.Drawing.Point(36, 63);
			customerNameTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerNameTextBox.Name = "customerNameTextBox";
			customerNameTextBox.Size = new System.Drawing.Size(295, 31);
			customerNameTextBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(36, 35);
			label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(66, 23);
			label2.TabIndex = 2;
			label2.Text = "Name:";
			// 
			// customerIdTextBox
			// 
			customerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerIdTextBox.Location = new System.Drawing.Point(43, 91);
			customerIdTextBox.Margin = new System.Windows.Forms.Padding(5);
			customerIdTextBox.Name = "customerIdTextBox";
			customerIdTextBox.Size = new System.Drawing.Size(127, 31);
			customerIdTextBox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(43, 63);
			label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(32, 23);
			label1.TabIndex = 0;
			label1.Text = "Id:";
			// 
			// tabPageManageStaffs
			// 
			tabPageManageStaffs.Controls.Add(groupBox10);
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
			staffSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffSearchTextBox.Location = new System.Drawing.Point(56, 38);
			staffSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
			staffSearchTextBox.Name = "staffSearchTextBox";
			staffSearchTextBox.Size = new System.Drawing.Size(750, 31);
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
			groupBox3.Controls.Add(label8);
			groupBox3.Controls.Add(label12);
			groupBox3.Controls.Add(staffMaleCheckBox);
			groupBox3.Controls.Add(staffNameTextBox);
			groupBox3.Location = new System.Drawing.Point(0, 0);
			groupBox3.Margin = new System.Windows.Forms.Padding(2);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new System.Windows.Forms.Padding(2);
			groupBox3.Size = new System.Drawing.Size(407, 237);
			groupBox3.TabIndex = 0;
			groupBox3.TabStop = false;
			groupBox3.Text = "Information";
			// 
			// staffDisableCheckBox
			// 
			staffDisableCheckBox.AutoSize = true;
			staffDisableCheckBox.Location = new System.Drawing.Point(599, 74);
			staffDisableCheckBox.Margin = new System.Windows.Forms.Padding(5);
			staffDisableCheckBox.Name = "staffDisableCheckBox";
			staffDisableCheckBox.Size = new System.Drawing.Size(96, 27);
			staffDisableCheckBox.TabIndex = 13;
			staffDisableCheckBox.Text = "Disable";
			staffDisableCheckBox.UseVisualStyleBackColor = true;
			// 
			// staffMaleCheckBox
			// 
			staffMaleCheckBox.AutoSize = true;
			staffMaleCheckBox.Location = new System.Drawing.Point(45, 168);
			staffMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
			staffMaleCheckBox.Name = "staffMaleCheckBox";
			staffMaleCheckBox.Size = new System.Drawing.Size(73, 27);
			staffMaleCheckBox.TabIndex = 12;
			staffMaleCheckBox.Text = "Male";
			staffMaleCheckBox.UseVisualStyleBackColor = true;
			// 
			// staffPermissionIdComboBox
			// 
			staffPermissionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			staffPermissionIdComboBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffPermissionIdComboBox.FormattingEnabled = true;
			staffPermissionIdComboBox.Location = new System.Drawing.Point(327, 154);
			staffPermissionIdComboBox.Margin = new System.Windows.Forms.Padding(5);
			staffPermissionIdComboBox.Name = "staffPermissionIdComboBox";
			staffPermissionIdComboBox.Size = new System.Drawing.Size(220, 31);
			staffPermissionIdComboBox.TabIndex = 11;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(327, 126);
			label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(113, 23);
			label16.TabIndex = 10;
			label16.Text = "Permission:";
			// 
			// staffUsernameTextBox
			// 
			staffUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffUsernameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffUsernameTextBox.Location = new System.Drawing.Point(327, 70);
			staffUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffUsernameTextBox.Name = "staffUsernameTextBox";
			staffUsernameTextBox.Size = new System.Drawing.Size(220, 31);
			staffUsernameTextBox.TabIndex = 7;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(327, 42);
			label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(103, 23);
			label14.TabIndex = 6;
			label14.Text = "Username:";
			// 
			// staffPositionTextBox
			// 
			staffPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffPositionTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffPositionTextBox.Location = new System.Drawing.Point(62, 154);
			staffPositionTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffPositionTextBox.Name = "staffPositionTextBox";
			staffPositionTextBox.Size = new System.Drawing.Size(209, 31);
			staffPositionTextBox.TabIndex = 5;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(62, 126);
			label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(87, 23);
			label13.TabIndex = 4;
			label13.Text = "Position:";
			// 
			// staffNameTextBox
			// 
			staffNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffNameTextBox.Location = new System.Drawing.Point(45, 80);
			staffNameTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffNameTextBox.Name = "staffNameTextBox";
			staffNameTextBox.Size = new System.Drawing.Size(314, 31);
			staffNameTextBox.TabIndex = 3;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(45, 49);
			label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(70, 23);
			label12.TabIndex = 2;
			label12.Text = "Name: ";
			// 
			// staffIdTextBox
			// 
			staffIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			staffIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			staffIdTextBox.Location = new System.Drawing.Point(62, 70);
			staffIdTextBox.Margin = new System.Windows.Forms.Padding(5);
			staffIdTextBox.Name = "staffIdTextBox";
			staffIdTextBox.Size = new System.Drawing.Size(209, 31);
			staffIdTextBox.TabIndex = 1;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(62, 42);
			label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(32, 23);
			label11.TabIndex = 0;
			label11.Text = "Id:";
			// 
			// tabPageFinancialReport
			// 
			tabPageFinancialReport.Controls.Add(panel1);
			tabPageFinancialReport.Controls.Add(dataGridViewDailyReport);
			tabPageFinancialReport.Location = new System.Drawing.Point(4, 35);
			tabPageFinancialReport.Name = "tabPageFinancialReport";
			tabPageFinancialReport.Size = new System.Drawing.Size(1254, 716);
			tabPageFinancialReport.TabIndex = 6;
			tabPageFinancialReport.Text = "Financial Report";
			tabPageFinancialReport.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(groupBox11);
			panel1.Controls.Add(dailyReportBtn);
			panel1.Controls.Add(label22);
			panel1.Controls.Add(dailyReportDateTimePicker);
			panel1.Dock = System.Windows.Forms.DockStyle.Left;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(514, 716);
			panel1.TabIndex = 9;
			// 
			// groupBox11
			// 
			groupBox11.Controls.Add(rbMonthly);
			groupBox11.Controls.Add(rbDaily);
			groupBox11.Location = new System.Drawing.Point(128, 143);
			groupBox11.Name = "groupBox11";
			groupBox11.Size = new System.Drawing.Size(300, 125);
			groupBox11.TabIndex = 9;
			groupBox11.TabStop = false;
			groupBox11.Text = "Select report type";
			// 
			// rbMonthly
			// 
			rbMonthly.AutoSize = true;
			rbMonthly.Location = new System.Drawing.Point(165, 66);
			rbMonthly.Name = "rbMonthly";
			rbMonthly.Size = new System.Drawing.Size(102, 27);
			rbMonthly.TabIndex = 1;
			rbMonthly.TabStop = true;
			rbMonthly.Text = "Monthly";
			rbMonthly.UseVisualStyleBackColor = true;
			// 
			// rbDaily
			// 
			rbDaily.AutoSize = true;
			rbDaily.Location = new System.Drawing.Point(24, 66);
			rbDaily.Name = "rbDaily";
			rbDaily.Size = new System.Drawing.Size(75, 27);
			rbDaily.TabIndex = 0;
			rbDaily.TabStop = true;
			rbDaily.Text = "Daily";
			rbDaily.UseVisualStyleBackColor = true;
			// 
			// dailyReportBtn
			// 
			dailyReportBtn.AutoSize = true;
			dailyReportBtn.Location = new System.Drawing.Point(169, 437);
			dailyReportBtn.Name = "dailyReportBtn";
			dailyReportBtn.Size = new System.Drawing.Size(171, 43);
			dailyReportBtn.TabIndex = 8;
			dailyReportBtn.Text = "Export Excel";
			dailyReportBtn.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new System.Drawing.Point(57, 341);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(60, 23);
			label22.TabIndex = 6;
			label22.Text = "Time:";
			// 
			// dailyReportDateTimePicker
			// 
			dailyReportDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			dailyReportDateTimePicker.Location = new System.Drawing.Point(128, 335);
			dailyReportDateTimePicker.Name = "dailyReportDateTimePicker";
			dailyReportDateTimePicker.Size = new System.Drawing.Size(300, 31);
			dailyReportDateTimePicker.TabIndex = 7;
			// 
			// dataGridViewDailyReport
			// 
			dataGridViewDailyReport.BackgroundColor = System.Drawing.Color.White;
			dataGridViewDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewDailyReport.Dock = System.Windows.Forms.DockStyle.Right;
			dataGridViewDailyReport.Location = new System.Drawing.Point(520, 0);
			dataGridViewDailyReport.Name = "dataGridViewDailyReport";
			dataGridViewDailyReport.RowHeadersWidth = 62;
			dataGridViewDailyReport.Size = new System.Drawing.Size(734, 716);
			dataGridViewDailyReport.TabIndex = 8;
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
			label19.Size = new System.Drawing.Size(28, 23);
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
			ratetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			ratetxt.Location = new System.Drawing.Point(1031, 106);
			ratetxt.Name = "ratetxt";
			ratetxt.Size = new System.Drawing.Size(142, 31);
			ratetxt.TabIndex = 10;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new System.Drawing.Point(829, 114);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(182, 23);
			label17.TabIndex = 9;
			label17.Text = "AnnualInterestRate:";
			// 
			// monthtxt
			// 
			monthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			monthtxt.Location = new System.Drawing.Point(652, 106);
			monthtxt.Name = "monthtxt";
			monthtxt.ReadOnly = true;
			monthtxt.Size = new System.Drawing.Size(125, 31);
			monthtxt.TabIndex = 8;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(477, 114);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(154, 23);
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			data_rate.RowsDefaultCellStyle = dataGridViewCellStyle2;
			data_rate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			data_rate.Size = new System.Drawing.Size(426, 198);
			data_rate.TabIndex = 2;
			data_rate.CellClick += data_rate_CellClick;
			// 
			// groupBox10
			// 
			groupBox10.Controls.Add(label15);
			groupBox10.Controls.Add(staffDisableCheckBox);
			groupBox10.Controls.Add(staffIdTextBox);
			groupBox10.Controls.Add(staffPermissionIdComboBox);
			groupBox10.Controls.Add(label11);
			groupBox10.Controls.Add(label13);
			groupBox10.Controls.Add(staffPositionTextBox);
			groupBox10.Controls.Add(label16);
			groupBox10.Controls.Add(staffUsernameTextBox);
			groupBox10.Controls.Add(label14);
			groupBox10.Location = new System.Drawing.Point(426, 0);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new System.Drawing.Size(823, 237);
			groupBox10.TabIndex = 4;
			groupBox10.TabStop = false;
			groupBox10.Text = "Account";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(45, 136);
			label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(77, 23);
			label8.TabIndex = 14;
			label8.Text = "Gender:";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(599, 42);
			label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(69, 23);
			label15.TabIndex = 15;
			label15.Text = "Status:";
			// 
			// panel2
			// 
			panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel2.Controls.Add(customerWithdrawBalanceTextBox);
			panel2.Controls.Add(customerWithdrawBalanceLabel);
			panel2.Controls.Add(customerWithdrawAmountNumeric);
			panel2.Controls.Add(customerWithdrawIdTextBox);
			panel2.Controls.Add(customerWithdrawContentLabel);
			panel2.Controls.Add(customerWithdrawAmountLabel);
			panel2.Controls.Add(customerWithdrawCicNumberTextBox);
			panel2.Controls.Add(customerWithdrawCicNumberLabel);
			panel2.Controls.Add(customerWithdrawNameTextBox);
			panel2.Controls.Add(customerWithdrawNameLabel);
			panel2.Controls.Add(customerWithdrawIdLabel);
			panel2.Controls.Add(amountWithdrawingErrorLabel);
			panel2.Controls.Add(customerWithdrawContentTextBox);
			panel2.Controls.Add(reportWithdrawBtn);
			panel2.Controls.Add(withdrawPrintButton);
			panel2.Controls.Add(customerWithdrawButton);
			panel2.Dock = System.Windows.Forms.DockStyle.Left;
			panel2.Location = new System.Drawing.Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(674, 716);
			panel2.TabIndex = 10;
			// 
			// customerWithdrawBalanceTextBox
			// 
			customerWithdrawBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerWithdrawBalanceTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawBalanceTextBox.Location = new System.Drawing.Point(259, 315);
			customerWithdrawBalanceTextBox.Name = "customerWithdrawBalanceTextBox";
			customerWithdrawBalanceTextBox.ReadOnly = true;
			customerWithdrawBalanceTextBox.Size = new System.Drawing.Size(386, 31);
			customerWithdrawBalanceTextBox.TabIndex = 17;
			// 
			// customerWithdrawBalanceLabel
			// 
			customerWithdrawBalanceLabel.AutoSize = true;
			customerWithdrawBalanceLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawBalanceLabel.Location = new System.Drawing.Point(23, 317);
			customerWithdrawBalanceLabel.Name = "customerWithdrawBalanceLabel";
			customerWithdrawBalanceLabel.Size = new System.Drawing.Size(82, 23);
			customerWithdrawBalanceLabel.TabIndex = 18;
			customerWithdrawBalanceLabel.Text = "Balance:";
			// 
			// customerWithdrawAmountNumeric
			// 
			customerWithdrawAmountNumeric.DecimalPlaces = 2;
			customerWithdrawAmountNumeric.Enabled = false;
			customerWithdrawAmountNumeric.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawAmountNumeric.Location = new System.Drawing.Point(259, 380);
			customerWithdrawAmountNumeric.Margin = new System.Windows.Forms.Padding(5);
			customerWithdrawAmountNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
			customerWithdrawAmountNumeric.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
			customerWithdrawAmountNumeric.Name = "customerWithdrawAmountNumeric";
			customerWithdrawAmountNumeric.Size = new System.Drawing.Size(386, 31);
			customerWithdrawAmountNumeric.TabIndex = 19;
			// 
			// customerWithdrawIdTextBox
			// 
			customerWithdrawIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerWithdrawIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawIdTextBox.Location = new System.Drawing.Point(259, 117);
			customerWithdrawIdTextBox.MaxLength = 0;
			customerWithdrawIdTextBox.Name = "customerWithdrawIdTextBox";
			customerWithdrawIdTextBox.Size = new System.Drawing.Size(386, 31);
			customerWithdrawIdTextBox.TabIndex = 25;
			// 
			// customerWithdrawContentLabel
			// 
			customerWithdrawContentLabel.AutoSize = true;
			customerWithdrawContentLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawContentLabel.Location = new System.Drawing.Point(23, 483);
			customerWithdrawContentLabel.Name = "customerWithdrawContentLabel";
			customerWithdrawContentLabel.Size = new System.Drawing.Size(83, 23);
			customerWithdrawContentLabel.TabIndex = 21;
			customerWithdrawContentLabel.Text = "Content:";
			// 
			// customerWithdrawAmountLabel
			// 
			customerWithdrawAmountLabel.AutoSize = true;
			customerWithdrawAmountLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawAmountLabel.Location = new System.Drawing.Point(23, 382);
			customerWithdrawAmountLabel.Name = "customerWithdrawAmountLabel";
			customerWithdrawAmountLabel.Size = new System.Drawing.Size(172, 23);
			customerWithdrawAmountLabel.TabIndex = 20;
			customerWithdrawAmountLabel.Text = "Withdraw amount:";
			// 
			// customerWithdrawCicNumberTextBox
			// 
			customerWithdrawCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerWithdrawCicNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawCicNumberTextBox.Location = new System.Drawing.Point(259, 249);
			customerWithdrawCicNumberTextBox.Name = "customerWithdrawCicNumberTextBox";
			customerWithdrawCicNumberTextBox.ReadOnly = true;
			customerWithdrawCicNumberTextBox.Size = new System.Drawing.Size(386, 31);
			customerWithdrawCicNumberTextBox.TabIndex = 15;
			// 
			// customerWithdrawCicNumberLabel
			// 
			customerWithdrawCicNumberLabel.AutoSize = true;
			customerWithdrawCicNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawCicNumberLabel.Location = new System.Drawing.Point(23, 251);
			customerWithdrawCicNumberLabel.Name = "customerWithdrawCicNumberLabel";
			customerWithdrawCicNumberLabel.Size = new System.Drawing.Size(118, 23);
			customerWithdrawCicNumberLabel.TabIndex = 16;
			customerWithdrawCicNumberLabel.Text = "CIC Number:";
			// 
			// customerWithdrawNameTextBox
			// 
			customerWithdrawNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerWithdrawNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawNameTextBox.Location = new System.Drawing.Point(259, 183);
			customerWithdrawNameTextBox.Name = "customerWithdrawNameTextBox";
			customerWithdrawNameTextBox.ReadOnly = true;
			customerWithdrawNameTextBox.Size = new System.Drawing.Size(386, 31);
			customerWithdrawNameTextBox.TabIndex = 13;
			// 
			// customerWithdrawNameLabel
			// 
			customerWithdrawNameLabel.AutoSize = true;
			customerWithdrawNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawNameLabel.Location = new System.Drawing.Point(23, 185);
			customerWithdrawNameLabel.Name = "customerWithdrawNameLabel";
			customerWithdrawNameLabel.Size = new System.Drawing.Size(66, 23);
			customerWithdrawNameLabel.TabIndex = 14;
			customerWithdrawNameLabel.Text = "Name:";
			// 
			// customerWithdrawIdLabel
			// 
			customerWithdrawIdLabel.AutoSize = true;
			customerWithdrawIdLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawIdLabel.Location = new System.Drawing.Point(23, 119);
			customerWithdrawIdLabel.Name = "customerWithdrawIdLabel";
			customerWithdrawIdLabel.Size = new System.Drawing.Size(122, 23);
			customerWithdrawIdLabel.TabIndex = 12;
			customerWithdrawIdLabel.Text = "Customer ID:";
			// 
			// amountWithdrawingErrorLabel
			// 
			amountWithdrawingErrorLabel.AutoSize = true;
			amountWithdrawingErrorLabel.Font = new System.Drawing.Font("Cambria", 12F);
			amountWithdrawingErrorLabel.ForeColor = System.Drawing.Color.Red;
			amountWithdrawingErrorLabel.Location = new System.Drawing.Point(259, 416);
			amountWithdrawingErrorLabel.Name = "amountWithdrawingErrorLabel";
			amountWithdrawingErrorLabel.Size = new System.Drawing.Size(386, 23);
			amountWithdrawingErrorLabel.TabIndex = 22;
			amountWithdrawingErrorLabel.Text = "The minimum amount to withdraw is $ 0.00";
			amountWithdrawingErrorLabel.Visible = false;
			// 
			// customerWithdrawContentTextBox
			// 
			customerWithdrawContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerWithdrawContentTextBox.Enabled = false;
			customerWithdrawContentTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawContentTextBox.Location = new System.Drawing.Point(259, 481);
			customerWithdrawContentTextBox.Name = "customerWithdrawContentTextBox";
			customerWithdrawContentTextBox.Size = new System.Drawing.Size(386, 31);
			customerWithdrawContentTextBox.TabIndex = 23;
			// 
			// reportWithdrawBtn
			// 
			reportWithdrawBtn.AutoSize = true;
			reportWithdrawBtn.Font = new System.Drawing.Font("Cambria", 12F);
			reportWithdrawBtn.Location = new System.Drawing.Point(259, 570);
			reportWithdrawBtn.Margin = new System.Windows.Forms.Padding(2);
			reportWithdrawBtn.Name = "reportWithdrawBtn";
			reportWithdrawBtn.Size = new System.Drawing.Size(90, 36);
			reportWithdrawBtn.TabIndex = 27;
			reportWithdrawBtn.Text = "Report";
			reportWithdrawBtn.UseVisualStyleBackColor = true;
			// 
			// withdrawPrintButton
			// 
			withdrawPrintButton.AutoSize = true;
			withdrawPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			withdrawPrintButton.Enabled = false;
			withdrawPrintButton.Font = new System.Drawing.Font("Cambria", 12F);
			withdrawPrintButton.Location = new System.Drawing.Point(400, 575);
			withdrawPrintButton.Name = "withdrawPrintButton";
			withdrawPrintButton.Size = new System.Drawing.Size(63, 33);
			withdrawPrintButton.TabIndex = 26;
			withdrawPrintButton.Text = "Print";
			withdrawPrintButton.UseVisualStyleBackColor = true;
			// 
			// customerWithdrawButton
			// 
			customerWithdrawButton.AutoSize = true;
			customerWithdrawButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			customerWithdrawButton.Enabled = false;
			customerWithdrawButton.Font = new System.Drawing.Font("Cambria", 12F);
			customerWithdrawButton.Location = new System.Drawing.Point(510, 572);
			customerWithdrawButton.Name = "customerWithdrawButton";
			customerWithdrawButton.Size = new System.Drawing.Size(106, 33);
			customerWithdrawButton.TabIndex = 24;
			customerWithdrawButton.Text = "Withdraw";
			customerWithdrawButton.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel3.Controls.Add(customerDepositAmountNumeric);
			panel3.Controls.Add(customerDepositIdTextBox);
			panel3.Controls.Add(customerDepositContentTextBox);
			panel3.Controls.Add(customerDepositContentLabel);
			panel3.Controls.Add(customerDepositAmountLabel);
			panel3.Controls.Add(customerDepositCicNumberTextBox);
			panel3.Controls.Add(customerDepositCicNumberLabel);
			panel3.Controls.Add(customerDepositNameTextBox);
			panel3.Controls.Add(customerDepositNameLabel);
			panel3.Controls.Add(customerDepositIdLabel);
			panel3.Controls.Add(reportDepositBtn);
			panel3.Controls.Add(customerPrintButton);
			panel3.Controls.Add(customerDepositButton);
			panel3.Dock = System.Windows.Forms.DockStyle.Left;
			panel3.Location = new System.Drawing.Point(2, 2);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(674, 712);
			panel3.TabIndex = 9;
			// 
			// customerDepositAmountNumeric
			// 
			customerDepositAmountNumeric.DecimalPlaces = 2;
			customerDepositAmountNumeric.Enabled = false;
			customerDepositAmountNumeric.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositAmountNumeric.Location = new System.Drawing.Point(259, 315);
			customerDepositAmountNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
			customerDepositAmountNumeric.Name = "customerDepositAmountNumeric";
			customerDepositAmountNumeric.Size = new System.Drawing.Size(386, 31);
			customerDepositAmountNumeric.TabIndex = 18;
			// 
			// customerDepositIdTextBox
			// 
			customerDepositIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerDepositIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositIdTextBox.Location = new System.Drawing.Point(259, 117);
			customerDepositIdTextBox.MaxLength = 10;
			customerDepositIdTextBox.Name = "customerDepositIdTextBox";
			customerDepositIdTextBox.Size = new System.Drawing.Size(386, 31);
			customerDepositIdTextBox.TabIndex = 7;
			// 
			// customerDepositContentTextBox
			// 
			customerDepositContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerDepositContentTextBox.Enabled = false;
			customerDepositContentTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositContentTextBox.Location = new System.Drawing.Point(259, 381);
			customerDepositContentTextBox.Name = "customerDepositContentTextBox";
			customerDepositContentTextBox.Size = new System.Drawing.Size(386, 31);
			customerDepositContentTextBox.TabIndex = 14;
			// 
			// customerDepositContentLabel
			// 
			customerDepositContentLabel.AutoSize = true;
			customerDepositContentLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositContentLabel.Location = new System.Drawing.Point(29, 383);
			customerDepositContentLabel.Name = "customerDepositContentLabel";
			customerDepositContentLabel.Size = new System.Drawing.Size(83, 23);
			customerDepositContentLabel.TabIndex = 15;
			customerDepositContentLabel.Text = "Content:";
			// 
			// customerDepositAmountLabel
			// 
			customerDepositAmountLabel.AutoSize = true;
			customerDepositAmountLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositAmountLabel.Location = new System.Drawing.Point(29, 317);
			customerDepositAmountLabel.Name = "customerDepositAmountLabel";
			customerDepositAmountLabel.Size = new System.Drawing.Size(153, 23);
			customerDepositAmountLabel.TabIndex = 13;
			customerDepositAmountLabel.Text = "Deposit amount:";
			// 
			// customerDepositCicNumberTextBox
			// 
			customerDepositCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerDepositCicNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositCicNumberTextBox.Location = new System.Drawing.Point(259, 246);
			customerDepositCicNumberTextBox.Name = "customerDepositCicNumberTextBox";
			customerDepositCicNumberTextBox.ReadOnly = true;
			customerDepositCicNumberTextBox.Size = new System.Drawing.Size(386, 31);
			customerDepositCicNumberTextBox.TabIndex = 11;
			// 
			// customerDepositCicNumberLabel
			// 
			customerDepositCicNumberLabel.AutoSize = true;
			customerDepositCicNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositCicNumberLabel.Location = new System.Drawing.Point(29, 248);
			customerDepositCicNumberLabel.Name = "customerDepositCicNumberLabel";
			customerDepositCicNumberLabel.Size = new System.Drawing.Size(118, 23);
			customerDepositCicNumberLabel.TabIndex = 12;
			customerDepositCicNumberLabel.Text = "CIC Number:";
			// 
			// customerDepositNameTextBox
			// 
			customerDepositNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			customerDepositNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositNameTextBox.Location = new System.Drawing.Point(259, 183);
			customerDepositNameTextBox.Name = "customerDepositNameTextBox";
			customerDepositNameTextBox.ReadOnly = true;
			customerDepositNameTextBox.Size = new System.Drawing.Size(386, 31);
			customerDepositNameTextBox.TabIndex = 9;
			// 
			// customerDepositNameLabel
			// 
			customerDepositNameLabel.AutoSize = true;
			customerDepositNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositNameLabel.Location = new System.Drawing.Point(29, 185);
			customerDepositNameLabel.Name = "customerDepositNameLabel";
			customerDepositNameLabel.Size = new System.Drawing.Size(66, 23);
			customerDepositNameLabel.TabIndex = 10;
			customerDepositNameLabel.Text = "Name:";
			// 
			// customerDepositIdLabel
			// 
			customerDepositIdLabel.AutoSize = true;
			customerDepositIdLabel.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositIdLabel.Location = new System.Drawing.Point(29, 119);
			customerDepositIdLabel.Name = "customerDepositIdLabel";
			customerDepositIdLabel.Size = new System.Drawing.Size(122, 23);
			customerDepositIdLabel.TabIndex = 8;
			customerDepositIdLabel.Text = "Customer ID:";
			// 
			// reportDepositBtn
			// 
			reportDepositBtn.AutoSize = true;
			reportDepositBtn.Font = new System.Drawing.Font("Cambria", 12F);
			reportDepositBtn.Location = new System.Drawing.Point(259, 476);
			reportDepositBtn.Margin = new System.Windows.Forms.Padding(2);
			reportDepositBtn.Name = "reportDepositBtn";
			reportDepositBtn.Size = new System.Drawing.Size(90, 36);
			reportDepositBtn.TabIndex = 19;
			reportDepositBtn.Text = "Report";
			reportDepositBtn.UseVisualStyleBackColor = true;
			// 
			// customerPrintButton
			// 
			customerPrintButton.AutoSize = true;
			customerPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			customerPrintButton.Enabled = false;
			customerPrintButton.Font = new System.Drawing.Font("Cambria", 12F);
			customerPrintButton.Location = new System.Drawing.Point(416, 479);
			customerPrintButton.Name = "customerPrintButton";
			customerPrintButton.Size = new System.Drawing.Size(63, 33);
			customerPrintButton.TabIndex = 16;
			customerPrintButton.Text = "Print";
			customerPrintButton.UseVisualStyleBackColor = true;
			// 
			// customerDepositButton
			// 
			customerDepositButton.AutoSize = true;
			customerDepositButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			customerDepositButton.Enabled = false;
			customerDepositButton.Font = new System.Drawing.Font("Cambria", 12F);
			customerDepositButton.Location = new System.Drawing.Point(558, 479);
			customerDepositButton.Name = "customerDepositButton";
			customerDepositButton.Size = new System.Drawing.Size(87, 33);
			customerDepositButton.TabIndex = 17;
			customerDepositButton.Text = "Deposit";
			customerDepositButton.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			groupBox8.Controls.Add(customerIdTextBox);
			groupBox8.Controls.Add(customerBalanceTextBox);
			groupBox8.Controls.Add(label10);
			groupBox8.Controls.Add(label1);
			groupBox8.Controls.Add(customerUsernameTextBox);
			groupBox8.Controls.Add(label7);
			groupBox8.Location = new System.Drawing.Point(793, 0);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new System.Drawing.Size(461, 281);
			groupBox8.TabIndex = 5;
			groupBox8.TabStop = false;
			groupBox8.Text = "Account";
			// 
			// StaffMenuForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1262, 755);
			Controls.Add(tabControlStaffMenu);
			Margin = new System.Windows.Forms.Padding(2);
			Name = "StaffMenuForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Staff";
			FormClosing += StaffMenuForm_FormClosing;
			Load += StaffMenuForm_Load;
			tabControlStaffMenu.ResumeLayout(false);
			tabPageInformation.ResumeLayout(false);
			tabPageInformation.PerformLayout();
			tabPageDeposit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).EndInit();
			tabPageWithdraw.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewWithdraw).EndInit();
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
			tabPageFinancialReport.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox11.ResumeLayout(false);
			groupBox11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewDailyReport).EndInit();
			tabPageChangeRegulations.ResumeLayout(false);
			tabPageChangeRegulations.PerformLayout();
			groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)data_rate).EndInit();
			groupBox10.ResumeLayout(false);
			groupBox10.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).EndInit();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TabControl tabControlStaffMenu;
        private System.Windows.Forms.TabPage tabPageInformation;
        private System.Windows.Forms.TabPage tabPageDeposit;
        private System.Windows.Forms.TabPage tabPageWithdraw;
        private System.Windows.Forms.TabPage tabPageManageStaffs;
        private System.Windows.Forms.TabPage tabPageChangeRegulations;
        private System.Windows.Forms.TabPage tabPageManageCustomers;
        private System.Windows.Forms.TextBox customerDepositAmountTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.DataGridView dataGridViewWithdraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageFinancialReport;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.RadioButton rbMonthly;
		private System.Windows.Forms.RadioButton rbDaily;
		private System.Windows.Forms.Button dailyReportBtn;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.DateTimePicker dailyReportDateTimePicker;
		private System.Windows.Forms.DataGridView dataGridViewDailyReport;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox customerWithdrawBalanceTextBox;
		private System.Windows.Forms.NumericUpDown customerWithdrawAmountNumeric;
		private System.Windows.Forms.TextBox customerWithdrawIdTextBox;
		private System.Windows.Forms.TextBox customerWithdrawCicNumberTextBox;
		private System.Windows.Forms.TextBox customerWithdrawNameTextBox;
		private System.Windows.Forms.Label amountWithdrawingErrorLabel;
		private System.Windows.Forms.TextBox customerWithdrawContentTextBox;
		private System.Windows.Forms.Button reportWithdrawBtn;
		private System.Windows.Forms.Button withdrawPrintButton;
		private System.Windows.Forms.Button customerWithdrawButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.NumericUpDown customerDepositAmountNumeric;
		private System.Windows.Forms.TextBox customerDepositIdTextBox;
		private System.Windows.Forms.TextBox customerDepositContentTextBox;
		private System.Windows.Forms.Label customerDepositContentLabel;
		private System.Windows.Forms.Label customerDepositAmountLabel;
		private System.Windows.Forms.TextBox customerDepositCicNumberTextBox;
		private System.Windows.Forms.Label customerDepositCicNumberLabel;
		private System.Windows.Forms.TextBox customerDepositNameTextBox;
		private System.Windows.Forms.Label customerDepositNameLabel;
		private System.Windows.Forms.Label customerDepositIdLabel;
		private System.Windows.Forms.Button reportDepositBtn;
		private System.Windows.Forms.Button customerPrintButton;
		private System.Windows.Forms.Button customerDepositButton;
		private System.Windows.Forms.GroupBox groupBox8;
	}
}