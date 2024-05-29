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

public partial class CustomerMenuForm : Form {
	public bool GoingBackToLoginForm { get; private set; } = false;
	DataTable dt;
	private const string InterestTextFormat = "{0:#,0.00#%}/year";
	private const string BalanceTextFormat = "{0:#,0.00##}";
	private SavingOpeningInfo? savingDepositInfo = new SavingOpeningInfo();
	private SavingWithdrawInfo? savingWithdrawInfo = new SavingWithdrawInfo();

	public CustomerMenuForm() {
		InitializeComponent();
		InitializeStatistical();
		InitializeSavings();
	}

	#region System
	#endregion
	#region Savings
	private void InitializeSavings() {
		this.LoadForm();
	}

	private void LoadForm() {
		try {
			var customerBalance = CustomerAccounts.CurrentCustomerBalance;
			this.balanceOpeningTextBox.Text = string.Format(
				CultureInfo.CurrentCulture, BalanceTextFormat, customerBalance);
			this.amountOpeningNumeric.Maximum = customerBalance is decimal balance ? balance : decimal.Zero;

			this.savingDetailsComboBox.SelectedItem = null;
			this.savingClosingComboBox.SelectedItem = null;
			this.periodOpeningComboBox.SelectedItem = null;

			this.savingDetailsComboBox.Items.Clear();
			this.savingClosingComboBox.Items.Clear();
			foreach (object id in Savings.SavingsId) {
				this.savingDetailsComboBox.Items.Add(id);
				this.savingClosingComboBox.Items.Add(id);
			}

			this.periodOpeningComboBox.Items.Clear();
			foreach (var period in SavingInterestRates.Periods) {
				this.periodOpeningComboBox.Items.Add(period);
			}

			this.savingTabControl.SelectedTab = this.detailsTabPage;
		} catch (Exception ex) {
			MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
			this.Close();
		}
	}

	private void savingDetailsComboBox_SelectedValueChanged(object sender, EventArgs e) {
		if (this.savingDetailsComboBox.SelectedItem is null) {
			this.balanceDetailsTextBox.Text = string.Empty;
			this.periodDetailsTextBox.Text = string.Empty;
			this.interestDetailsTextBox.Text = string.Empty;
			this.openDayDetailsTextBox.Text = string.Empty;
			this.maturityDayDetailsTextBox.Text = string.Empty;

			this.closeSavingDetailsButton.Enabled = false;
		} else if (this.savingDetailsComboBox.SelectedItem is int savingId) {
			try {
				Saving saving = Savings.GetSaving(savingId);
				this.balanceDetailsTextBox.Text = string.Format(
					CultureInfo.CurrentCulture, BalanceTextFormat, saving.Balance);
				this.periodDetailsTextBox.Text = saving.PeriodInMonths.ToString(CultureInfo.CurrentCulture);
				this.interestDetailsTextBox.Text = string.Format(
					CultureInfo.InvariantCulture, InterestTextFormat, saving.AnnualInterestRate);
				this.openDayDetailsTextBox.Text = DateOnly.FromDateTime(saving.OpeningDateTime.LocalDateTime)
					.ToString(CultureInfo.CurrentCulture);
				this.maturityDayDetailsTextBox.Text = Savings.GetMaturityDate(saving.OpeningDateTime, saving.PeriodInMonths)
					.ToString(CultureInfo.CurrentCulture);

				this.closeSavingDetailsButton.Enabled = true;
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.LoadForm();
			}
		} else {
			MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			this.LoadForm();
		}
	}

	private void periodDepositComboBox_SelectedValueChanged(object sender, EventArgs e) {
		if (this.periodOpeningComboBox.SelectedItem is null) {
			this.savingDepositInfo = null;

			this.interestOpeningTextBox.Text = string.Empty;
			this.maturityDayOpeningTextBox.Text = string.Empty;
			this.amountOpeningNumeric.Value = this.amountOpeningNumeric.Minimum;

			this.openingSavingOpeningButton.Enabled = false;
		} else if (this.periodOpeningComboBox.SelectedItem is int period) {
			try {
				this.savingDepositInfo = new SavingOpeningInfo {
					PeriodInMonths = period,
					AnnualInterestRate = SavingInterestRates.GetInterest(period),
				};

				this.interestOpeningTextBox.Text = string.Format(
					CultureInfo.InvariantCulture, InterestTextFormat, this.savingDepositInfo.AnnualInterestRate);
				this.maturityDayOpeningTextBox.Text = DateOnly.FromDateTime(DateTimeOffset.Now.LocalDateTime)
														.AddMonths(this.savingDepositInfo.PeriodInMonths)
														.ToString(CultureInfo.CurrentCulture);

				this.openingSavingOpeningButton.Enabled = true;
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.LoadForm();
			}
		} else {
			MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			this.LoadForm();
		}
	}

	private void openingSavingOpeningButton_Click(object sender, EventArgs e) {
		try {
			ArgumentNullException.ThrowIfNull(this.savingDepositInfo);

			this.savingDepositInfo.Balance = this.amountOpeningNumeric.Value;

			if (MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, Properties.Resources.OpeningSavingConfirmationStringFormat,
				this.savingDepositInfo.PeriodInMonths, this.savingDepositInfo.AnnualInterestRate, this.savingDepositInfo.Balance),
				Properties.Resources.ConfirmationTitleString, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
				== DialogResult.Yes) {
				Savings.Open(this.savingDepositInfo);
				MessageBox.Show(this, Properties.Resources.OpeningSavingSuccessfullyString, Properties.Resources.InformationTitleString,
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.LoadForm();
			}

		} catch (Exception ex) {
			MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
			this.LoadForm();
		}
	}

	private void closingSavingDetailsButton_Click(object sender, EventArgs e) {
		this.savingClosingComboBox.SelectedItem = this.savingDetailsComboBox.SelectedItem;
		this.savingTabControl.SelectedTab = this.withdrawTabPage;
	}

	private void savingClosingComboBox_SelectedValueChanged(object sender, EventArgs e) {
		if (this.savingClosingComboBox.SelectedItem is null) {
			this.savingWithdrawInfo = null;

			this.balanceClosingTextBox.Text = string.Empty;
			this.maturityDayClosingTextBox.Text = string.Empty;
			this.amountToGetClosingTextBox.Text = string.Empty;

			this.closingSavingClosingButton.Enabled = false;
		} else if (this.savingClosingComboBox.SelectedItem is int savingId) {
			try {
				this.savingWithdrawInfo = Savings.GetWithdrawInfo(savingId);
				this.balanceClosingTextBox.Text = string.Format(
					CultureInfo.CurrentCulture, BalanceTextFormat, savingWithdrawInfo.Balance);
				this.maturityDayClosingTextBox.Text = savingWithdrawInfo.MaturityDate.ToString(CultureInfo.CurrentCulture);
				this.amountToGetClosingTextBox.Text = string.Format(
					CultureInfo.CurrentCulture, BalanceTextFormat, savingWithdrawInfo.AmountToGet);

				this.closingSavingClosingButton.Enabled = true;
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.LoadForm();
			}
		} else {
			MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			this.LoadForm();
		}
	}

	private void closingSavingClosingButton_Click(object sender, EventArgs e) {
		try {
			ArgumentNullException.ThrowIfNull(this.savingWithdrawInfo);

			if (this.savingWithdrawInfo.MaturityDate <= DateOnly.FromDateTime(DateTime.Now) ||
				(MessageBox.Show(this, Properties.Resources.ClosingSavingBeforeMaturityDayWarningString, Properties.Resources.WarningTitleString,
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
				== DialogResult.Yes)) {
				Savings.Close(this.savingWithdrawInfo.Id);
				MessageBox.Show(this, Properties.Resources.ClosingSavingSuccessfullyString, Properties.Resources.InformationTitleString,
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		} catch (Exception ex) {
			MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		this.LoadForm();
	}
	#endregion
	#region Statistical

	private void InitializeStatistical() {
		LoadingScene();
		LoadingTransactionList();
	}

	public void LoadingScene() {
		panelSavings.LeftColor = Color.FromArgb(0, 221, 176);
		panelSavings.RightColor = Color.FromArgb(0, 221, 176);
		panelExpenses.LeftColor = Color.FromArgb(244, 132, 132);
		panelExpenses.RightColor = Color.FromArgb(244, 132, 132);

		groupBoxTransactionList.BackColor = Color.FromArgb(1, 242, 240, 245);
		groupBoxStats.BackColor = Color.FromArgb(1, 242, 240, 245);
		groupBoxFunction.BackColor = Color.FromArgb(1, 242, 240, 245);
	}

	public void LoadingTransactionList() {
		dt = new DataTable();
		dt.Columns.AddRange(new[] { new DataColumn("Amount", typeof(string)),
						new DataColumn("Transaction Time", typeof(string)),
			new DataColumn("Content", typeof(string))});
		int? currentCustomerId = CustomerAccounts.CurrentCustomerId;
		if (currentCustomerId.HasValue) {
			decimal expenses = decimal.Zero;
			decimal savings = decimal.Zero;
			var cashFlows = CashFlows.GetCashFlowsByCustomerId(currentCustomerId.Value);
			foreach (var cashFlow in cashFlows) {
				AddCashFlowEntry(cashFlow);
				if (cashFlow.BalanceChanging < decimal.Zero) {
					expenses -= cashFlow.BalanceChanging;
				} else {
					savings += cashFlow.BalanceChanging;
				}
			}
			lbExpenses.Text = expenses.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
			lbSavings.Text = savings.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
		} else {
			MessageBox.Show(Resources.NoCustomerLoggingInString);
		}

	}

	private void AddCashFlowEntry(CashFlow cashFlow) {
		dt.Rows.Add(cashFlow.BalanceChanging.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture),
			cashFlow.Time.ToString(Resources.DateTimeStringFormat, CultureInfo.CurrentCulture),
			cashFlow.Content);
		this.data_Transactions.DataSource = dt;
		data_Transactions.Columns[0].ReadOnly = false;
		for (int k = 1; k < data_Transactions.Columns.Count; k++) {
			data_Transactions.Columns[k].ReadOnly = true;
		}
		this.data_Transactions.AllowUserToAddRows = false;
	}

	private void btnExport_Click(object sender, EventArgs e) {
		try {
			using SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = Resources.SavingExcelFileFilter;
			if (data_Transactions.Rows.Count > 0 && saveFile.ShowDialog() == DialogResult.OK) {
				FileInfo fileInfo = new FileInfo(saveFile.FileName);
				if (fileInfo.Exists) {
					fileInfo.Delete();
				}
				ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
				using ExcelPackage pck = new ExcelPackage(fileInfo);
				ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");
				for (int i = 0; i < data_Transactions.Columns.Count; i++) {
					ws.Cells[1, i + 1].Value = data_Transactions.Columns[i].HeaderText.ToUpper(CultureInfo.InvariantCulture);
					for (int j = 0; j < data_Transactions.Columns.Count; j++) {
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
		} catch (Exception ex) {
			MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
		}
	}

	#endregion

	// FIXME
	private void Form_MainMenu_Load(object sender, EventArgs e) {
		this.GoingBackToLoginForm = false;

		switch (string.Empty) {
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

	private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e) {
		using var accountInfoForm = new AccountInfoForm();
		accountInfoForm.ShowDialog(this);
	}

	private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e) {
		using var accountManagementForm = new AccountManagementForm();
		accountManagementForm.ShowDialog(this);
	}

	private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e) {
		using var personalInfoForm = new PersonalInfoForm();
		personalInfoForm.ShowDialog(this);
	}

	private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e) {
		Form bg = new Form();
		CloseWindow logOut = new CloseWindow();
		using (logOut) {
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
