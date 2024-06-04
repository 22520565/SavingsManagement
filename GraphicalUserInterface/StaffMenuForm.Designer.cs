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
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPageManageStaffs = new System.Windows.Forms.TabPage();
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
            tabControl1.Controls.Add(tabPage4);
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
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 35);
            tabPage1.Margin = new System.Windows.Forms.Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2);
            tabPage1.Size = new System.Drawing.Size(1254, 716);
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
            tabPage2.Location = new System.Drawing.Point(4, 35);
            tabPage2.Margin = new System.Windows.Forms.Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(2);
            tabPage2.Size = new System.Drawing.Size(1254, 716);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deposit";
            tabPage2.UseVisualStyleBackColor = true;
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
            tabPage3.Location = new System.Drawing.Point(4, 35);
            tabPage3.Margin = new System.Windows.Forms.Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1254, 716);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Withdraw";
            tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 35);
            tabPage4.Margin = new System.Windows.Forms.Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(1254, 716);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Customer Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPageManageStaffs
            // 
            tabPageManageStaffs.Location = new System.Drawing.Point(4, 35);
            tabPageManageStaffs.Margin = new System.Windows.Forms.Padding(2);
            tabPageManageStaffs.Name = "tabPageManageStaffs";
            tabPageManageStaffs.Size = new System.Drawing.Size(1254, 716);
            tabPageManageStaffs.TabIndex = 3;
            tabPageManageStaffs.Text = "Staff Management";
            tabPageManageStaffs.UseVisualStyleBackColor = true;
            // 
            // tabPageChangeRegulations
            // 
            tabPageChangeRegulations.Location = new System.Drawing.Point(4, 35);
            tabPageChangeRegulations.Margin = new System.Windows.Forms.Padding(2);
            tabPageChangeRegulations.Name = "tabPageChangeRegulations";
            tabPageChangeRegulations.Size = new System.Drawing.Size(1254, 716);
            tabPageChangeRegulations.TabIndex = 4;
            tabPageChangeRegulations.Text = "Change regulations";
            tabPageChangeRegulations.UseVisualStyleBackColor = true;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerWithdrawAmountNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageManageStaffs;
        private System.Windows.Forms.TabPage tabPageChangeRegulations;
        private System.Windows.Forms.TabPage tabPage4;
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
    }
}