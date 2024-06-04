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
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            customerUsernameTextBox = new TextBox();
            customerUsernameLabel = new Label();
            customerIdTextBox = new TextBox();
            customerIdLabel = new Label();
            customerChangePasswordButton = new Button();
            customerBalanceTextBox = new TextBox();
            customerAddressTextBox = new TextBox();
            customerEmailTextBox = new TextBox();
            customerEmailLabel = new Label();
            customerPhoneNumberLabel = new Label();
            customerBirthdayTextBox = new TextBox();
            customerAddressLabel = new Label();
            customerPhoneNumberTextBox = new TextBox();
            customerBirthdayLabel = new Label();
            customerCicNumberTextBox = new TextBox();
            customerCicNumberLabel = new Label();
            customerGenderTextBox = new TextBox();
            customerGenderLabel = new Label();
            customerNameTextBox = new TextBox();
            customerBalanceLabel = new Label();
            customerNameLabel = new Label();
            tabPage2 = new TabPage();
            savingTabControl = new TabControl();
            detailsTabPage = new TabPage();
            maturityDayDetailsTextBox = new TextBox();
            label5 = new Label();
            closeSavingDetailsButton = new Button();
            openDayDetailsTextBox = new TextBox();
            openDayDetailsLabel = new Label();
            interestDetailsTextBox = new TextBox();
            interestDetailsLabel = new Label();
            periodDetailsTextBox = new TextBox();
            periodDetailsLabel = new Label();
            balanceDetailsTextBox = new TextBox();
            balanceDetailsLabel = new Label();
            savingDetailsComboBox = new ComboBox();
            savingsDetailsLabel = new Label();
            depositTabPage = new TabPage();
            maturityDayOpeningTextBox = new TextBox();
            maturityDayOpeningLabel = new Label();
            interestOpeningTextBox = new TextBox();
            interestOpeningLabel = new Label();
            openingSavingOpeningButton = new Button();
            balanceOpeningTextBox = new TextBox();
            amountOpeningNumeric = new NumericUpDown();
            amountOpeningLabel = new Label();
            periodOpeningLabel = new Label();
            periodOpeningComboBox = new ComboBox();
            balanceOpeningLabel = new Label();
            withdrawTabPage = new TabPage();
            maturityDayClosingTextBox = new TextBox();
            maturityDayClosingLabel = new Label();
            closingSavingClosingButton = new Button();
            amountToGetClosingTextBox = new TextBox();
            amountToGetClosingLabel = new Label();
            balanceClosingTextBox = new TextBox();
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
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            savingTabControl.SuspendLayout();
            detailsTabPage.SuspendLayout();
            depositTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountOpeningNumeric).BeginInit();
            withdrawTabPage.SuspendLayout();
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
            tabControl1.Controls.Add(tabPage1);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new System.Drawing.Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(1141, 722);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(1135, 716);
            tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(customerUsernameTextBox);
            tabPage3.Controls.Add(customerUsernameLabel);
            tabPage3.Controls.Add(customerIdTextBox);
            tabPage3.Controls.Add(customerIdLabel);
            tabPage3.Controls.Add(customerChangePasswordButton);
            tabPage3.Controls.Add(customerBalanceTextBox);
            tabPage3.Controls.Add(customerAddressTextBox);
            tabPage3.Controls.Add(customerEmailTextBox);
            tabPage3.Controls.Add(customerEmailLabel);
            tabPage3.Controls.Add(customerPhoneNumberLabel);
            tabPage3.Controls.Add(customerBirthdayTextBox);
            tabPage3.Controls.Add(customerAddressLabel);
            tabPage3.Controls.Add(customerPhoneNumberTextBox);
            tabPage3.Controls.Add(customerBirthdayLabel);
            tabPage3.Controls.Add(customerCicNumberTextBox);
            tabPage3.Controls.Add(customerCicNumberLabel);
            tabPage3.Controls.Add(customerGenderTextBox);
            tabPage3.Controls.Add(customerGenderLabel);
            tabPage3.Controls.Add(customerNameTextBox);
            tabPage3.Controls.Add(customerBalanceLabel);
            tabPage3.Controls.Add(customerNameLabel);
            tabPage3.Location = new System.Drawing.Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new System.Drawing.Size(1127, 680);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Details";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // customerUsernameTextBox
            // 
            customerUsernameTextBox.Location = new System.Drawing.Point(194, 316);
            customerUsernameTextBox.Name = "customerUsernameTextBox";
            customerUsernameTextBox.ReadOnly = true;
            customerUsernameTextBox.Size = new System.Drawing.Size(351, 31);
            customerUsernameTextBox.TabIndex = 8;
            // 
            // customerUsernameLabel
            // 
            customerUsernameLabel.AutoSize = true;
            customerUsernameLabel.Location = new System.Drawing.Point(85, 316);
            customerUsernameLabel.Name = "customerUsernameLabel";
            customerUsernameLabel.Size = new System.Drawing.Size(103, 23);
            customerUsernameLabel.TabIndex = 8;
            customerUsernameLabel.Text = "Username:";
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new System.Drawing.Point(61, 41);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.ReadOnly = true;
            customerIdTextBox.Size = new System.Drawing.Size(365, 31);
            customerIdTextBox.TabIndex = 0;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(21, 44);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(34, 23);
            customerIdLabel.TabIndex = 0;
            customerIdLabel.Text = "ID:";
            // 
            // customerChangePasswordButton
            // 
            customerChangePasswordButton.AutoSize = true;
            customerChangePasswordButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customerChangePasswordButton.Location = new System.Drawing.Point(907, 395);
            customerChangePasswordButton.Name = "customerChangePasswordButton";
            customerChangePasswordButton.Size = new System.Drawing.Size(171, 33);
            customerChangePasswordButton.TabIndex = 10;
            customerChangePasswordButton.Text = "Change Password";
            customerChangePasswordButton.UseVisualStyleBackColor = true;
            customerChangePasswordButton.Click += customerChangePasswordButton_Click;
            // 
            // customerBalanceTextBox
            // 
            customerBalanceTextBox.Location = new System.Drawing.Point(708, 316);
            customerBalanceTextBox.Name = "customerBalanceTextBox";
            customerBalanceTextBox.ReadOnly = true;
            customerBalanceTextBox.Size = new System.Drawing.Size(260, 31);
            customerBalanceTextBox.TabIndex = 9;
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Location = new System.Drawing.Point(112, 241);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.ReadOnly = true;
            customerAddressTextBox.Size = new System.Drawing.Size(997, 31);
            customerAddressTextBox.TabIndex = 7;
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.Location = new System.Drawing.Point(555, 168);
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.ReadOnly = true;
            customerEmailTextBox.Size = new System.Drawing.Size(554, 31);
            customerEmailTextBox.TabIndex = 6;
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.Location = new System.Drawing.Point(484, 171);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new System.Drawing.Size(65, 23);
            customerEmailLabel.TabIndex = 6;
            customerEmailLabel.Text = "Email:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(21, 171);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(144, 23);
            customerPhoneNumberLabel.TabIndex = 5;
            customerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // customerBirthdayTextBox
            // 
            customerBirthdayTextBox.Location = new System.Drawing.Point(867, 108);
            customerBirthdayTextBox.Name = "customerBirthdayTextBox";
            customerBirthdayTextBox.ReadOnly = true;
            customerBirthdayTextBox.Size = new System.Drawing.Size(242, 31);
            customerBirthdayTextBox.TabIndex = 4;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new System.Drawing.Point(21, 244);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new System.Drawing.Size(85, 23);
            customerAddressLabel.TabIndex = 7;
            customerAddressLabel.Text = "Address:";
            // 
            // customerPhoneNumberTextBox
            // 
            customerPhoneNumberTextBox.Location = new System.Drawing.Point(171, 168);
            customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            customerPhoneNumberTextBox.ReadOnly = true;
            customerPhoneNumberTextBox.Size = new System.Drawing.Size(271, 31);
            customerPhoneNumberTextBox.TabIndex = 5;
            // 
            // customerBirthdayLabel
            // 
            customerBirthdayLabel.AutoSize = true;
            customerBirthdayLabel.Location = new System.Drawing.Point(771, 108);
            customerBirthdayLabel.Name = "customerBirthdayLabel";
            customerBirthdayLabel.Size = new System.Drawing.Size(90, 23);
            customerBirthdayLabel.TabIndex = 4;
            customerBirthdayLabel.Text = "Birthday:";
            // 
            // customerCicNumberTextBox
            // 
            customerCicNumberTextBox.Location = new System.Drawing.Point(432, 105);
            customerCicNumberTextBox.Name = "customerCicNumberTextBox";
            customerCicNumberTextBox.ReadOnly = true;
            customerCicNumberTextBox.Size = new System.Drawing.Size(287, 31);
            customerCicNumberTextBox.TabIndex = 3;
            // 
            // customerCicNumberLabel
            // 
            customerCicNumberLabel.AutoSize = true;
            customerCicNumberLabel.Location = new System.Drawing.Point(308, 108);
            customerCicNumberLabel.Name = "customerCicNumberLabel";
            customerCicNumberLabel.Size = new System.Drawing.Size(118, 23);
            customerCicNumberLabel.TabIndex = 3;
            customerCicNumberLabel.Text = "CIC Number:";
            // 
            // customerGenderTextBox
            // 
            customerGenderTextBox.Location = new System.Drawing.Point(104, 105);
            customerGenderTextBox.Name = "customerGenderTextBox";
            customerGenderTextBox.ReadOnly = true;
            customerGenderTextBox.Size = new System.Drawing.Size(162, 31);
            customerGenderTextBox.TabIndex = 2;
            // 
            // customerGenderLabel
            // 
            customerGenderLabel.AutoSize = true;
            customerGenderLabel.Location = new System.Drawing.Point(21, 108);
            customerGenderLabel.Name = "customerGenderLabel";
            customerGenderLabel.Size = new System.Drawing.Size(77, 23);
            customerGenderLabel.TabIndex = 2;
            customerGenderLabel.Text = "Gender:";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new System.Drawing.Point(540, 41);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.ReadOnly = true;
            customerNameTextBox.Size = new System.Drawing.Size(569, 31);
            customerNameTextBox.TabIndex = 1;
            // 
            // customerBalanceLabel
            // 
            customerBalanceLabel.AutoSize = true;
            customerBalanceLabel.Location = new System.Drawing.Point(620, 319);
            customerBalanceLabel.Name = "customerBalanceLabel";
            customerBalanceLabel.Size = new System.Drawing.Size(82, 23);
            customerBalanceLabel.TabIndex = 9;
            customerBalanceLabel.Text = "Balance:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(468, 44);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(66, 23);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Name:";
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
            savingTabControl.Controls.Add(depositTabPage);
            savingTabControl.Controls.Add(withdrawTabPage);
            savingTabControl.Dock = DockStyle.Fill;
            savingTabControl.Location = new System.Drawing.Point(3, 3);
            savingTabControl.Name = "savingTabControl";
            savingTabControl.SelectedIndex = 0;
            savingTabControl.Size = new System.Drawing.Size(1135, 716);
            savingTabControl.TabIndex = 1;
            // 
            // detailsTabPage
            // 
            detailsTabPage.Controls.Add(maturityDayDetailsTextBox);
            detailsTabPage.Controls.Add(label5);
            detailsTabPage.Controls.Add(closeSavingDetailsButton);
            detailsTabPage.Controls.Add(openDayDetailsTextBox);
            detailsTabPage.Controls.Add(openDayDetailsLabel);
            detailsTabPage.Controls.Add(interestDetailsTextBox);
            detailsTabPage.Controls.Add(interestDetailsLabel);
            detailsTabPage.Controls.Add(periodDetailsTextBox);
            detailsTabPage.Controls.Add(periodDetailsLabel);
            detailsTabPage.Controls.Add(balanceDetailsTextBox);
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
            // maturityDayDetailsTextBox
            // 
            maturityDayDetailsTextBox.Location = new System.Drawing.Point(343, 238);
            maturityDayDetailsTextBox.Name = "maturityDayDetailsTextBox";
            maturityDayDetailsTextBox.ReadOnly = true;
            maturityDayDetailsTextBox.Size = new System.Drawing.Size(213, 31);
            maturityDayDetailsTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(48, 242);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 23);
            label5.TabIndex = 6;
            label5.Text = "Maturity date:";
            // 
            // closeSavingDetailsButton
            // 
            closeSavingDetailsButton.AutoSize = true;
            closeSavingDetailsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeSavingDetailsButton.Enabled = false;
            closeSavingDetailsButton.Location = new System.Drawing.Point(407, 304);
            closeSavingDetailsButton.Name = "closeSavingDetailsButton";
            closeSavingDetailsButton.Size = new System.Drawing.Size(126, 33);
            closeSavingDetailsButton.TabIndex = 6;
            closeSavingDetailsButton.Text = "Close saving";
            closeSavingDetailsButton.UseVisualStyleBackColor = true;
            closeSavingDetailsButton.Click += closingSavingDetailsButton_Click;
            // 
            // openDayDetailsTextBox
            // 
            openDayDetailsTextBox.Location = new System.Drawing.Point(343, 193);
            openDayDetailsTextBox.Name = "openDayDetailsTextBox";
            openDayDetailsTextBox.ReadOnly = true;
            openDayDetailsTextBox.Size = new System.Drawing.Size(213, 31);
            openDayDetailsTextBox.TabIndex = 4;
            // 
            // openDayDetailsLabel
            // 
            openDayDetailsLabel.AutoSize = true;
            openDayDetailsLabel.Location = new System.Drawing.Point(48, 197);
            openDayDetailsLabel.Name = "openDayDetailsLabel";
            openDayDetailsLabel.Size = new System.Drawing.Size(129, 23);
            openDayDetailsLabel.TabIndex = 4;
            openDayDetailsLabel.Text = "Opening date:";
            // 
            // interestDetailsTextBox
            // 
            interestDetailsTextBox.Location = new System.Drawing.Point(343, 147);
            interestDetailsTextBox.Name = "interestDetailsTextBox";
            interestDetailsTextBox.ReadOnly = true;
            interestDetailsTextBox.Size = new System.Drawing.Size(213, 31);
            interestDetailsTextBox.TabIndex = 3;
            // 
            // interestDetailsLabel
            // 
            interestDetailsLabel.AutoSize = true;
            interestDetailsLabel.Location = new System.Drawing.Point(48, 151);
            interestDetailsLabel.Name = "interestDetailsLabel";
            interestDetailsLabel.Size = new System.Drawing.Size(186, 23);
            interestDetailsLabel.TabIndex = 3;
            interestDetailsLabel.Text = "Annual interest rate:";
            // 
            // periodDetailsTextBox
            // 
            periodDetailsTextBox.Location = new System.Drawing.Point(343, 103);
            periodDetailsTextBox.Name = "periodDetailsTextBox";
            periodDetailsTextBox.ReadOnly = true;
            periodDetailsTextBox.Size = new System.Drawing.Size(213, 31);
            periodDetailsTextBox.TabIndex = 2;
            // 
            // periodDetailsLabel
            // 
            periodDetailsLabel.AutoSize = true;
            periodDetailsLabel.Location = new System.Drawing.Point(48, 107);
            periodDetailsLabel.Name = "periodDetailsLabel";
            periodDetailsLabel.Size = new System.Drawing.Size(158, 23);
            periodDetailsLabel.TabIndex = 2;
            periodDetailsLabel.Text = "Period (months):";
            // 
            // balanceDetailsTextBox
            // 
            balanceDetailsTextBox.Location = new System.Drawing.Point(343, 61);
            balanceDetailsTextBox.Name = "balanceDetailsTextBox";
            balanceDetailsTextBox.ReadOnly = true;
            balanceDetailsTextBox.Size = new System.Drawing.Size(213, 31);
            balanceDetailsTextBox.TabIndex = 1;
            // 
            // balanceDetailsLabel
            // 
            balanceDetailsLabel.AutoSize = true;
            balanceDetailsLabel.Location = new System.Drawing.Point(48, 65);
            balanceDetailsLabel.Name = "balanceDetailsLabel";
            balanceDetailsLabel.Size = new System.Drawing.Size(82, 23);
            balanceDetailsLabel.TabIndex = 1;
            balanceDetailsLabel.Text = "Balance:";
            // 
            // savingDetailsComboBox
            // 
            savingDetailsComboBox.FormattingEnabled = true;
            savingDetailsComboBox.Location = new System.Drawing.Point(343, 15);
            savingDetailsComboBox.Name = "savingDetailsComboBox";
            savingDetailsComboBox.Size = new System.Drawing.Size(213, 31);
            savingDetailsComboBox.TabIndex = 0;
            savingDetailsComboBox.SelectedValueChanged += savingDetailsComboBox_SelectedValueChanged;
            // 
            // savingsDetailsLabel
            // 
            savingsDetailsLabel.AutoSize = true;
            savingsDetailsLabel.Location = new System.Drawing.Point(48, 19);
            savingsDetailsLabel.Name = "savingsDetailsLabel";
            savingsDetailsLabel.Size = new System.Drawing.Size(72, 23);
            savingsDetailsLabel.TabIndex = 0;
            savingsDetailsLabel.Text = "Saving:";
            // 
            // depositTabPage
            // 
            depositTabPage.Controls.Add(maturityDayOpeningTextBox);
            depositTabPage.Controls.Add(maturityDayOpeningLabel);
            depositTabPage.Controls.Add(interestOpeningTextBox);
            depositTabPage.Controls.Add(interestOpeningLabel);
            depositTabPage.Controls.Add(openingSavingOpeningButton);
            depositTabPage.Controls.Add(balanceOpeningTextBox);
            depositTabPage.Controls.Add(amountOpeningNumeric);
            depositTabPage.Controls.Add(amountOpeningLabel);
            depositTabPage.Controls.Add(periodOpeningLabel);
            depositTabPage.Controls.Add(periodOpeningComboBox);
            depositTabPage.Controls.Add(balanceOpeningLabel);
            depositTabPage.Location = new System.Drawing.Point(4, 29);
            depositTabPage.Name = "depositTabPage";
            depositTabPage.Padding = new Padding(3);
            depositTabPage.Size = new System.Drawing.Size(1127, 683);
            depositTabPage.TabIndex = 0;
            depositTabPage.Text = "Opening";
            depositTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayOpeningTextBox
            // 
            maturityDayOpeningTextBox.Location = new System.Drawing.Point(311, 165);
            maturityDayOpeningTextBox.Name = "maturityDayOpeningTextBox";
            maturityDayOpeningTextBox.ReadOnly = true;
            maturityDayOpeningTextBox.Size = new System.Drawing.Size(244, 31);
            maturityDayOpeningTextBox.TabIndex = 3;
            // 
            // maturityDayOpeningLabel
            // 
            maturityDayOpeningLabel.AutoSize = true;
            maturityDayOpeningLabel.Location = new System.Drawing.Point(52, 168);
            maturityDayOpeningLabel.Name = "maturityDayOpeningLabel";
            maturityDayOpeningLabel.Size = new System.Drawing.Size(125, 23);
            maturityDayOpeningLabel.TabIndex = 8;
            maturityDayOpeningLabel.Text = "Maturity day:";
            // 
            // interestOpeningTextBox
            // 
            interestOpeningTextBox.Location = new System.Drawing.Point(311, 120);
            interestOpeningTextBox.Name = "interestOpeningTextBox";
            interestOpeningTextBox.ReadOnly = true;
            interestOpeningTextBox.ShortcutsEnabled = false;
            interestOpeningTextBox.Size = new System.Drawing.Size(244, 31);
            interestOpeningTextBox.TabIndex = 2;
            // 
            // interestOpeningLabel
            // 
            interestOpeningLabel.AutoSize = true;
            interestOpeningLabel.Location = new System.Drawing.Point(52, 123);
            interestOpeningLabel.Name = "interestOpeningLabel";
            interestOpeningLabel.Size = new System.Drawing.Size(186, 23);
            interestOpeningLabel.TabIndex = 2;
            interestOpeningLabel.Text = "Annual interest rate:";
            // 
            // openingSavingOpeningButton
            // 
            openingSavingOpeningButton.AutoSize = true;
            openingSavingOpeningButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openingSavingOpeningButton.Enabled = false;
            openingSavingOpeningButton.Location = new System.Drawing.Point(405, 269);
            openingSavingOpeningButton.Name = "openingSavingOpeningButton";
            openingSavingOpeningButton.Size = new System.Drawing.Size(125, 33);
            openingSavingOpeningButton.TabIndex = 5;
            openingSavingOpeningButton.Text = "Open saving";
            openingSavingOpeningButton.UseVisualStyleBackColor = true;
            openingSavingOpeningButton.Click += openingSavingOpeningButton_Click;
            // 
            // balanceOpeningTextBox
            // 
            balanceOpeningTextBox.Location = new System.Drawing.Point(311, 29);
            balanceOpeningTextBox.Name = "balanceOpeningTextBox";
            balanceOpeningTextBox.ReadOnly = true;
            balanceOpeningTextBox.ShortcutsEnabled = false;
            balanceOpeningTextBox.Size = new System.Drawing.Size(244, 31);
            balanceOpeningTextBox.TabIndex = 0;
            // 
            // amountOpeningNumeric
            // 
            amountOpeningNumeric.DecimalPlaces = 2;
            amountOpeningNumeric.Location = new System.Drawing.Point(311, 210);
            amountOpeningNumeric.Name = "amountOpeningNumeric";
            amountOpeningNumeric.Size = new System.Drawing.Size(244, 31);
            amountOpeningNumeric.TabIndex = 4;
            // 
            // amountOpeningLabel
            // 
            amountOpeningLabel.AutoSize = true;
            amountOpeningLabel.Location = new System.Drawing.Point(52, 213);
            amountOpeningLabel.Name = "amountOpeningLabel";
            amountOpeningLabel.Size = new System.Drawing.Size(153, 23);
            amountOpeningLabel.TabIndex = 2;
            amountOpeningLabel.Text = "Deposit amount:";
            // 
            // periodOpeningLabel
            // 
            periodOpeningLabel.AutoSize = true;
            periodOpeningLabel.Location = new System.Drawing.Point(52, 78);
            periodOpeningLabel.Name = "periodOpeningLabel";
            periodOpeningLabel.Size = new System.Drawing.Size(158, 23);
            periodOpeningLabel.TabIndex = 1;
            periodOpeningLabel.Text = "Period (months):";
            // 
            // periodOpeningComboBox
            // 
            periodOpeningComboBox.FormattingEnabled = true;
            periodOpeningComboBox.Location = new System.Drawing.Point(311, 74);
            periodOpeningComboBox.Name = "periodOpeningComboBox";
            periodOpeningComboBox.Size = new System.Drawing.Size(244, 31);
            periodOpeningComboBox.TabIndex = 1;
            periodOpeningComboBox.SelectedValueChanged += periodDepositComboBox_SelectedValueChanged;
            // 
            // balanceOpeningLabel
            // 
            balanceOpeningLabel.AutoSize = true;
            balanceOpeningLabel.Location = new System.Drawing.Point(52, 33);
            balanceOpeningLabel.Name = "balanceOpeningLabel";
            balanceOpeningLabel.Size = new System.Drawing.Size(124, 23);
            balanceOpeningLabel.TabIndex = 0;
            balanceOpeningLabel.Text = "Your balance:";
            // 
            // withdrawTabPage
            // 
            withdrawTabPage.Controls.Add(maturityDayClosingTextBox);
            withdrawTabPage.Controls.Add(maturityDayClosingLabel);
            withdrawTabPage.Controls.Add(closingSavingClosingButton);
            withdrawTabPage.Controls.Add(amountToGetClosingTextBox);
            withdrawTabPage.Controls.Add(amountToGetClosingLabel);
            withdrawTabPage.Controls.Add(balanceClosingTextBox);
            withdrawTabPage.Controls.Add(balanceClosingLabel);
            withdrawTabPage.Controls.Add(savingClosingComboBox);
            withdrawTabPage.Controls.Add(savingClosingLabel);
            withdrawTabPage.Location = new System.Drawing.Point(4, 29);
            withdrawTabPage.Name = "withdrawTabPage";
            withdrawTabPage.Padding = new Padding(3);
            withdrawTabPage.Size = new System.Drawing.Size(1127, 683);
            withdrawTabPage.TabIndex = 1;
            withdrawTabPage.Text = "Closing";
            withdrawTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayClosingTextBox
            // 
            maturityDayClosingTextBox.Location = new System.Drawing.Point(223, 170);
            maturityDayClosingTextBox.Name = "maturityDayClosingTextBox";
            maturityDayClosingTextBox.ReadOnly = true;
            maturityDayClosingTextBox.Size = new System.Drawing.Size(213, 31);
            maturityDayClosingTextBox.TabIndex = 2;
            // 
            // maturityDayClosingLabel
            // 
            maturityDayClosingLabel.AutoSize = true;
            maturityDayClosingLabel.Location = new System.Drawing.Point(54, 174);
            maturityDayClosingLabel.Name = "maturityDayClosingLabel";
            maturityDayClosingLabel.Size = new System.Drawing.Size(125, 23);
            maturityDayClosingLabel.TabIndex = 2;
            maturityDayClosingLabel.Text = "Maturity day:";
            // 
            // closingSavingClosingButton
            // 
            closingSavingClosingButton.AutoSize = true;
            closingSavingClosingButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closingSavingClosingButton.Enabled = false;
            closingSavingClosingButton.Location = new System.Drawing.Point(372, 277);
            closingSavingClosingButton.Name = "closingSavingClosingButton";
            closingSavingClosingButton.Size = new System.Drawing.Size(126, 33);
            closingSavingClosingButton.TabIndex = 4;
            closingSavingClosingButton.Text = "Close saving";
            closingSavingClosingButton.UseVisualStyleBackColor = true;
            closingSavingClosingButton.Click += closingSavingClosingButton_Click;
            // 
            // amountToGetClosingTextBox
            // 
            amountToGetClosingTextBox.Location = new System.Drawing.Point(223, 222);
            amountToGetClosingTextBox.Name = "amountToGetClosingTextBox";
            amountToGetClosingTextBox.ReadOnly = true;
            amountToGetClosingTextBox.Size = new System.Drawing.Size(213, 31);
            amountToGetClosingTextBox.TabIndex = 3;
            // 
            // amountToGetClosingLabel
            // 
            amountToGetClosingLabel.AutoSize = true;
            amountToGetClosingLabel.Location = new System.Drawing.Point(54, 226);
            amountToGetClosingLabel.Name = "amountToGetClosingLabel";
            amountToGetClosingLabel.Size = new System.Drawing.Size(112, 23);
            amountToGetClosingLabel.TabIndex = 3;
            amountToGetClosingLabel.Text = "You will get:";
            // 
            // balanceClosingTextBox
            // 
            balanceClosingTextBox.Location = new System.Drawing.Point(223, 118);
            balanceClosingTextBox.Name = "balanceClosingTextBox";
            balanceClosingTextBox.ReadOnly = true;
            balanceClosingTextBox.Size = new System.Drawing.Size(213, 31);
            balanceClosingTextBox.TabIndex = 1;
            // 
            // balanceClosingLabel
            // 
            balanceClosingLabel.AutoSize = true;
            balanceClosingLabel.Location = new System.Drawing.Point(54, 122);
            balanceClosingLabel.Name = "balanceClosingLabel";
            balanceClosingLabel.Size = new System.Drawing.Size(82, 23);
            balanceClosingLabel.TabIndex = 1;
            balanceClosingLabel.Text = "Balance:";
            // 
            // savingClosingComboBox
            // 
            savingClosingComboBox.FormattingEnabled = true;
            savingClosingComboBox.Location = new System.Drawing.Point(223, 66);
            savingClosingComboBox.Name = "savingClosingComboBox";
            savingClosingComboBox.Size = new System.Drawing.Size(213, 31);
            savingClosingComboBox.TabIndex = 0;
            savingClosingComboBox.SelectedValueChanged += savingClosingComboBox_SelectedValueChanged;
            // 
            // savingClosingLabel
            // 
            savingClosingLabel.AutoSize = true;
            savingClosingLabel.Location = new System.Drawing.Point(54, 70);
            savingClosingLabel.Name = "savingClosingLabel";
            savingClosingLabel.Size = new System.Drawing.Size(72, 23);
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
            btnExport.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExport.ForeColor = System.Drawing.Color.Black;
            btnExport.Location = new System.Drawing.Point(42, 62);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(174, 46);
            btnExport.TabIndex = 10;
            btnExport.Text = "Export File ";
            btnExport.UseVisualStyleBackColor = true;
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
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            savingTabControl.ResumeLayout(false);
            detailsTabPage.ResumeLayout(false);
            detailsTabPage.PerformLayout();
            depositTabPage.ResumeLayout(false);
            depositTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountOpeningNumeric).EndInit();
            withdrawTabPage.ResumeLayout(false);
            withdrawTabPage.PerformLayout();
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
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabStatistical;
		private System.Windows.Forms.TabControl savingTabControl;
		private System.Windows.Forms.TabPage detailsTabPage;
		private System.Windows.Forms.TextBox maturityDayDetailsTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button closeSavingDetailsButton;
		private System.Windows.Forms.TextBox openDayDetailsTextBox;
		private System.Windows.Forms.Label openDayDetailsLabel;
		private System.Windows.Forms.TextBox interestDetailsTextBox;
		private System.Windows.Forms.Label interestDetailsLabel;
		private System.Windows.Forms.TextBox periodDetailsTextBox;
		private System.Windows.Forms.Label periodDetailsLabel;
		private System.Windows.Forms.TextBox balanceDetailsTextBox;
		private System.Windows.Forms.Label balanceDetailsLabel;
		private System.Windows.Forms.ComboBox savingDetailsComboBox;
		private System.Windows.Forms.Label savingsDetailsLabel;
		private System.Windows.Forms.TabPage depositTabPage;
		private System.Windows.Forms.TextBox maturityDayOpeningTextBox;
		private System.Windows.Forms.Label maturityDayOpeningLabel;
		private System.Windows.Forms.TextBox interestOpeningTextBox;
		private System.Windows.Forms.Label interestOpeningLabel;
		private System.Windows.Forms.Button openingSavingOpeningButton;
		private System.Windows.Forms.TextBox balanceOpeningTextBox;
		private System.Windows.Forms.NumericUpDown amountOpeningNumeric;
		private System.Windows.Forms.Label amountOpeningLabel;
		private System.Windows.Forms.Label periodOpeningLabel;
		private System.Windows.Forms.ComboBox periodOpeningComboBox;
		private System.Windows.Forms.Label balanceOpeningLabel;
		private System.Windows.Forms.TabPage withdrawTabPage;
		private System.Windows.Forms.TextBox maturityDayClosingTextBox;
		private System.Windows.Forms.Label maturityDayClosingLabel;
		private System.Windows.Forms.Button closingSavingClosingButton;
		private System.Windows.Forms.TextBox amountToGetClosingTextBox;
		private System.Windows.Forms.Label amountToGetClosingLabel;
		private System.Windows.Forms.TextBox balanceClosingTextBox;
		private System.Windows.Forms.Label balanceClosingLabel;
		private System.Windows.Forms.ComboBox savingClosingComboBox;
		private System.Windows.Forms.Label savingClosingLabel;
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox customerBirthdayTextBox;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.Label customerBirthdayLabel;
        private System.Windows.Forms.TextBox customerCicNumberTextBox;
        private System.Windows.Forms.Label customerCicNumberLabel;
        private System.Windows.Forms.TextBox customerGenderTextBox;
        private System.Windows.Forms.Label customerGenderLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerBalanceLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.TextBox customerBalanceTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Button customerChangePasswordButton;
        private Label customerIdLabel;
        private TextBox customerIdTextBox;
        private TextBox customerUsernameTextBox;
        private Label customerUsernameLabel;
    }
}