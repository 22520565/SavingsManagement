namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using DataAccess;

public partial class StatisticForm : Form
{
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
        this.panelSavings.RightColor = Color.FromArgb(90, 229, 63, 82);
        this.panelSavings.Angle = 180;
        this.panelExpenses.LeftColor = Color.FromArgb(240, 95, 34);
        this.panelExpenses.RightColor = Color.FromArgb(90, 229, 63, 82);
        this.panelExpenses.Angle = 180;
        this.flpTransactions.BackColor = Color.FromArgb(24, 27, 58);
        this.panelTransactionList.BackColor = Color.FromArgb(24, 27, 58);
        this.panelTransactionInfo.BackColor = Color.FromArgb(24, 27, 58);
    }

    public void LoadingTransactionList()
    {
        this.flpTransactions.Controls.Clear();

        int? currentCustomerId = CustomerAccounts.CurrentCustomerId;
        if (currentCustomerId.HasValue)
        {
            var cashFlows = CashFlows.GetCashFlowsByCustomerId(currentCustomerId.Value);
            foreach (var cashFlow in cashFlows)
            {
                AddCashFlowEntry(cashFlow);
            }
        }
        else
        {
            MessageBox.Show("No customer is currently logged in.");
        }

    }

    private void AddCashFlowEntry(CashFlow cashFlow)
    {
        Panel cashFlowPanel = new Panel
        {
            Width = this.flpTransactions.Width - 20,
            Height = 50,
            BackColor = Color.FromArgb(36, 37, 60),
            Margin = new Padding(5)
        };

        Label lblTime = new Label
        {
            Text = cashFlow.Time.ToString("g"),
            ForeColor = Color.White,
            AutoSize = true,
            Location = new Point(10, 15)
        };

        Label lblBalanceChanging = new Label
        {
            Text = cashFlow.BalanceChanging < 0
    ? $"-{Math.Abs(cashFlow.BalanceChanging):C}"
    : cashFlow.BalanceChanging.ToString("C"),
            ForeColor = cashFlow.BalanceChanging >= 0 ? Color.Green : Color.Red,
            AutoSize = true,
            Location = new Point(300, 15)
        };

        cashFlowPanel.Click += (sender, e) => ShowPanelInfo(cashFlow);

        cashFlowPanel.MouseEnter += (sender, e) =>
        {
            this.Cursor = Cursors.Hand;
        };

        cashFlowPanel.MouseLeave += (sender, e) =>
        {
            this.Cursor = Cursors.Default;
        };

        cashFlowPanel.Controls.Add(lblTime);
        cashFlowPanel.Controls.Add(lblBalanceChanging);

        this.flpTransactions.Controls.Add(cashFlowPanel);
    }

    public void ShowPanelInfo(CashFlow cashFlow)
    {
        this.lbTime.Text = cashFlow.Time.ToString("g");
        this.lbAmount.Text = cashFlow.BalanceChanging < 0
    ? $"-{Math.Abs(cashFlow.BalanceChanging):C}"
    : cashFlow.BalanceChanging.ToString("C");
        this.lbAmount.ForeColor = cashFlow.BalanceChanging >= 0 ? Color.Green : Color.Red;
        this.lbContent.Text = cashFlow.Content;
    }
}
