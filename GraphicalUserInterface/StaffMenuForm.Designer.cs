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
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPageManageStaffs = new System.Windows.Forms.TabPage();
            tabPageChangeRegulations = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
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
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1578, 944);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 47);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1570, 893);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 47);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1570, 893);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recharge";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 47);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1570, 893);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Withdraw";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 47);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(1570, 893);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Customer Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPageManageStaffs
            // 
            tabPageManageStaffs.Location = new System.Drawing.Point(4, 47);
            tabPageManageStaffs.Name = "tabPageManageStaffs";
            tabPageManageStaffs.Size = new System.Drawing.Size(1570, 893);
            tabPageManageStaffs.TabIndex = 3;
            tabPageManageStaffs.Text = "Staff Management";
            tabPageManageStaffs.UseVisualStyleBackColor = true;
            // 
            // tabPageChangeRegulations
            // 
            tabPageChangeRegulations.Location = new System.Drawing.Point(4, 47);
            tabPageChangeRegulations.Name = "tabPageChangeRegulations";
            tabPageChangeRegulations.Size = new System.Drawing.Size(1570, 893);
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
            Name = "StaffMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StaffMenuForm";
            FormClosing += StaffMenuForm_FormClosing;
            Load += StaffMenuForm_Load;
            tabControl1.ResumeLayout(false);
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
    }
}