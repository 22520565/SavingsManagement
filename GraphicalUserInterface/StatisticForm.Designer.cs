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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			panelTransactionList = new System.Windows.Forms.Panel();
			data_Transactions = new System.Windows.Forms.DataGridView();
			label1 = new System.Windows.Forms.Label();
			panelSavings = new GradientPanel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			panelExpenses = new GradientPanel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label7 = new System.Windows.Forms.Label();
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			data_Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			data_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			data_Transactions.DefaultCellStyle = dataGridViewCellStyle5;
			data_Transactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			data_Transactions.Location = new System.Drawing.Point(3, 78);
			data_Transactions.Name = "data_Transactions";
			data_Transactions.RowHeadersVisible = false;
			data_Transactions.RowHeadersWidth = 51;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			data_Transactions.RowsDefaultCellStyle = dataGridViewCellStyle6;
			data_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			data_Transactions.Size = new System.Drawing.Size(810, 624);
			data_Transactions.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(272, 17);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(300, 46);
			label1.TabIndex = 2;
			label1.Text = "Recent Transaction";
			// 
			// panelSavings
			// 
			panelSavings.Angle = 0F;
			panelSavings.Controls.Add(pictureBox1);
			panelSavings.Controls.Add(label6);
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
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = System.Drawing.Color.Transparent;
			label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.White;
			label6.Location = new System.Drawing.Point(16, 121);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(97, 28);
			label6.TabIndex = 1;
			label6.Text = "$1,146.45";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = System.Drawing.Color.Transparent;
			label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.White;
			label5.Location = new System.Drawing.Point(16, 79);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(79, 28);
			label5.TabIndex = 0;
			label5.Text = "Savings";
			// 
			// panelExpenses
			// 
			panelExpenses.Angle = 0F;
			panelExpenses.Controls.Add(pictureBox2);
			panelExpenses.Controls.Add(label7);
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
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = System.Drawing.Color.Transparent;
			label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.Color.White;
			label7.Location = new System.Drawing.Point(16, 121);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(97, 28);
			label7.TabIndex = 1;
			label7.Text = "$2,146.45";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = System.Drawing.Color.Transparent;
			label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label8.ForeColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(16, 79);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(90, 28);
			label8.TabIndex = 0;
			label8.Text = "Expenses";
			// 
			// btnExport
			// 
			btnExport.Location = new System.Drawing.Point(12, 514);
			btnExport.Name = "btnExport";
			btnExport.Size = new System.Drawing.Size(137, 46);
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
		private System.Windows.Forms.Label label6;
		private GradientPanel panelExpenses;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.DataGridView data_Transactions;
	}
}