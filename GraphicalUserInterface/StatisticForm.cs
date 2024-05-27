namespace GraphicalUserInterface;

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business;
using DataAccess;
using OfficeOpenXml;

public partial class StatisticForm : Form {
	DataTable dt;
	public StatisticForm() {
		this.InitializeComponent();
		this.LoadingScene();
		this.LoadingTransactionList();
	}

	public void LoadingScene() {
		this.BackColor = Color.FromArgb(9, 13, 40);
		this.panelSavings.LeftColor = Color.FromArgb(240, 95, 34);
		this.panelSavings.RightColor = Color.FromArgb(240, 95, 34);
		this.panelSavings.Angle = 180;
		this.panelExpenses.LeftColor = Color.FromArgb(240, 95, 34);
		this.panelExpenses.RightColor = Color.FromArgb(240, 95, 34);
		this.panelExpenses.Angle = 180;
		this.panelTransactionList.BackColor = Color.FromArgb(24, 27, 58);
	}

	public void LoadingTransactionList() {
		dt = new DataTable();
		dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Amount", typeof(string)),
						new DataColumn("Transaction Time", typeof(string)), new DataColumn("Content", typeof(string))});
		int? currentCustomerId = CustomerAccounts.CurrentCustomerId;
		if (currentCustomerId.HasValue) {
			decimal expenses = 0;
			decimal savings = 0;
			var cashFlows = CashFlows.GetCashFlowsByCustomerId(currentCustomerId.Value);
			foreach (var cashFlow in cashFlows) {
				AddCashFlowEntry(cashFlow);
				if (cashFlow.BalanceChanging < 0) {
					expenses += Math.Abs(cashFlow.BalanceChanging);
				} else {
					savings += cashFlow.BalanceChanging;
				}
			}
			lbExpenses.Text = "$" + expenses.ToString();
			lbSavings.Text = "$" + savings.ToString();
		} else {
			MessageBox.Show("No customer is currently logged in.");
		}

	}

	private void AddCashFlowEntry(CashFlow cashFlow) {
		dt.Rows.Add("$" + cashFlow.BalanceChanging.ToString(), cashFlow.Time.ToString("h:m:s:tt,  d/M/yyyy"), cashFlow.Content);
		this.data_Transactions.DataSource = dt;
		data_Transactions.Columns[0].ReadOnly = false;
		for (int k = 1; k < data_Transactions.Columns.Count; k++) {
			data_Transactions.Columns[k].ReadOnly = true;
		}
		this.data_Transactions.AllowUserToAddRows = false;
	}

	private void btnExport_Click(object sender, EventArgs e) {
		SaveFileDialog saveFile = new SaveFileDialog();
		saveFile.Filter = "Excel Files (*.xlsx)|*.xlsx;*.xls";
		if (data_Transactions.Rows.Count > 0) {
			if (saveFile.ShowDialog() == DialogResult.OK) {
				ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
				using (ExcelPackage pck = new ExcelPackage(new FileInfo(saveFile.FileName))) {
					ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");
					for (int i = 0; i < data_Transactions.Columns.Count; i++) {
						ws.Cells[1, i + 1].Value = data_Transactions.Columns[i].HeaderText.ToUpper();
					}

					for (int i = 0; i < (data_Transactions.Rows.Count); i++) {
						for (int j = 0; j < data_Transactions.Columns.Count; j++) {
							if (data_Transactions.Rows[i].Cells[j].Value != null) {
								ws.Cells[i + 2, j + 1].Value = data_Transactions.Rows[i].Cells[j].Value.ToString();
							}
						}
					}
					pck.Save();
				}
				try {
					using (FileStream fs = File.Open(saveFile.FileName, FileMode.Open, FileAccess.Read, FileShare.None)) {
						MessageBox.Show("Export file successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				} catch (IOException ex) {
					MessageBox.Show("Cannot export file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}
	}
}
