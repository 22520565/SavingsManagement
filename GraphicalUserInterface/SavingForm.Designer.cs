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
            closeSavingDetailsButton = new System.Windows.Forms.Button();
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
            maturityDayOpeningTextBox = new System.Windows.Forms.TextBox();
            maturityDayOpeningLabel = new System.Windows.Forms.Label();
            interestOpeningTextBox = new System.Windows.Forms.TextBox();
            interestOpeningLabel = new System.Windows.Forms.Label();
            openingSavingOpeningButton = new System.Windows.Forms.Button();
            balanceOpeningTextBox = new System.Windows.Forms.TextBox();
            amountOpeningNumeric = new System.Windows.Forms.NumericUpDown();
            amountOpeningLabel = new System.Windows.Forms.Label();
            periodOpeningLabel = new System.Windows.Forms.Label();
            periodOpeningComboBox = new System.Windows.Forms.ComboBox();
            balanceOpeningLabel = new System.Windows.Forms.Label();
            withdrawTabPage = new System.Windows.Forms.TabPage();
            maturityDayClosingTextBox = new System.Windows.Forms.TextBox();
            maturityDayClosingLabel = new System.Windows.Forms.Label();
            closingSavingClosingButton = new System.Windows.Forms.Button();
            amountToGetClosingTextBox = new System.Windows.Forms.TextBox();
            amountToGetClosingLabel = new System.Windows.Forms.Label();
            balanceClosingTextBox = new System.Windows.Forms.TextBox();
            balanceClosingLabel = new System.Windows.Forms.Label();
            savingClosingComboBox = new System.Windows.Forms.ComboBox();
            savingClosingLabel = new System.Windows.Forms.Label();
            savingTabControl.SuspendLayout();
            detailsTabPage.SuspendLayout();
            depositTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountOpeningNumeric).BeginInit();
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
            // closeSavingDetailsButton
            // 
            closeSavingDetailsButton.Enabled = false;
            closeSavingDetailsButton.Location = new System.Drawing.Point(379, 258);
            closeSavingDetailsButton.Name = "closeSavingDetailsButton";
            closeSavingDetailsButton.Size = new System.Drawing.Size(99, 29);
            closeSavingDetailsButton.TabIndex = 5;
            closeSavingDetailsButton.Text = "Close saving";
            closeSavingDetailsButton.UseVisualStyleBackColor = true;
            closeSavingDetailsButton.Click += closingSavingDetailsButton_Click;
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
            openDayDetailsLabel.Size = new System.Drawing.Size(97, 20);
            openDayDetailsLabel.TabIndex = 4;
            openDayDetailsLabel.Text = "Opening day:";
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
            depositTabPage.Padding = new System.Windows.Forms.Padding(3);
            depositTabPage.Size = new System.Drawing.Size(521, 312);
            depositTabPage.TabIndex = 0;
            depositTabPage.Text = "Opening";
            depositTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayOpeningTextBox
            // 
            maturityDayOpeningTextBox.Location = new System.Drawing.Point(196, 153);
            maturityDayOpeningTextBox.Name = "maturityDayOpeningTextBox";
            maturityDayOpeningTextBox.ReadOnly = true;
            maturityDayOpeningTextBox.Size = new System.Drawing.Size(244, 27);
            maturityDayOpeningTextBox.TabIndex = 9;
            // 
            // maturityDayOpeningLabel
            // 
            maturityDayOpeningLabel.AutoSize = true;
            maturityDayOpeningLabel.Location = new System.Drawing.Point(49, 156);
            maturityDayOpeningLabel.Name = "maturityDayOpeningLabel";
            maturityDayOpeningLabel.Size = new System.Drawing.Size(95, 20);
            maturityDayOpeningLabel.TabIndex = 8;
            maturityDayOpeningLabel.Text = "Maturity day:";
            // 
            // interestOpeningTextBox
            // 
            interestOpeningTextBox.Location = new System.Drawing.Point(196, 117);
            interestOpeningTextBox.Name = "interestOpeningTextBox";
            interestOpeningTextBox.ReadOnly = true;
            interestOpeningTextBox.ShortcutsEnabled = false;
            interestOpeningTextBox.Size = new System.Drawing.Size(244, 27);
            interestOpeningTextBox.TabIndex = 2;
            // 
            // interestOpeningLabel
            // 
            interestOpeningLabel.AutoSize = true;
            interestOpeningLabel.Location = new System.Drawing.Point(49, 120);
            interestOpeningLabel.Name = "interestOpeningLabel";
            interestOpeningLabel.Size = new System.Drawing.Size(141, 20);
            interestOpeningLabel.TabIndex = 2;
            interestOpeningLabel.Text = "Annual interest rate:";
            // 
            // openingSavingOpeningButton
            // 
            openingSavingOpeningButton.Enabled = false;
            openingSavingOpeningButton.Location = new System.Drawing.Point(387, 245);
            openingSavingOpeningButton.Name = "openingSavingOpeningButton";
            openingSavingOpeningButton.Size = new System.Drawing.Size(104, 29);
            openingSavingOpeningButton.TabIndex = 3;
            openingSavingOpeningButton.Text = "Open saving";
            openingSavingOpeningButton.UseVisualStyleBackColor = true;
            openingSavingOpeningButton.Click += openingSavingOpeningButton_Click;
            // 
            // balanceOpeningTextBox
            // 
            balanceOpeningTextBox.Location = new System.Drawing.Point(196, 44);
            balanceOpeningTextBox.Name = "balanceOpeningTextBox";
            balanceOpeningTextBox.ReadOnly = true;
            balanceOpeningTextBox.ShortcutsEnabled = false;
            balanceOpeningTextBox.Size = new System.Drawing.Size(244, 27);
            balanceOpeningTextBox.TabIndex = 0;
            // 
            // amountOpeningNumeric
            // 
            amountOpeningNumeric.DecimalPlaces = 2;
            amountOpeningNumeric.Location = new System.Drawing.Point(196, 189);
            amountOpeningNumeric.Name = "amountOpeningNumeric";
            amountOpeningNumeric.Size = new System.Drawing.Size(244, 27);
            amountOpeningNumeric.TabIndex = 3;
            // 
            // amountOpeningLabel
            // 
            amountOpeningLabel.AutoSize = true;
            amountOpeningLabel.Location = new System.Drawing.Point(49, 192);
            amountOpeningLabel.Name = "amountOpeningLabel";
            amountOpeningLabel.Size = new System.Drawing.Size(119, 20);
            amountOpeningLabel.TabIndex = 2;
            amountOpeningLabel.Text = "Deposit amount:";
            // 
            // periodOpeningLabel
            // 
            periodOpeningLabel.AutoSize = true;
            periodOpeningLabel.Location = new System.Drawing.Point(49, 84);
            periodOpeningLabel.Name = "periodOpeningLabel";
            periodOpeningLabel.Size = new System.Drawing.Size(117, 20);
            periodOpeningLabel.TabIndex = 1;
            periodOpeningLabel.Text = "Period (months):";
            // 
            // periodOpeningComboBox
            // 
            periodOpeningComboBox.FormattingEnabled = true;
            periodOpeningComboBox.Location = new System.Drawing.Point(196, 80);
            periodOpeningComboBox.Name = "periodOpeningComboBox";
            periodOpeningComboBox.Size = new System.Drawing.Size(244, 28);
            periodOpeningComboBox.TabIndex = 1;
            periodOpeningComboBox.SelectedValueChanged += periodDepositComboBox_SelectedValueChanged;
            // 
            // balanceOpeningLabel
            // 
            balanceOpeningLabel.AutoSize = true;
            balanceOpeningLabel.Location = new System.Drawing.Point(49, 47);
            balanceOpeningLabel.Name = "balanceOpeningLabel";
            balanceOpeningLabel.Size = new System.Drawing.Size(97, 20);
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
            withdrawTabPage.Padding = new System.Windows.Forms.Padding(3);
            withdrawTabPage.Size = new System.Drawing.Size(521, 312);
            withdrawTabPage.TabIndex = 1;
            withdrawTabPage.Text = "Closing";
            withdrawTabPage.UseVisualStyleBackColor = true;
            // 
            // maturityDayClosingTextBox
            // 
            maturityDayClosingTextBox.Location = new System.Drawing.Point(223, 133);
            maturityDayClosingTextBox.Name = "maturityDayClosingTextBox";
            maturityDayClosingTextBox.ReadOnly = true;
            maturityDayClosingTextBox.Size = new System.Drawing.Size(213, 27);
            maturityDayClosingTextBox.TabIndex = 2;
            // 
            // maturityDayClosingLabel
            // 
            maturityDayClosingLabel.AutoSize = true;
            maturityDayClosingLabel.Location = new System.Drawing.Point(51, 136);
            maturityDayClosingLabel.Name = "maturityDayClosingLabel";
            maturityDayClosingLabel.Size = new System.Drawing.Size(95, 20);
            maturityDayClosingLabel.TabIndex = 2;
            maturityDayClosingLabel.Text = "Maturity day:";
            // 
            // closingSavingClosingButton
            // 
            closingSavingClosingButton.Enabled = false;
            closingSavingClosingButton.Location = new System.Drawing.Point(386, 226);
            closingSavingClosingButton.Name = "closingSavingClosingButton";
            closingSavingClosingButton.Size = new System.Drawing.Size(99, 29);
            closingSavingClosingButton.TabIndex = 4;
            closingSavingClosingButton.Text = "Close saving";
            closingSavingClosingButton.UseVisualStyleBackColor = true;
            closingSavingClosingButton.Click += closingSavingClosingButton_Click;
            // 
            // amountToGetClosingTextBox
            // 
            amountToGetClosingTextBox.Location = new System.Drawing.Point(223, 165);
            amountToGetClosingTextBox.Name = "amountToGetClosingTextBox";
            amountToGetClosingTextBox.ReadOnly = true;
            amountToGetClosingTextBox.Size = new System.Drawing.Size(213, 27);
            amountToGetClosingTextBox.TabIndex = 3;
            // 
            // amountToGetClosingLabel
            // 
            amountToGetClosingLabel.AutoSize = true;
            amountToGetClosingLabel.Location = new System.Drawing.Point(51, 168);
            amountToGetClosingLabel.Name = "amountToGetClosingLabel";
            amountToGetClosingLabel.Size = new System.Drawing.Size(89, 20);
            amountToGetClosingLabel.TabIndex = 3;
            amountToGetClosingLabel.Text = "You will get:";
            // 
            // balanceClosingTextBox
            // 
            balanceClosingTextBox.Location = new System.Drawing.Point(223, 100);
            balanceClosingTextBox.Name = "balanceClosingTextBox";
            balanceClosingTextBox.ReadOnly = true;
            balanceClosingTextBox.Size = new System.Drawing.Size(213, 27);
            balanceClosingTextBox.TabIndex = 1;
            // 
            // balanceClosingLabel
            // 
            balanceClosingLabel.AutoSize = true;
            balanceClosingLabel.Location = new System.Drawing.Point(51, 103);
            balanceClosingLabel.Name = "balanceClosingLabel";
            balanceClosingLabel.Size = new System.Drawing.Size(64, 20);
            balanceClosingLabel.TabIndex = 1;
            balanceClosingLabel.Text = "Balance:";
            // 
            // savingClosingComboBox
            // 
            savingClosingComboBox.FormattingEnabled = true;
            savingClosingComboBox.Location = new System.Drawing.Point(223, 66);
            savingClosingComboBox.Name = "savingClosingComboBox";
            savingClosingComboBox.Size = new System.Drawing.Size(213, 28);
            savingClosingComboBox.TabIndex = 0;
            savingClosingComboBox.SelectedValueChanged += savingClosingComboBox_SelectedValueChanged;
            // 
            // savingClosingLabel
            // 
            savingClosingLabel.AutoSize = true;
            savingClosingLabel.Location = new System.Drawing.Point(51, 69);
            savingClosingLabel.Name = "savingClosingLabel";
            savingClosingLabel.Size = new System.Drawing.Size(56, 20);
            savingClosingLabel.TabIndex = 0;
            savingClosingLabel.Text = "Saving:";
            // 
            // SavingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(529, 345);
            Controls.Add(savingTabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "SavingForm";
            Text = "Saving";
            Load += SavingsForm_Load;
            savingTabControl.ResumeLayout(false);
            detailsTabPage.ResumeLayout(false);
            detailsTabPage.PerformLayout();
            depositTabPage.ResumeLayout(false);
            depositTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountOpeningNumeric).EndInit();
            withdrawTabPage.ResumeLayout(false);
            withdrawTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl savingTabControl;
        private System.Windows.Forms.TabPage depositTabPage;
        private System.Windows.Forms.TabPage withdrawTabPage;
        private System.Windows.Forms.Label balanceOpeningLabel;
        private System.Windows.Forms.ComboBox periodOpeningComboBox;
        private System.Windows.Forms.Label amountOpeningLabel;
        private System.Windows.Forms.Label periodOpeningLabel;
        private System.Windows.Forms.NumericUpDown amountOpeningNumeric;
        private System.Windows.Forms.TextBox balanceOpeningTextBox;
        private System.Windows.Forms.Button openingSavingOpeningButton;
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
        private System.Windows.Forms.TextBox interestOpeningTextBox;
        private System.Windows.Forms.Label interestOpeningLabel;
        private System.Windows.Forms.Button closeSavingDetailsButton;
        private System.Windows.Forms.TextBox amountToGetClosingTextBox;
        private System.Windows.Forms.Label amountToGetClosingLabel;
        private System.Windows.Forms.TextBox balanceClosingTextBox;
        private System.Windows.Forms.Label balanceClosingLabel;
        private System.Windows.Forms.ComboBox savingClosingComboBox;
        private System.Windows.Forms.Label savingClosingLabel;
        private System.Windows.Forms.Button closingSavingClosingButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maturityDayDetailsTextBox;
        private System.Windows.Forms.TextBox maturityDayOpeningTextBox;
        private System.Windows.Forms.Label maturityDayOpeningLabel;
        private System.Windows.Forms.TextBox maturityDayClosingTextBox;
        private System.Windows.Forms.Label maturityDayClosingLabel;
    }
}