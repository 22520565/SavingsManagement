using System.Windows.Forms;

namespace GraphicalUserInterface
{
    partial class CustomerMenuForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			tabControl1 = new TabControl();
			tabInformation = new TabPage();
			gbInfo = new GroupBox();
			customerNameTextBox = new TextBox();
			customerNameLabel = new Label();
			customerBirthdayTextBox = new TextBox();
			customerAddressTextBox = new TextBox();
			customerAddressLabel = new Label();
			customerBirthdayLabel = new Label();
			customerPhoneNumberLabel = new Label();
			customerEmailTextBox = new TextBox();
			customerEmailLabel = new Label();
			customerPhoneNumberTextBox = new TextBox();
			customerGenderTextBox = new TextBox();
			customerGenderLabel = new Label();
			gbFunction = new GroupBox();
			btnChangeInfo = new Button();
			customerChangePasswordButton = new Button();
			gbAccount = new GroupBox();
			customerUsernameTextBox = new TextBox();
			customerUsernameLabel = new Label();
			customerBalanceTextBox = new TextBox();
			customerCicNumberTextBox = new TextBox();
			customerCicNumberLabel = new Label();
			customerIdTextBox = new TextBox();
			customerIdLabel = new Label();
			customerBalanceLabel = new Label();
			tabPage2 = new TabPage();
			savingTabControl = new TabControl();
			detailsTabPage = new TabPage();
			exportDetailsButton = new Button();
			maturityDayDetailsTextBox = new TextBox();
			openDayDetailsTextBox = new TextBox();
			interestDetailsTextBox = new TextBox();
			periodDetailsTextBox = new TextBox();
			balanceDetailsTextBox = new TextBox();
			label5 = new Label();
			closeSavingDetailsButton = new Button();
			openDayDetailsLabel = new Label();
			interestDetailsLabel = new Label();
			periodDetailsLabel = new Label();
			balanceDetailsLabel = new Label();
			savingDetailsComboBox = new ComboBox();
			savingsDetailsLabel = new Label();
			openingTabPage = new TabPage();
			maturityDayOpeningTextBox = new TextBox();
			interestOpeningTextBox = new TextBox();
			balanceOpeningTextBox = new TextBox();
			maturityDayOpeningLabel = new Label();
			interestOpeningLabel = new Label();
			openingSavingOpeningButton = new Button();
			amountOpeningNumeric = new NumericUpDown();
			amountOpeningLabel = new Label();
			periodOpeningLabel = new Label();
			periodOpeningComboBox = new ComboBox();
			balanceOpeningLabel = new Label();
			closingTabPage = new TabPage();
			maturityDayClosingTextBox = new TextBox();
			amountToGetClosingTextBox = new TextBox();
			balanceClosingTextBox = new TextBox();
			maturityDayClosingLabel = new Label();
			closingSavingClosingButton = new Button();
			amountToGetClosingLabel = new Label();
			balanceClosingLabel = new Label();
			savingClosingComboBox = new ComboBox();
			savingClosingLabel = new Label();
			tabStatistical = new TabPage();
			groupBoxFunction = new GroupBox();
			btnExport = new Button();
			groupBoxTransactionList = new GroupBox();
			data_Transactions = new DataGridView();
			groupBoxStats = new GroupBox();
			panelSavings = new GradientPanel();
			pictureBox1 = new PictureBox();
			lbSavings = new Label();
			label2 = new Label();
			panelExpenses = new GradientPanel();
			pictureBox2 = new PictureBox();
			lbExpenses = new Label();
			label8 = new Label();
			tabControl1.SuspendLayout();
			tabInformation.SuspendLayout();
			gbInfo.SuspendLayout();
			gbFunction.SuspendLayout();
			gbAccount.SuspendLayout();
			tabPage2.SuspendLayout();
			savingTabControl.SuspendLayout();
			detailsTabPage.SuspendLayout();
			openingTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)amountOpeningNumeric).BeginInit();
			closingTabPage.SuspendLayout();
			tabStatistical.SuspendLayout();
			groupBoxFunction.SuspendLayout();
			groupBoxTransactionList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)data_Transactions).BeginInit();
			groupBoxStats.SuspendLayout();
			panelSavings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panelExpenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Appearance = TabAppearance.Buttons;
			tabControl1.Controls.Add(tabInformation);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabStatistical);
			tabControl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			tabControl1.Location = new System.Drawing.Point(1, 1);
			tabControl1.Multiline = true;
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new System.Drawing.Size(1149, 761);
			tabControl1.TabIndex = 1;
			// 
			// tabInformation
			// 
			tabInformation.Controls.Add(gbInfo);
			tabInformation.Controls.Add(gbFunction);
			tabInformation.Controls.Add(gbAccount);
			tabInformation.Location = new System.Drawing.Point(4, 35);
			tabInformation.Name = "tabInformation";
			tabInformation.Padding = new Padding(3);
			tabInformation.Size = new System.Drawing.Size(1141, 722);
			tabInformation.TabIndex = 0;
			tabInformation.Text = "Information";
			tabInformation.UseVisualStyleBackColor = true;
			// 
			// gbInfo
			// 
			gbInfo.BackColor = System.Drawing.Color.Honeydew;
			gbInfo.Controls.Add(customerNameTextBox);
			gbInfo.Controls.Add(customerNameLabel);
			gbInfo.Controls.Add(customerBirthdayTextBox);
			gbInfo.Controls.Add(customerAddressTextBox);
			gbInfo.Controls.Add(customerAddressLabel);
			gbInfo.Controls.Add(customerBirthdayLabel);
			gbInfo.Controls.Add(customerPhoneNumberLabel);
			gbInfo.Controls.Add(customerEmailTextBox);
			gbInfo.Controls.Add(customerEmailLabel);
			gbInfo.Controls.Add(customerPhoneNumberTextBox);
			gbInfo.Controls.Add(customerGenderTextBox);
			gbInfo.Controls.Add(customerGenderLabel);
			gbInfo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			gbInfo.Location = new System.Drawing.Point(30, 43);
			gbInfo.Name = "gbInfo";
			gbInfo.Size = new System.Drawing.Size(555, 592);
			gbInfo.TabIndex = 17;
			gbInfo.TabStop = false;
			gbInfo.Text = "Information";
			// 
			// customerNameTextBox
			// 
			customerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerNameTextBox.Location = new System.Drawing.Point(207, 69);
			customerNameTextBox.Name = "customerNameTextBox";
			customerNameTextBox.ReadOnly = true;
			customerNameTextBox.Size = new System.Drawing.Size(308, 34);
			customerNameTextBox.TabIndex = 1;
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Location = new System.Drawing.Point(98, 69);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(75, 27);
			customerNameLabel.TabIndex = 1;
			customerNameLabel.Text = "Name:";
			// 
			// customerBirthdayTextBox
			// 
			customerBirthdayTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerBirthdayTextBox.Location = new System.Drawing.Point(207, 135);
			customerBirthdayTextBox.Name = "customerBirthdayTextBox";
			customerBirthdayTextBox.ReadOnly = true;
			customerBirthdayTextBox.Size = new System.Drawing.Size(308, 34);
			customerBirthdayTextBox.TabIndex = 4;
			// 
			// customerAddressTextBox
			// 
			customerAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerAddressTextBox.Location = new System.Drawing.Point(207, 399);
			customerAddressTextBox.Name = "customerAddressTextBox";
			customerAddressTextBox.ReadOnly = true;
			customerAddressTextBox.Size = new System.Drawing.Size(308, 34);
			customerAddressTextBox.TabIndex = 7;
			// 
			// customerAddressLabel
			// 
			customerAddressLabel.AutoSize = true;
			customerAddressLabel.Location = new System.Drawing.Point(79, 401);
			customerAddressLabel.Name = "customerAddressLabel";
			customerAddressLabel.Size = new System.Drawing.Size(99, 27);
			customerAddressLabel.TabIndex = 7;
			customerAddressLabel.Text = "Address:";
			// 
			// customerBirthdayLabel
			// 
			customerBirthdayLabel.AutoSize = true;
			customerBirthdayLabel.Location = new System.Drawing.Point(74, 137);
			customerBirthdayLabel.Name = "customerBirthdayLabel";
			customerBirthdayLabel.Size = new System.Drawing.Size(105, 27);
			customerBirthdayLabel.TabIndex = 4;
			customerBirthdayLabel.Text = "Birthday:";
			// 
			// customerPhoneNumberLabel
			// 
			customerPhoneNumberLabel.AutoSize = true;
			customerPhoneNumberLabel.Location = new System.Drawing.Point(20, 335);
			customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
			customerPhoneNumberLabel.Size = new System.Drawing.Size(167, 27);
			customerPhoneNumberLabel.TabIndex = 5;
			customerPhoneNumberLabel.Text = "Phone Number:";
			// 
			// customerEmailTextBox
			// 
			customerEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerEmailTextBox.Location = new System.Drawing.Point(207, 201);
			customerEmailTextBox.Name = "customerEmailTextBox";
			customerEmailTextBox.ReadOnly = true;
			customerEmailTextBox.Size = new System.Drawing.Size(308, 34);
			customerEmailTextBox.TabIndex = 6;
			// 
			// customerEmailLabel
			// 
			customerEmailLabel.AutoSize = true;
			customerEmailLabel.Location = new System.Drawing.Point(99, 205);
			customerEmailLabel.Name = "customerEmailLabel";
			customerEmailLabel.Size = new System.Drawing.Size(73, 27);
			customerEmailLabel.TabIndex = 6;
			customerEmailLabel.Text = "Email:";
			// 
			// customerPhoneNumberTextBox
			// 
			customerPhoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerPhoneNumberTextBox.Location = new System.Drawing.Point(207, 333);
			customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
			customerPhoneNumberTextBox.ReadOnly = true;
			customerPhoneNumberTextBox.Size = new System.Drawing.Size(308, 34);
			customerPhoneNumberTextBox.TabIndex = 5;
			// 
			// customerGenderTextBox
			// 
			customerGenderTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerGenderTextBox.Location = new System.Drawing.Point(207, 267);
			customerGenderTextBox.Name = "customerGenderTextBox";
			customerGenderTextBox.ReadOnly = true;
			customerGenderTextBox.Size = new System.Drawing.Size(162, 34);
			customerGenderTextBox.TabIndex = 2;
			// 
			// customerGenderLabel
			// 
			customerGenderLabel.AutoSize = true;
			customerGenderLabel.Location = new System.Drawing.Point(87, 269);
			customerGenderLabel.Name = "customerGenderLabel";
			customerGenderLabel.Size = new System.Drawing.Size(90, 27);
			customerGenderLabel.TabIndex = 2;
			customerGenderLabel.Text = "Gender:";
			// 
			// gbFunction
			// 
			gbFunction.BackColor = System.Drawing.Color.Honeydew;
			gbFunction.Controls.Add(btnChangeInfo);
			gbFunction.Controls.Add(customerChangePasswordButton);
			gbFunction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			gbFunction.Location = new System.Drawing.Point(623, 407);
			gbFunction.Name = "gbFunction";
			gbFunction.Size = new System.Drawing.Size(486, 228);
			gbFunction.TabIndex = 16;
			gbFunction.TabStop = false;
			gbFunction.Text = "Function";
			// 
			// btnChangeInfo
			// 
			btnChangeInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnChangeInfo.BackColor = System.Drawing.Color.DarkCyan;
			btnChangeInfo.Cursor = Cursors.Hand;
			btnChangeInfo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnChangeInfo.ForeColor = System.Drawing.Color.White;
			btnChangeInfo.Location = new System.Drawing.Point(118, 53);
			btnChangeInfo.Name = "btnChangeInfo";
			btnChangeInfo.Padding = new Padding(5);
			btnChangeInfo.Size = new System.Drawing.Size(255, 66);
			btnChangeInfo.TabIndex = 11;
			btnChangeInfo.Text = "Change Infomation";
			btnChangeInfo.UseVisualStyleBackColor = false;
			btnChangeInfo.Click += button1_Click;
			// 
			// customerChangePasswordButton
			// 
			customerChangePasswordButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			customerChangePasswordButton.BackColor = System.Drawing.Color.DarkCyan;
			customerChangePasswordButton.Cursor = Cursors.Hand;
			customerChangePasswordButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			customerChangePasswordButton.ForeColor = System.Drawing.Color.White;
			customerChangePasswordButton.Location = new System.Drawing.Point(118, 138);
			customerChangePasswordButton.Name = "customerChangePasswordButton";
			customerChangePasswordButton.Padding = new Padding(5);
			customerChangePasswordButton.Size = new System.Drawing.Size(255, 62);
			customerChangePasswordButton.TabIndex = 10;
			customerChangePasswordButton.Text = "Change Password";
			customerChangePasswordButton.UseVisualStyleBackColor = false;
			customerChangePasswordButton.Click += customerChangePasswordButton_Click;
			// 
			// gbAccount
			// 
			gbAccount.BackColor = System.Drawing.Color.Honeydew;
			gbAccount.Controls.Add(customerUsernameTextBox);
			gbAccount.Controls.Add(customerUsernameLabel);
			gbAccount.Controls.Add(customerBalanceTextBox);
			gbAccount.Controls.Add(customerCicNumberTextBox);
			gbAccount.Controls.Add(customerCicNumberLabel);
			gbAccount.Controls.Add(customerIdTextBox);
			gbAccount.Controls.Add(customerIdLabel);
			gbAccount.Controls.Add(customerBalanceLabel);
			gbAccount.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			gbAccount.Location = new System.Drawing.Point(623, 43);
			gbAccount.Name = "gbAccount";
			gbAccount.Size = new System.Drawing.Size(486, 332);
			gbAccount.TabIndex = 15;
			gbAccount.TabStop = false;
			gbAccount.Text = "Account";
			// 
			// customerUsernameTextBox
			// 
			customerUsernameTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerUsernameTextBox.Location = new System.Drawing.Point(181, 135);
			customerUsernameTextBox.Name = "customerUsernameTextBox";
			customerUsernameTextBox.ReadOnly = true;
			customerUsernameTextBox.Size = new System.Drawing.Size(270, 34);
			customerUsernameTextBox.TabIndex = 8;
			// 
			// customerUsernameLabel
			// 
			customerUsernameLabel.AutoSize = true;
			customerUsernameLabel.Location = new System.Drawing.Point(32, 137);
			customerUsernameLabel.Name = "customerUsernameLabel";
			customerUsernameLabel.Size = new System.Drawing.Size(118, 27);
			customerUsernameLabel.TabIndex = 8;
			customerUsernameLabel.Text = "Username:";
			// 
			// customerBalanceTextBox
			// 
			customerBalanceTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerBalanceTextBox.Location = new System.Drawing.Point(181, 201);
			customerBalanceTextBox.Name = "customerBalanceTextBox";
			customerBalanceTextBox.ReadOnly = true;
			customerBalanceTextBox.Size = new System.Drawing.Size(270, 34);
			customerBalanceTextBox.TabIndex = 9;
			// 
			// customerCicNumberTextBox
			// 
			customerCicNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerCicNumberTextBox.Location = new System.Drawing.Point(181, 261);
			customerCicNumberTextBox.Name = "customerCicNumberTextBox";
			customerCicNumberTextBox.ReadOnly = true;
			customerCicNumberTextBox.Size = new System.Drawing.Size(270, 34);
			customerCicNumberTextBox.TabIndex = 3;
			// 
			// customerCicNumberLabel
			// 
			customerCicNumberLabel.AutoSize = true;
			customerCicNumberLabel.Location = new System.Drawing.Point(17, 263);
			customerCicNumberLabel.Name = "customerCicNumberLabel";
			customerCicNumberLabel.Size = new System.Drawing.Size(138, 27);
			customerCicNumberLabel.TabIndex = 3;
			customerCicNumberLabel.Text = "CIC Number:";
			// 
			// customerIdTextBox
			// 
			customerIdTextBox.BorderStyle = BorderStyle.FixedSingle;
			customerIdTextBox.Location = new System.Drawing.Point(181, 69);
			customerIdTextBox.Name = "customerIdTextBox";
			customerIdTextBox.ReadOnly = true;
			customerIdTextBox.Size = new System.Drawing.Size(270, 34);
			customerIdTextBox.TabIndex = 0;
			// 
			// customerIdLabel
			// 
			customerIdLabel.AutoSize = true;
			customerIdLabel.Location = new System.Drawing.Point(101, 71);
			customerIdLabel.Name = "customerIdLabel";
			customerIdLabel.Size = new System.Drawing.Size(40, 27);
			customerIdLabel.TabIndex = 0;
			customerIdLabel.Text = "ID:";
			// 
			// customerBalanceLabel
			// 
			customerBalanceLabel.AutoSize = true;
			customerBalanceLabel.Location = new System.Drawing.Point(53, 203);
			customerBalanceLabel.Name = "customerBalanceLabel";
			customerBalanceLabel.Size = new System.Drawing.Size(94, 27);
			customerBalanceLabel.TabIndex = 9;
			customerBalanceLabel.Text = "Balance:";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(savingTabControl);
			tabPage2.Location = new System.Drawing.Point(4, 35);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new System.Drawing.Size(1141, 722);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Savings";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// savingTabControl
			// 
			savingTabControl.Controls.Add(detailsTabPage);
			savingTabControl.Controls.Add(openingTabPage);
			savingTabControl.Controls.Add(closingTabPage);
			savingTabControl.Dock = DockStyle.Fill;
			savingTabControl.Location = new System.Drawing.Point(3, 3);
			savingTabControl.Name = "savingTabControl";
			savingTabControl.SelectedIndex = 0;
			savingTabControl.Size = new System.Drawing.Size(1135, 716);
			savingTabControl.TabIndex = 1;
			// 
			// detailsTabPage
			// 
			detailsTabPage.AutoScroll = true;
			detailsTabPage.Controls.Add(exportDetailsButton);
			detailsTabPage.Controls.Add(maturityDayDetailsTextBox);
			detailsTabPage.Controls.Add(openDayDetailsTextBox);
			detailsTabPage.Controls.Add(interestDetailsTextBox);
			detailsTabPage.Controls.Add(periodDetailsTextBox);
			detailsTabPage.Controls.Add(balanceDetailsTextBox);
			detailsTabPage.Controls.Add(label5);
			detailsTabPage.Controls.Add(closeSavingDetailsButton);
			detailsTabPage.Controls.Add(openDayDetailsLabel);
			detailsTabPage.Controls.Add(interestDetailsLabel);
			detailsTabPage.Controls.Add(periodDetailsLabel);
			detailsTabPage.Controls.Add(balanceDetailsLabel);
			detailsTabPage.Controls.Add(savingDetailsComboBox);
			detailsTabPage.Controls.Add(savingsDetailsLabel);
			detailsTabPage.Location = new System.Drawing.Point(4, 32);
			detailsTabPage.Name = "detailsTabPage";
			detailsTabPage.Padding = new Padding(3);
			detailsTabPage.Size = new System.Drawing.Size(1127, 680);
			detailsTabPage.TabIndex = 2;
			detailsTabPage.Text = "Details";
			detailsTabPage.UseVisualStyleBackColor = true;
			// 
			// exportDetailsButton
			// 
			exportDetailsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			exportDetailsButton.Cursor = Cursors.Hand;
			exportDetailsButton.Enabled = false;
			exportDetailsButton.Font = new System.Drawing.Font("Cambria", 13.8F);
			exportDetailsButton.ForeColor = System.Drawing.Color.White;
			exportDetailsButton.Location = new System.Drawing.Point(397, 517);
			exportDetailsButton.Name = "exportDetailsButton";
			exportDetailsButton.Padding = new Padding(5);
			exportDetailsButton.Size = new System.Drawing.Size(119, 49);
			exportDetailsButton.TabIndex = 7;
			exportDetailsButton.Text = "Export";
			exportDetailsButton.UseVisualStyleBackColor = true;
			exportDetailsButton.Click += exportDetailsButton_Click;
			// 
			// maturityDayDetailsTextBox
			// 
			maturityDayDetailsTextBox.BorderStyle = BorderStyle.FixedSingle;
			maturityDayDetailsTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			maturityDayDetailsTextBox.Location = new System.Drawing.Point(582, 429);
			maturityDayDetailsTextBox.Name = "maturityDayDetailsTextBox";
			maturityDayDetailsTextBox.ReadOnly = true;
			maturityDayDetailsTextBox.Size = new System.Drawing.Size(271, 34);
			maturityDayDetailsTextBox.TabIndex = 5;
			// 
			// openDayDetailsTextBox
			// 
			openDayDetailsTextBox.BorderStyle = BorderStyle.FixedSingle;
			openDayDetailsTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			openDayDetailsTextBox.Location = new System.Drawing.Point(582, 363);
			openDayDetailsTextBox.Name = "openDayDetailsTextBox";
			openDayDetailsTextBox.ReadOnly = true;
			openDayDetailsTextBox.Size = new System.Drawing.Size(271, 34);
			openDayDetailsTextBox.TabIndex = 4;
			// 
			// interestDetailsTextBox
			// 
			interestDetailsTextBox.BorderStyle = BorderStyle.FixedSingle;
			interestDetailsTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			interestDetailsTextBox.Location = new System.Drawing.Point(582, 297);
			interestDetailsTextBox.Name = "interestDetailsTextBox";
			interestDetailsTextBox.ReadOnly = true;
			interestDetailsTextBox.Size = new System.Drawing.Size(271, 34);
			interestDetailsTextBox.TabIndex = 3;
			// 
			// periodDetailsTextBox
			// 
			periodDetailsTextBox.BorderStyle = BorderStyle.FixedSingle;
			periodDetailsTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			periodDetailsTextBox.Location = new System.Drawing.Point(583, 231);
			periodDetailsTextBox.Name = "periodDetailsTextBox";
			periodDetailsTextBox.ReadOnly = true;
			periodDetailsTextBox.Size = new System.Drawing.Size(270, 34);
			periodDetailsTextBox.TabIndex = 2;
			// 
			// balanceDetailsTextBox
			// 
			balanceDetailsTextBox.BorderStyle = BorderStyle.FixedSingle;
			balanceDetailsTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			balanceDetailsTextBox.Location = new System.Drawing.Point(583, 165);
			balanceDetailsTextBox.Name = "balanceDetailsTextBox";
			balanceDetailsTextBox.ReadOnly = true;
			balanceDetailsTextBox.Size = new System.Drawing.Size(270, 34);
			balanceDetailsTextBox.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Cambria", 13.8F);
			label5.Location = new System.Drawing.Point(312, 432);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(153, 27);
			label5.TabIndex = 6;
			label5.Text = "Maturity date:";
			// 
			// closeSavingDetailsButton
			// 
			closeSavingDetailsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			closeSavingDetailsButton.Cursor = Cursors.Hand;
			closeSavingDetailsButton.Enabled = false;
			closeSavingDetailsButton.Font = new System.Drawing.Font("Cambria", 13.8F);
			closeSavingDetailsButton.ForeColor = System.Drawing.Color.White;
			closeSavingDetailsButton.Location = new System.Drawing.Point(628, 517);
			closeSavingDetailsButton.Name = "closeSavingDetailsButton";
			closeSavingDetailsButton.Padding = new Padding(5);
			closeSavingDetailsButton.Size = new System.Drawing.Size(179, 49);
			closeSavingDetailsButton.TabIndex = 6;
			closeSavingDetailsButton.Text = "Close saving";
			closeSavingDetailsButton.UseVisualStyleBackColor = true;
			closeSavingDetailsButton.Click += closingSavingDetailsButton_Click;
			// 
			// openDayDetailsLabel
			// 
			openDayDetailsLabel.AutoSize = true;
			openDayDetailsLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			openDayDetailsLabel.Location = new System.Drawing.Point(312, 366);
			openDayDetailsLabel.Name = "openDayDetailsLabel";
			openDayDetailsLabel.Size = new System.Drawing.Size(148, 27);
			openDayDetailsLabel.TabIndex = 4;
			openDayDetailsLabel.Text = "Opening date:";
			// 
			// interestDetailsLabel
			// 
			interestDetailsLabel.AutoSize = true;
			interestDetailsLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			interestDetailsLabel.Location = new System.Drawing.Point(312, 300);
			interestDetailsLabel.Name = "interestDetailsLabel";
			interestDetailsLabel.Size = new System.Drawing.Size(215, 27);
			interestDetailsLabel.TabIndex = 3;
			interestDetailsLabel.Text = "Annual interest rate:";
			// 
			// periodDetailsLabel
			// 
			periodDetailsLabel.AutoSize = true;
			periodDetailsLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			periodDetailsLabel.Location = new System.Drawing.Point(312, 231);
			periodDetailsLabel.Name = "periodDetailsLabel";
			periodDetailsLabel.Size = new System.Drawing.Size(181, 27);
			periodDetailsLabel.TabIndex = 2;
			periodDetailsLabel.Text = "Period (months):";
			// 
			// balanceDetailsLabel
			// 
			balanceDetailsLabel.AutoSize = true;
			balanceDetailsLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			balanceDetailsLabel.Location = new System.Drawing.Point(312, 168);
			balanceDetailsLabel.Name = "balanceDetailsLabel";
			balanceDetailsLabel.Size = new System.Drawing.Size(94, 27);
			balanceDetailsLabel.TabIndex = 1;
			balanceDetailsLabel.Text = "Balance:";
			// 
			// savingDetailsComboBox
			// 
			savingDetailsComboBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			savingDetailsComboBox.FormattingEnabled = true;
			savingDetailsComboBox.Location = new System.Drawing.Point(582, 99);
			savingDetailsComboBox.Name = "savingDetailsComboBox";
			savingDetailsComboBox.Size = new System.Drawing.Size(271, 35);
			savingDetailsComboBox.TabIndex = 0;
			savingDetailsComboBox.SelectedValueChanged += savingDetailsComboBox_SelectedValueChanged;
			// 
			// savingsDetailsLabel
			// 
			savingsDetailsLabel.AutoSize = true;
			savingsDetailsLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			savingsDetailsLabel.Location = new System.Drawing.Point(312, 102);
			savingsDetailsLabel.Name = "savingsDetailsLabel";
			savingsDetailsLabel.Size = new System.Drawing.Size(82, 27);
			savingsDetailsLabel.TabIndex = 0;
			savingsDetailsLabel.Text = "Saving:";
			// 
			// openingTabPage
			// 
			openingTabPage.Controls.Add(maturityDayOpeningTextBox);
			openingTabPage.Controls.Add(interestOpeningTextBox);
			openingTabPage.Controls.Add(balanceOpeningTextBox);
			openingTabPage.Controls.Add(maturityDayOpeningLabel);
			openingTabPage.Controls.Add(interestOpeningLabel);
			openingTabPage.Controls.Add(openingSavingOpeningButton);
			openingTabPage.Controls.Add(amountOpeningNumeric);
			openingTabPage.Controls.Add(amountOpeningLabel);
			openingTabPage.Controls.Add(periodOpeningLabel);
			openingTabPage.Controls.Add(periodOpeningComboBox);
			openingTabPage.Controls.Add(balanceOpeningLabel);
			openingTabPage.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			openingTabPage.Location = new System.Drawing.Point(4, 32);
			openingTabPage.Name = "openingTabPage";
			openingTabPage.Padding = new Padding(3);
			openingTabPage.Size = new System.Drawing.Size(1127, 680);
			openingTabPage.TabIndex = 0;
			openingTabPage.Text = "Opening";
			openingTabPage.UseVisualStyleBackColor = true;
			// 
			// maturityDayOpeningTextBox
			// 
			maturityDayOpeningTextBox.BorderStyle = BorderStyle.FixedSingle;
			maturityDayOpeningTextBox.Location = new System.Drawing.Point(554, 332);
			maturityDayOpeningTextBox.Name = "maturityDayOpeningTextBox";
			maturityDayOpeningTextBox.ReadOnly = true;
			maturityDayOpeningTextBox.Size = new System.Drawing.Size(244, 34);
			maturityDayOpeningTextBox.TabIndex = 3;
			// 
			// interestOpeningTextBox
			// 
			interestOpeningTextBox.BorderStyle = BorderStyle.FixedSingle;
			interestOpeningTextBox.Location = new System.Drawing.Point(554, 267);
			interestOpeningTextBox.Name = "interestOpeningTextBox";
			interestOpeningTextBox.ReadOnly = true;
			interestOpeningTextBox.ShortcutsEnabled = false;
			interestOpeningTextBox.Size = new System.Drawing.Size(244, 34);
			interestOpeningTextBox.TabIndex = 2;
			// 
			// balanceOpeningTextBox
			// 
			balanceOpeningTextBox.BorderStyle = BorderStyle.FixedSingle;
			balanceOpeningTextBox.Location = new System.Drawing.Point(554, 135);
			balanceOpeningTextBox.Name = "balanceOpeningTextBox";
			balanceOpeningTextBox.ReadOnly = true;
			balanceOpeningTextBox.ShortcutsEnabled = false;
			balanceOpeningTextBox.Size = new System.Drawing.Size(244, 34);
			balanceOpeningTextBox.TabIndex = 0;
			// 
			// maturityDayOpeningLabel
			// 
			maturityDayOpeningLabel.AutoSize = true;
			maturityDayOpeningLabel.Location = new System.Drawing.Point(295, 335);
			maturityDayOpeningLabel.Name = "maturityDayOpeningLabel";
			maturityDayOpeningLabel.Size = new System.Drawing.Size(146, 27);
			maturityDayOpeningLabel.TabIndex = 8;
			maturityDayOpeningLabel.Text = "Maturity day:";
			// 
			// interestOpeningLabel
			// 
			interestOpeningLabel.AutoSize = true;
			interestOpeningLabel.Location = new System.Drawing.Point(295, 270);
			interestOpeningLabel.Name = "interestOpeningLabel";
			interestOpeningLabel.Size = new System.Drawing.Size(215, 27);
			interestOpeningLabel.TabIndex = 2;
			interestOpeningLabel.Text = "Annual interest rate:";
			// 
			// openingSavingOpeningButton
			// 
			openingSavingOpeningButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			openingSavingOpeningButton.Cursor = Cursors.Hand;
			openingSavingOpeningButton.Enabled = false;
			openingSavingOpeningButton.ForeColor = System.Drawing.Color.White;
			openingSavingOpeningButton.Location = new System.Drawing.Point(591, 492);
			openingSavingOpeningButton.Name = "openingSavingOpeningButton";
			openingSavingOpeningButton.Padding = new Padding(5);
			openingSavingOpeningButton.Size = new System.Drawing.Size(179, 49);
			openingSavingOpeningButton.TabIndex = 5;
			openingSavingOpeningButton.Text = "Open saving";
			openingSavingOpeningButton.UseVisualStyleBackColor = true;
			openingSavingOpeningButton.Click += openingSavingOpeningButton_Click;
			// 
			// amountOpeningNumeric
			// 
			amountOpeningNumeric.DecimalPlaces = 2;
			amountOpeningNumeric.Location = new System.Drawing.Point(554, 396);
			amountOpeningNumeric.Name = "amountOpeningNumeric";
			amountOpeningNumeric.Size = new System.Drawing.Size(244, 34);
			amountOpeningNumeric.TabIndex = 4;
			// 
			// amountOpeningLabel
			// 
			amountOpeningLabel.AutoSize = true;
			amountOpeningLabel.Location = new System.Drawing.Point(295, 398);
			amountOpeningLabel.Name = "amountOpeningLabel";
			amountOpeningLabel.Size = new System.Drawing.Size(174, 27);
			amountOpeningLabel.TabIndex = 2;
			amountOpeningLabel.Text = "Deposit amount:";
			// 
			// periodOpeningLabel
			// 
			periodOpeningLabel.AutoSize = true;
			periodOpeningLabel.Location = new System.Drawing.Point(295, 204);
			periodOpeningLabel.Name = "periodOpeningLabel";
			periodOpeningLabel.Size = new System.Drawing.Size(181, 27);
			periodOpeningLabel.TabIndex = 1;
			periodOpeningLabel.Text = "Period (months):";
			// 
			// periodOpeningComboBox
			// 
			periodOpeningComboBox.FormattingEnabled = true;
			periodOpeningComboBox.Location = new System.Drawing.Point(554, 201);
			periodOpeningComboBox.Name = "periodOpeningComboBox";
			periodOpeningComboBox.Size = new System.Drawing.Size(244, 35);
			periodOpeningComboBox.TabIndex = 1;
			periodOpeningComboBox.SelectedValueChanged += periodDepositComboBox_SelectedValueChanged;
			// 
			// balanceOpeningLabel
			// 
			balanceOpeningLabel.AutoSize = true;
			balanceOpeningLabel.Location = new System.Drawing.Point(295, 138);
			balanceOpeningLabel.Name = "balanceOpeningLabel";
			balanceOpeningLabel.Size = new System.Drawing.Size(144, 27);
			balanceOpeningLabel.TabIndex = 0;
			balanceOpeningLabel.Text = "Your balance:";
			// 
			// closingTabPage
			// 
			closingTabPage.Controls.Add(maturityDayClosingTextBox);
			closingTabPage.Controls.Add(amountToGetClosingTextBox);
			closingTabPage.Controls.Add(balanceClosingTextBox);
			closingTabPage.Controls.Add(maturityDayClosingLabel);
			closingTabPage.Controls.Add(closingSavingClosingButton);
			closingTabPage.Controls.Add(amountToGetClosingLabel);
			closingTabPage.Controls.Add(balanceClosingLabel);
			closingTabPage.Controls.Add(savingClosingComboBox);
			closingTabPage.Controls.Add(savingClosingLabel);
			closingTabPage.Location = new System.Drawing.Point(4, 32);
			closingTabPage.Name = "closingTabPage";
			closingTabPage.Padding = new Padding(3);
			closingTabPage.Size = new System.Drawing.Size(1127, 680);
			closingTabPage.TabIndex = 1;
			closingTabPage.Text = "Closing";
			closingTabPage.UseVisualStyleBackColor = true;
			// 
			// maturityDayClosingTextBox
			// 
			maturityDayClosingTextBox.BorderStyle = BorderStyle.FixedSingle;
			maturityDayClosingTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			maturityDayClosingTextBox.Location = new System.Drawing.Point(537, 291);
			maturityDayClosingTextBox.Name = "maturityDayClosingTextBox";
			maturityDayClosingTextBox.ReadOnly = true;
			maturityDayClosingTextBox.Size = new System.Drawing.Size(213, 34);
			maturityDayClosingTextBox.TabIndex = 2;
			// 
			// amountToGetClosingTextBox
			// 
			amountToGetClosingTextBox.BorderStyle = BorderStyle.FixedSingle;
			amountToGetClosingTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			amountToGetClosingTextBox.Location = new System.Drawing.Point(537, 357);
			amountToGetClosingTextBox.Name = "amountToGetClosingTextBox";
			amountToGetClosingTextBox.ReadOnly = true;
			amountToGetClosingTextBox.Size = new System.Drawing.Size(213, 34);
			amountToGetClosingTextBox.TabIndex = 3;
			// 
			// balanceClosingTextBox
			// 
			balanceClosingTextBox.BorderStyle = BorderStyle.FixedSingle;
			balanceClosingTextBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			balanceClosingTextBox.Location = new System.Drawing.Point(537, 225);
			balanceClosingTextBox.Name = "balanceClosingTextBox";
			balanceClosingTextBox.ReadOnly = true;
			balanceClosingTextBox.Size = new System.Drawing.Size(213, 34);
			balanceClosingTextBox.TabIndex = 1;
			// 
			// maturityDayClosingLabel
			// 
			maturityDayClosingLabel.AutoSize = true;
			maturityDayClosingLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			maturityDayClosingLabel.Location = new System.Drawing.Point(324, 294);
			maturityDayClosingLabel.Name = "maturityDayClosingLabel";
			maturityDayClosingLabel.Size = new System.Drawing.Size(146, 27);
			maturityDayClosingLabel.TabIndex = 2;
			maturityDayClosingLabel.Text = "Maturity day:";
			// 
			// closingSavingClosingButton
			// 
			closingSavingClosingButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			closingSavingClosingButton.Cursor = Cursors.Hand;
			closingSavingClosingButton.Enabled = false;
			closingSavingClosingButton.Font = new System.Drawing.Font("Cambria", 13.8F);
			closingSavingClosingButton.ForeColor = System.Drawing.Color.White;
			closingSavingClosingButton.Location = new System.Drawing.Point(552, 468);
			closingSavingClosingButton.Name = "closingSavingClosingButton";
			closingSavingClosingButton.Padding = new Padding(5);
			closingSavingClosingButton.Size = new System.Drawing.Size(179, 49);
			closingSavingClosingButton.TabIndex = 4;
			closingSavingClosingButton.Text = "Close saving";
			closingSavingClosingButton.UseVisualStyleBackColor = true;
			closingSavingClosingButton.Click += closingSavingClosingButton_Click;
			// 
			// amountToGetClosingLabel
			// 
			amountToGetClosingLabel.AutoSize = true;
			amountToGetClosingLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			amountToGetClosingLabel.Location = new System.Drawing.Point(324, 360);
			amountToGetClosingLabel.Name = "amountToGetClosingLabel";
			amountToGetClosingLabel.Size = new System.Drawing.Size(130, 27);
			amountToGetClosingLabel.TabIndex = 3;
			amountToGetClosingLabel.Text = "You will get:";
			// 
			// balanceClosingLabel
			// 
			balanceClosingLabel.AutoSize = true;
			balanceClosingLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			balanceClosingLabel.Location = new System.Drawing.Point(324, 228);
			balanceClosingLabel.Name = "balanceClosingLabel";
			balanceClosingLabel.Size = new System.Drawing.Size(94, 27);
			balanceClosingLabel.TabIndex = 1;
			balanceClosingLabel.Text = "Balance:";
			// 
			// savingClosingComboBox
			// 
			savingClosingComboBox.Font = new System.Drawing.Font("Cambria", 13.8F);
			savingClosingComboBox.FormattingEnabled = true;
			savingClosingComboBox.Location = new System.Drawing.Point(537, 159);
			savingClosingComboBox.Name = "savingClosingComboBox";
			savingClosingComboBox.Size = new System.Drawing.Size(213, 35);
			savingClosingComboBox.TabIndex = 0;
			savingClosingComboBox.SelectedValueChanged += savingClosingComboBox_SelectedValueChanged;
			// 
			// savingClosingLabel
			// 
			savingClosingLabel.AutoSize = true;
			savingClosingLabel.Font = new System.Drawing.Font("Cambria", 13.8F);
			savingClosingLabel.Location = new System.Drawing.Point(324, 163);
			savingClosingLabel.Name = "savingClosingLabel";
			savingClosingLabel.Size = new System.Drawing.Size(82, 27);
			savingClosingLabel.TabIndex = 0;
			savingClosingLabel.Text = "Saving:";
			// 
			// tabStatistical
			// 
			tabStatistical.BackColor = System.Drawing.Color.White;
			tabStatistical.Controls.Add(groupBoxFunction);
			tabStatistical.Controls.Add(groupBoxTransactionList);
			tabStatistical.Controls.Add(groupBoxStats);
			tabStatistical.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			tabStatistical.Location = new System.Drawing.Point(4, 35);
			tabStatistical.Name = "tabStatistical";
			tabStatistical.Padding = new Padding(3);
			tabStatistical.Size = new System.Drawing.Size(1141, 722);
			tabStatistical.TabIndex = 2;
			tabStatistical.Text = "Statistical";
			// 
			// groupBoxFunction
			// 
			groupBoxFunction.BackColor = System.Drawing.SystemColors.Control;
			groupBoxFunction.Controls.Add(btnExport);
			groupBoxFunction.ForeColor = System.Drawing.Color.Black;
			groupBoxFunction.Location = new System.Drawing.Point(13, 438);
			groupBoxFunction.Name = "groupBoxFunction";
			groupBoxFunction.Size = new System.Drawing.Size(262, 269);
			groupBoxFunction.TabIndex = 12;
			groupBoxFunction.TabStop = false;
			groupBoxFunction.Text = "Function";
			// 
			// btnExport
			// 
			btnExport.Cursor = Cursors.Hand;
			btnExport.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnExport.ForeColor = System.Drawing.Color.White;
			btnExport.Location = new System.Drawing.Point(42, 62);
			btnExport.Name = "btnExport";
			btnExport.Size = new System.Drawing.Size(174, 46);
			btnExport.TabIndex = 10;
			btnExport.Text = "Export File ";
			btnExport.UseVisualStyleBackColor = true;
			btnExport.Click += btnExport_Click;
			// 
			// groupBoxTransactionList
			// 
			groupBoxTransactionList.BackColor = System.Drawing.SystemColors.Control;
			groupBoxTransactionList.Controls.Add(data_Transactions);
			groupBoxTransactionList.ForeColor = System.Drawing.Color.Black;
			groupBoxTransactionList.Location = new System.Drawing.Point(297, 18);
			groupBoxTransactionList.Name = "groupBoxTransactionList";
			groupBoxTransactionList.Size = new System.Drawing.Size(836, 689);
			groupBoxTransactionList.TabIndex = 11;
			groupBoxTransactionList.TabStop = false;
			groupBoxTransactionList.Text = "Transaction List";
			// 
			// data_Transactions
			// 
			data_Transactions.AllowUserToAddRows = false;
			data_Transactions.AllowUserToDeleteRows = false;
			data_Transactions.AllowUserToResizeColumns = false;
			data_Transactions.AllowUserToResizeRows = false;
			data_Transactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			data_Transactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			data_Transactions.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new Padding(5);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			data_Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			data_Transactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Padding = new Padding(5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			data_Transactions.DefaultCellStyle = dataGridViewCellStyle2;
			data_Transactions.EditMode = DataGridViewEditMode.EditOnF2;
			data_Transactions.Location = new System.Drawing.Point(5, 38);
			data_Transactions.Name = "data_Transactions";
			data_Transactions.RowHeadersVisible = false;
			data_Transactions.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Padding = new Padding(5);
			data_Transactions.RowsDefaultCellStyle = dataGridViewCellStyle3;
			data_Transactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			data_Transactions.Size = new System.Drawing.Size(825, 645);
			data_Transactions.TabIndex = 4;
			// 
			// groupBoxStats
			// 
			groupBoxStats.BackColor = System.Drawing.SystemColors.Control;
			groupBoxStats.Controls.Add(panelSavings);
			groupBoxStats.Controls.Add(panelExpenses);
			groupBoxStats.ForeColor = System.Drawing.Color.Black;
			groupBoxStats.Location = new System.Drawing.Point(13, 18);
			groupBoxStats.Name = "groupBoxStats";
			groupBoxStats.Size = new System.Drawing.Size(262, 374);
			groupBoxStats.TabIndex = 4;
			groupBoxStats.TabStop = false;
			groupBoxStats.Text = "Stats";
			// 
			// panelSavings
			// 
			panelSavings.Angle = 0F;
			panelSavings.Controls.Add(pictureBox1);
			panelSavings.Controls.Add(lbSavings);
			panelSavings.Controls.Add(label2);
			panelSavings.LeftColor = System.Drawing.Color.Empty;
			panelSavings.Location = new System.Drawing.Point(6, 38);
			panelSavings.Name = "panelSavings";
			panelSavings.RightColor = System.Drawing.Color.Empty;
			panelSavings.Size = new System.Drawing.Size(250, 162);
			panelSavings.TabIndex = 8;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.Image = Properties.Resources.savingsImage;
			pictureBox1.Location = new System.Drawing.Point(16, 20);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(40, 40);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// lbSavings
			// 
			lbSavings.AutoSize = true;
			lbSavings.BackColor = System.Drawing.Color.Transparent;
			lbSavings.Font = new System.Drawing.Font("Cambria", 13.8F);
			lbSavings.ForeColor = System.Drawing.Color.White;
			lbSavings.Location = new System.Drawing.Point(16, 121);
			lbSavings.Name = "lbSavings";
			lbSavings.Size = new System.Drawing.Size(112, 27);
			lbSavings.TabIndex = 1;
			lbSavings.Text = "$1,146.45";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.Color.Transparent;
			label2.Font = new System.Drawing.Font("Cambria", 13.8F);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(16, 79);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(86, 27);
			label2.TabIndex = 0;
			label2.Text = "Savings";
			// 
			// panelExpenses
			// 
			panelExpenses.Angle = 0F;
			panelExpenses.Controls.Add(pictureBox2);
			panelExpenses.Controls.Add(lbExpenses);
			panelExpenses.Controls.Add(label8);
			panelExpenses.LeftColor = System.Drawing.Color.Empty;
			panelExpenses.Location = new System.Drawing.Point(6, 206);
			panelExpenses.Name = "panelExpenses";
			panelExpenses.RightColor = System.Drawing.Color.Empty;
			panelExpenses.Size = new System.Drawing.Size(250, 162);
			panelExpenses.TabIndex = 9;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.Image = Properties.Resources.expenses;
			pictureBox2.Location = new System.Drawing.Point(16, 20);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(40, 40);
			pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// lbExpenses
			// 
			lbExpenses.AutoSize = true;
			lbExpenses.BackColor = System.Drawing.Color.Transparent;
			lbExpenses.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lbExpenses.ForeColor = System.Drawing.Color.White;
			lbExpenses.Location = new System.Drawing.Point(16, 121);
			lbExpenses.Name = "lbExpenses";
			lbExpenses.Size = new System.Drawing.Size(112, 27);
			lbExpenses.TabIndex = 1;
			lbExpenses.Text = "$2,146.45";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = System.Drawing.Color.Transparent;
			label8.Font = new System.Drawing.Font("Cambria", 13.8F);
			label8.ForeColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(16, 79);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(104, 27);
			label8.TabIndex = 0;
			label8.Text = "Expenses";
			// 
			// CustomerMenuForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1150, 763);
			Controls.Add(tabControl1);
			Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(4, 5, 4, 5);
			Name = "CustomerMenuForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Customer";
			FormClosing += MainMenuForm_FormClosing;
			Load += Form_MainMenu_Load;
			tabControl1.ResumeLayout(false);
			tabInformation.ResumeLayout(false);
			gbInfo.ResumeLayout(false);
			gbInfo.PerformLayout();
			gbFunction.ResumeLayout(false);
			gbAccount.ResumeLayout(false);
			gbAccount.PerformLayout();
			tabPage2.ResumeLayout(false);
			savingTabControl.ResumeLayout(false);
			detailsTabPage.ResumeLayout(false);
			detailsTabPage.PerformLayout();
			openingTabPage.ResumeLayout(false);
			openingTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)amountOpeningNumeric).EndInit();
			closingTabPage.ResumeLayout(false);
			closingTabPage.PerformLayout();
			tabStatistical.ResumeLayout(false);
			groupBoxFunction.ResumeLayout(false);
			groupBoxTransactionList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)data_Transactions).EndInit();
			groupBoxStats.ResumeLayout(false);
			panelSavings.ResumeLayout(false);
			panelSavings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panelExpenses.ResumeLayout(false);
			panelExpenses.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabInformation;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabStatistical;
		private GradientPanel panelSavings;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbSavings;
		private System.Windows.Forms.Label label2;
		private GradientPanel panelExpenses;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbExpenses;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.GroupBox groupBoxStats;
		private System.Windows.Forms.GroupBox groupBoxTransactionList;
		private System.Windows.Forms.DataGridView data_Transactions;
		private System.Windows.Forms.GroupBox groupBoxFunction;
        private TabControl savingTabControl;
        private TabPage detailsTabPage;
        private Button exportDetailsButton;
        private TextBox maturityDayDetailsTextBox;
        private TextBox openDayDetailsTextBox;
        private TextBox interestDetailsTextBox;
        private TextBox periodDetailsTextBox;
        private TextBox balanceDetailsTextBox;
        private Label label5;
        private Button closeSavingDetailsButton;
        private Label openDayDetailsLabel;
        private Label interestDetailsLabel;
        private Label periodDetailsLabel;
        private Label balanceDetailsLabel;
        private ComboBox savingDetailsComboBox;
        private Label savingsDetailsLabel;
        private TabPage openingTabPage;
        private TextBox maturityDayOpeningTextBox;
        private TextBox interestOpeningTextBox;
        private TextBox balanceOpeningTextBox;
        private Label maturityDayOpeningLabel;
        private Label interestOpeningLabel;
        private Button openingSavingOpeningButton;
        private NumericUpDown amountOpeningNumeric;
        private Label amountOpeningLabel;
        private Label periodOpeningLabel;
        private ComboBox periodOpeningComboBox;
        private Label balanceOpeningLabel;
        private TabPage closingTabPage;
        private TextBox maturityDayClosingTextBox;
        private TextBox amountToGetClosingTextBox;
        private TextBox balanceClosingTextBox;
        private Label maturityDayClosingLabel;
        private Button closingSavingClosingButton;
        private Label amountToGetClosingLabel;
        private Label balanceClosingLabel;
        private ComboBox savingClosingComboBox;
        private Label savingClosingLabel;
		private GroupBox gbInfo;
		private TextBox customerNameTextBox;
		private Label customerNameLabel;
		private TextBox customerBirthdayTextBox;
		private TextBox customerAddressTextBox;
		private Label customerAddressLabel;
		private Label customerBirthdayLabel;
		private Label customerPhoneNumberLabel;
		private TextBox customerEmailTextBox;
		private Label customerEmailLabel;
		private TextBox customerPhoneNumberTextBox;
		private TextBox customerGenderTextBox;
		private Label customerGenderLabel;
		private GroupBox gbFunction;
		private Button btnChangeInfo;
		private Button customerChangePasswordButton;
		private GroupBox gbAccount;
		private TextBox customerUsernameTextBox;
		private Label customerUsernameLabel;
		private TextBox customerBalanceTextBox;
		private TextBox customerCicNumberTextBox;
		private Label customerCicNumberLabel;
		private TextBox customerIdTextBox;
		private Label customerIdLabel;
		private Label customerBalanceLabel;
	}
}