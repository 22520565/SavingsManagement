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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
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
            tabPage3 = new System.Windows.Forms.TabPage();
            customerWithdrawBalanceTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawAmountNumeric = new System.Windows.Forms.NumericUpDown();
            customerWithdrawIdTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawButton = new System.Windows.Forms.Button();
            customerWithdrawContentTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawCicNumberTextBox = new System.Windows.Forms.TextBox();
            customerWithdrawNameTextBox = new System.Windows.Forms.TextBox();
            tabPageManageCustomers = new System.Windows.Forms.TabPage();
            dataGridViewCustomer = new System.Windows.Forms.DataGridView();
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
            customerWithdrawContentLabel = new System.Windows.Forms.Label();
            customerWithdrawAmountLabel = new System.Windows.Forms.Label();
            customerWithdrawCicNumberLabel = new System.Windows.Forms.Label();
            customerWithdrawNameLabel = new System.Windows.Forms.Label();
            customerWithdrawIdLabel = new System.Windows.Forms.Label();
            customerWithdrawBalanceLabel = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).BeginInit();
            tabPageManageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageManageStaffs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // customerWithdrawContentLabel
            // 
            customerWithdrawContentLabel.AutoSize = true;
            customerWithdrawContentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawContentLabel.Location = new System.Drawing.Point(105, 320);
            customerWithdrawContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawContentLabel.Name = "customerWithdrawContentLabel";
            customerWithdrawContentLabel.Size = new System.Drawing.Size(112, 33);
            customerWithdrawContentLabel.TabIndex = 5;
            customerWithdrawContentLabel.Text = "Content:";
            // 
            // customerWithdrawAmountLabel
            // 
            customerWithdrawAmountLabel.AutoSize = true;
            customerWithdrawAmountLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawAmountLabel.Location = new System.Drawing.Point(105, 262);
            customerWithdrawAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawAmountLabel.Name = "customerWithdrawAmountLabel";
            customerWithdrawAmountLabel.Size = new System.Drawing.Size(221, 33);
            customerWithdrawAmountLabel.TabIndex = 4;
            customerWithdrawAmountLabel.Text = "Withdraw amount:";
            // 
            // customerWithdrawCicNumberLabel
            // 
            customerWithdrawCicNumberLabel.AutoSize = true;
            customerWithdrawCicNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawCicNumberLabel.Location = new System.Drawing.Point(105, 160);
            customerWithdrawCicNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawCicNumberLabel.Name = "customerWithdrawCicNumberLabel";
            customerWithdrawCicNumberLabel.Size = new System.Drawing.Size(165, 33);
            customerWithdrawCicNumberLabel.TabIndex = 2;
            customerWithdrawCicNumberLabel.Text = "CIC Number:";
            // 
            // customerWithdrawNameLabel
            // 
            customerWithdrawNameLabel.AutoSize = true;
            customerWithdrawNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawNameLabel.Location = new System.Drawing.Point(105, 108);
            customerWithdrawNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawNameLabel.Name = "customerWithdrawNameLabel";
            customerWithdrawNameLabel.Size = new System.Drawing.Size(87, 33);
            customerWithdrawNameLabel.TabIndex = 1;
            customerWithdrawNameLabel.Text = "Name:";
            // 
            // customerWithdrawIdLabel
            // 
            customerWithdrawIdLabel.AutoSize = true;
            customerWithdrawIdLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawIdLabel.Location = new System.Drawing.Point(105, 50);
            customerWithdrawIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawIdLabel.Name = "customerWithdrawIdLabel";
            customerWithdrawIdLabel.Size = new System.Drawing.Size(165, 33);
            customerWithdrawIdLabel.TabIndex = 0;
            customerWithdrawIdLabel.Text = "Customer ID:";
            // 
            // customerWithdrawBalanceLabel
            // 
            customerWithdrawBalanceLabel.AutoSize = true;
            customerWithdrawBalanceLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerWithdrawBalanceLabel.Location = new System.Drawing.Point(105, 209);
            customerWithdrawBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerWithdrawBalanceLabel.Name = "customerWithdrawBalanceLabel";
            customerWithdrawBalanceLabel.Size = new System.Drawing.Size(112, 33);
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
            tabControl1.Size = new System.Drawing.Size(1578, 944);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 42);
            tabPage1.Margin = new System.Windows.Forms.Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2);
            tabPage1.Size = new System.Drawing.Size(1570, 898);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            tabPage2.Location = new System.Drawing.Point(4, 42);
            tabPage2.Margin = new System.Windows.Forms.Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(2);
            tabPage2.Size = new System.Drawing.Size(1570, 898);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deposit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customerDepositAmountNumeric
            // 
            customerDepositAmountNumeric.DecimalPlaces = 2;
            customerDepositAmountNumeric.Enabled = false;
            customerDepositAmountNumeric.Location = new System.Drawing.Point(454, 218);
            customerDepositAmountNumeric.Margin = new System.Windows.Forms.Padding(4);
            customerDepositAmountNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            customerDepositAmountNumeric.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            customerDepositAmountNumeric.Name = "customerDepositAmountNumeric";
            customerDepositAmountNumeric.Size = new System.Drawing.Size(379, 39);
            customerDepositAmountNumeric.TabIndex = 6;
            customerDepositAmountNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // customerDepositIdTextBox
            // 
            customerDepositIdTextBox.Location = new System.Drawing.Point(454, 51);
            customerDepositIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerDepositIdTextBox.MaxLength = 10;
            customerDepositIdTextBox.Name = "customerDepositIdTextBox";
            customerDepositIdTextBox.Size = new System.Drawing.Size(378, 39);
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
            customerDepositButton.Location = new System.Drawing.Point(751, 406);
            customerDepositButton.Margin = new System.Windows.Forms.Padding(4);
            customerDepositButton.Name = "customerDepositButton";
            customerDepositButton.Size = new System.Drawing.Size(112, 43);
            customerDepositButton.TabIndex = 5;
            customerDepositButton.Text = "Deposit";
            customerDepositButton.UseVisualStyleBackColor = true;
            customerDepositButton.Click += customerDepositButton_Click;
            // 
            // customerDepositContentTextBox
            // 
            customerDepositContentTextBox.Enabled = false;
            customerDepositContentTextBox.Location = new System.Drawing.Point(85, 328);
            customerDepositContentTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerDepositContentTextBox.Name = "customerDepositContentTextBox";
            customerDepositContentTextBox.Size = new System.Drawing.Size(746, 39);
            customerDepositContentTextBox.TabIndex = 4;
            customerDepositContentTextBox.TextChanged += customerDepositContentTextBox_TextChanged;
            // 
            // customerDepositContentLabel
            // 
            customerDepositContentLabel.AutoSize = true;
            customerDepositContentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositContentLabel.Location = new System.Drawing.Point(85, 278);
            customerDepositContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositContentLabel.Name = "customerDepositContentLabel";
            customerDepositContentLabel.Size = new System.Drawing.Size(112, 33);
            customerDepositContentLabel.TabIndex = 4;
            customerDepositContentLabel.Text = "Content:";
            // 
            // customerDepositAmountLabel
            // 
            customerDepositAmountLabel.AutoSize = true;
            customerDepositAmountLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositAmountLabel.Location = new System.Drawing.Point(85, 220);
            customerDepositAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositAmountLabel.Name = "customerDepositAmountLabel";
            customerDepositAmountLabel.Size = new System.Drawing.Size(199, 33);
            customerDepositAmountLabel.TabIndex = 3;
            customerDepositAmountLabel.Text = "Deposit amount:";
            // 
            // customerDepositCicNumberTextBox
            // 
            customerDepositCicNumberTextBox.Location = new System.Drawing.Point(454, 160);
            customerDepositCicNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerDepositCicNumberTextBox.Name = "customerDepositCicNumberTextBox";
            customerDepositCicNumberTextBox.ReadOnly = true;
            customerDepositCicNumberTextBox.Size = new System.Drawing.Size(378, 39);
            customerDepositCicNumberTextBox.TabIndex = 2;
            // 
            // customerDepositCicNumberLabel
            // 
            customerDepositCicNumberLabel.AutoSize = true;
            customerDepositCicNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositCicNumberLabel.Location = new System.Drawing.Point(85, 165);
            customerDepositCicNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositCicNumberLabel.Name = "customerDepositCicNumberLabel";
            customerDepositCicNumberLabel.Size = new System.Drawing.Size(165, 33);
            customerDepositCicNumberLabel.TabIndex = 2;
            customerDepositCicNumberLabel.Text = "CIC Number:";
            // 
            // customerDepositNameTextBox
            // 
            customerDepositNameTextBox.Location = new System.Drawing.Point(454, 108);
            customerDepositNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerDepositNameTextBox.Name = "customerDepositNameTextBox";
            customerDepositNameTextBox.ReadOnly = true;
            customerDepositNameTextBox.Size = new System.Drawing.Size(378, 39);
            customerDepositNameTextBox.TabIndex = 1;
            // 
            // customerDepositNameLabel
            // 
            customerDepositNameLabel.AutoSize = true;
            customerDepositNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositNameLabel.Location = new System.Drawing.Point(85, 112);
            customerDepositNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositNameLabel.Name = "customerDepositNameLabel";
            customerDepositNameLabel.Size = new System.Drawing.Size(87, 33);
            customerDepositNameLabel.TabIndex = 1;
            customerDepositNameLabel.Text = "Name:";
            // 
            // customerDepositIdLabel
            // 
            customerDepositIdLabel.AutoSize = true;
            customerDepositIdLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            customerDepositIdLabel.Location = new System.Drawing.Point(85, 55);
            customerDepositIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerDepositIdLabel.Name = "customerDepositIdLabel";
            customerDepositIdLabel.Size = new System.Drawing.Size(165, 33);
            customerDepositIdLabel.TabIndex = 0;
            customerDepositIdLabel.Text = "Customer ID:";
            // 
            // tabPage3
            // 
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
            tabPage3.Location = new System.Drawing.Point(4, 42);
            tabPage3.Margin = new System.Windows.Forms.Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1570, 898);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Withdraw";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // customerWithdrawBalanceTextBox
            // 
            customerWithdrawBalanceTextBox.Location = new System.Drawing.Point(474, 205);
            customerWithdrawBalanceTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawBalanceTextBox.Name = "customerWithdrawBalanceTextBox";
            customerWithdrawBalanceTextBox.ReadOnly = true;
            customerWithdrawBalanceTextBox.Size = new System.Drawing.Size(378, 39);
            customerWithdrawBalanceTextBox.TabIndex = 3;
            // 
            // customerWithdrawAmountNumeric
            // 
            customerWithdrawAmountNumeric.DecimalPlaces = 2;
            customerWithdrawAmountNumeric.Enabled = false;
            customerWithdrawAmountNumeric.Location = new System.Drawing.Point(474, 260);
            customerWithdrawAmountNumeric.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawAmountNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            customerWithdrawAmountNumeric.Name = "customerWithdrawAmountNumeric";
            customerWithdrawAmountNumeric.Size = new System.Drawing.Size(379, 39);
            customerWithdrawAmountNumeric.TabIndex = 4;
            // 
            // customerWithdrawIdTextBox
            // 
            customerWithdrawIdTextBox.Location = new System.Drawing.Point(474, 46);
            customerWithdrawIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawIdTextBox.MaxLength = 0;
            customerWithdrawIdTextBox.Name = "customerWithdrawIdTextBox";
            customerWithdrawIdTextBox.Size = new System.Drawing.Size(378, 39);
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
            customerWithdrawButton.Location = new System.Drawing.Point(771, 449);
            customerWithdrawButton.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawButton.Name = "customerWithdrawButton";
            customerWithdrawButton.Size = new System.Drawing.Size(134, 43);
            customerWithdrawButton.TabIndex = 6;
            customerWithdrawButton.Text = "Withdraw";
            customerWithdrawButton.UseVisualStyleBackColor = true;
            customerWithdrawButton.Click += customerWithdrawButton_Click;
            // 
            // customerWithdrawContentTextBox
            // 
            customerWithdrawContentTextBox.Enabled = false;
            customerWithdrawContentTextBox.Location = new System.Drawing.Point(105, 370);
            customerWithdrawContentTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawContentTextBox.Name = "customerWithdrawContentTextBox";
            customerWithdrawContentTextBox.Size = new System.Drawing.Size(746, 39);
            customerWithdrawContentTextBox.TabIndex = 5;
            customerWithdrawContentTextBox.TextChanged += customerWithdrawContentTextBox_TextChanged;
            // 
            // customerWithdrawCicNumberTextBox
            // 
            customerWithdrawCicNumberTextBox.Location = new System.Drawing.Point(474, 155);
            customerWithdrawCicNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawCicNumberTextBox.Name = "customerWithdrawCicNumberTextBox";
            customerWithdrawCicNumberTextBox.ReadOnly = true;
            customerWithdrawCicNumberTextBox.Size = new System.Drawing.Size(378, 39);
            customerWithdrawCicNumberTextBox.TabIndex = 2;
            // 
            // customerWithdrawNameTextBox
            // 
            customerWithdrawNameTextBox.Location = new System.Drawing.Point(474, 102);
            customerWithdrawNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            customerWithdrawNameTextBox.Name = "customerWithdrawNameTextBox";
            customerWithdrawNameTextBox.ReadOnly = true;
            customerWithdrawNameTextBox.Size = new System.Drawing.Size(378, 39);
            customerWithdrawNameTextBox.TabIndex = 1;
            // 
            // tabPageManageCustomers
            // 
            tabPageManageCustomers.Controls.Add(dataGridViewCustomer);
            tabPageManageCustomers.Controls.Add(groupBox2);
            tabPageManageCustomers.Controls.Add(groupBox1);
            tabPageManageCustomers.Location = new System.Drawing.Point(4, 42);
            tabPageManageCustomers.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageCustomers.Name = "tabPageManageCustomers";
            tabPageManageCustomers.Size = new System.Drawing.Size(1570, 898);
            tabPageManageCustomers.TabIndex = 5;
            tabPageManageCustomers.Text = "Customer Management";
            tabPageManageCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCustomer.Location = new System.Drawing.Point(0, 466);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new System.Drawing.Size(1570, 432);
            dataGridViewCustomer.TabIndex = 2;
            dataGridViewCustomer.CellContentClick += customerDataGridView_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(enableCustomerBtn);
            groupBox2.Controls.Add(clearScreenCustomerBtn);
            groupBox2.Controls.Add(disableCustomerBtn);
            groupBox2.Controls.Add(saveCustomerBtn);
            groupBox2.Controls.Add(addCustomerBtn);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(0, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1570, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control button";
            // 
            // enableCustomerBtn
            // 
            enableCustomerBtn.AutoSize = true;
            enableCustomerBtn.Location = new System.Drawing.Point(546, 56);
            enableCustomerBtn.Name = "enableCustomerBtn";
            enableCustomerBtn.Size = new System.Drawing.Size(112, 43);
            enableCustomerBtn.TabIndex = 4;
            enableCustomerBtn.Text = "Enable";
            enableCustomerBtn.UseVisualStyleBackColor = true;
            enableCustomerBtn.Click += enableCustomerBtn_Click;
            // 
            // clearScreenCustomerBtn
            // 
            clearScreenCustomerBtn.AutoSize = true;
            clearScreenCustomerBtn.Location = new System.Drawing.Point(702, 56);
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
            disableCustomerBtn.Location = new System.Drawing.Point(385, 56);
            disableCustomerBtn.Name = "disableCustomerBtn";
            disableCustomerBtn.Size = new System.Drawing.Size(112, 43);
            disableCustomerBtn.TabIndex = 2;
            disableCustomerBtn.Text = "Disable";
            disableCustomerBtn.UseVisualStyleBackColor = true;
            disableCustomerBtn.Click += disableCustomerBtn_Click;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.AutoSize = true;
            saveCustomerBtn.Location = new System.Drawing.Point(218, 56);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new System.Drawing.Size(112, 43);
            saveCustomerBtn.TabIndex = 1;
            saveCustomerBtn.Text = "Save";
            saveCustomerBtn.UseVisualStyleBackColor = true;
            saveCustomerBtn.Click += saveCustomerBtn_Click;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.AutoSize = true;
            addCustomerBtn.Location = new System.Drawing.Point(55, 56);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new System.Drawing.Size(112, 43);
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
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1570, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // customerBalanceTextBox
            // 
            customerBalanceTextBox.Location = new System.Drawing.Point(1226, 213);
            customerBalanceTextBox.Name = "customerBalanceTextBox";
            customerBalanceTextBox.Size = new System.Drawing.Size(318, 39);
            customerBalanceTextBox.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(1101, 219);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(119, 33);
            label10.TabIndex = 20;
            label10.Text = "Balance: ";
            // 
            // customerDisableCheckBox
            // 
            customerDisableCheckBox.AutoSize = true;
            customerDisableCheckBox.Location = new System.Drawing.Point(1101, 289);
            customerDisableCheckBox.Name = "customerDisableCheckBox";
            customerDisableCheckBox.Size = new System.Drawing.Size(126, 37);
            customerDisableCheckBox.TabIndex = 19;
            customerDisableCheckBox.Text = "Disable";
            customerDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerBirthDateTimePicker
            // 
            customerBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            customerBirthDateTimePicker.Location = new System.Drawing.Point(641, 131);
            customerBirthDateTimePicker.Name = "customerBirthDateTimePicker";
            customerBirthDateTimePicker.Size = new System.Drawing.Size(409, 39);
            customerBirthDateTimePicker.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(470, 134);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(165, 33);
            label9.TabIndex = 17;
            label9.Text = "Date of birth:";
            // 
            // customerMaleCheckBox
            // 
            customerMaleCheckBox.AutoSize = true;
            customerMaleCheckBox.Location = new System.Drawing.Point(1101, 38);
            customerMaleCheckBox.Name = "customerMaleCheckBox";
            customerMaleCheckBox.Size = new System.Drawing.Size(98, 37);
            customerMaleCheckBox.TabIndex = 16;
            customerMaleCheckBox.Text = "Male";
            customerMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerHashedPasswordTextBox
            // 
            customerHashedPasswordTextBox.Location = new System.Drawing.Point(687, 287);
            customerHashedPasswordTextBox.Name = "customerHashedPasswordTextBox";
            customerHashedPasswordTextBox.Size = new System.Drawing.Size(363, 39);
            customerHashedPasswordTextBox.TabIndex = 15;
            customerHashedPasswordTextBox.KeyPress += customerHashedPasswordTextBox_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(470, 293);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(211, 33);
            label8.TabIndex = 14;
            label8.Text = "HashedPassword:";
            // 
            // customerUsernameTextBox
            // 
            customerUsernameTextBox.Location = new System.Drawing.Point(192, 287);
            customerUsernameTextBox.Name = "customerUsernameTextBox";
            customerUsernameTextBox.Size = new System.Drawing.Size(218, 39);
            customerUsernameTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(47, 293);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(139, 33);
            label7.TabIndex = 12;
            label7.Text = "Username: ";
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.Location = new System.Drawing.Point(578, 219);
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.Size = new System.Drawing.Size(472, 39);
            customerEmailTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(470, 222);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 33);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Location = new System.Drawing.Point(173, 216);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new System.Drawing.Size(237, 39);
            customerAddressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(47, 219);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 33);
            label5.TabIndex = 8;
            label5.Text = "Address: ";
            // 
            // customerPhoneNumberTextBox
            // 
            customerPhoneNumberTextBox.Location = new System.Drawing.Point(1287, 128);
            customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            customerPhoneNumberTextBox.Size = new System.Drawing.Size(257, 39);
            customerPhoneNumberTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1100, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(181, 33);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // customerCicNumberTextBox
            // 
            customerCicNumberTextBox.Location = new System.Drawing.Point(196, 128);
            customerCicNumberTextBox.Name = "customerCicNumberTextBox";
            customerCicNumberTextBox.Size = new System.Drawing.Size(214, 39);
            customerCicNumberTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 131);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 33);
            label3.TabIndex = 4;
            label3.Text = "CicNumber:";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new System.Drawing.Point(563, 48);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new System.Drawing.Size(487, 39);
            customerNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(470, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 33);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new System.Drawing.Point(98, 48);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new System.Drawing.Size(312, 39);
            customerIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 33);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // tabPageManageStaffs
            // 
            tabPageManageStaffs.Controls.Add(dataGridViewStaff);
            tabPageManageStaffs.Controls.Add(groupBox4);
            tabPageManageStaffs.Controls.Add(groupBox3);
            tabPageManageStaffs.Location = new System.Drawing.Point(4, 42);
            tabPageManageStaffs.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageStaffs.Name = "tabPageManageStaffs";
            tabPageManageStaffs.Size = new System.Drawing.Size(1570, 898);
            tabPageManageStaffs.TabIndex = 3;
            tabPageManageStaffs.Text = "Staff Management";
            tabPageManageStaffs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewStaff.Location = new System.Drawing.Point(0, 423);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersWidth = 62;
            dataGridViewStaff.Size = new System.Drawing.Size(1570, 475);
            dataGridViewStaff.TabIndex = 2;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(enableStaffBtn);
            groupBox4.Controls.Add(clearScreenStaffBtn);
            groupBox4.Controls.Add(disableStaffBtn);
            groupBox4.Controls.Add(saveStaffBtn);
            groupBox4.Controls.Add(addStaffBtn);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox4.Location = new System.Drawing.Point(0, 296);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(1570, 127);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Control Button";
            // 
            // enableStaffBtn
            // 
            enableStaffBtn.AutoSize = true;
            enableStaffBtn.Location = new System.Drawing.Point(584, 55);
            enableStaffBtn.Name = "enableStaffBtn";
            enableStaffBtn.Size = new System.Drawing.Size(112, 43);
            enableStaffBtn.TabIndex = 4;
            enableStaffBtn.Text = "Enable";
            enableStaffBtn.UseVisualStyleBackColor = true;
            enableStaffBtn.Click += enableStaffBtn_Click;
            // 
            // clearScreenStaffBtn
            // 
            clearScreenStaffBtn.AutoSize = true;
            clearScreenStaffBtn.Location = new System.Drawing.Point(735, 55);
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
            disableStaffBtn.Location = new System.Drawing.Point(422, 55);
            disableStaffBtn.Name = "disableStaffBtn";
            disableStaffBtn.Size = new System.Drawing.Size(112, 43);
            disableStaffBtn.TabIndex = 2;
            disableStaffBtn.Text = "Disable";
            disableStaffBtn.UseVisualStyleBackColor = true;
            disableStaffBtn.Click += disableStaffBtn_Click;
            // 
            // saveStaffBtn
            // 
            saveStaffBtn.AutoSize = true;
            saveStaffBtn.Location = new System.Drawing.Point(245, 55);
            saveStaffBtn.Name = "saveStaffBtn";
            saveStaffBtn.Size = new System.Drawing.Size(112, 43);
            saveStaffBtn.TabIndex = 1;
            saveStaffBtn.Text = "Save";
            saveStaffBtn.UseVisualStyleBackColor = true;
            saveStaffBtn.Click += saveStaffBtn_Click;
            // 
            // addStaffBtn
            // 
            addStaffBtn.AutoSize = true;
            addStaffBtn.Location = new System.Drawing.Point(70, 55);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.Size = new System.Drawing.Size(112, 43);
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
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(1570, 296);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Staff Information";
            // 
            // staffDisableCheckBox
            // 
            staffDisableCheckBox.AutoSize = true;
            staffDisableCheckBox.Location = new System.Drawing.Point(1146, 130);
            staffDisableCheckBox.Name = "staffDisableCheckBox";
            staffDisableCheckBox.Size = new System.Drawing.Size(126, 37);
            staffDisableCheckBox.TabIndex = 13;
            staffDisableCheckBox.Text = "Disable";
            staffDisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffMaleCheckBox
            // 
            staffMaleCheckBox.AutoSize = true;
            staffMaleCheckBox.Location = new System.Drawing.Point(1146, 51);
            staffMaleCheckBox.Name = "staffMaleCheckBox";
            staffMaleCheckBox.Size = new System.Drawing.Size(98, 37);
            staffMaleCheckBox.TabIndex = 12;
            staffMaleCheckBox.Text = "Male";
            staffMaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffPermissionIdComboBox
            // 
            staffPermissionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            staffPermissionIdComboBox.FormattingEnabled = true;
            staffPermissionIdComboBox.Items.AddRange(new object[] { "1 - Admin", "2 - Staff" });
            staffPermissionIdComboBox.Location = new System.Drawing.Point(691, 126);
            staffPermissionIdComboBox.Name = "staffPermissionIdComboBox";
            staffPermissionIdComboBox.Size = new System.Drawing.Size(376, 41);
            staffPermissionIdComboBox.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(499, 129);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(168, 33);
            label16.TabIndex = 10;
            label16.Text = "PermissionId:";
            // 
            // staffHashedPasswordTextBox
            // 
            staffHashedPasswordTextBox.Location = new System.Drawing.Point(716, 210);
            staffHashedPasswordTextBox.Name = "staffHashedPasswordTextBox";
            staffHashedPasswordTextBox.Size = new System.Drawing.Size(790, 39);
            staffHashedPasswordTextBox.TabIndex = 9;
            staffHashedPasswordTextBox.KeyPress += staffHashedPasswordTextBox_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(499, 213);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(211, 33);
            label15.TabIndex = 8;
            label15.Text = "HashedPassword:";
            // 
            // staffUsernameTextBox
            // 
            staffUsernameTextBox.Location = new System.Drawing.Point(188, 210);
            staffUsernameTextBox.Name = "staffUsernameTextBox";
            staffUsernameTextBox.Size = new System.Drawing.Size(253, 39);
            staffUsernameTextBox.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(50, 213);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(132, 33);
            label14.TabIndex = 6;
            label14.Text = "Username:";
            // 
            // staffPositionTextBox
            // 
            staffPositionTextBox.Location = new System.Drawing.Point(172, 126);
            staffPositionTextBox.Name = "staffPositionTextBox";
            staffPositionTextBox.Size = new System.Drawing.Size(269, 39);
            staffPositionTextBox.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(50, 129);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(116, 33);
            label13.TabIndex = 4;
            label13.Text = "Position:";
            // 
            // staffNameTextBox
            // 
            staffNameTextBox.Location = new System.Drawing.Point(599, 49);
            staffNameTextBox.Name = "staffNameTextBox";
            staffNameTextBox.Size = new System.Drawing.Size(468, 39);
            staffNameTextBox.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(499, 55);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(94, 33);
            label12.TabIndex = 2;
            label12.Text = "Name: ";
            // 
            // staffIdTextBox
            // 
            staffIdTextBox.Location = new System.Drawing.Point(101, 53);
            staffIdTextBox.Name = "staffIdTextBox";
            staffIdTextBox.Size = new System.Drawing.Size(340, 39);
            staffIdTextBox.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(50, 56);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(45, 33);
            label11.TabIndex = 0;
            label11.Text = "Id:";
            // 
            // tabPageChangeRegulations
            // 
            tabPageChangeRegulations.Location = new System.Drawing.Point(4, 42);
            tabPageChangeRegulations.Margin = new System.Windows.Forms.Padding(2);
            tabPageChangeRegulations.Name = "tabPageChangeRegulations";
            tabPageChangeRegulations.Size = new System.Drawing.Size(1570, 898);
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
            Margin = new System.Windows.Forms.Padding(2);
            Name = "StaffMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StaffMenuForm";
            FormClosing += StaffMenuForm_FormClosing;
            Load += StaffMenuForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).EndInit();
            tabPageManageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageManageStaffs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
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
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Button clearScreenStaffBtn;
        private System.Windows.Forms.Button disableStaffBtn;
        private System.Windows.Forms.Button saveStaffBtn;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button enableCustomerBtn;
        private System.Windows.Forms.Button enableStaffBtn;
    }
}