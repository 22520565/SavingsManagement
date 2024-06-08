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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportViewer.Location = new System.Drawing.Point(0, 0);
            reportViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new System.Drawing.Size(1378, 844);
            reportViewer.TabIndex = 0;
            reportViewer.Load += reportViewer_Load;
            // 
            // SavingReportForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1378, 844);
            Controls.Add(reportViewer);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "SavingReportForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SavingReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}