﻿using DataAccess;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMenuForm));
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
            customerWithdrawBalanceLabel.Location = new System.Drawing.Point(23, 320);
            customerWithdrawBalanceLabel.Name = "customerWithdrawBalanceLabel";
            customerWithdrawBalanceLabel.Size = new System.Drawing.Size(82, 23);
            customerWithdrawBalanceLabel.TabIndex = 18;
            customerWithdrawBalanceLabel.Text = "Balance:";
            // 
            // customerWithdrawContentLabel
            // 
            customerWithdrawContentLabel.AutoSize = true;
            customerWithdrawContentLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawContentLabel.Location = new System.Drawing.Point(23, 499);
            customerWithdrawContentLabel.Name = "customerWithdrawContentLabel";
            customerWithdrawContentLabel.Size = new System.Drawing.Size(83, 23);
            customerWithdrawContentLabel.TabIndex = 21;
            customerWithdrawContentLabel.Text = "Content:";
            // 
            // customerWithdrawAmountLabel
            // 
            customerWithdrawAmountLabel.AutoSize = true;
            customerWithdrawAmountLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawAmountLabel.Location = new System.Drawing.Point(23, 397);
            customerWithdrawAmountLabel.Name = "customerWithdrawAmountLabel";
            customerWithdrawAmountLabel.Size = new System.Drawing.Size(172, 23);
            customerWithdrawAmountLabel.TabIndex = 20;
            customerWithdrawAmountLabel.Text = "Withdraw amount:";
            // 
            // customerWithdrawCicNumberLabel
            // 
            customerWithdrawCicNumberLabel.AutoSize = true;
            customerWithdrawCicNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawCicNumberLabel.Location = new System.Drawing.Point(23, 243);
            customerWithdrawCicNumberLabel.Name = "customerWithdrawCicNumberLabel";
            customerWithdrawCicNumberLabel.Size = new System.Drawing.Size(118, 23);
            customerWithdrawCicNumberLabel.TabIndex = 16;
            customerWithdrawCicNumberLabel.Text = "CIC Number:";
            // 
            // customerWithdrawNameLabel
            // 
            customerWithdrawNameLabel.AutoSize = true;
            customerWithdrawNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawNameLabel.Location = new System.Drawing.Point(23, 166);
            customerWithdrawNameLabel.Name = "customerWithdrawNameLabel";
            customerWithdrawNameLabel.Size = new System.Drawing.Size(66, 23);
            customerWithdrawNameLabel.TabIndex = 14;
            customerWithdrawNameLabel.Text = "Name:";
            // 
            // customerWithdrawIdLabel
            // 
            customerWithdrawIdLabel.AutoSize = true;
            customerWithdrawIdLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawIdLabel.Location = new System.Drawing.Point(23, 89);
            customerWithdrawIdLabel.Name = "customerWithdrawIdLabel";
            customerWithdrawIdLabel.Size = new System.Drawing.Size(122, 23);
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
            tabControlStaffMenu.Size = new System.Drawing.Size(1262, 755);
            tabControlStaffMenu.TabIndex = 0;
            tabControlStaffMenu.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageInformation
            // 
            tabPageInformation.Controls.Add(gbFunction);
            tabPageInformation.Controls.Add(gbAccount);
            tabPageInformation.Controls.Add(gbPersonal);
            tabPageInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabPageInformation.Location = new System.Drawing.Point(4, 35);
            tabPageInformation.Margin = new System.Windows.Forms.Padding(2);
            tabPageInformation.Name = "tabPageInformation";
            tabPageInformation.Padding = new System.Windows.Forms.Padding(2);
            tabPageInformation.Size = new System.Drawing.Size(1254, 716);
            tabPageInformation.TabIndex = 0;
            tabPageInformation.Text = "Information";
            tabPageInformation.UseVisualStyleBackColor = true;
            // 
            // gbFunction
            // 
            gbFunction.Controls.Add(button1);
            gbFunction.Controls.Add(staffChangePasswordButton);
            gbFunction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gbFunction.Location = new System.Drawing.Point(685, 380);
            gbFunction.Name = "gbFunction";
            gbFunction.Size = new System.Drawing.Size(538, 286);
            gbFunction.TabIndex = 36;
            gbFunction.TabStop = false;
            gbFunction.Text = "Function";
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(159, 63);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(5);
            button1.Size = new System.Drawing.Size(255, 66);
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
            staffChangePasswordButton.Location = new System.Drawing.Point(159, 161);
            staffChangePasswordButton.Name = "staffChangePasswordButton";
            staffChangePasswordButton.Padding = new System.Windows.Forms.Padding(5);
            staffChangePasswordButton.Size = new System.Drawing.Size(255, 66);
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
            gbAccount.Location = new System.Drawing.Point(685, 42);
            gbAccount.Name = "gbAccount";
            gbAccount.Size = new System.Drawing.Size(538, 276);
            gbAccount.TabIndex = 35;
            gbAccount.TabStop = false;
            gbAccount.Text = "Account";
            // 
            // staffIdtxt
            // 
            staffIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffIdtxt.Location = new System.Drawing.Point(170, 100);
            staffIdtxt.Name = "staffIdtxt";
            staffIdtxt.ReadOnly = true;
            staffIdtxt.Size = new System.Drawing.Size(336, 34);
            staffIdtxt.TabIndex = 22;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(30, 100);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(40, 27);
            customerIdLabel.TabIndex = 23;
            customerIdLabel.Text = "ID:";
            // 
            // staffusernametxt
            // 
            staffusernametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffusernametxt.Location = new System.Drawing.Point(170, 174);
            staffusernametxt.Name = "staffusernametxt";
            staffusernametxt.ReadOnly = true;
            staffusernametxt.Size = new System.Drawing.Size(336, 34);
            staffusernametxt.TabIndex = 30;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(30, 176);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(118, 27);
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
            gbPersonal.Location = new System.Drawing.Point(40, 42);
            gbPersonal.Name = "gbPersonal";
            gbPersonal.Size = new System.Drawing.Size(623, 624);
            gbPersonal.TabIndex = 34;
            gbPersonal.TabStop = false;
            gbPersonal.Text = "Personal";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(96, 152);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(105, 27);
            label28.TabIndex = 36;
            label28.Text = "Birthday:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(96, 472);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(99, 27);
            label27.TabIndex = 34;
            label27.Text = "Address:";
            // 
            // staffAddressTxt
            // 
            staffAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffAddressTxt.Location = new System.Drawing.Point(223, 470);
            staffAddressTxt.Name = "staffAddressTxt";
            staffAddressTxt.ReadOnly = true;
            staffAddressTxt.Size = new System.Drawing.Size(322, 34);
            staffAddressTxt.TabIndex = 35;
            // 
            // staffBirthdayTxt
            // 
            staffBirthdayTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffBirthdayTxt.Location = new System.Drawing.Point(223, 150);
            staffBirthdayTxt.Name = "staffBirthdayTxt";
            staffBirthdayTxt.ReadOnly = true;
            staffBirthdayTxt.Size = new System.Drawing.Size(322, 34);
            staffBirthdayTxt.TabIndex = 37;
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(96, 552);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(98, 27);
            customerPhoneNumberLabel.TabIndex = 28;
            customerPhoneNumberLabel.Text = "Position:";
            // 
            // staffpositiontxt
            // 
            staffpositiontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffpositiontxt.Location = new System.Drawing.Point(223, 550);
            staffpositiontxt.Name = "staffpositiontxt";
            staffpositiontxt.ReadOnly = true;
            staffpositiontxt.Size = new System.Drawing.Size(322, 34);
            staffpositiontxt.TabIndex = 29;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(96, 392);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(73, 27);
            label26.TabIndex = 32;
            label26.Text = "Email:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(96, 232);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(80, 27);
            label25.TabIndex = 30;
            label25.Text = "Phone:";
            // 
            // staffPhoneTxt
            // 
            staffPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffPhoneTxt.Location = new System.Drawing.Point(223, 230);
            staffPhoneTxt.Name = "staffPhoneTxt";
            staffPhoneTxt.ReadOnly = true;
            staffPhoneTxt.Size = new System.Drawing.Size(322, 34);
            staffPhoneTxt.TabIndex = 31;
            // 
            // staffEmailTxt
            // 
            staffEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffEmailTxt.Location = new System.Drawing.Point(223, 390);
            staffEmailTxt.Name = "staffEmailTxt";
            staffEmailTxt.ReadOnly = true;
            staffEmailTxt.Size = new System.Drawing.Size(322, 34);
            staffEmailTxt.TabIndex = 33;
            // 
            // staffnametxt
            // 
            staffnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffnametxt.Location = new System.Drawing.Point(223, 70);
            staffnametxt.Name = "staffnametxt";
            staffnametxt.ReadOnly = true;
            staffnametxt.Size = new System.Drawing.Size(322, 34);
            staffnametxt.TabIndex = 24;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(96, 72);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(75, 27);
            customerNameLabel.TabIndex = 25;
            customerNameLabel.Text = "Name:";
            // 
            // staffgendertxt
            // 
            staffgendertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffgendertxt.Location = new System.Drawing.Point(223, 310);
            staffgendertxt.Name = "staffgendertxt";
            staffgendertxt.ReadOnly = true;
            staffgendertxt.Size = new System.Drawing.Size(183, 34);
            staffgendertxt.TabIndex = 26;
            // 
            // customerGenderLabel
            // 
            customerGenderLabel.AutoSize = true;
            customerGenderLabel.Location = new System.Drawing.Point(96, 312);
            customerGenderLabel.Name = "customerGenderLabel";
            customerGenderLabel.Size = new System.Drawing.Size(90, 27);
            customerGenderLabel.TabIndex = 27;
            customerGenderLabel.Text = "Gender:";
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
            panel3.Size = new System.Drawing.Size(444, 712);
            panel3.TabIndex = 9;
            // 
            // customerDepositAmountNumeric
            // 
            customerDepositAmountNumeric.DecimalPlaces = 2;
            customerDepositAmountNumeric.Enabled = false;
            customerDepositAmountNumeric.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositAmountNumeric.Location = new System.Drawing.Point(23, 344);
            customerDepositAmountNumeric.Margin = new System.Windows.Forms.Padding(5);
            customerDepositAmountNumeric.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            customerDepositAmountNumeric.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            customerDepositAmountNumeric.Name = "customerDepositAmountNumeric";
            customerDepositAmountNumeric.Size = new System.Drawing.Size(386, 31);
            customerDepositAmountNumeric.TabIndex = 18;
            // 
            // customerDepositIdTextBox
            // 
            customerDepositIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositIdTextBox.Location = new System.Drawing.Point(23, 113);
            customerDepositIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerDepositIdTextBox.MaxLength = 10;
            customerDepositIdTextBox.Name = "customerDepositIdTextBox";
            customerDepositIdTextBox.Size = new System.Drawing.Size(386, 31);
            customerDepositIdTextBox.TabIndex = 7;
            customerDepositIdTextBox.Enter += customerDepositIdTextBox_Enter;
            customerDepositIdTextBox.Leave += customerDepositIdTextBox_Leave;
            // 
            // customerDepositContentTextBox
            // 
            customerDepositContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositContentTextBox.Enabled = false;
            customerDepositContentTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositContentTextBox.Location = new System.Drawing.Point(23, 421);
            customerDepositContentTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerDepositContentTextBox.Name = "customerDepositContentTextBox";
            customerDepositContentTextBox.Size = new System.Drawing.Size(386, 31);
            customerDepositContentTextBox.TabIndex = 14;
            customerDepositContentTextBox.TextChanged += customerDepositContentTextBox_TextChanged;
            // 
            // customerDepositContentLabel
            // 
            customerDepositContentLabel.AutoSize = true;
            customerDepositContentLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositContentLabel.Location = new System.Drawing.Point(23, 393);
            customerDepositContentLabel.Name = "customerDepositContentLabel";
            customerDepositContentLabel.Size = new System.Drawing.Size(83, 23);
            customerDepositContentLabel.TabIndex = 15;
            customerDepositContentLabel.Text = "Content:";
            // 
            // customerDepositAmountLabel
            // 
            customerDepositAmountLabel.AutoSize = true;
            customerDepositAmountLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositAmountLabel.Location = new System.Drawing.Point(23, 316);
            customerDepositAmountLabel.Name = "customerDepositAmountLabel";
            customerDepositAmountLabel.Size = new System.Drawing.Size(153, 23);
            customerDepositAmountLabel.TabIndex = 13;
            customerDepositAmountLabel.Text = "Deposit amount:";
            // 
            // customerDepositCicNumberTextBox
            // 
            customerDepositCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositCicNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositCicNumberTextBox.Location = new System.Drawing.Point(23, 267);
            customerDepositCicNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerDepositCicNumberTextBox.Name = "customerDepositCicNumberTextBox";
            customerDepositCicNumberTextBox.ReadOnly = true;
            customerDepositCicNumberTextBox.Size = new System.Drawing.Size(386, 31);
            customerDepositCicNumberTextBox.TabIndex = 11;
            // 
            // customerDepositCicNumberLabel
            // 
            customerDepositCicNumberLabel.AutoSize = true;
            customerDepositCicNumberLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositCicNumberLabel.Location = new System.Drawing.Point(23, 239);
            customerDepositCicNumberLabel.Name = "customerDepositCicNumberLabel";
            customerDepositCicNumberLabel.Size = new System.Drawing.Size(118, 23);
            customerDepositCicNumberLabel.TabIndex = 12;
            customerDepositCicNumberLabel.Text = "CIC Number:";
            // 
            // customerDepositNameTextBox
            // 
            customerDepositNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerDepositNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositNameTextBox.Location = new System.Drawing.Point(23, 190);
            customerDepositNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerDepositNameTextBox.Name = "customerDepositNameTextBox";
            customerDepositNameTextBox.ReadOnly = true;
            customerDepositNameTextBox.Size = new System.Drawing.Size(386, 31);
            customerDepositNameTextBox.TabIndex = 9;
            // 
            // customerDepositNameLabel
            // 
            customerDepositNameLabel.AutoSize = true;
            customerDepositNameLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositNameLabel.Location = new System.Drawing.Point(23, 162);
            customerDepositNameLabel.Name = "customerDepositNameLabel";
            customerDepositNameLabel.Size = new System.Drawing.Size(66, 23);
            customerDepositNameLabel.TabIndex = 10;
            customerDepositNameLabel.Text = "Name:";
            // 
            // customerDepositIdLabel
            // 
            customerDepositIdLabel.AutoSize = true;
            customerDepositIdLabel.Font = new System.Drawing.Font("Cambria", 12F);
            customerDepositIdLabel.Location = new System.Drawing.Point(23, 85);
            customerDepositIdLabel.Name = "customerDepositIdLabel";
            customerDepositIdLabel.Size = new System.Drawing.Size(122, 23);
            customerDepositIdLabel.TabIndex = 8;
            customerDepositIdLabel.Text = "Customer ID:";
            // 
            // reportDepositBtn
            // 
            reportDepositBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            reportDepositBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            reportDepositBtn.Font = new System.Drawing.Font("Cambria", 13.8F);
            reportDepositBtn.ForeColor = System.Drawing.Color.White;
            reportDepositBtn.Location = new System.Drawing.Point(23, 521);
            reportDepositBtn.Margin = new System.Windows.Forms.Padding(2);
            reportDepositBtn.Name = "reportDepositBtn";
            reportDepositBtn.Padding = new System.Windows.Forms.Padding(5);
            reportDepositBtn.Size = new System.Drawing.Size(100, 50);
            reportDepositBtn.TabIndex = 19;
            reportDepositBtn.Text = "Report";
            reportDepositBtn.UseVisualStyleBackColor = true;
            reportDepositBtn.Click += reportDepositBtn_Click;
            // 
            // customerPrintButton
            // 
            customerPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerPrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            customerPrintButton.Enabled = false;
            customerPrintButton.Font = new System.Drawing.Font("Cambria", 13.8F);
            customerPrintButton.Location = new System.Drawing.Point(158, 521);
            customerPrintButton.Name = "customerPrintButton";
            customerPrintButton.Padding = new System.Windows.Forms.Padding(5);
            customerPrintButton.Size = new System.Drawing.Size(100, 50);
            customerPrintButton.TabIndex = 16;
            customerPrintButton.Text = "Print";
            customerPrintButton.UseVisualStyleBackColor = true;
            customerPrintButton.Click += customerPrintButton_Click;
            // 
            // customerDepositButton
            // 
            customerDepositButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerDepositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            customerDepositButton.Enabled = false;
            customerDepositButton.Font = new System.Drawing.Font("Cambria", 13.8F);
            customerDepositButton.Location = new System.Drawing.Point(296, 521);
            customerDepositButton.Name = "customerDepositButton";
            customerDepositButton.Padding = new System.Windows.Forms.Padding(5);
            customerDepositButton.Size = new System.Drawing.Size(113, 50);
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
            dataGridViewDeposit.Location = new System.Drawing.Point(451, 2);
            dataGridViewDeposit.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewDeposit.Name = "dataGridViewDeposit";
            dataGridViewDeposit.RowHeadersVisible = false;
            dataGridViewDeposit.RowHeadersWidth = 62;
            dataGridViewDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDeposit.Size = new System.Drawing.Size(801, 712);
            dataGridViewDeposit.TabIndex = 8;
            dataGridViewDeposit.CellClick += dataGridViewDeposit_CellClick;
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
            panel2.Size = new System.Drawing.Size(438, 716);
            panel2.TabIndex = 10;
            // 
            // customerWithdrawBalanceTextBox
            // 
            customerWithdrawBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawBalanceTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawBalanceTextBox.Location = new System.Drawing.Point(23, 348);
            customerWithdrawBalanceTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerWithdrawBalanceTextBox.Name = "customerWithdrawBalanceTextBox";
            customerWithdrawBalanceTextBox.ReadOnly = true;
            customerWithdrawBalanceTextBox.Size = new System.Drawing.Size(386, 31);
            customerWithdrawBalanceTextBox.TabIndex = 17;
            // 
            // customerWithdrawAmountNumeric
            // 
            customerWithdrawAmountNumeric.DecimalPlaces = 2;
            customerWithdrawAmountNumeric.Enabled = false;
            customerWithdrawAmountNumeric.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawAmountNumeric.Location = new System.Drawing.Point(23, 425);
            customerWithdrawAmountNumeric.Margin = new System.Windows.Forms.Padding(5);
            customerWithdrawAmountNumeric.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            customerWithdrawAmountNumeric.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            customerWithdrawAmountNumeric.Name = "customerWithdrawAmountNumeric";
            customerWithdrawAmountNumeric.Size = new System.Drawing.Size(386, 31);
            customerWithdrawAmountNumeric.TabIndex = 19;
            // 
            // customerWithdrawIdTextBox
            // 
            customerWithdrawIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawIdTextBox.Location = new System.Drawing.Point(23, 117);
            customerWithdrawIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerWithdrawIdTextBox.MaxLength = 0;
            customerWithdrawIdTextBox.Name = "customerWithdrawIdTextBox";
            customerWithdrawIdTextBox.Size = new System.Drawing.Size(386, 31);
            customerWithdrawIdTextBox.TabIndex = 25;
            customerWithdrawIdTextBox.Enter += customerWithdrawIdTextBox_Enter;
            customerWithdrawIdTextBox.Leave += customerWithdrawIdTextBox_Leave;
            // 
            // customerWithdrawCicNumberTextBox
            // 
            customerWithdrawCicNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawCicNumberTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawCicNumberTextBox.Location = new System.Drawing.Point(23, 271);
            customerWithdrawCicNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerWithdrawCicNumberTextBox.Name = "customerWithdrawCicNumberTextBox";
            customerWithdrawCicNumberTextBox.ReadOnly = true;
            customerWithdrawCicNumberTextBox.Size = new System.Drawing.Size(386, 31);
            customerWithdrawCicNumberTextBox.TabIndex = 15;
            // 
            // customerWithdrawNameTextBox
            // 
            customerWithdrawNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerWithdrawNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawNameTextBox.Location = new System.Drawing.Point(23, 194);
            customerWithdrawNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerWithdrawNameTextBox.Name = "customerWithdrawNameTextBox";
            customerWithdrawNameTextBox.ReadOnly = true;
            customerWithdrawNameTextBox.Size = new System.Drawing.Size(386, 31);
            customerWithdrawNameTextBox.TabIndex = 13;
            // 
            // amountWithdrawingErrorLabel
            // 
            amountWithdrawingErrorLabel.AutoSize = true;
            amountWithdrawingErrorLabel.Font = new System.Drawing.Font("Cambria", 12F);
            amountWithdrawingErrorLabel.ForeColor = System.Drawing.Color.Red;
            amountWithdrawingErrorLabel.Location = new System.Drawing.Point(23, 462);
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
            customerWithdrawContentTextBox.Location = new System.Drawing.Point(23, 527);
            customerWithdrawContentTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerWithdrawContentTextBox.Name = "customerWithdrawContentTextBox";
            customerWithdrawContentTextBox.Size = new System.Drawing.Size(386, 31);
            customerWithdrawContentTextBox.TabIndex = 23;
            customerWithdrawContentTextBox.TextChanged += customerWithdrawContentTextBox_TextChanged;
            // 
            // reportWithdrawBtn
            // 
            reportWithdrawBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            reportWithdrawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            reportWithdrawBtn.Font = new System.Drawing.Font("Cambria", 12F);
            reportWithdrawBtn.ForeColor = System.Drawing.Color.White;
            reportWithdrawBtn.Location = new System.Drawing.Point(25, 598);
            reportWithdrawBtn.Margin = new System.Windows.Forms.Padding(2);
            reportWithdrawBtn.Name = "reportWithdrawBtn";
            reportWithdrawBtn.Padding = new System.Windows.Forms.Padding(5);
            reportWithdrawBtn.Size = new System.Drawing.Size(120, 50);
            reportWithdrawBtn.TabIndex = 27;
            reportWithdrawBtn.Text = "Report";
            reportWithdrawBtn.UseVisualStyleBackColor = true;
            reportWithdrawBtn.Click += reportWithdrawBtn_Click;
            // 
            // withdrawPrintButton
            // 
            withdrawPrintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            withdrawPrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            withdrawPrintButton.Enabled = false;
            withdrawPrintButton.Font = new System.Drawing.Font("Cambria", 12F);
            withdrawPrintButton.Location = new System.Drawing.Point(157, 598);
            withdrawPrintButton.Name = "withdrawPrintButton";
            withdrawPrintButton.Padding = new System.Windows.Forms.Padding(5);
            withdrawPrintButton.Size = new System.Drawing.Size(120, 50);
            withdrawPrintButton.TabIndex = 26;
            withdrawPrintButton.Text = "Print";
            withdrawPrintButton.UseVisualStyleBackColor = true;
            withdrawPrintButton.Click += withdrawPrintButton_Click;
            // 
            // customerWithdrawButton
            // 
            customerWithdrawButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            customerWithdrawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            customerWithdrawButton.Enabled = false;
            customerWithdrawButton.Font = new System.Drawing.Font("Cambria", 12F);
            customerWithdrawButton.Location = new System.Drawing.Point(289, 598);
            customerWithdrawButton.Name = "customerWithdrawButton";
            customerWithdrawButton.Padding = new System.Windows.Forms.Padding(5);
            customerWithdrawButton.Size = new System.Drawing.Size(120, 50);
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
            dataGridViewWithdraw.Location = new System.Drawing.Point(443, 0);
            dataGridViewWithdraw.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewWithdraw.Name = "dataGridViewWithdraw";
            dataGridViewWithdraw.RowHeadersVisible = false;
            dataGridViewWithdraw.RowHeadersWidth = 62;
            dataGridViewWithdraw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWithdraw.Size = new System.Drawing.Size(811, 716);
            dataGridViewWithdraw.TabIndex = 9;
            dataGridViewWithdraw.CellClick += dataGridViewWithdraw_CellClick;
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
            // customerIdTextBox
            // 
            customerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerIdTextBox.Location = new System.Drawing.Point(43, 91);
            customerIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new System.Drawing.Size(127, 31);
            customerIdTextBox.TabIndex = 1;
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
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new System.Drawing.Point(0, 451);
            dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersVisible = false;
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomer.Size = new System.Drawing.Size(1254, 265);
            dataGridViewCustomer.TabIndex = 3;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(customerSearchTextBox);
            groupBox6.Location = new System.Drawing.Point(0, 377);
            groupBox6.Margin = new System.Windows.Forms.Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(2);
            groupBox6.Size = new System.Drawing.Size(1254, 74);
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
            groupBox2.Location = new System.Drawing.Point(0, 286);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(1254, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control button";
            // 
            // enableCustomerBtn
            // 
            enableCustomerBtn.AutoSize = true;
            enableCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            enableCustomerBtn.ForeColor = System.Drawing.Color.White;
            enableCustomerBtn.Location = new System.Drawing.Point(456, 33);
            enableCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            enableCustomerBtn.Name = "enableCustomerBtn";
            enableCustomerBtn.Size = new System.Drawing.Size(108, 43);
            enableCustomerBtn.TabIndex = 4;
            enableCustomerBtn.Text = "Enable";
            enableCustomerBtn.UseVisualStyleBackColor = true;
            enableCustomerBtn.Click += enableCustomerBtn_Click;
            // 
            // clearScreenCustomerBtn
            // 
            clearScreenCustomerBtn.AutoSize = true;
            clearScreenCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            clearScreenCustomerBtn.ForeColor = System.Drawing.Color.White;
            clearScreenCustomerBtn.Location = new System.Drawing.Point(587, 33);
            clearScreenCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            clearScreenCustomerBtn.Name = "clearScreenCustomerBtn";
            clearScreenCustomerBtn.Size = new System.Drawing.Size(177, 43);
            clearScreenCustomerBtn.TabIndex = 3;
            clearScreenCustomerBtn.Text = "Clear Screen";
            clearScreenCustomerBtn.UseVisualStyleBackColor = true;
            clearScreenCustomerBtn.Click += clearScreenCustomerBtn_Click;
            // 
            // disableCustomerBtn
            // 
            disableCustomerBtn.AutoSize = true;
            disableCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            disableCustomerBtn.ForeColor = System.Drawing.Color.White;
            disableCustomerBtn.Location = new System.Drawing.Point(308, 33);
            disableCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            disableCustomerBtn.Name = "disableCustomerBtn";
            disableCustomerBtn.Size = new System.Drawing.Size(114, 43);
            disableCustomerBtn.TabIndex = 2;
            disableCustomerBtn.Text = "Disable";
            disableCustomerBtn.UseVisualStyleBackColor = true;
            disableCustomerBtn.Click += disableCustomerBtn_Click;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.AutoSize = true;
            saveCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            saveCustomerBtn.ForeColor = System.Drawing.Color.White;
            saveCustomerBtn.Location = new System.Drawing.Point(174, 33);
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
            addCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            addCustomerBtn.ForeColor = System.Drawing.Color.White;
            addCustomerBtn.Location = new System.Drawing.Point(45, 33);
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
            groupBox10.Location = new System.Drawing.Point(772, 0);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new System.Drawing.Size(477, 276);
            groupBox10.TabIndex = 4;
            groupBox10.TabStop = false;
            groupBox10.Text = "Account";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(249, 134);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(69, 23);
            label15.TabIndex = 15;
            label15.Text = "Status:";
            // 
            // staffIdTextBox
            // 
            staffIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffIdTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffIdTextBox.Location = new System.Drawing.Point(28, 82);
            staffIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffIdTextBox.Name = "staffIdTextBox";
            staffIdTextBox.Size = new System.Drawing.Size(172, 31);
            staffIdTextBox.TabIndex = 1;
            // 
            // staffPermissionIdComboBox
            // 
            staffPermissionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            staffPermissionIdComboBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffPermissionIdComboBox.FormattingEnabled = true;
            staffPermissionIdComboBox.Location = new System.Drawing.Point(28, 164);
            staffPermissionIdComboBox.Margin = new System.Windows.Forms.Padding(5);
            staffPermissionIdComboBox.Name = "staffPermissionIdComboBox";
            staffPermissionIdComboBox.Size = new System.Drawing.Size(172, 31);
            staffPermissionIdComboBox.TabIndex = 11;
            // 
            // staffDisableCheckBox
            // 
            staffDisableCheckBox.AutoSize = true;
            staffDisableCheckBox.Location = new System.Drawing.Point(249, 166);
            staffDisableCheckBox.Margin = new System.Windows.Forms.Padding(5);
            staffDisableCheckBox.Name = "staffDisableCheckBox";
            staffDisableCheckBox.Size = new System.Drawing.Size(96, 27);
            staffDisableCheckBox.TabIndex = 13;
            staffDisableCheckBox.Text = "Disable";
            staffDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(28, 54);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(32, 23);
            label11.TabIndex = 0;
            label11.Text = "Id:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(28, 136);
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
            staffUsernameTextBox.Location = new System.Drawing.Point(249, 80);
            staffUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffUsernameTextBox.Name = "staffUsernameTextBox";
            staffUsernameTextBox.Size = new System.Drawing.Size(208, 31);
            staffUsernameTextBox.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(249, 52);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(103, 23);
            label14.TabIndex = 6;
            label14.Text = "Username:";
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new System.Drawing.Point(0, 473);
            dataGridViewStaff.Margin = new System.Windows.Forms.Padding(2);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersVisible = false;
            dataGridViewStaff.RowHeadersWidth = 62;
            dataGridViewStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStaff.Size = new System.Drawing.Size(1254, 243);
            dataGridViewStaff.TabIndex = 3;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(staffSearchTextBox);
            groupBox7.Location = new System.Drawing.Point(0, 387);
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
            groupBox4.Location = new System.Drawing.Point(2, 281);
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
            enableStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            enableStaffBtn.ForeColor = System.Drawing.Color.White;
            enableStaffBtn.Location = new System.Drawing.Point(497, 44);
            enableStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            enableStaffBtn.Name = "enableStaffBtn";
            enableStaffBtn.Size = new System.Drawing.Size(108, 43);
            enableStaffBtn.TabIndex = 4;
            enableStaffBtn.Text = "Enable";
            enableStaffBtn.UseVisualStyleBackColor = true;
            enableStaffBtn.Click += enableStaffBtn_Click;
            // 
            // clearScreenStaffBtn
            // 
            clearScreenStaffBtn.AutoSize = true;
            clearScreenStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            clearScreenStaffBtn.ForeColor = System.Drawing.Color.White;
            clearScreenStaffBtn.Location = new System.Drawing.Point(646, 44);
            clearScreenStaffBtn.Name = "clearScreenStaffBtn";
            clearScreenStaffBtn.Size = new System.Drawing.Size(170, 43);
            clearScreenStaffBtn.TabIndex = 3;
            clearScreenStaffBtn.Text = "ClearScreen";
            clearScreenStaffBtn.UseVisualStyleBackColor = true;
            clearScreenStaffBtn.Click += clearScreenStaffBtn_Click;
            // 
            // disableStaffBtn
            // 
            disableStaffBtn.AutoSize = true;
            disableStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            disableStaffBtn.ForeColor = System.Drawing.Color.White;
            disableStaffBtn.Location = new System.Drawing.Point(338, 44);
            disableStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            disableStaffBtn.Name = "disableStaffBtn";
            disableStaffBtn.Size = new System.Drawing.Size(114, 43);
            disableStaffBtn.TabIndex = 2;
            disableStaffBtn.Text = "Disable";
            disableStaffBtn.UseVisualStyleBackColor = true;
            disableStaffBtn.Click += disableStaffBtn_Click;
            // 
            // saveStaffBtn
            // 
            saveStaffBtn.AutoSize = true;
            saveStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            saveStaffBtn.ForeColor = System.Drawing.Color.White;
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
            addStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            addStaffBtn.ForeColor = System.Drawing.Color.White;
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
            groupBox3.Size = new System.Drawing.Size(767, 277);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information";
            // 
            // staffBirthDateTimePicker
            // 
            staffBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            staffBirthDateTimePicker.Location = new System.Drawing.Point(317, 59);
            staffBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            staffBirthDateTimePicker.Name = "staffBirthDateTimePicker";
            staffBirthDateTimePicker.Size = new System.Drawing.Size(202, 31);
            staffBirthDateTimePicker.TabIndex = 34;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(317, 31);
            label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(123, 23);
            label20.TabIndex = 33;
            label20.Text = "Date of birth:";
            // 
            // staffEmailTextBox
            // 
            staffEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffEmailTextBox.Location = new System.Drawing.Point(31, 147);
            staffEmailTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffEmailTextBox.Name = "staffEmailTextBox";
            staffEmailTextBox.Size = new System.Drawing.Size(238, 31);
            staffEmailTextBox.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(554, 31);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(77, 23);
            label8.TabIndex = 14;
            label8.Text = "Gender:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(554, 119);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(87, 23);
            label13.TabIndex = 4;
            label13.Text = "Position:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(31, 119);
            label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(65, 23);
            label21.TabIndex = 31;
            label21.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(31, 31);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(70, 23);
            label12.TabIndex = 2;
            label12.Text = "Name: ";
            // 
            // staffPhoneTextBox
            // 
            staffPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffPhoneTextBox.Location = new System.Drawing.Point(317, 147);
            staffPhoneTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffPhoneTextBox.Name = "staffPhoneTextBox";
            staffPhoneTextBox.Size = new System.Drawing.Size(202, 31);
            staffPhoneTextBox.TabIndex = 28;
            // 
            // staffPositionTextBox
            // 
            staffPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffPositionTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffPositionTextBox.Location = new System.Drawing.Point(554, 147);
            staffPositionTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffPositionTextBox.Name = "staffPositionTextBox";
            staffPositionTextBox.Size = new System.Drawing.Size(184, 31);
            staffPositionTextBox.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(31, 195);
            label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(89, 23);
            label23.TabIndex = 29;
            label23.Text = "Address: ";
            // 
            // staffAddressTextBox
            // 
            staffAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffAddressTextBox.Location = new System.Drawing.Point(31, 223);
            staffAddressTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffAddressTextBox.Name = "staffAddressTextBox";
            staffAddressTextBox.Size = new System.Drawing.Size(488, 31);
            staffAddressTextBox.TabIndex = 30;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(317, 119);
            label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(139, 23);
            label24.TabIndex = 27;
            label24.Text = "Phone Number";
            // 
            // staffMaleCheckBox
            // 
            staffMaleCheckBox.AutoSize = true;
            staffMaleCheckBox.Location = new System.Drawing.Point(554, 60);
            staffMaleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            staffMaleCheckBox.Name = "staffMaleCheckBox";
            staffMaleCheckBox.Size = new System.Drawing.Size(73, 27);
            staffMaleCheckBox.TabIndex = 12;
            staffMaleCheckBox.Text = "Male";
            staffMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffNameTextBox
            // 
            staffNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            staffNameTextBox.Font = new System.Drawing.Font("Cambria", 12F);
            staffNameTextBox.Location = new System.Drawing.Point(31, 59);
            staffNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            staffNameTextBox.Name = "staffNameTextBox";
            staffNameTextBox.Size = new System.Drawing.Size(238, 31);
            staffNameTextBox.TabIndex = 3;
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
            rbMonthly.CheckedChanged += rbMonthly_CheckedChanged;
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
            rbDaily.CheckedChanged += rbDaily_CheckedChanged;
            // 
            // dailyReportBtn
            // 
            dailyReportBtn.AutoSize = true;
            dailyReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            dailyReportBtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dailyReportBtn.ForeColor = System.Drawing.Color.White;
            dailyReportBtn.Location = new System.Drawing.Point(169, 437);
            dailyReportBtn.Name = "dailyReportBtn";
            dailyReportBtn.Size = new System.Drawing.Size(185, 54);
            dailyReportBtn.TabIndex = 8;
            dailyReportBtn.Text = "Export Excel";
            dailyReportBtn.UseVisualStyleBackColor = true;
            dailyReportBtn.Click += dailyReportBtn_Click;
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
            dailyReportDateTimePicker.ValueChanged += dailyReportDateTimePicker_ValueChanged;
            // 
            // dataGridViewDailyReport
            // 
            dataGridViewDailyReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDailyReport.Dock = System.Windows.Forms.DockStyle.Right;
            dataGridViewDailyReport.Location = new System.Drawing.Point(520, 0);
            dataGridViewDailyReport.Name = "dataGridViewDailyReport";
            dataGridViewDailyReport.RowHeadersVisible = false;
            dataGridViewDailyReport.RowHeadersWidth = 62;
            dataGridViewDailyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            label19.Location = new System.Drawing.Point(1009, 332);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(28, 23);
            label19.TabIndex = 12;
            label19.Text = "%";
            // 
            // saveRate
            // 
            saveRate.Cursor = System.Windows.Forms.Cursors.Hand;
            saveRate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            saveRate.ForeColor = System.Drawing.Color.White;
            saveRate.Location = new System.Drawing.Point(840, 444);
            saveRate.Name = "saveRate";
            saveRate.Size = new System.Drawing.Size(124, 42);
            saveRate.TabIndex = 11;
            saveRate.Text = "Save";
            saveRate.UseVisualStyleBackColor = true;
            saveRate.Click += saveRate_Click;
            // 
            // ratetxt
            // 
            ratetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ratetxt.Location = new System.Drawing.Point(793, 330);
            ratetxt.Margin = new System.Windows.Forms.Padding(5);
            ratetxt.Name = "ratetxt";
            ratetxt.Size = new System.Drawing.Size(208, 31);
            ratetxt.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(793, 302);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(182, 23);
            label17.TabIndex = 9;
            label17.Text = "AnnualInterestRate:";
            // 
            // monthtxt
            // 
            monthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            monthtxt.Location = new System.Drawing.Point(794, 237);
            monthtxt.Margin = new System.Windows.Forms.Padding(5);
            monthtxt.Name = "monthtxt";
            monthtxt.ReadOnly = true;
            monthtxt.Size = new System.Drawing.Size(207, 31);
            monthtxt.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(793, 209);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(154, 23);
            label18.TabIndex = 7;
            label18.Text = "PeriodInMonths:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(data_rate);
            groupBox5.Location = new System.Drawing.Point(100, 142);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(617, 350);
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
            data_rate.Location = new System.Drawing.Point(6, 27);
            data_rate.Name = "data_rate";
            data_rate.ReadOnly = true;
            data_rate.RowHeadersVisible = false;
            data_rate.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            data_rate.RowsDefaultCellStyle = dataGridViewCellStyle1;
            data_rate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            data_rate.Size = new System.Drawing.Size(605, 317);
            data_rate.TabIndex = 2;
            data_rate.CellClick += data_rate_CellClick;
            // 
            // StaffMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 755);
            Controls.Add(tabControlStaffMenu);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
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