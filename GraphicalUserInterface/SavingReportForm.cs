namespace GraphicalUserInterface;

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DataAccess;
using Microsoft.Reporting.WinForms;
using Properties;

public partial class SavingReportForm : Form
{
    private Saving saving = new Saving();

    public SavingReportForm(Saving saving)
    {
        this.InitializeComponent();
        this.saving = saving;
    }

    private void reportViewer_Load(object sender, EventArgs e)
    {
        using SavingsManagementDataSet savingsManagementDataSet = new SavingsManagementDataSet();
        DataTable savingsDataTable = savingsManagementDataSet.Savings;
        MemoryStream memoryStream = new MemoryStream(Resources.SavingsReport);
        savingsDataTable.Rows.Add(this.saving.Id, this.saving.CustomerId, this.saving.Balance, this.saving.AnnualInterestRate, this.saving.PeriodInMonths, this.saving.OpeningDateTime);
        ReportDataSource reportDataSource = new ReportDataSource(
            "SavingsDataSet", savingsDataTable
        );

        this.reportViewer.Reset();
        this.reportViewer.ProcessingMode = ProcessingMode.Local;
        this.reportViewer.LocalReport.LoadReportDefinition(memoryStream);
        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer.RefreshReport();
    }

    private void SavingReportForm_Load(object sender, EventArgs e)
    {

    }
}
