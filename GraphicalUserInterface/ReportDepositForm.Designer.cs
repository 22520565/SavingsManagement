namespace GraphicalUserInterface
{
    partial class ReportDepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDepositForm));
            reportViewerDeposit = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewerDeposit
            // 
            reportViewerDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            reportViewerDeposit.Location = new System.Drawing.Point(0, 0);
            reportViewerDeposit.Name = "reportViewerDeposit";
            reportViewerDeposit.ServerReport.BearerToken = null;
            reportViewerDeposit.Size = new System.Drawing.Size(1378, 844);
            reportViewerDeposit.TabIndex = 0;
            // 
            // ReportDepositForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1378, 844);
            Controls.Add(reportViewerDeposit);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ReportDepositForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Report Deposit";
            Load += ReportDepositForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDeposit;
    }
}