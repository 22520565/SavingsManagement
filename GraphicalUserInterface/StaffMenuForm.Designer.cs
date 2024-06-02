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
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPageManageStaffs = new System.Windows.Forms.TabPage();
            tabPageChangeRegulations = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDepositAmountNumeric).BeginInit();
            SuspendLayout();
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
            tabPage3.Location = new System.Drawing.Point(4, 35);
            tabPage3.Margin = new System.Windows.Forms.Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1254, 716);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Withdraw";
            tabPage3.UseVisualStyleBackColor = true;
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
    }
}