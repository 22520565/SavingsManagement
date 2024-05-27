namespace GraphicalUserInterface {
	partial class StatisticForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			panelTransactionList = new System.Windows.Forms.Panel();
			data_Transactions = new System.Windows.Forms.DataGridView();
			label1 = new System.Windows.Forms.Label();
			panelSavings = new GradientPanel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			lbSavings = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			panelExpenses = new GradientPanel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			lbExpenses = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			btnExport = new System.Windows.Forms.Button();
			panelTransactionList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)data_Transactions).BeginInit();
			panelSavings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panelExpenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panelTransactionList
			// 
			panelTransactionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelTransactionList.Controls.Add(data_Transactions);
			panelTransactionList.Controls.Add(label1);
			panelTransactionList.Location = new System.Drawing.Point(282, 12);
			panelTransactionList.Name = "panelTransactionList";
			panelTransactionList.Size = new System.Drawing.Size(818, 707);
			panelTransactionList.TabIndex = 0;
			// 
			// data_Transactions
			// 
			data_Transactions.AllowUserToAddRows = false;
			data_Transactions.AllowUserToDeleteRows = false;
			data_Transactions.AllowUserToResizeColumns = false;
			data_Transactions.AllowUserToResizeRows = false;
			data_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			data_Transactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			data_Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			data_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			data_Transactions.DefaultCellStyle = dataGridViewCellStyle2;
			data_Transactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			data_Transactions.Location = new System.Drawing.Point(3, 78);
			data_Transactions.Name = "data_Transactions";
			data_Transactions.RowHeadersVisible = false;
			data_Transactions.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
			data_Transactions.RowsDefaultCellStyle = dataGridViewCellStyle3;
			data_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			data_Transactions.Size = new System.Drawing.Size(810, 624);
			data_Transactions.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(255, 12);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(351, 47);
			label1.TabIndex = 2;
			label1.Text = "Recent Transaction";
			// 
			// panelSavings
			// 
			panelSavings.Angle = 0F;
			panelSavings.Controls.Add(pictureBox1);
			panelSavings.Controls.Add(lbSavings);
			panelSavings.Controls.Add(label5);
			panelSavings.LeftColor = System.Drawing.Color.Empty;
			panelSavings.Location = new System.Drawing.Point(12, 12);
			panelSavings.Name = "panelSavings";
			panelSavings.RightColor = System.Drawing.Color.Empty;
			panelSavings.Size = new System.Drawing.Size(250, 162);
			panelSavings.TabIndex = 3;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.Image = Properties.Resources.savingsImage;
			pictureBox1.Location = new System.Drawing.Point(16, 20);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(40, 40);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// lbSavings
			// 
			lbSavings.AutoSize = true;
			lbSavings.BackColor = System.Drawing.Color.Transparent;
			lbSavings.Font = new System.Drawing.Font("Cambria", 13.8F);
			lbSavings.ForeColor = System.Drawing.Color.White;
			lbSavings.Location = new System.Drawing.Point(16, 121);
			lbSavings.Name = "lbSavings";
			lbSavings.Size = new System.Drawing.Size(112, 27);
			lbSavings.TabIndex = 1;
			lbSavings.Text = "$1,146.45";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = System.Drawing.Color.Transparent;
			label5.Font = new System.Drawing.Font("Cambria", 13.8F);
			label5.ForeColor = System.Drawing.Color.White;
			label5.Location = new System.Drawing.Point(16, 79);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(86, 27);
			label5.TabIndex = 0;
			label5.Text = "Savings";
			// 
			// panelExpenses
			// 
			panelExpenses.Angle = 0F;
			panelExpenses.Controls.Add(pictureBox2);
			panelExpenses.Controls.Add(lbExpenses);
			panelExpenses.Controls.Add(label8);
			panelExpenses.LeftColor = System.Drawing.Color.Empty;
			panelExpenses.Location = new System.Drawing.Point(12, 208);
			panelExpenses.Name = "panelExpenses";
			panelExpenses.RightColor = System.Drawing.Color.Empty;
			panelExpenses.Size = new System.Drawing.Size(250, 162);
			panelExpenses.TabIndex = 5;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.Image = Properties.Resources.expenses;
			pictureBox2.Location = new System.Drawing.Point(16, 20);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(40, 40);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// lbExpenses
			// 
			lbExpenses.AutoSize = true;
			lbExpenses.BackColor = System.Drawing.Color.Transparent;
			lbExpenses.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lbExpenses.ForeColor = System.Drawing.Color.White;
			lbExpenses.Location = new System.Drawing.Point(16, 121);
			lbExpenses.Name = "lbExpenses";
			lbExpenses.Size = new System.Drawing.Size(112, 27);
			lbExpenses.TabIndex = 1;
			lbExpenses.Text = "$2,146.45";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = System.Drawing.Color.Transparent;
			label8.Font = new System.Drawing.Font("Cambria", 13.8F);
			label8.ForeColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(16, 79);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(104, 27);
			label8.TabIndex = 0;
			label8.Text = "Expenses";
			// 
			// btnExport
			// 
			btnExport.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnExport.Location = new System.Drawing.Point(12, 482);
			btnExport.Name = "btnExport";
			btnExport.Size = new System.Drawing.Size(250, 46);
			btnExport.TabIndex = 6;
			btnExport.Text = "Export File ";
			btnExport.UseVisualStyleBackColor = true;
			btnExport.Click += btnExport_Click;
			// 
			// StatisticForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.LightGray;
			ClientSize = new System.Drawing.Size(1113, 723);
			Controls.Add(btnExport);
			Controls.Add(panelExpenses);
			Controls.Add(panelSavings);
			Controls.Add(panelTransactionList);
			Name = "StatisticForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Statistic";
			panelTransactionList.ResumeLayout(false);
			panelTransactionList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)data_Transactions).EndInit();
			panelSavings.ResumeLayout(false);
			panelSavings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panelExpenses.ResumeLayout(false);
			panelExpenses.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel panelTransactionList;
		private System.Windows.Forms.Label label1;
		private GradientPanel panelSavings;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbSavings;
		private GradientPanel panelExpenses;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbExpenses;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.DataGridView data_Transactions;
	}
}