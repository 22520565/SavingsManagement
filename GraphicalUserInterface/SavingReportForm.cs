namespace GraphicalUserInterface;

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Microsoft.Reporting.WinForms;
using Properties;

public partial class SavingReportForm : Form
{
    private Saving saving = new Saving();
    private DataTable dt;

    public SavingReportForm(Saving saving)
    {
        this.InitializeComponent();
        this.saving = saving;
    }

    private void SavingReportForm_Load(object sender, EventArgs e)
    {
        try
        {
            reportViewerSaving.LocalReport.ReportEmbeddedResource = "GraphicalUserInterface.SavingsReport.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            using (var context = new SavingsManagementContext())
            {
                var savings = context.Savings.Where(s => s.Id == saving.Id)
                                        .Select(s => new
                                        {
                                            s.Id,
                                            s.CustomerId,
                                            s.Balance,
                                            s.AnnualInterestRate,
                                            s.PeriodInMonths,
                                            s.OpeningDateTime,
                                        }).ToList();

                // Convert the list to a DataTable
                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("CustomerId", typeof(string));
                dt.Columns.Add("Balance", typeof(decimal));
                dt.Columns.Add("AnnualInterestRate", typeof(decimal));
                dt.Columns.Add("PeriodInMonths", typeof(int));
                dt.Columns.Add("OpeningDateTime", typeof(DateTimeOffset));
                

                foreach (var saving in savings)
                {
                    dt.Rows.Add(saving.Id, saving.CustomerId, saving.Balance, saving.AnnualInterestRate, saving.PeriodInMonths, saving.OpeningDateTime);
                }
            }
            reportDataSource.Value = dt;

            // Thay thế giá trị cột Content bằng giá trị cột CustomerName
            reportViewerSaving.LocalReport.DataSources.Clear();
            reportViewerSaving.LocalReport.DataSources.Add(reportDataSource);
            reportViewerSaving.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

            reportViewerSaving.RefreshReport();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
