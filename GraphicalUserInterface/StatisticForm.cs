namespace GraphicalUserInterface;

using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Business;
using DataAccess;
using OfficeOpenXml;
using Properties;

public partial class StatisticForm : Form
{
    DataTable dt;
    public StatisticForm()
    {
        this.InitializeComponent();
        this.LoadingScene();
        this.LoadingTransactionList();
    }

    public void LoadingScene()
    {
        this.BackColor = Color.FromArgb(9, 13, 40);
        this.panelSavings.LeftColor = Color.FromArgb(240, 95, 34);
        this.panelSavings.RightColor = Color.FromArgb(240, 95, 34);
        this.panelSavings.Angle = 180;
        this.panelExpenses.LeftColor = Color.FromArgb(240, 95, 34);
        this.panelExpenses.RightColor = Color.FromArgb(240, 95, 34);
        this.panelExpenses.Angle = 180;
        this.panelTransactionList.BackColor = Color.FromArgb(24, 27, 58);
    }

    public void LoadingTransactionList()
    {
        dt = new DataTable();
        dt.Columns.AddRange(new[] { new DataColumn("Amount", typeof(string)),
                        new DataColumn("Transaction Time", typeof(string)),
            new DataColumn("Content", typeof(string))});
        int? currentCustomerId = CustomerAccounts.CurrentCustomerId;
        if (currentCustomerId.HasValue)
        {
            decimal expenses = decimal.Zero;
            decimal savings = decimal.Zero;
            var cashFlows = CashFlows.GetCashFlowsByCustomerId(currentCustomerId.Value);
            foreach (var cashFlow in cashFlows)
            {
                AddCashFlowEntry(cashFlow);
                if (cashFlow.BalanceChanging < decimal.Zero)
                {
                    expenses -= cashFlow.BalanceChanging;
                }
                else
                {
                    savings += cashFlow.BalanceChanging;
                }
            }
            lbExpenses.Text = expenses.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
            lbSavings.Text = savings.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
        }
        else
        {
            MessageBox.Show(Resources.NoCustomerLoggingInString);
        }

    }

    private void AddCashFlowEntry(CashFlow cashFlow)
    {
        dt.Rows.Add(cashFlow.BalanceChanging.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture),
            cashFlow.Time.ToString(Resources.DateTimeStringFormat, CultureInfo.CurrentCulture),
            cashFlow.Content);
        this.data_Transactions.DataSource = dt;
        data_Transactions.Columns[0].ReadOnly = false;
        for (int k = 1; k < data_Transactions.Columns.Count; k++)
        {
            data_Transactions.Columns[k].ReadOnly = true;
        }
        this.data_Transactions.AllowUserToAddRows = false;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        try
        {
            using SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = Resources.SavingExcelFileFilter;
            if (data_Transactions.Rows.Count > 0 && saveFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFile.FileName);
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using ExcelPackage pck = new ExcelPackage(fileInfo);
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");
                for (int i = 0; i < data_Transactions.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = data_Transactions.Columns[i].HeaderText.ToUpper(CultureInfo.InvariantCulture);
                    for (int j = 0; j < data_Transactions.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = data_Transactions.Rows[i].Cells[j].Value;
                    }
                }
                pck.Save();

                using FileStream fs = File.Open(saveFile.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                MessageBox.Show(Resources.ExportingFileSuccessfullyString,
                    Resources.InformationTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
