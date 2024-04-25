namespace GraphicalUserInterface
{
    partial class SavingForm
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
            savingTabControl = new System.Windows.Forms.TabControl();
            detailsTabPage = new System.Windows.Forms.TabPage();
            maturityDayDetailsTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            withdrawDetailsButton = new System.Windows.Forms.Button();
            openDayDetailsTextBox = new System.Windows.Forms.TextBox();
            openDayDetailsLabel = new System.Windows.Forms.Label();
            interestDetailsTextBox = new System.Windows.Forms.TextBox();
            interestDetailsLabel = new System.Windows.Forms.Label();
            periodDetailsTextBox = new System.Windows.Forms.TextBox();
            periodDetailsLabel = new System.Windows.Forms.Label();
            balanceDetailsTextBox = new System.Windows.Forms.TextBox();
            balanceDetailsLabel = new System.Windows.Forms.Label();
            savingDetailsComboBox = new System.Windows.Forms.ComboBox();
            savingsDetailsLabel = new System.Windows.Forms.Label();
            depositTabPage = new System.Windows.Forms.TabPage();
            maturityDayDepositTextBox = new System.Windows.Forms.TextBox();
            maturityDayDepositLabel = new System.Windows.Forms.Label();
            interestDepositTextBox = new System.Windows.Forms.TextBox();
            interestDepositLabel = new System.Windows.Forms.Label();
            depositButton = new System.Windows.Forms.Button();
            balanceDepositTextBox = new System.Windows.Forms.TextBox();
            amountDepositNumeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            periodLabel = new System.Windows.Forms.Label();
            periodDepositComboBox = new System.Windows.Forms.ComboBox();
            balanceDepositLabel = new System.Windows.Forms.Label();
            withdrawTabPage = new System.Windows.Forms.TabPage();
            maturityDayWithdrawTextBox = new System.Windows.Forms.TextBox();
            maturityDayWithdrawLabel = new System.Windows.Forms.Label();
            withdrawWithdrawButton = new System.Windows.Forms.Button();
            amountToGetWithdrawTextBox = new System.Windows.Forms.TextBox();
            amountToGetWithdrawLabel = new System.Windows.Forms.Label();
            balanceWithdrawTextBox = new System.Windows.Forms.TextBox();
            balanceWithdrawLabel = new System.Windows.Forms.Label();
            savingWithdrawComboBox = new System.Windows.Forms.ComboBox();
            savingWithdrawLabel = new System.Windows.Forms.Label();
            savingTabControl.SuspendLayout();
            detailsTabPage.SuspendLayout();
            depositTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountDepositNumeric).BeginInit();
            withdrawTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // savingTabControl
            // 
            savingTabControl.Controls.Add(detailsTabPage);
            savingTabControl.Controls.Add(depositTabPage);
            savingTabControl.Controls.Add(withdrawTabPage);
            savingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            savingTabControl.Location = new System.Drawing.Point(0, 0);
            savingTabControl.Name = "savingTabControl";
            savingTabControl.SelectedIndex = 0;
            savingTabControl.Size = new System.Drawing.Size(529, 345);
            savingTabControl.TabIndex = 0;
            // 
            // detailsTabPage
            // 
            detailsTabPage.Controls.Add(maturityDayDetailsTextBox);
            detailsTabPage.Controls.Add(label5);
            detailsTabPage.Controls.Add(withdrawDetailsButton);
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
            detailsTabPage.Location = new System.Drawing.Point(4, 29);
            detailsTabPage.Name = "detailsTabPage";
            detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            detailsTabPage.Size = new System.Drawing.Size(521, 312);
            detailsTabPage.TabIndex = 2;
            detailsTabPage.Text = "Details";
            detailsTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayDetailsTextBox
            // 
            maturityDayDetailsTextBox.Location = new System.Drawing.Point(215, 204);
            maturityDayDetailsTextBox.Name = "maturityDayDetailsTextBox";
            maturityDayDetailsTextBox.ReadOnly = true;
            maturityDayDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            maturityDayDetailsTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(43, 204);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 20);
            label5.TabIndex = 6;
            label5.Text = "Maturity day:";
            // 
            // withdrawDetailsButton
            // 
            withdrawDetailsButton.Enabled = false;
            withdrawDetailsButton.Location = new System.Drawing.Point(390, 258);
            withdrawDetailsButton.Name = "withdrawDetailsButton";
            withdrawDetailsButton.Size = new System.Drawing.Size(94, 29);
            withdrawDetailsButton.TabIndex = 5;
            withdrawDetailsButton.Text = "Withdraw";
            withdrawDetailsButton.UseVisualStyleBackColor = true;
            withdrawDetailsButton.Click += withdrawDetailsButton_Click;
            // 
            // openDayDetailsTextBox
            // 
            openDayDetailsTextBox.Location = new System.Drawing.Point(215, 164);
            openDayDetailsTextBox.Name = "openDayDetailsTextBox";
            openDayDetailsTextBox.ReadOnly = true;
            openDayDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            openDayDetailsTextBox.TabIndex = 4;
            // 
            // openDayDetailsLabel
            // 
            openDayDetailsLabel.AutoSize = true;
            openDayDetailsLabel.Location = new System.Drawing.Point(43, 167);
            openDayDetailsLabel.Name = "openDayDetailsLabel";
            openDayDetailsLabel.Size = new System.Drawing.Size(76, 20);
            openDayDetailsLabel.TabIndex = 4;
            openDayDetailsLabel.Text = "Open day:";
            // 
            // interestDetailsTextBox
            // 
            interestDetailsTextBox.Location = new System.Drawing.Point(215, 127);
            interestDetailsTextBox.Name = "interestDetailsTextBox";
            interestDetailsTextBox.ReadOnly = true;
            interestDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            interestDetailsTextBox.TabIndex = 3;
            // 
            // interestDetailsLabel
            // 
            interestDetailsLabel.AutoSize = true;
            interestDetailsLabel.Location = new System.Drawing.Point(43, 130);
            interestDetailsLabel.Name = "interestDetailsLabel";
            interestDetailsLabel.Size = new System.Drawing.Size(141, 20);
            interestDetailsLabel.TabIndex = 3;
            interestDetailsLabel.Text = "Annual interest rate:";
            // 
            // periodDetailsTextBox
            // 
            periodDetailsTextBox.Location = new System.Drawing.Point(215, 92);
            periodDetailsTextBox.Name = "periodDetailsTextBox";
            periodDetailsTextBox.ReadOnly = true;
            periodDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            periodDetailsTextBox.TabIndex = 2;
            // 
            // periodDetailsLabel
            // 
            periodDetailsLabel.AutoSize = true;
            periodDetailsLabel.Location = new System.Drawing.Point(43, 95);
            periodDetailsLabel.Name = "periodDetailsLabel";
            periodDetailsLabel.Size = new System.Drawing.Size(117, 20);
            periodDetailsLabel.TabIndex = 2;
            periodDetailsLabel.Text = "Period (months):";
            // 
            // balanceDetailsTextBox
            // 
            balanceDetailsTextBox.Location = new System.Drawing.Point(215, 55);
            balanceDetailsTextBox.Name = "balanceDetailsTextBox";
            balanceDetailsTextBox.ReadOnly = true;
            balanceDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            balanceDetailsTextBox.TabIndex = 1;
            // 
            // balanceDetailsLabel
            // 
            balanceDetailsLabel.AutoSize = true;
            balanceDetailsLabel.Location = new System.Drawing.Point(43, 58);
            balanceDetailsLabel.Name = "balanceDetailsLabel";
            balanceDetailsLabel.Size = new System.Drawing.Size(64, 20);
            balanceDetailsLabel.TabIndex = 1;
            balanceDetailsLabel.Text = "Balance:";
            // 
            // savingDetailsComboBox
            // 
            savingDetailsComboBox.FormattingEnabled = true;
            savingDetailsComboBox.Location = new System.Drawing.Point(215, 21);
            savingDetailsComboBox.Name = "savingDetailsComboBox";
            savingDetailsComboBox.Size = new System.Drawing.Size(213, 28);
            savingDetailsComboBox.TabIndex = 0;
            savingDetailsComboBox.SelectedValueChanged += savingDetailsComboBox_SelectedValueChanged;
            // 
            // savingsDetailsLabel
            // 
            savingsDetailsLabel.AutoSize = true;
            savingsDetailsLabel.Location = new System.Drawing.Point(43, 24);
            savingsDetailsLabel.Name = "savingsDetailsLabel";
            savingsDetailsLabel.Size = new System.Drawing.Size(56, 20);
            savingsDetailsLabel.TabIndex = 0;
            savingsDetailsLabel.Text = "Saving:";
            // 
            // depositTabPage
            // 
            depositTabPage.Controls.Add(maturityDayDepositTextBox);
            depositTabPage.Controls.Add(maturityDayDepositLabel);
            depositTabPage.Controls.Add(interestDepositTextBox);
            depositTabPage.Controls.Add(interestDepositLabel);
            depositTabPage.Controls.Add(depositButton);
            depositTabPage.Controls.Add(balanceDepositTextBox);
            depositTabPage.Controls.Add(amountDepositNumeric);
            depositTabPage.Controls.Add(label3);
            depositTabPage.Controls.Add(periodLabel);
            depositTabPage.Controls.Add(periodDepositComboBox);
            depositTabPage.Controls.Add(balanceDepositLabel);
            depositTabPage.Location = new System.Drawing.Point(4, 29);
            depositTabPage.Name = "depositTabPage";
            depositTabPage.Padding = new System.Windows.Forms.Padding(3);
            depositTabPage.Size = new System.Drawing.Size(521, 312);
            depositTabPage.TabIndex = 0;
            depositTabPage.Text = " Deposit";
            depositTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayDepositTextBox
            // 
            maturityDayDepositTextBox.Location = new System.Drawing.Point(196, 156);
            maturityDayDepositTextBox.Name = "maturityDayDepositTextBox";
            maturityDayDepositTextBox.ReadOnly = true;
            maturityDayDepositTextBox.Size = new System.Drawing.Size(244, 27);
            maturityDayDepositTextBox.TabIndex = 9;
            // 
            // maturityDayDepositLabel
            // 
            maturityDayDepositLabel.AutoSize = true;
            maturityDayDepositLabel.Location = new System.Drawing.Point(49, 159);
            maturityDayDepositLabel.Name = "maturityDayDepositLabel";
            maturityDayDepositLabel.Size = new System.Drawing.Size(95, 20);
            maturityDayDepositLabel.TabIndex = 8;
            maturityDayDepositLabel.Text = "Maturity day:";
            // 
            // interestDepositTextBox
            // 
            interestDepositTextBox.Location = new System.Drawing.Point(196, 120);
            interestDepositTextBox.Name = "interestDepositTextBox";
            interestDepositTextBox.ReadOnly = true;
            interestDepositTextBox.ShortcutsEnabled = false;
            interestDepositTextBox.Size = new System.Drawing.Size(244, 27);
            interestDepositTextBox.TabIndex = 2;
            // 
            // interestDepositLabel
            // 
            interestDepositLabel.AutoSize = true;
            interestDepositLabel.Location = new System.Drawing.Point(49, 123);
            interestDepositLabel.Name = "interestDepositLabel";
            interestDepositLabel.Size = new System.Drawing.Size(141, 20);
            interestDepositLabel.TabIndex = 2;
            interestDepositLabel.Text = "Annual interest rate:";
            // 
            // depositButton
            // 
            depositButton.Enabled = false;
            depositButton.Location = new System.Drawing.Point(415, 236);
            depositButton.Name = "depositButton";
            depositButton.Size = new System.Drawing.Size(94, 29);
            depositButton.TabIndex = 3;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // balanceDepositTextBox
            // 
            balanceDepositTextBox.Location = new System.Drawing.Point(196, 47);
            balanceDepositTextBox.Name = "balanceDepositTextBox";
            balanceDepositTextBox.ReadOnly = true;
            balanceDepositTextBox.ShortcutsEnabled = false;
            balanceDepositTextBox.Size = new System.Drawing.Size(244, 27);
            balanceDepositTextBox.TabIndex = 0;
            // 
            // amountDepositNumeric
            // 
            amountDepositNumeric.DecimalPlaces = 2;
            amountDepositNumeric.Location = new System.Drawing.Point(196, 192);
            amountDepositNumeric.Name = "amountDepositNumeric";
            amountDepositNumeric.Size = new System.Drawing.Size(244, 27);
            amountDepositNumeric.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(49, 195);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Amount to deposit:";
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Location = new System.Drawing.Point(49, 87);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(117, 20);
            periodLabel.TabIndex = 1;
            periodLabel.Text = "Period (months):";
            // 
            // periodDepositComboBox
            // 
            periodDepositComboBox.FormattingEnabled = true;
            periodDepositComboBox.Location = new System.Drawing.Point(196, 83);
            periodDepositComboBox.Name = "periodDepositComboBox";
            periodDepositComboBox.Size = new System.Drawing.Size(244, 28);
            periodDepositComboBox.TabIndex = 1;
            periodDepositComboBox.SelectedValueChanged += periodDepositComboBox_SelectedValueChanged;
            // 
            // balanceDepositLabel
            // 
            balanceDepositLabel.AutoSize = true;
            balanceDepositLabel.Location = new System.Drawing.Point(49, 50);
            balanceDepositLabel.Name = "balanceDepositLabel";
            balanceDepositLabel.Size = new System.Drawing.Size(97, 20);
            balanceDepositLabel.TabIndex = 0;
            balanceDepositLabel.Text = "Your balance:";
            // 
            // withdrawTabPage
            // 
            withdrawTabPage.Controls.Add(maturityDayWithdrawTextBox);
            withdrawTabPage.Controls.Add(maturityDayWithdrawLabel);
            withdrawTabPage.Controls.Add(withdrawWithdrawButton);
            withdrawTabPage.Controls.Add(amountToGetWithdrawTextBox);
            withdrawTabPage.Controls.Add(amountToGetWithdrawLabel);
            withdrawTabPage.Controls.Add(balanceWithdrawTextBox);
            withdrawTabPage.Controls.Add(balanceWithdrawLabel);
            withdrawTabPage.Controls.Add(savingWithdrawComboBox);
            withdrawTabPage.Controls.Add(savingWithdrawLabel);
            withdrawTabPage.Location = new System.Drawing.Point(4, 29);
            withdrawTabPage.Name = "withdrawTabPage";
            withdrawTabPage.Padding = new System.Windows.Forms.Padding(3);
            withdrawTabPage.Size = new System.Drawing.Size(521, 312);
            withdrawTabPage.TabIndex = 1;
            withdrawTabPage.Text = "Withdraw";
            withdrawTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayWithdrawTextBox
            // 
            maturityDayWithdrawTextBox.Location = new System.Drawing.Point(211, 136);
            maturityDayWithdrawTextBox.Name = "maturityDayWithdrawTextBox";
            maturityDayWithdrawTextBox.ReadOnly = true;
            maturityDayWithdrawTextBox.Size = new System.Drawing.Size(213, 27);
            maturityDayWithdrawTextBox.TabIndex = 2;
            // 
            // maturityDayWithdrawLabel
            // 
            maturityDayWithdrawLabel.AutoSize = true;
            maturityDayWithdrawLabel.Location = new System.Drawing.Point(39, 139);
            maturityDayWithdrawLabel.Name = "maturityDayWithdrawLabel";
            maturityDayWithdrawLabel.Size = new System.Drawing.Size(95, 20);
            maturityDayWithdrawLabel.TabIndex = 2;
            maturityDayWithdrawLabel.Text = "Maturity day:";
            // 
            // withdrawWithdrawButton
            // 
            withdrawWithdrawButton.Enabled = false;
            withdrawWithdrawButton.Location = new System.Drawing.Point(406, 215);
            withdrawWithdrawButton.Name = "withdrawWithdrawButton";
            withdrawWithdrawButton.Size = new System.Drawing.Size(94, 29);
            withdrawWithdrawButton.TabIndex = 4;
            withdrawWithdrawButton.Text = "Withdraw";
            withdrawWithdrawButton.UseVisualStyleBackColor = true;
            withdrawWithdrawButton.Click += withdrawWithdrawButton_Click;
            // 
            // amountToGetWithdrawTextBox
            // 
            amountToGetWithdrawTextBox.Location = new System.Drawing.Point(211, 168);
            amountToGetWithdrawTextBox.Name = "amountToGetWithdrawTextBox";
            amountToGetWithdrawTextBox.ReadOnly = true;
            amountToGetWithdrawTextBox.Size = new System.Drawing.Size(213, 27);
            amountToGetWithdrawTextBox.TabIndex = 3;
            // 
            // amountToGetWithdrawLabel
            // 
            amountToGetWithdrawLabel.AutoSize = true;
            amountToGetWithdrawLabel.Location = new System.Drawing.Point(39, 171);
            amountToGetWithdrawLabel.Name = "amountToGetWithdrawLabel";
            amountToGetWithdrawLabel.Size = new System.Drawing.Size(89, 20);
            amountToGetWithdrawLabel.TabIndex = 3;
            amountToGetWithdrawLabel.Text = "You will get:";
            // 
            // balanceWithdrawTextBox
            // 
            balanceWithdrawTextBox.Location = new System.Drawing.Point(211, 103);
            balanceWithdrawTextBox.Name = "balanceWithdrawTextBox";
            balanceWithdrawTextBox.ReadOnly = true;
            balanceWithdrawTextBox.Size = new System.Drawing.Size(213, 27);
            balanceWithdrawTextBox.TabIndex = 1;
            // 
            // balanceWithdrawLabel
            // 
            balanceWithdrawLabel.AutoSize = true;
            balanceWithdrawLabel.Location = new System.Drawing.Point(39, 106);
            balanceWithdrawLabel.Name = "balanceWithdrawLabel";
            balanceWithdrawLabel.Size = new System.Drawing.Size(64, 20);
            balanceWithdrawLabel.TabIndex = 1;
            balanceWithdrawLabel.Text = "Balance:";
            // 
            // savingWithdrawComboBox
            // 
            savingWithdrawComboBox.FormattingEnabled = true;
            savingWithdrawComboBox.Location = new System.Drawing.Point(211, 69);
            savingWithdrawComboBox.Name = "savingWithdrawComboBox";
            savingWithdrawComboBox.Size = new System.Drawing.Size(213, 28);
            savingWithdrawComboBox.TabIndex = 0;
            savingWithdrawComboBox.SelectedValueChanged += savingWithdrawComboBox_SelectedValueChanged;
            // 
            // savingWithdrawLabel
            // 
            savingWithdrawLabel.AutoSize = true;
            savingWithdrawLabel.Location = new System.Drawing.Point(39, 72);
            savingWithdrawLabel.Name = "savingWithdrawLabel";
            savingWithdrawLabel.Size = new System.Drawing.Size(56, 20);
            savingWithdrawLabel.TabIndex = 0;
            savingWithdrawLabel.Text = "Saving:";
            // 
            // SavingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(529, 345);
            Controls.Add(savingTabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "SavingsForm";
            Text = "Saving";
            Load += SavingsForm_Load;
            savingTabControl.ResumeLayout(false);
            detailsTabPage.ResumeLayout(false);
            detailsTabPage.PerformLayout();
            depositTabPage.ResumeLayout(false);
            depositTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountDepositNumeric).EndInit();
            withdrawTabPage.ResumeLayout(false);
            withdrawTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl savingTabControl;
        private System.Windows.Forms.TabPage depositTabPage;
        private System.Windows.Forms.TabPage withdrawTabPage;
        private System.Windows.Forms.Label balanceDepositLabel;
        private System.Windows.Forms.ComboBox periodDepositComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.NumericUpDown amountDepositNumeric;
        private System.Windows.Forms.TextBox balanceDepositTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TabPage detailsTabPage;
        private System.Windows.Forms.Label savingsDetailsLabel;
        private System.Windows.Forms.ComboBox savingDetailsComboBox;
        private System.Windows.Forms.Label periodDetailsLabel;
        private System.Windows.Forms.TextBox balanceDetailsTextBox;
        private System.Windows.Forms.Label balanceDetailsLabel;
        private System.Windows.Forms.TextBox openDayDetailsTextBox;
        private System.Windows.Forms.Label openDayDetailsLabel;
        private System.Windows.Forms.TextBox interestDetailsTextBox;
        private System.Windows.Forms.Label interestDetailsLabel;
        private System.Windows.Forms.TextBox periodDetailsTextBox;
        private System.Windows.Forms.TextBox interestDepositTextBox;
        private System.Windows.Forms.Label interestDepositLabel;
        private System.Windows.Forms.Button withdrawDetailsButton;
        private System.Windows.Forms.TextBox amountToGetWithdrawTextBox;
        private System.Windows.Forms.Label amountToGetWithdrawLabel;
        private System.Windows.Forms.TextBox balanceWithdrawTextBox;
        private System.Windows.Forms.Label balanceWithdrawLabel;
        private System.Windows.Forms.ComboBox savingWithdrawComboBox;
        private System.Windows.Forms.Label savingWithdrawLabel;
        private System.Windows.Forms.Button withdrawWithdrawButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maturityDayDetailsTextBox;
        private System.Windows.Forms.TextBox maturityDayDepositTextBox;
        private System.Windows.Forms.Label maturityDayDepositLabel;
        private System.Windows.Forms.TextBox maturityDayWithdrawTextBox;
        private System.Windows.Forms.Label maturityDayWithdrawLabel;
    }
}