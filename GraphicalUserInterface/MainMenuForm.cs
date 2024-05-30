namespace GraphicalUserInterface;

using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using OfficeOpenXml;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class MainMenuForm : Form
{
    public bool GoingBackToLoginForm { get; private set; } = false;
    private const string BalanceTextFormat = "{0:#,0.00##}";
    DataTable dt;

    public MainMenuForm()
    {
        InitializeComponent();
        InitializeStatistical();
        InitializeSystem();

    }

    #region System
    private void InitializeSystem()
    {
        LoadingAccountInfo();

    }

    public void LoadingAccountInfo()
    {
        try
        {
            CustomerAccount info = CustomerAccounts.GetCustomerAccount;
            this.txtname.Text = info.Name;
            if (info.IsMale)
            {
                this.txtsex.Text = "male";
            }
            else { this.txtsex.Text = "female"; }

            this.txtCicnum.Text = info.CicNumber;
            this.txtBirth.Text = info.BirthDate.ToString();
            this.txtPhone.Text = info.PhoneNumber;
            this.txtAddress.Text = info.Address;
            this.txtEmail.Text = info.Email;
            this.txtbalance.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, info.Balance);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnchange_Click(object sender, EventArgs e)
    {
        changePass form = new changePass();
        form.ShowDialog();
    }
    #endregion
    #region Savings
    #endregion
    #region Statistical

    private void InitializeStatistical()
    {
        LoadingScene();
        LoadingTransactionList();
    }

    public void LoadingScene()
    {
        tabStatistical.BackColor = Color.FromArgb(246, 248, 252);
        panelSavings.LeftColor = Color.FromArgb(0, 221, 176);
        panelSavings.RightColor = Color.FromArgb(0, 221, 176);
        panelSavings.Angle = 180;
        panelExpenses.LeftColor = Color.FromArgb(244, 132, 132);
        panelExpenses.RightColor = Color.FromArgb(244, 132, 132);
        panelExpenses.Angle = 180;
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

    #endregion

    // FIXME
    private void Form_MainMenu_Load(object sender, EventArgs e)
    {
        this.GoingBackToLoginForm = false;

        switch (string.Empty)
        {
            case "error":
                MessageBox.Show("User authorization error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            case "admin":
                break;
            case "staff":
                //accountManagementToolStripMenuItem.Enabled = false;
                //changeRegulationsToolStripMenuItem.Enabled = false;
                break;
            case "customer":
                //accountManagementToolStripMenuItem.Enabled = false;
                //statisticalToolStripMenuItem.Enabled = false;
                //changeRegulationsToolStripMenuItem.Enabled = false;
                break;
        }
    }

    private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var accountInfoForm = new AccountInfoForm();
        accountInfoForm.ShowDialog(this);
    }

    private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var accountManagementForm = new AccountManagementForm();
        accountManagementForm.ShowDialog(this);
    }

    private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var personalInfoForm = new PersonalInfoForm();
        personalInfoForm.ShowDialog(this);
    }

    private void savingToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var savingForm = new SavingForm();
        savingForm.ShowDialog(this);
    }

    private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Form bg = new Form();
        CloseWindow logOut = new CloseWindow();
        using (logOut)
        {
            logOut.Notification.Text = "Do you want to log out?";
            logOut.Text = "Log out";
            logOut.Confirm.Text = "Log out";
            bg.StartPosition = FormStartPosition.Manual;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.BackColor = Color.Black;
            bg.Opacity = 0.7d;
            bg.Size = this.Size;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            bg.Show(this);
            logOut.Owner = bg;
            logOut.ShowDialog(bg);
            bg.Dispose();
        }
        this.GoingBackToLoginForm = !logOut.IsNotClosed;
        e.Cancel = logOut.IsNotClosed;
    }

   
}
