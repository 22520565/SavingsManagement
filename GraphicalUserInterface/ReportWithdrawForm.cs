namespace GraphicalUserInterface;

using DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;


public partial class ReportWithdrawForm : Form
{
    private int withdrawID;
    private DataTable dt;

    public ReportWithdrawForm(int withdrawId)
    {
        InitializeComponent();
        this.withdrawID = withdrawId;
    }

    private void ReportWithdrawForm_Load(object sender, EventArgs e)
    {
        try
        {
            reportViewerWithdraw.LocalReport.ReportEmbeddedResource = "GraphicalUserInterface.ReportWithdraw.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            using (var context = new SavingsManagementContext())
            {
                var withdraws = (from cf in context.CashFlows
                                join ca in context.CustomerAccounts on cf.CustomerId equals ca.Id
                                where cf.BalanceChanging < 0 && cf.Id == withdrawID
                                select new
                                {
                                    cf.Id,
                                    cf.CustomerId,
                                    CustomerName = ca.Name,
                                    cf.Time,
                                    cf.BalanceChanging,
                                    cf.Content,
                                }).ToList();

                // Convert the list to a DataTable
                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Columns.Add("Time", typeof(DateTime));
                dt.Columns.Add("BalanceChanging", typeof(decimal));

                foreach (var wihtdraw in withdraws)
                {
                    dt.Rows.Add(wihtdraw.Id, wihtdraw.CustomerName, wihtdraw.Time.UtcDateTime, wihtdraw.BalanceChanging);
                }
            }
            reportDataSource.Value = dt;

            // Thay thế giá trị cột Content bằng giá trị cột CustomerName
            reportViewerWithdraw.LocalReport.DataSources.Clear();
            reportViewerWithdraw.LocalReport.DataSources.Add(reportDataSource);
            reportViewerWithdraw.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewerWithdraw.RefreshReport();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
