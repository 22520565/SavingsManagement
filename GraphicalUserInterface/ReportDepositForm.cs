namespace GraphicalUserInterface
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.Reporting.WinForms;
    using Business;
    using DataAccess;

    public partial class ReportDepositForm : Form
    {
        private int depositID;
        private DataTable dt;

        public ReportDepositForm(int depositId)
        {
            InitializeComponent();
            this.depositID = depositId;
        }

        private void ReportDepositForm_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewerDeposit.LocalReport.ReportEmbeddedResource = "GraphicalUserInterface.ReportDeposit.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                using (var context = new SavingsManagementContext())
                {
                    var deposits = (from cf in context.CashFlows
                                    join ca in context.CustomerAccounts on cf.CustomerId equals ca.Id
                                    where cf.BalanceChanging > 0 && cf.Id == depositID
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

                    foreach (var deposit in deposits)
                    {
                        dt.Rows.Add(deposit.Id, deposit.CustomerName, deposit.Time.UtcDateTime, deposit.BalanceChanging);
                    }
                }
                reportDataSource.Value = dt;

                // Thay thế giá trị cột Content bằng giá trị cột CustomerName
                reportViewerDeposit.LocalReport.DataSources.Clear();
                reportViewerDeposit.LocalReport.DataSources.Add(reportDataSource);
                reportViewerDeposit.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

                reportViewerDeposit.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
