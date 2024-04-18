namespace GraphicalUserInterface
{
    partial class SavingsForm
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
            button1 = new System.Windows.Forms.Button();
            openDateDetailsTextBox = new System.Windows.Forms.TextBox();
            openDateDetailsLabel = new System.Windows.Forms.Label();
            interestDetailsTextBox = new System.Windows.Forms.TextBox();
            interestDetailsLabel = new System.Windows.Forms.Label();
            periodDetailsTextBox = new System.Windows.Forms.TextBox();
            periodDetailsLabel = new System.Windows.Forms.Label();
            balanceDetailsTextBox = new System.Windows.Forms.TextBox();
            balanceDetailsLabel = new System.Windows.Forms.Label();
            savingDetailsComboBox = new System.Windows.Forms.ComboBox();
            savingsDetailsLabel = new System.Windows.Forms.Label();
            depositTabPage = new System.Windows.Forms.TabPage();
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
            button2 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
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
            savingTabControl.Size = new System.Drawing.Size(523, 275);
            savingTabControl.TabIndex = 0;
            // 
            // detailsTabPage
            // 
            detailsTabPage.Controls.Add(button1);
            detailsTabPage.Controls.Add(openDateDetailsTextBox);
            detailsTabPage.Controls.Add(openDateDetailsLabel);
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
            detailsTabPage.Size = new System.Drawing.Size(515, 242);
            detailsTabPage.TabIndex = 2;
            detailsTabPage.Text = "Details";
            detailsTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(305, 204);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Withdraw";
            button1.UseVisualStyleBackColor = true;
            // 
            // openDateDetailsTextBox
            // 
            openDateDetailsTextBox.Location = new System.Drawing.Point(190, 159);
            openDateDetailsTextBox.Name = "openDateDetailsTextBox";
            openDateDetailsTextBox.ReadOnly = true;
            openDateDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            openDateDetailsTextBox.TabIndex = 4;
            // 
            // openDateDetailsLabel
            // 
            openDateDetailsLabel.AutoSize = true;
            openDateDetailsLabel.Location = new System.Drawing.Point(18, 162);
            openDateDetailsLabel.Name = "openDateDetailsLabel";
            openDateDetailsLabel.Size = new System.Drawing.Size(82, 20);
            openDateDetailsLabel.TabIndex = 4;
            openDateDetailsLabel.Text = "Open date:";
            // 
            // interestDetailsTextBox
            // 
            interestDetailsTextBox.Location = new System.Drawing.Point(190, 122);
            interestDetailsTextBox.Name = "interestDetailsTextBox";
            interestDetailsTextBox.ReadOnly = true;
            interestDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            interestDetailsTextBox.TabIndex = 3;
            // 
            // interestDetailsLabel
            // 
            interestDetailsLabel.AutoSize = true;
            interestDetailsLabel.Location = new System.Drawing.Point(18, 125);
            interestDetailsLabel.Name = "interestDetailsLabel";
            interestDetailsLabel.Size = new System.Drawing.Size(141, 20);
            interestDetailsLabel.TabIndex = 3;
            interestDetailsLabel.Text = "Annual interest rate:";
            // 
            // periodDetailsTextBox
            // 
            periodDetailsTextBox.Location = new System.Drawing.Point(190, 87);
            periodDetailsTextBox.Name = "periodDetailsTextBox";
            periodDetailsTextBox.ReadOnly = true;
            periodDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            periodDetailsTextBox.TabIndex = 2;
            // 
            // periodDetailsLabel
            // 
            periodDetailsLabel.AutoSize = true;
            periodDetailsLabel.Location = new System.Drawing.Point(18, 90);
            periodDetailsLabel.Name = "periodDetailsLabel";
            periodDetailsLabel.Size = new System.Drawing.Size(117, 20);
            periodDetailsLabel.TabIndex = 2;
            periodDetailsLabel.Text = "Period (months):";
            // 
            // balanceDetailsTextBox
            // 
            balanceDetailsTextBox.Location = new System.Drawing.Point(190, 50);
            balanceDetailsTextBox.Name = "balanceDetailsTextBox";
            balanceDetailsTextBox.ReadOnly = true;
            balanceDetailsTextBox.Size = new System.Drawing.Size(213, 27);
            balanceDetailsTextBox.TabIndex = 1;
            // 
            // balanceDetailsLabel
            // 
            balanceDetailsLabel.AutoSize = true;
            balanceDetailsLabel.Location = new System.Drawing.Point(18, 53);
            balanceDetailsLabel.Name = "balanceDetailsLabel";
            balanceDetailsLabel.Size = new System.Drawing.Size(64, 20);
            balanceDetailsLabel.TabIndex = 1;
            balanceDetailsLabel.Text = "Balance:";
            // 
            // savingDetailsComboBox
            // 
            savingDetailsComboBox.FormattingEnabled = true;
            savingDetailsComboBox.Location = new System.Drawing.Point(190, 16);
            savingDetailsComboBox.Name = "savingDetailsComboBox";
            savingDetailsComboBox.Size = new System.Drawing.Size(213, 28);
            savingDetailsComboBox.TabIndex = 0;
            savingDetailsComboBox.SelectionChangeCommitted += savingComboBox_SelectionChangeCommitted;
            savingDetailsComboBox.Click += savingComboBox_Click;
            // 
            // savingsDetailsLabel
            // 
            savingsDetailsLabel.AutoSize = true;
            savingsDetailsLabel.Location = new System.Drawing.Point(18, 19);
            savingsDetailsLabel.Name = "savingsDetailsLabel";
            savingsDetailsLabel.Size = new System.Drawing.Size(56, 20);
            savingsDetailsLabel.TabIndex = 0;
            savingsDetailsLabel.Text = "Saving:";
            // 
            // depositTabPage
            // 
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
            depositTabPage.Size = new System.Drawing.Size(515, 242);
            depositTabPage.TabIndex = 0;
            depositTabPage.Text = " Deposit";
            depositTabPage.UseVisualStyleBackColor = true;
            // 
            // interestDepositTextBox
            // 
            interestDepositTextBox.Location = new System.Drawing.Point(167, 89);
            interestDepositTextBox.Name = "interestDepositTextBox";
            interestDepositTextBox.ReadOnly = true;
            interestDepositTextBox.ShortcutsEnabled = false;
            interestDepositTextBox.Size = new System.Drawing.Size(244, 27);
            interestDepositTextBox.TabIndex = 2;
            // 
            // interestDepositLabel
            // 
            interestDepositLabel.AutoSize = true;
            interestDepositLabel.Location = new System.Drawing.Point(20, 92);
            interestDepositLabel.Name = "interestDepositLabel";
            interestDepositLabel.Size = new System.Drawing.Size(141, 20);
            interestDepositLabel.TabIndex = 2;
            interestDepositLabel.Text = "Annual interest rate:";
            // 
            // depositButton
            // 
            depositButton.Location = new System.Drawing.Point(386, 164);
            depositButton.Name = "depositButton";
            depositButton.Size = new System.Drawing.Size(94, 29);
            depositButton.TabIndex = 3;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // balanceDepositTextBox
            // 
            balanceDepositTextBox.Location = new System.Drawing.Point(167, 16);
            balanceDepositTextBox.Name = "balanceDepositTextBox";
            balanceDepositTextBox.ReadOnly = true;
            balanceDepositTextBox.ShortcutsEnabled = false;
            balanceDepositTextBox.Size = new System.Drawing.Size(244, 27);
            balanceDepositTextBox.TabIndex = 0;
            // 
            // amountDepositNumeric
            // 
            amountDepositNumeric.DecimalPlaces = 2;
            amountDepositNumeric.Location = new System.Drawing.Point(167, 125);
            amountDepositNumeric.Name = "amountDepositNumeric";
            amountDepositNumeric.Size = new System.Drawing.Size(244, 27);
            amountDepositNumeric.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Amount to deposit:";
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Location = new System.Drawing.Point(20, 56);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(117, 20);
            periodLabel.TabIndex = 1;
            periodLabel.Text = "Period (months):";
            // 
            // periodDepositComboBox
            // 
            periodDepositComboBox.FormattingEnabled = true;
            periodDepositComboBox.Location = new System.Drawing.Point(167, 52);
            periodDepositComboBox.Name = "periodDepositComboBox";
            periodDepositComboBox.Size = new System.Drawing.Size(244, 28);
            periodDepositComboBox.TabIndex = 1;
            periodDepositComboBox.SelectionChangeCommitted += periodDepositComboBox_SelectionChangeCommitted;
            // 
            // balanceDepositLabel
            // 
            balanceDepositLabel.AutoSize = true;
            balanceDepositLabel.Location = new System.Drawing.Point(20, 19);
            balanceDepositLabel.Name = "balanceDepositLabel";
            balanceDepositLabel.Size = new System.Drawing.Size(97, 20);
            balanceDepositLabel.TabIndex = 0;
            balanceDepositLabel.Text = "Your balance:";
            // 
            // withdrawTabPage
            // 
            withdrawTabPage.Controls.Add(button2);
            withdrawTabPage.Controls.Add(textBox2);
            withdrawTabPage.Controls.Add(label4);
            withdrawTabPage.Controls.Add(textBox1);
            withdrawTabPage.Controls.Add(label1);
            withdrawTabPage.Controls.Add(comboBox1);
            withdrawTabPage.Controls.Add(label2);
            withdrawTabPage.Location = new System.Drawing.Point(4, 29);
            withdrawTabPage.Name = "withdrawTabPage";
            withdrawTabPage.Padding = new System.Windows.Forms.Padding(3);
            withdrawTabPage.Size = new System.Drawing.Size(515, 242);
            withdrawTabPage.TabIndex = 1;
            withdrawTabPage.Text = "Withdraw";
            withdrawTabPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(341, 169);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(232, 115);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(213, 27);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(60, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "You will get:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(232, 80);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(213, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Balance:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(232, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(213, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Saving:";
            // 
            // SavingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 275);
            Controls.Add(savingTabControl);
            Name = "SavingsForm";
            Text = "SavingsForm";
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
        private System.Windows.Forms.TextBox openDateDetailsTextBox;
        private System.Windows.Forms.Label openDateDetailsLabel;
        private System.Windows.Forms.TextBox interestDetailsTextBox;
        private System.Windows.Forms.Label interestDetailsLabel;
        private System.Windows.Forms.TextBox periodDetailsTextBox;
        private System.Windows.Forms.TextBox interestDepositTextBox;
        private System.Windows.Forms.Label interestDepositLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}