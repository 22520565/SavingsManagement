namespace GraphicalUserInterface
{
    partial class SavingReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingReportForm));
            reportViewerSaving = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewerSaving
            // 
            reportViewerSaving.Dock = System.Windows.Forms.DockStyle.Fill;
            reportViewerSaving.Location = new System.Drawing.Point(0, 0);
            reportViewerSaving.Margin = new System.Windows.Forms.Padding(4);
            reportViewerSaving.Name = "reportViewerSaving";
            reportViewerSaving.ServerReport.BearerToken = null;
            reportViewerSaving.Size = new System.Drawing.Size(1378, 844);
            reportViewerSaving.TabIndex = 0;
            // 
            // SavingReportForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1378, 844);
            Controls.Add(reportViewerSaving);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "SavingReportForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Report Saving";
            Load += SavingReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSaving;
    }
}