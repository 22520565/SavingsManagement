namespace GraphicalUserInterface
{
    partial class ReportWithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportWithdrawForm));
            reportViewerWithdraw = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewerWithdraw
            // 
            reportViewerWithdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            reportViewerWithdraw.Location = new System.Drawing.Point(0, 0);
            reportViewerWithdraw.Name = "reportViewerWithdraw";
            reportViewerWithdraw.ServerReport.BearerToken = null;
            reportViewerWithdraw.Size = new System.Drawing.Size(1378, 844);
            reportViewerWithdraw.TabIndex = 0;
            // 
            // ReportWithdrawForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1378, 844);
            Controls.Add(reportViewerWithdraw);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ReportWithdrawForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Report Withdraw";
            Load += ReportWithdrawForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerWithdraw;
    }
}