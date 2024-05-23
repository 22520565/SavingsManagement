using Business;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface {
	public partial class Statistic : Form {
		public Statistic() {
			InitializeComponent();
			LoadingScene();
			LoadingTransactionList();
		}

		public void LoadingScene() {
			this.BackColor = Color.FromArgb(9, 13, 40);
			panelSavings.LeftColor = Color.FromArgb(240, 95, 34);
			panelSavings.RightColor = Color.FromArgb(90, 229, 63, 82);
			panelSavings.Angle = 180;
			panelExpenses.LeftColor = Color.FromArgb(240, 95, 34);
			panelExpenses.RightColor = Color.FromArgb(90, 229, 63, 82);
			panelExpenses.Angle = 180;
			flpTransactions.BackColor = Color.FromArgb(24, 27, 58);
			panelTransactionList.BackColor = Color.FromArgb(24, 27, 58);
			panelTransactionInfo.BackColor = Color.FromArgb(24, 27, 58);
		}

		public void LoadingTransactionList() {
			flpTransactions.Controls.Clear();

			int? currentCustomerId = CustomerAccounts.CurrentCustomerId;
			if (currentCustomerId.HasValue) {
				var cashFlows = CashFlows.GetCashFlowsByCustomerId(currentCustomerId.Value);
				foreach (var cashFlow in cashFlows) {
					AddCashFlowEntry(cashFlow);
				}
			} else {
				MessageBox.Show("No customer is currently logged in.");
			}

		}

		private void AddCashFlowEntry(CashFlow cashFlow) {
			Panel cashFlowPanel = new Panel {
				Width = flpTransactions.Width - 20,
				Height = 50,
				BackColor = Color.FromArgb(36, 37, 60),
				Margin = new Padding(5)
			};

			Label lblTime = new Label {
				Text = cashFlow.Time.ToString("g"),
				ForeColor = Color.White,
				AutoSize = true,
				Location = new Point(10, 15)
			};

			Label lblBalanceChanging = new Label {
				Text = cashFlow.BalanceChanging < 0
		? $"-{Math.Abs(cashFlow.BalanceChanging):C}"
		: cashFlow.BalanceChanging.ToString("C"),
				ForeColor = cashFlow.BalanceChanging >= 0 ? Color.Green : Color.Red,
				AutoSize = true,
				Location = new Point(300, 15)
			};

			cashFlowPanel.Click += (sender, e) => ShowPanelInfo(cashFlow);

			cashFlowPanel.MouseEnter += (sender, e) => {
				this.Cursor = Cursors.Hand;
			};

			cashFlowPanel.MouseLeave += (sender, e) => {
				this.Cursor = Cursors.Default;
			};

			cashFlowPanel.Controls.Add(lblTime);
			cashFlowPanel.Controls.Add(lblBalanceChanging);

			flpTransactions.Controls.Add(cashFlowPanel);
		}

		public void ShowPanelInfo(CashFlow cashFlow) {
			lbTime.Text = cashFlow.Time.ToString("g");
			lbAmount.Text = cashFlow.BalanceChanging < 0
		? $"-{Math.Abs(cashFlow.BalanceChanging):C}"
		: cashFlow.BalanceChanging.ToString("C");
			lbAmount.ForeColor = cashFlow.BalanceChanging >= 0 ? Color.Green : Color.Red;
			lbContent.Text = cashFlow.Content;
		}
	}
}
