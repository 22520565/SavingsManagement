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
            System.Windows.Forms.Label customerWithdrawBalanceLabel;
            System.Windows.Forms.Label customerWithdrawContentLabel;
            System.Windows.Forms.Label customerWithdrawAmountLabel;
            System.Windows.Forms.Label customerWithdrawCicNumberLabel;
            System.Windows.Forms.Label customerWithdrawNameLabel;
            System.Windows.Forms.Label customerWithdrawIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControlStaffMenu = new System.Windows.Forms.TabControl();
            tabPageInformation = new System.Windows.Forms.TabPage();
            gbFunction = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            staffChangePasswordButton = new System.Windows.Forms.Button();
            gbAccount = new System.Windows.Forms.GroupBox();
            staffIdtxt = new System.Windows.Forms.TextBox();
            customerIdLabel = new System.Windows.Forms.Label();
            staffusernametxt = new System.Windows.Forms.TextBox();
            customerUsernameLabel = new System.Windows.Forms.Label();
            gbPersonal = new System.Windows.Forms.GroupBox();
            label28 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            staffAddressTxt = new System.Windows.Forms.TextBox();
            staffBirthdayTxt = new System.Windows.Forms.TextBox();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            staffpositiontxt = new System.Windows.Forms.TextBox();
            label26 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            staffPhoneTxt = new System.Windows.Forms.TextBox();
            staffEmailTxt = new System.Windows.Forms.TextBox();
            staffnametxt = new System.Windows.Forms.TextBox();
            customerNameLabel = new System.Windows.Forms.Label();
            staffgendertxt = new System.Windows.Forms.TextBox();
            customerGenderLabel = new System.Windows.Forms.Label();
            tabPageDeposit = new System.Windows.Forms.TabPage();
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
            dataGridViewDeposit = new System.Windows.Forms.DataGridView();
            tabPageWithdraw = new System.Windows.Forms.TabPage();
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
            dataGridViewWithdraw = new System.Windows.Forms.DataGridView();
            tabPageManageCustomers = new System.Windows.Forms.TabPage();
            groupBox8 = new System.Windows.Forms.GroupBox();
            customerIdTextBox = new System.Windows.Forms.TextBox();
            customerBalanceTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            customerUsernameTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
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
            customerDisableCheckBox = new System.Windows.Forms.CheckBox();
            customerBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            customerMaleCheckBox = new System.Windows.Forms.CheckBox();
            customerEmailTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            customerAddressTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            customerCicNumberTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            customerNameTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tabPageManageStaffs = new System.Windows.Forms.TabPage();
            groupBox10 = new System.Windows.Forms.GroupBox();
            label15 = new System.Windows.Forms.Label();
            staffIdTextBox = new System.Windows.Forms.TextBox();
            staffPermissionIdComboBox = new System.Windows.Forms.ComboBox();
            staffDisableCheckBox = new System.Windows.Forms.CheckBox();
            label11 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            staffUsernameTextBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
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
            staffBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label20 = new System.Windows.Forms.Label();
            staffEmailTextBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            staffPhoneTextBox = new System.Windows.Forms.TextBox();
            staffPositionTextBox = new System.Windows.Forms.TextBox();
            label23 = new System.Windows.Forms.Label();
            staffAddressTextBox = new System.Windows.Forms.TextBox();
            label24 = new System.Windows.Forms.Label();
            staffMaleCheckBox = new System.Windows.Forms.CheckBox();
            staffNameTextBox = new System.Windows.Forms.TextBox();
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
            customerWithdrawBalanceLabel = new System.Windows.Forms.Label();
            customerWithdrawContentLabel = new System.Windows.Forms.Label();
            customerWithdrawAmountLabel = new System.Windows.Forms.Label();
            customerWithdrawCicNumberLabel = new System.Windows.Forms.Label();
            customerWithdrawNameLabel = new System.Windows.Forms.Label();
            customerWithdrawIdLabel = new System.Windows.Forms.Label();
            tabControlStaffMenu.SuspendLayout();
            tabPageInformation.SuspendLayout();
            gbFunction.SuspendLayout();
            gbAccount.SuspendLayout();
            gbPersonal.SuspendLayout();
            tabPageDeposit.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).BeginInit();
            tabPageWithdraw.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWithdraw).BeginInit();
            tabPageManageCustomers.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageManageStaffs.SuspendLayout();
            groupBox10.SuspendLayout();
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
            SuspendLayout();
            // 
            // customerWithdrawBalanceLabel
            // 
            customerWithdrawBalanceLabel.AutoSize = true;
            customerWithdrawBalanceLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawBalanceLabel.Location = new System.Drawing.Point(29, 400);
            customerWithdrawBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawBalanceLabel.Name = "customerWithdrawBalanceLabel";
            customerWithdrawBalanceLabel.Size = new System.Drawing.Size(100, 28);
            customerWithdrawBalanceLabel.TabIndex = 18;
            customerWithdrawBalanceLabel.Text = "Balance:";
            // 
            // customerWithdrawContentLabel
            // 
            customerWithdrawContentLabel.AutoSize = true;
            customerWithdrawContentLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawContentLabel.Location = new System.Drawing.Point(29, 624);
            customerWithdrawContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawContentLabel.Name = "customerWithdrawContentLabel";
            customerWithdrawContentLabel.Size = new System.Drawing.Size(99, 28);
            customerWithdrawContentLabel.TabIndex = 21;
            customerWithdrawContentLabel.Text = "Content:";
            // 
            // customerWithdrawAmountLabel
            // 
            customerWithdrawAmountLabel.AutoSize = true;
            customerWithdrawAmountLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawAmountLabel.Location = new System.Drawing.Point(29, 496);
            customerWithdrawAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawAmountLabel.Name = "customerWithdrawAmountLabel";
            customerWithdrawAmountLabel.Size = new System.Drawing.Size(206, 28);
            customerWithdrawAmountLabel.TabIndex = 20;
            customerWithdrawAmountLabel.Text = "Withdraw amount:";
            // 
            // customerWithdrawCicNumberLabel
            // 
            customerWithdrawCicNumberLabel.AutoSize = true;
            customerWithdrawCicNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawCicNumberLabel.Location = new System.Drawing.Point(29, 304);
            customerWithdrawCicNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawCicNumberLabel.Name = "customerWithdrawCicNumberLabel";
            customerWithdrawCicNumberLabel.Size = new System.Drawing.Size(143, 28);
            customerWithdrawCicNumberLabel.TabIndex = 16;
            customerWithdrawCicNumberLabel.Text = "CIC Number:";
            // 
            // customerWithdrawNameLabel
            // 
            customerWithdrawNameLabel.AutoSize = true;
            customerWithdrawNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawNameLabel.Location = new System.Drawing.Point(29, 208);
            customerWithdrawNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawNameLabel.Name = "customerWithdrawNameLabel";
            customerWithdrawNameLabel.Size = new System.Drawing.Size(78, 28);
            customerWithdrawNameLabel.TabIndex = 14;
            customerWithdrawNameLabel.Text = "Name:";
            // 
            // customerWithdrawIdLabel
            // 
            customerWithdrawIdLabel.AutoSize = true;
            customerWithdrawIdLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawIdLabel.Location = new System.Drawing.Point(29, 111);
            customerWithdrawIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawIdLabel.Name = "customerWithdrawIdLabel";
            customerWithdrawIdLabel.Size = new System.Drawing.Size(147, 28);
            customerWithdrawIdLabel.TabIndex = 12;
            customerWithdrawIdLabel.Text = "Customer ID:";
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
            tabControlStaffMenu.Size = new System.Drawing.Size(1578, 944);
            tabControlStaffMenu.TabIndex = 0;
            tabControlStaffMenu.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageInformation
            // 
            tabPageInformation.Controls.Add(gbFunction);
            tabPageInformation.Controls.Add(gbAccount);
            tabPageInformation.Controls.Add(gbPersonal);
            tabPageInformation.Location = new System.Drawing.Point(4, 40);
            tabPageInformation.Margin = new System.Windows.Forms.Padding(2);
            tabPageInformation.Name = "tabPageInformation";
            tabPageInformation.Padding = new System.Windows.Forms.Padding(2);
            tabPageInformation.Size = new System.Drawing.Size(1570, 900);
            tabPageInformation.TabIndex = 0;
            tabPageInformation.Text = "Information";
            tabPageInformation.UseVisualStyleBackColor = true;
            // 
            // gbFunction
            // 
            gbFunction.Controls.Add(button1);
            gbFunction.Controls.Add(staffChangePasswordButton);
            gbFunction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gbFunction.Location = new System.Drawing.Point(856, 475);
            gbFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbFunction.Name = "gbFunction";
            gbFunction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbFunction.Size = new System.Drawing.Size(672, 358);
            gbFunction.TabIndex = 36;
            gbFunction.TabStop = false;
            gbFunction.Text = "Function";
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(199, 79);
            button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            button1.Size = new System.Drawing.Size(319, 82);
            button1.TabIndex = 33;
            button1.Text = "Change Infomation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // staffChangePasswordButton
            // 
            staffChangePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            staffChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            staffChangePasswordButton.ForeColor = System.Drawing.Color.White;
            staffChangePasswordButton.Location = new System.Drawing.Point(199, 201);
            staffChangePasswordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffChangePasswordButton.Name = "staffChangePasswordButton";
            staffChangePasswordButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffChangePasswordButton.Size = new System.Drawing.Size(319, 82);
            staffChangePasswordButton.TabIndex = 32;
            staffChangePasswordButton.Text = "Change Password";
            staffChangePasswordButton.UseVisualStyleBackColor = true;
            staffChangePasswordButton.Click += staffChangePasswordButton_Click;
            // 
            // gbAccount
            // 
            gbAccount.Controls.Add(staffIdtxt);
            gbAccount.Controls.Add(customerIdLabel);
            gbAccount.Controls.Add(staffusernametxt);
            gbAccount.Controls.Add(customerUsernameLabel);
            gbAccount.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gbAccount.Location = new System.Drawing.Point(856, 52);
            gbAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbAccount.Name = "gbAccount";
            gbAccount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbAccount.Size = new System.Drawing.Size(672, 345);
            gbAccount.TabIndex = 35;
            gbAccount.TabStop = false;
            gbAccount.Text = "Account";
            // 
            // staffIdtxt
            // 
            staffIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffIdtxt.Location = new System.Drawing.Point(212, 125);
            staffIdtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffIdtxt.Name = "staffIdtxt";
            staffIdtxt.ReadOnly = true;
            staffIdtxt.Size = new System.Drawing.Size(420, 40);
            staffIdtxt.TabIndex = 22;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(38, 125);
            customerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(50, 33);
            customerIdLabel.TabIndex = 23;
            customerIdLabel.Text = "ID:";
            // 
            // staffusernametxt
            // 
            staffusernametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffusernametxt.Location = new System.Drawing.Point(212, 218);
            staffusernametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffusernametxt.Name = "staffusernametxt";
            staffusernametxt.ReadOnly = true;
            staffusernametxt.Size = new System.Drawing.Size(420, 40);
            staffusernametxt.TabIndex = 30;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(38, 220);
            customerUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(145, 33);
            customerUsernameLabel.TabIndex = 31;
            customerUsernameLabel.Text = "Username:";
            // 
            // gbPersonal
            // 
            gbPersonal.Controls.Add(label28);
            gbPersonal.Controls.Add(label27);
            gbPersonal.Controls.Add(staffAddressTxt);
            gbPersonal.Controls.Add(staffBirthdayTxt);
            gbPersonal.Controls.Add(customerPhoneNumberLabel);
            gbPersonal.Controls.Add(staffpositiontxt);
            gbPersonal.Controls.Add(label26);
            gbPersonal.Controls.Add(label25);
            gbPersonal.Controls.Add(staffPhoneTxt);
            gbPersonal.Controls.Add(staffEmailTxt);
            gbPersonal.Controls.Add(staffnametxt);
            gbPersonal.Controls.Add(customerNameLabel);
            gbPersonal.Controls.Add(staffgendertxt);
            gbPersonal.Controls.Add(customerGenderLabel);
            gbPersonal.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gbPersonal.Location = new System.Drawing.Point(50, 52);
            gbPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbPersonal.Name = "gbPersonal";
            gbPersonal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbPersonal.Size = new System.Drawing.Size(779, 780);
            gbPersonal.TabIndex = 34;
            gbPersonal.TabStop = false;
            gbPersonal.Text = "Personal";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(120, 190);
            label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(126, 33);
            label28.TabIndex = 36;
            label28.Text = "Birthday:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(120, 590);
            label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(121, 33);
            label27.TabIndex = 34;
            label27.Text = "Address:";
            // 
            // staffAddressTxt
            // 
            staffAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffAddressTxt.Location = new System.Drawing.Point(279, 588);
            staffAddressTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffAddressTxt.Name = "staffAddressTxt";
            staffAddressTxt.ReadOnly = true;
            staffAddressTxt.Size = new System.Drawing.Size(402, 40);
            staffAddressTxt.TabIndex = 35;
            // 
            // staffBirthdayTxt
            // 
            staffBirthdayTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffBirthdayTxt.Location = new System.Drawing.Point(279, 188);
            staffBirthdayTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffBirthdayTxt.Name = "staffBirthdayTxt";
            staffBirthdayTxt.ReadOnly = true;
            staffBirthdayTxt.Size = new System.Drawing.Size(402, 40);
            staffBirthdayTxt.TabIndex = 37;
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(120, 690);
            customerPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(120, 33);
            customerPhoneNumberLabel.TabIndex = 28;
            customerPhoneNumberLabel.Text = "Position:";
            // 
            // staffpositiontxt
            // 
            staffpositiontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffpositiontxt.Location = new System.Drawing.Point(279, 688);
            staffpositiontxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffpositiontxt.Name = "staffpositiontxt";
            staffpositiontxt.ReadOnly = true;
            staffpositiontxt.Size = new System.Drawing.Size(402, 40);
            staffpositiontxt.TabIndex = 29;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(120, 490);
            label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(91, 33);
            label26.TabIndex = 32;
            label26.Text = "Email:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(120, 290);
            label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(98, 33);
            label25.TabIndex = 30;
            label25.Text = "Phone:";
            // 
            // staffPhoneTxt
            // 
            staffPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffPhoneTxt.Location = new System.Drawing.Point(279, 288);
            staffPhoneTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffPhoneTxt.Name = "staffPhoneTxt";
            staffPhoneTxt.ReadOnly = true;
            staffPhoneTxt.Size = new System.Drawing.Size(402, 40);
            staffPhoneTxt.TabIndex = 31;
            // 
            // staffEmailTxt
            // 
            staffEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffEmailTxt.Location = new System.Drawing.Point(279, 488);
            staffEmailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffEmailTxt.Name = "staffEmailTxt";
            staffEmailTxt.ReadOnly = true;
            staffEmailTxt.Size = new System.Drawing.Size(402, 40);
            staffEmailTxt.TabIndex = 33;
            // 
            // staffnametxt
            // 
            staffnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffnametxt.Location = new System.Drawing.Point(279, 88);
            staffnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffnametxt.Name = "staffnametxt";
            staffnametxt.ReadOnly = true;
            staffnametxt.Size = new System.Drawing.Size(402, 40);
            staffnametxt.TabIndex = 24;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(120, 90);
            customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(92, 33);
            customerNameLabel.TabIndex = 25;
            customerNameLabel.Text = "Name:";
            // 
            // staffgendertxt
            // 
            staffgendertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffgendertxt.Location = new System.Drawing.Point(279, 388);
            staffgendertxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            staffgendertxt.Name = "staffgendertxt";
            staffgendertxt.ReadOnly = true;
            staffgendertxt.Size = new System.Drawing.Size(228, 40);
            staffgendertxt.TabIndex = 26;
            // 
            // customerGenderLabel
            // 
            customerGenderLabel.AutoSize = true;
            customerGenderLabel.Location = new System.Drawing.Point(120, 390);
            customerGenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerGenderLabel.Name = "customerGenderLabel";
            customerGenderLabel.Size = new System.Drawing.Size(111, 33);
            customerGenderLabel.TabIndex = 27;
            customerGenderLabel.Text = "Gender:";
            // 
            // tabPageDeposit
            // 
            tabPageDeposit.Controls.Add(panel3);
            tabPageDeposit.Controls.Add(dataGridViewDeposit);
            tabPageDeposit.Location = new System.Drawing.Point(4, 40);
            tabPageDeposit.Margin = new System.Windows.Forms.Padding(2);
            tabPageDeposit.Name = "tabPageDeposit";
            tabPageDeposit.Padding = new System.Windows.Forms.Padding(2);
            tabPageDeposit.Size = new System.Drawing.Size(1570, 900);
            tabPageDeposit.TabIndex = 1;
            tabPageDeposit.Text = "Deposit";
            tabPageDeposit.UseVisualStyleBackColor = true;
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
            panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(554, 896);
            panel3.TabIndex = 9;
            // 
            // customerDepositAmountNumeric
            // 
            customerDepositAmountNumeric.DecimalPlaces = 2;
            customerDepositAmountNumeric.Enabled = false;
            customerDepositAmountNumeric.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositAmountNumeric.Location = new System.Drawing.Point(29, 430);
            customerDepositAmountNumeric.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerDepositAmountNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            customerDepositAmountNumeric.Name = "customerDepositAmountNumeric";
            customerDepositAmountNumeric.Size = new System.Drawing.Size(482, 36);
            customerDepositAmountNumeric.TabIndex = 18;
            // 
            // customerDepositIdTextBox
            // 
            customerDepositIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositIdTextBox.Location = new System.Drawing.Point(29, 141);
            customerDepositIdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerDepositIdTextBox.MaxLength = 10;
            customerDepositIdTextBox.Name = "customerDepositIdTextBox";
            customerDepositIdTextBox.Size = new System.Drawing.Size(482, 36);
            customerDepositIdTextBox.TabIndex = 7;
            customerDepositIdTextBox.Enter += customerDepositIdTextBox_Enter;
            customerDepositIdTextBox.Leave += customerDepositIdTextBox_Leave;
            // 
            // customerDepositContentTextBox
            // 
            customerDepositContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositContentTextBox.Enabled = false;
            customerDepositContentTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositContentTextBox.Location = new System.Drawing.Point(29, 526);
            customerDepositContentTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerDepositContentTextBox.Name = "customerDepositContentTextBox";
            customerDepositContentTextBox.Size = new System.Drawing.Size(482, 36);
            customerDepositContentTextBox.TabIndex = 14;
            customerDepositContentTextBox.TextChanged += customerDepositContentTextBox_TextChanged;
            // 
            // customerDepositContentLabel
            // 
            customerDepositContentLabel.AutoSize = true;
            customerDepositContentLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositContentLabel.Location = new System.Drawing.Point(29, 491);
            customerDepositContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositContentLabel.Name = "customerDepositContentLabel";
            customerDepositContentLabel.Size = new System.Drawing.Size(99, 28);
            customerDepositContentLabel.TabIndex = 15;
            customerDepositContentLabel.Text = "Content:";
            // 
            // customerDepositAmountLabel
            // 
            customerDepositAmountLabel.AutoSize = true;
            customerDepositAmountLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositAmountLabel.Location = new System.Drawing.Point(29, 395);
            customerDepositAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositAmountLabel.Name = "customerDepositAmountLabel";
            customerDepositAmountLabel.Size = new System.Drawing.Size(181, 28);
            customerDepositAmountLabel.TabIndex = 13;
            customerDepositAmountLabel.Text = "Deposit amount:";
            // 
            // customerDepositCicNumberTextBox
            // 
            customerDepositCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositCicNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositCicNumberTextBox.Location = new System.Drawing.Point(29, 334);
            customerDepositCicNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerDepositCicNumberTextBox.Name = "customerDepositCicNumberTextBox";
            customerDepositCicNumberTextBox.ReadOnly = true;
            customerDepositCicNumberTextBox.Size = new System.Drawing.Size(482, 36);
            customerDepositCicNumberTextBox.TabIndex = 11;
            // 
            // customerDepositCicNumberLabel
            // 
            customerDepositCicNumberLabel.AutoSize = true;
            customerDepositCicNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositCicNumberLabel.Location = new System.Drawing.Point(29, 299);
            customerDepositCicNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositCicNumberLabel.Name = "customerDepositCicNumberLabel";
            customerDepositCicNumberLabel.Size = new System.Drawing.Size(143, 28);
            customerDepositCicNumberLabel.TabIndex = 12;
            customerDepositCicNumberLabel.Text = "CIC Number:";
            // 
            // customerDepositNameTextBox
            // 
            customerDepositNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositNameTextBox.Location = new System.Drawing.Point(29, 238);
            customerDepositNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerDepositNameTextBox.Name = "customerDepositNameTextBox";
            customerDepositNameTextBox.ReadOnly = true;
            customerDepositNameTextBox.Size = new System.Drawing.Size(482, 36);
            customerDepositNameTextBox.TabIndex = 9;
            // 
            // customerDepositNameLabel
            // 
            customerDepositNameLabel.AutoSize = true;
            customerDepositNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositNameLabel.Location = new System.Drawing.Point(29, 202);
            customerDepositNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositNameLabel.Name = "customerDepositNameLabel";
            customerDepositNameLabel.Size = new System.Drawing.Size(78, 28);
            customerDepositNameLabel.TabIndex = 10;
            customerDepositNameLabel.Text = "Name:";
            // 
            // customerDepositIdLabel
            // 
            customerDepositIdLabel.AutoSize = true;
            customerDepositIdLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositIdLabel.Location = new System.Drawing.Point(29, 106);
            customerDepositIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositIdLabel.Name = "customerDepositIdLabel";
            customerDepositIdLabel.Size = new System.Drawing.Size(147, 28);
            customerDepositIdLabel.TabIndex = 8;
            customerDepositIdLabel.Text = "Customer ID:";
            // 
            // reportDepositBtn
            // 
            reportDepositBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            reportDepositBtn.Font = new System.Drawing.Font("Cambria", 13.8F);
            reportDepositBtn.Location = new System.Drawing.Point(29, 651);
            reportDepositBtn.Margin = new System.Windows.Forms.Padding(2);
            reportDepositBtn.Name = "reportDepositBtn";
            reportDepositBtn.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            reportDepositBtn.Size = new System.Drawing.Size(125, 62);
            reportDepositBtn.TabIndex = 19;
            reportDepositBtn.Text = "Report";
            reportDepositBtn.UseVisualStyleBackColor = true;
            reportDepositBtn.Click += reportDepositBtn_Click;
            // 
            // customerPrintButton
            // 
            customerPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerPrintButton.Enabled = false;
            customerPrintButton.Font = new System.Drawing.Font("Cambria", 13.8F);
            customerPrintButton.Location = new System.Drawing.Point(198, 651);
            customerPrintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            customerPrintButton.Name = "customerPrintButton";
            customerPrintButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerPrintButton.Size = new System.Drawing.Size(125, 62);
            customerPrintButton.TabIndex = 16;
            customerPrintButton.Text = "Print";
            customerPrintButton.UseVisualStyleBackColor = true;
            customerPrintButton.Click += customerPrintButton_Click;
            // 
            // customerDepositButton
            // 
            customerDepositButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerDepositButton.Enabled = false;
            customerDepositButton.Font = new System.Drawing.Font("Cambria", 13.8F);
            customerDepositButton.Location = new System.Drawing.Point(370, 651);
            customerDepositButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            customerDepositButton.Name = "customerDepositButton";
            customerDepositButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerDepositButton.Size = new System.Drawing.Size(141, 62);
            customerDepositButton.TabIndex = 17;
            customerDepositButton.Text = "Deposit";
            customerDepositButton.UseVisualStyleBackColor = true;
            customerDepositButton.Click += customerDepositButton_Click;
            // 
            // dataGridViewDeposit
            // 
            dataGridViewDeposit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeposit.Dock = System.Windows.Forms.DockStyle.Right;
            dataGridViewDeposit.Location = new System.Drawing.Point(567, 2);
            dataGridViewDeposit.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewDeposit.Name = "dataGridViewDeposit";
            dataGridViewDeposit.RowHeadersWidth = 62;
            dataGridViewDeposit.Size = new System.Drawing.Size(1001, 896);
            dataGridViewDeposit.TabIndex = 8;
            dataGridViewDeposit.CellContentClick += dataGridViewDeposit_CellContentClick;
            // 
            // tabPageWithdraw
            // 
            tabPageWithdraw.Controls.Add(panel2);
            tabPageWithdraw.Controls.Add(dataGridViewWithdraw);
            tabPageWithdraw.Location = new System.Drawing.Point(4, 40);
            tabPageWithdraw.Margin = new System.Windows.Forms.Padding(2);
            tabPageWithdraw.Name = "tabPageWithdraw";
            tabPageWithdraw.Size = new System.Drawing.Size(1570, 900);
            tabPageWithdraw.TabIndex = 2;
            tabPageWithdraw.Text = "Withdraw";
            tabPageWithdraw.UseVisualStyleBackColor = true;
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
            panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(547, 900);
            panel2.TabIndex = 10;
            // 
            // customerWithdrawBalanceTextBox
            // 
            customerWithdrawBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawBalanceTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawBalanceTextBox.Location = new System.Drawing.Point(29, 435);
            customerWithdrawBalanceTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawBalanceTextBox.Name = "customerWithdrawBalanceTextBox";
            customerWithdrawBalanceTextBox.ReadOnly = true;
            customerWithdrawBalanceTextBox.Size = new System.Drawing.Size(482, 36);
            customerWithdrawBalanceTextBox.TabIndex = 17;
            // 
            // customerWithdrawAmountNumeric
            // 
            customerWithdrawAmountNumeric.DecimalPlaces = 2;
            customerWithdrawAmountNumeric.Enabled = false;
            customerWithdrawAmountNumeric.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawAmountNumeric.Location = new System.Drawing.Point(29, 531);
            customerWithdrawAmountNumeric.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawAmountNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            customerWithdrawAmountNumeric.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            customerWithdrawAmountNumeric.Name = "customerWithdrawAmountNumeric";
            customerWithdrawAmountNumeric.Size = new System.Drawing.Size(482, 36);
            customerWithdrawAmountNumeric.TabIndex = 19;
            // 
            // customerWithdrawIdTextBox
            // 
            customerWithdrawIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawIdTextBox.Location = new System.Drawing.Point(29, 146);
            customerWithdrawIdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawIdTextBox.MaxLength = 0;
            customerWithdrawIdTextBox.Name = "customerWithdrawIdTextBox";
            customerWithdrawIdTextBox.Size = new System.Drawing.Size(482, 36);
            customerWithdrawIdTextBox.TabIndex = 25;
            customerWithdrawIdTextBox.Enter += customerWithdrawIdTextBox_Enter;
            customerWithdrawIdTextBox.Leave += customerWithdrawIdTextBox_Leave;
            // 
            // customerWithdrawCicNumberTextBox
            // 
            customerWithdrawCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawCicNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawCicNumberTextBox.Location = new System.Drawing.Point(29, 339);
            customerWithdrawCicNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawCicNumberTextBox.Name = "customerWithdrawCicNumberTextBox";
            customerWithdrawCicNumberTextBox.ReadOnly = true;
            customerWithdrawCicNumberTextBox.Size = new System.Drawing.Size(482, 36);
            customerWithdrawCicNumberTextBox.TabIndex = 15;
            // 
            // customerWithdrawNameTextBox
            // 
            customerWithdrawNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawNameTextBox.Location = new System.Drawing.Point(29, 242);
            customerWithdrawNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawNameTextBox.Name = "customerWithdrawNameTextBox";
            customerWithdrawNameTextBox.ReadOnly = true;
            customerWithdrawNameTextBox.Size = new System.Drawing.Size(482, 36);
            customerWithdrawNameTextBox.TabIndex = 13;
            // 
            // amountWithdrawingErrorLabel
            // 
            amountWithdrawingErrorLabel.AutoSize = true;
            amountWithdrawingErrorLabel.Font = new System.Drawing.Font("Cambria", 12F);
            amountWithdrawingErrorLabel.ForeColor = System.Drawing.Color.Red;
            amountWithdrawingErrorLabel.Location = new System.Drawing.Point(29, 578);
            amountWithdrawingErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            amountWithdrawingErrorLabel.Name = "amountWithdrawingErrorLabel";
            amountWithdrawingErrorLabel.Size = new System.Drawing.Size(460, 28);
            amountWithdrawingErrorLabel.TabIndex = 22;
            amountWithdrawingErrorLabel.Text = "The minimum amount to withdraw is $ 0.00";
            amountWithdrawingErrorLabel.Visible = false;
            // 
            // customerWithdrawContentTextBox
            // 
            customerWithdrawContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawContentTextBox.Enabled = false;
            customerWithdrawContentTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawContentTextBox.Location = new System.Drawing.Point(29, 659);
            customerWithdrawContentTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawContentTextBox.Name = "customerWithdrawContentTextBox";
            customerWithdrawContentTextBox.Size = new System.Drawing.Size(482, 36);
            customerWithdrawContentTextBox.TabIndex = 23;
            customerWithdrawContentTextBox.TextChanged += customerWithdrawContentTextBox_TextChanged;
            // 
            // reportWithdrawBtn
            // 
            reportWithdrawBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            reportWithdrawBtn.Font = new System.Drawing.Font("Cambria", 12F);
            reportWithdrawBtn.Location = new System.Drawing.Point(31, 748);
            reportWithdrawBtn.Margin = new System.Windows.Forms.Padding(2);
            reportWithdrawBtn.Name = "reportWithdrawBtn";
            reportWithdrawBtn.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            reportWithdrawBtn.Size = new System.Drawing.Size(150, 62);
            reportWithdrawBtn.TabIndex = 27;
            reportWithdrawBtn.Text = "Report";
            reportWithdrawBtn.UseVisualStyleBackColor = true;
            reportWithdrawBtn.Click += reportWithdrawBtn_Click;
            // 
            // withdrawPrintButton
            // 
            withdrawPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            withdrawPrintButton.Enabled = false;
            withdrawPrintButton.Font = new System.Drawing.Font("Cambria", 12F);
            withdrawPrintButton.Location = new System.Drawing.Point(196, 748);
            withdrawPrintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            withdrawPrintButton.Name = "withdrawPrintButton";
            withdrawPrintButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            withdrawPrintButton.Size = new System.Drawing.Size(150, 62);
            withdrawPrintButton.TabIndex = 26;
            withdrawPrintButton.Text = "Print";
            withdrawPrintButton.UseVisualStyleBackColor = true;
            withdrawPrintButton.Click += withdrawPrintButton_Click;
            // 
            // customerWithdrawButton
            // 
            customerWithdrawButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerWithdrawButton.Enabled = false;
            customerWithdrawButton.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawButton.Location = new System.Drawing.Point(361, 748);
            customerWithdrawButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            customerWithdrawButton.Name = "customerWithdrawButton";
            customerWithdrawButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerWithdrawButton.Size = new System.Drawing.Size(150, 62);
            customerWithdrawButton.TabIndex = 24;
            customerWithdrawButton.Text = "Withdraw";
            customerWithdrawButton.UseVisualStyleBackColor = true;
            customerWithdrawButton.Click += customerWithdrawButton_Click;
            // 
            // dataGridViewWithdraw
            // 
            dataGridViewWithdraw.BackgroundColor = System.Drawing.Color.White;
            dataGridViewWithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWithdraw.Dock = System.Windows.Forms.DockStyle.Right;
            dataGridViewWithdraw.Location = new System.Drawing.Point(556, 0);
            dataGridViewWithdraw.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewWithdraw.Name = "dataGridViewWithdraw";
            dataGridViewWithdraw.RowHeadersWidth = 62;
            dataGridViewWithdraw.Size = new System.Drawing.Size(1014, 900);
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
            tabPageManageCustomers.Location = new System.Drawing.Point(4, 40);
            tabPageManageCustomers.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageCustomers.Name = "tabPageManageCustomers";
            tabPageManageCustomers.Size = new System.Drawing.Size(1570, 900);
            tabPageManageCustomers.TabIndex = 5;
            tabPageManageCustomers.Text = "Customer Management";
            tabPageManageCustomers.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(customerIdTextBox);
            groupBox8.Controls.Add(customerBalanceTextBox);
            groupBox8.Controls.Add(label10);
            groupBox8.Controls.Add(label1);
            groupBox8.Controls.Add(customerUsernameTextBox);
            groupBox8.Controls.Add(label7);
            groupBox8.Location = new System.Drawing.Point(991, 0);
            groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox8.Size = new System.Drawing.Size(576, 351);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Account";
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerIdTextBox.Location = new System.Drawing.Point(54, 114);
            customerIdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new System.Drawing.Size(158, 36);
            customerIdTextBox.TabIndex = 1;
            // 
            // customerBalanceTextBox
            // 
            customerBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerBalanceTextBox.Location = new System.Drawing.Point(284, 114);
            customerBalanceTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerBalanceTextBox.Name = "customerBalanceTextBox";
            customerBalanceTextBox.Size = new System.Drawing.Size(242, 36);
            customerBalanceTextBox.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(284, 79);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(105, 28);
            label10.TabIndex = 20;
            label10.Text = "Balance: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(54, 79);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 28);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // customerUsernameTextBox
            // 
            customerUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerUsernameTextBox.Location = new System.Drawing.Point(54, 222);
            customerUsernameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerUsernameTextBox.Name = "customerUsernameTextBox";
            customerUsernameTextBox.Size = new System.Drawing.Size(472, 36);
            customerUsernameTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(54, 188);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(128, 28);
            label7.TabIndex = 12;
            label7.Text = "Username: ";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new System.Drawing.Point(0, 564);
            dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new System.Drawing.Size(1568, 331);
            dataGridViewCustomer.TabIndex = 3;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(customerSearchTextBox);
            groupBox6.Location = new System.Drawing.Point(0, 466);
            groupBox6.Margin = new System.Windows.Forms.Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(2);
            groupBox6.Size = new System.Drawing.Size(1568, 98);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Search";
            // 
            // customerSearchTextBox
            // 
            customerSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerSearchTextBox.Location = new System.Drawing.Point(56, 40);
            customerSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new System.Drawing.Size(887, 36);
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
            groupBox2.Location = new System.Drawing.Point(0, 351);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(1568, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control button";
            // 
            // enableCustomerBtn
            // 
            enableCustomerBtn.AutoSize = true;
            enableCustomerBtn.Location = new System.Drawing.Point(570, 48);
            enableCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            enableCustomerBtn.Name = "enableCustomerBtn";
            enableCustomerBtn.Size = new System.Drawing.Size(128, 54);
            enableCustomerBtn.TabIndex = 4;
            enableCustomerBtn.Text = "Enable";
            enableCustomerBtn.UseVisualStyleBackColor = true;
            enableCustomerBtn.Click += enableCustomerBtn_Click;
            // 
            // clearScreenCustomerBtn
            // 
            clearScreenCustomerBtn.AutoSize = true;
            clearScreenCustomerBtn.Location = new System.Drawing.Point(734, 48);
            clearScreenCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            clearScreenCustomerBtn.Name = "clearScreenCustomerBtn";
            clearScreenCustomerBtn.Size = new System.Drawing.Size(209, 54);
            clearScreenCustomerBtn.TabIndex = 3;
            clearScreenCustomerBtn.Text = "Clear Screen";
            clearScreenCustomerBtn.UseVisualStyleBackColor = true;
            clearScreenCustomerBtn.Click += clearScreenCustomerBtn_Click;
            // 
            // disableCustomerBtn
            // 
            disableCustomerBtn.AutoSize = true;
            disableCustomerBtn.Location = new System.Drawing.Point(385, 48);
            disableCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            disableCustomerBtn.Name = "disableCustomerBtn";
            disableCustomerBtn.Size = new System.Drawing.Size(138, 54);
            disableCustomerBtn.TabIndex = 2;
            disableCustomerBtn.Text = "Disable";
            disableCustomerBtn.UseVisualStyleBackColor = true;
            disableCustomerBtn.Click += disableCustomerBtn_Click;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.AutoSize = true;
            saveCustomerBtn.Location = new System.Drawing.Point(218, 48);
            saveCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new System.Drawing.Size(112, 54);
            saveCustomerBtn.TabIndex = 1;
            saveCustomerBtn.Text = "Save";
            saveCustomerBtn.UseVisualStyleBackColor = true;
            saveCustomerBtn.Click += saveCustomerBtn_Click;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.AutoSize = true;
            addCustomerBtn.Location = new System.Drawing.Point(56, 48);
            addCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new System.Drawing.Size(112, 54);
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
            groupBox1.Size = new System.Drawing.Size(985, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // customerDisableCheckBox
            // 
            customerDisableCheckBox.AutoSize = true;
            customerDisableCheckBox.Location = new System.Drawing.Point(588, 365);
            customerDisableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            customerDisableCheckBox.Name = "customerDisableCheckBox";
            customerDisableCheckBox.Size = new System.Drawing.Size(115, 32);
            customerDisableCheckBox.TabIndex = 19;
            customerDisableCheckBox.Text = "Disable";
            customerDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerBirthDateTimePicker
            // 
            customerBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            customerBirthDateTimePicker.Location = new System.Drawing.Point(481, 79);
            customerBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerBirthDateTimePicker.Name = "customerBirthDateTimePicker";
            customerBirthDateTimePicker.Size = new System.Drawing.Size(303, 36);
            customerBirthDateTimePicker.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(481, 44);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(147, 28);
            label9.TabIndex = 17;
            label9.Text = "Date of birth:";
            // 
            // customerMaleCheckBox
            // 
            customerMaleCheckBox.AutoSize = true;
            customerMaleCheckBox.Location = new System.Drawing.Point(839, 80);
            customerMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            customerMaleCheckBox.Name = "customerMaleCheckBox";
            customerMaleCheckBox.Size = new System.Drawing.Size(89, 32);
            customerMaleCheckBox.TabIndex = 16;
            customerMaleCheckBox.Text = "Male";
            customerMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerEmailTextBox.Location = new System.Drawing.Point(45, 186);
            customerEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.Size = new System.Drawing.Size(368, 36);
            customerEmailTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(45, 151);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 28);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // customerPhoneNumberTextBox
            // 
            customerPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerPhoneNumberTextBox.Location = new System.Drawing.Point(481, 186);
            customerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            customerPhoneNumberTextBox.Size = new System.Drawing.Size(303, 36);
            customerPhoneNumberTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(481, 151);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(166, 28);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerAddressTextBox.Location = new System.Drawing.Point(45, 279);
            customerAddressTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new System.Drawing.Size(368, 36);
            customerAddressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(45, 244);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 28);
            label5.TabIndex = 8;
            label5.Text = "Address: ";
            // 
            // customerCicNumberTextBox
            // 
            customerCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerCicNumberTextBox.Location = new System.Drawing.Point(481, 279);
            customerCicNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerCicNumberTextBox.Name = "customerCicNumberTextBox";
            customerCicNumberTextBox.Size = new System.Drawing.Size(303, 36);
            customerCicNumberTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(481, 244);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(143, 28);
            label3.TabIndex = 4;
            label3.Text = "CIC Number:";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerNameTextBox.Location = new System.Drawing.Point(45, 79);
            customerNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new System.Drawing.Size(368, 36);
            customerNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 44);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 28);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // tabPageManageStaffs
            // 
            tabPageManageStaffs.Controls.Add(groupBox10);
            tabPageManageStaffs.Controls.Add(dataGridViewStaff);
            tabPageManageStaffs.Controls.Add(groupBox7);
            tabPageManageStaffs.Controls.Add(groupBox4);
            tabPageManageStaffs.Controls.Add(groupBox3);
            tabPageManageStaffs.Location = new System.Drawing.Point(4, 40);
            tabPageManageStaffs.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageStaffs.Name = "tabPageManageStaffs";
            tabPageManageStaffs.Size = new System.Drawing.Size(1570, 900);
            tabPageManageStaffs.TabIndex = 3;
            tabPageManageStaffs.Text = "Staff Management";
            tabPageManageStaffs.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(label15);
            groupBox10.Controls.Add(staffIdTextBox);
            groupBox10.Controls.Add(staffPermissionIdComboBox);
            groupBox10.Controls.Add(staffDisableCheckBox);
            groupBox10.Controls.Add(label11);
            groupBox10.Controls.Add(label16);
            groupBox10.Controls.Add(staffUsernameTextBox);
            groupBox10.Controls.Add(label14);
            groupBox10.Location = new System.Drawing.Point(965, 0);
            groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox10.Size = new System.Drawing.Size(596, 345);
            groupBox10.TabIndex = 4;
            groupBox10.TabStop = false;
            groupBox10.Text = "Account";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(311, 168);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(81, 28);
            label15.TabIndex = 15;
            label15.Text = "Status:";
            // 
            // staffIdTextBox
            // 
            staffIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffIdTextBox.Location = new System.Drawing.Point(35, 102);
            staffIdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffIdTextBox.Name = "staffIdTextBox";
            staffIdTextBox.Size = new System.Drawing.Size(214, 36);
            staffIdTextBox.TabIndex = 1;
            // 
            // staffPermissionIdComboBox
            // 
            staffPermissionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            staffPermissionIdComboBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffPermissionIdComboBox.FormattingEnabled = true;
            staffPermissionIdComboBox.Location = new System.Drawing.Point(35, 205);
            staffPermissionIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffPermissionIdComboBox.Name = "staffPermissionIdComboBox";
            staffPermissionIdComboBox.Size = new System.Drawing.Size(214, 36);
            staffPermissionIdComboBox.TabIndex = 11;
            // 
            // staffDisableCheckBox
            // 
            staffDisableCheckBox.AutoSize = true;
            staffDisableCheckBox.Location = new System.Drawing.Point(311, 208);
            staffDisableCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffDisableCheckBox.Name = "staffDisableCheckBox";
            staffDisableCheckBox.Size = new System.Drawing.Size(115, 32);
            staffDisableCheckBox.TabIndex = 13;
            staffDisableCheckBox.Text = "Disable";
            staffDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(35, 68);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(39, 28);
            label11.TabIndex = 0;
            label11.Text = "Id:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(35, 170);
            label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(134, 28);
            label16.TabIndex = 10;
            label16.Text = "Permission:";
            // 
            // staffUsernameTextBox
            // 
            staffUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffUsernameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffUsernameTextBox.Location = new System.Drawing.Point(311, 100);
            staffUsernameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffUsernameTextBox.Name = "staffUsernameTextBox";
            staffUsernameTextBox.Size = new System.Drawing.Size(260, 36);
            staffUsernameTextBox.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(311, 65);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(123, 28);
            label14.TabIndex = 6;
            label14.Text = "Username:";
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new System.Drawing.Point(0, 591);
            dataGridViewStaff.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersWidth = 62;
            dataGridViewStaff.Size = new System.Drawing.Size(1568, 304);
            dataGridViewStaff.TabIndex = 3;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(staffSearchTextBox);
            groupBox7.Location = new System.Drawing.Point(0, 484);
            groupBox7.Margin = new System.Windows.Forms.Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding(2);
            groupBox7.Size = new System.Drawing.Size(1568, 102);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Search";
            // 
            // staffSearchTextBox
            // 
            staffSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffSearchTextBox.Location = new System.Drawing.Point(70, 48);
            staffSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            staffSearchTextBox.Name = "staffSearchTextBox";
            staffSearchTextBox.Size = new System.Drawing.Size(937, 36);
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
            groupBox4.Location = new System.Drawing.Point(2, 351);
            groupBox4.Margin = new System.Windows.Forms.Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(2);
            groupBox4.Size = new System.Drawing.Size(1568, 128);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Control Button";
            // 
            // enableStaffBtn
            // 
            enableStaffBtn.AutoSize = true;
            enableStaffBtn.Location = new System.Drawing.Point(621, 55);
            enableStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            enableStaffBtn.Name = "enableStaffBtn";
            enableStaffBtn.Size = new System.Drawing.Size(128, 54);
            enableStaffBtn.TabIndex = 4;
            enableStaffBtn.Text = "Enable";
            enableStaffBtn.UseVisualStyleBackColor = true;
            enableStaffBtn.Click += enableStaffBtn_Click;
            // 
            // clearScreenStaffBtn
            // 
            clearScreenStaffBtn.AutoSize = true;
            clearScreenStaffBtn.Location = new System.Drawing.Point(808, 55);
            clearScreenStaffBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            clearScreenStaffBtn.Name = "clearScreenStaffBtn";
            clearScreenStaffBtn.Size = new System.Drawing.Size(200, 54);
            clearScreenStaffBtn.TabIndex = 3;
            clearScreenStaffBtn.Text = "ClearScreen";
            clearScreenStaffBtn.UseVisualStyleBackColor = true;
            clearScreenStaffBtn.Click += clearScreenStaffBtn_Click;
            // 
            // disableStaffBtn
            // 
            disableStaffBtn.AutoSize = true;
            disableStaffBtn.Location = new System.Drawing.Point(422, 55);
            disableStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            disableStaffBtn.Name = "disableStaffBtn";
            disableStaffBtn.Size = new System.Drawing.Size(138, 54);
            disableStaffBtn.TabIndex = 2;
            disableStaffBtn.Text = "Disable";
            disableStaffBtn.UseVisualStyleBackColor = true;
            disableStaffBtn.Click += disableStaffBtn_Click;
            // 
            // saveStaffBtn
            // 
            saveStaffBtn.AutoSize = true;
            saveStaffBtn.Location = new System.Drawing.Point(245, 55);
            saveStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            saveStaffBtn.Name = "saveStaffBtn";
            saveStaffBtn.Size = new System.Drawing.Size(112, 54);
            saveStaffBtn.TabIndex = 1;
            saveStaffBtn.Text = "Save";
            saveStaffBtn.UseVisualStyleBackColor = true;
            saveStaffBtn.Click += saveStaffBtn_Click;
            // 
            // addStaffBtn
            // 
            addStaffBtn.AutoSize = true;
            addStaffBtn.Location = new System.Drawing.Point(70, 55);
            addStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.Size = new System.Drawing.Size(112, 54);
            addStaffBtn.TabIndex = 0;
            addStaffBtn.Text = "Add";
            addStaffBtn.UseVisualStyleBackColor = true;
            addStaffBtn.Click += addStaffBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(staffBirthDateTimePicker);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(staffEmailTextBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(staffPhoneTextBox);
            groupBox3.Controls.Add(staffPositionTextBox);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(staffAddressTextBox);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(staffMaleCheckBox);
            groupBox3.Controls.Add(staffNameTextBox);
            groupBox3.Location = new System.Drawing.Point(0, 0);
            groupBox3.Margin = new System.Windows.Forms.Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(2);
            groupBox3.Size = new System.Drawing.Size(959, 346);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information";
            // 
            // staffBirthDateTimePicker
            // 
            staffBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            staffBirthDateTimePicker.Location = new System.Drawing.Point(396, 74);
            staffBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffBirthDateTimePicker.Name = "staffBirthDateTimePicker";
            staffBirthDateTimePicker.Size = new System.Drawing.Size(252, 36);
            staffBirthDateTimePicker.TabIndex = 34;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(396, 39);
            label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(147, 28);
            label20.TabIndex = 33;
            label20.Text = "Date of birth:";
            // 
            // staffEmailTextBox
            // 
            staffEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffEmailTextBox.Location = new System.Drawing.Point(39, 184);
            staffEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffEmailTextBox.Name = "staffEmailTextBox";
            staffEmailTextBox.Size = new System.Drawing.Size(297, 36);
            staffEmailTextBox.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(692, 39);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(93, 28);
            label8.TabIndex = 14;
            label8.Text = "Gender:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(692, 149);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 28);
            label13.TabIndex = 4;
            label13.Text = "Position:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(39, 149);
            label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(78, 28);
            label21.TabIndex = 31;
            label21.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(39, 39);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(83, 28);
            label12.TabIndex = 2;
            label12.Text = "Name: ";
            // 
            // staffPhoneTextBox
            // 
            staffPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffPhoneTextBox.Location = new System.Drawing.Point(396, 184);
            staffPhoneTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffPhoneTextBox.Name = "staffPhoneTextBox";
            staffPhoneTextBox.Size = new System.Drawing.Size(252, 36);
            staffPhoneTextBox.TabIndex = 28;
            // 
            // staffPositionTextBox
            // 
            staffPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffPositionTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffPositionTextBox.Location = new System.Drawing.Point(692, 184);
            staffPositionTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffPositionTextBox.Name = "staffPositionTextBox";
            staffPositionTextBox.Size = new System.Drawing.Size(230, 36);
            staffPositionTextBox.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(39, 244);
            label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(106, 28);
            label23.TabIndex = 29;
            label23.Text = "Address: ";
            // 
            // staffAddressTextBox
            // 
            staffAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffAddressTextBox.Location = new System.Drawing.Point(39, 279);
            staffAddressTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffAddressTextBox.Name = "staffAddressTextBox";
            staffAddressTextBox.Size = new System.Drawing.Size(610, 36);
            staffAddressTextBox.TabIndex = 30;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(396, 149);
            label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(166, 28);
            label24.TabIndex = 27;
            label24.Text = "Phone Number";
            // 
            // staffMaleCheckBox
            // 
            staffMaleCheckBox.AutoSize = true;
            staffMaleCheckBox.Location = new System.Drawing.Point(692, 75);
            staffMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            staffMaleCheckBox.Name = "staffMaleCheckBox";
            staffMaleCheckBox.Size = new System.Drawing.Size(89, 32);
            staffMaleCheckBox.TabIndex = 12;
            staffMaleCheckBox.Text = "Male";
            staffMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffNameTextBox
            // 
            staffNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffNameTextBox.Location = new System.Drawing.Point(39, 74);
            staffNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            staffNameTextBox.Name = "staffNameTextBox";
            staffNameTextBox.Size = new System.Drawing.Size(297, 36);
            staffNameTextBox.TabIndex = 3;
            // 
            // tabPageFinancialReport
            // 
            tabPageFinancialReport.Controls.Add(panel1);
            tabPageFinancialReport.Controls.Add(dataGridViewDailyReport);
            tabPageFinancialReport.Location = new System.Drawing.Point(4, 40);
            tabPageFinancialReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabPageFinancialReport.Name = "tabPageFinancialReport";
            tabPageFinancialReport.Size = new System.Drawing.Size(1570, 900);
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
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(642, 900);
            panel1.TabIndex = 9;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(rbMonthly);
            groupBox11.Controls.Add(rbDaily);
            groupBox11.Location = new System.Drawing.Point(160, 179);
            groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox11.Size = new System.Drawing.Size(375, 156);
            groupBox11.TabIndex = 9;
            groupBox11.TabStop = false;
            groupBox11.Text = "Select report type";
            // 
            // rbMonthly
            // 
            rbMonthly.AutoSize = true;
            rbMonthly.Location = new System.Drawing.Point(206, 82);
            rbMonthly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            rbMonthly.Name = "rbMonthly";
            rbMonthly.Size = new System.Drawing.Size(123, 32);
            rbMonthly.TabIndex = 1;
            rbMonthly.TabStop = true;
            rbMonthly.Text = "Monthly";
            rbMonthly.UseVisualStyleBackColor = true;
            rbMonthly.CheckedChanged += rbMonthly_CheckedChanged;
            // 
            // rbDaily
            // 
            rbDaily.AutoSize = true;
            rbDaily.Location = new System.Drawing.Point(30, 82);
            rbDaily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            rbDaily.Name = "rbDaily";
            rbDaily.Size = new System.Drawing.Size(91, 32);
            rbDaily.TabIndex = 0;
            rbDaily.TabStop = true;
            rbDaily.Text = "Daily";
            rbDaily.UseVisualStyleBackColor = true;
            rbDaily.CheckedChanged += rbDaily_CheckedChanged;
            // 
            // dailyReportBtn
            // 
            dailyReportBtn.AutoSize = true;
            dailyReportBtn.Location = new System.Drawing.Point(211, 546);
            dailyReportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dailyReportBtn.Name = "dailyReportBtn";
            dailyReportBtn.Size = new System.Drawing.Size(214, 54);
            dailyReportBtn.TabIndex = 8;
            dailyReportBtn.Text = "Export Excel";
            dailyReportBtn.UseVisualStyleBackColor = true;
            dailyReportBtn.Click += dailyReportBtn_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(71, 426);
            label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(71, 28);
            label22.TabIndex = 6;
            label22.Text = "Time:";
            // 
            // dailyReportDateTimePicker
            // 
            dailyReportDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dailyReportDateTimePicker.Location = new System.Drawing.Point(160, 419);
            dailyReportDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dailyReportDateTimePicker.Name = "dailyReportDateTimePicker";
            dailyReportDateTimePicker.Size = new System.Drawing.Size(374, 36);
            dailyReportDateTimePicker.TabIndex = 7;
            dailyReportDateTimePicker.ValueChanged += dailyReportDateTimePicker_ValueChanged;
            // 
            // dataGridViewDailyReport
            // 
            dataGridViewDailyReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDailyReport.Dock = System.Windows.Forms.DockStyle.Right;
            dataGridViewDailyReport.Location = new System.Drawing.Point(652, 0);
            dataGridViewDailyReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dataGridViewDailyReport.Name = "dataGridViewDailyReport";
            dataGridViewDailyReport.RowHeadersWidth = 62;
            dataGridViewDailyReport.Size = new System.Drawing.Size(918, 900);
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
            tabPageChangeRegulations.Location = new System.Drawing.Point(4, 40);
            tabPageChangeRegulations.Margin = new System.Windows.Forms.Padding(2);
            tabPageChangeRegulations.Name = "tabPageChangeRegulations";
            tabPageChangeRegulations.Size = new System.Drawing.Size(1570, 900);
            tabPageChangeRegulations.TabIndex = 4;
            tabPageChangeRegulations.Text = "Change regulations";
            tabPageChangeRegulations.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(1261, 415);
            label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(33, 28);
            label19.TabIndex = 12;
            label19.Text = "%";
            // 
            // saveRate
            // 
            saveRate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            saveRate.Location = new System.Drawing.Point(1050, 555);
            saveRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            saveRate.Name = "saveRate";
            saveRate.Size = new System.Drawing.Size(155, 52);
            saveRate.TabIndex = 11;
            saveRate.Text = "Save";
            saveRate.UseVisualStyleBackColor = true;
            saveRate.Click += saveRate_Click;
            // 
            // ratetxt
            // 
            ratetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ratetxt.Location = new System.Drawing.Point(991, 412);
            ratetxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            ratetxt.Name = "ratetxt";
            ratetxt.Size = new System.Drawing.Size(260, 36);
            ratetxt.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(991, 378);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(219, 28);
            label17.TabIndex = 9;
            label17.Text = "AnnualInterestRate:";
            // 
            // monthtxt
            // 
            monthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            monthtxt.Location = new System.Drawing.Point(992, 296);
            monthtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            monthtxt.Name = "monthtxt";
            monthtxt.ReadOnly = true;
            monthtxt.Size = new System.Drawing.Size(258, 36);
            monthtxt.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(991, 261);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(185, 28);
            label18.TabIndex = 7;
            label18.Text = "PeriodInMonths:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(data_rate);
            groupBox5.Location = new System.Drawing.Point(125, 178);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox5.Size = new System.Drawing.Size(771, 438);
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
            data_rate.BackgroundColor = System.Drawing.Color.White;
            data_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            data_rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_rate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            data_rate.Location = new System.Drawing.Point(8, 34);
            data_rate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            data_rate.Name = "data_rate";
            data_rate.ReadOnly = true;
            data_rate.RowHeadersVisible = false;
            data_rate.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            data_rate.RowsDefaultCellStyle = dataGridViewCellStyle1;
            data_rate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            data_rate.Size = new System.Drawing.Size(756, 396);
            data_rate.TabIndex = 2;
            data_rate.CellClick += data_rate_CellClick;
            // 
            // StaffMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1578, 944);
            Controls.Add(tabControlStaffMenu);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "StaffMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Staff";
            FormClosing += StaffMenuForm_FormClosing;
            Load += StaffMenuForm_Load;
            tabControlStaffMenu.ResumeLayout(false);
            tabPageInformation.ResumeLayout(false);
            gbFunction.ResumeLayout(false);
            gbAccount.ResumeLayout(false);
            gbAccount.PerformLayout();
            gbPersonal.ResumeLayout(false);
            gbPersonal.PerformLayout();
            tabPageDeposit.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).EndInit();
            tabPageWithdraw.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWithdraw).EndInit();
            tabPageManageCustomers.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageManageStaffs.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
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
		private System.Windows.Forms.DateTimePicker staffBirthDateTimePicker;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox staffEmailTextBox;
		private System.Windows.Forms.TextBox staffPhoneTextBox;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox staffAddressTextBox;
		private System.Windows.Forms.GroupBox gbAccount;
		private System.Windows.Forms.GroupBox gbPersonal;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox staffEmailTxt;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox staffPhoneTxt;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox staffAddressTxt;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox staffBirthdayTxt;
		private System.Windows.Forms.GroupBox gbFunction;
	}
}