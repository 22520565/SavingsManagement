namespace GraphicalUserInterface;

using System;
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
        var dataTable = savingsManagementDataSet.Tables[savingsManagementDataSet.Savings.TableName];
        MemoryStream memoryStream = new MemoryStream(Resources.SavingsReport);
        dataTable?.Rows.Add(this.saving.Id, this.saving.CustomerId, this.saving.Balance, this.saving.AnnualInterestRate, this.saving.PeriodInMonths, this.saving.OpeningDateTime);
        ReportDataSource reportDataSource = new ReportDataSource(
            "SavingsDataSet", dataTable
        );

        this.reportViewer.Reset();
        this.reportViewer.ProcessingMode = ProcessingMode.Local;
        this.reportViewer.LocalReport.LoadReportDefinition(memoryStream);
        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer.RefreshReport();
    }
}
