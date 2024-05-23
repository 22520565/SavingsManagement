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
			panelTransactionList = new System.Windows.Forms.Panel();
			label1 = new System.Windows.Forms.Label();
			flpTransactions = new System.Windows.Forms.FlowLayoutPanel();
			panelTransactionInfo = new System.Windows.Forms.Panel();
			label9 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			lbContent = new System.Windows.Forms.Label();
			lbAmount = new System.Windows.Forms.Label();
			lbTime = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			panelSavings = new GradientPanel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			panelExpenses = new GradientPanel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label7 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			panelTransactionList.SuspendLayout();
			panelTransactionInfo.SuspendLayout();
			panel1.SuspendLayout();
			panelSavings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panelExpenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panelTransactionList
			// 
			panelTransactionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelTransactionList.Controls.Add(label1);
			panelTransactionList.Controls.Add(flpTransactions);
			panelTransactionList.Location = new System.Drawing.Point(12, 410);
			panelTransactionList.Name = "panelTransactionList";
			panelTransactionList.Size = new System.Drawing.Size(519, 301);
			panelTransactionList.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(6, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(173, 28);
			label1.TabIndex = 2;
			label1.Text = "Recent Transaction";
			// 
			// flpTransactions
			// 
			flpTransactions.AutoScroll = true;
			flpTransactions.Location = new System.Drawing.Point(3, 41);
			flpTransactions.Name = "flpTransactions";
			flpTransactions.Size = new System.Drawing.Size(513, 257);
			flpTransactions.TabIndex = 0;
			// 
			// panelTransactionInfo
			// 
			panelTransactionInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panelTransactionInfo.Controls.Add(label9);
			panelTransactionInfo.Controls.Add(panel1);
			panelTransactionInfo.Location = new System.Drawing.Point(577, 410);
			panelTransactionInfo.Name = "panelTransactionInfo";
			panelTransactionInfo.Size = new System.Drawing.Size(519, 301);
			panelTransactionInfo.TabIndex = 1;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label9.ForeColor = System.Drawing.Color.White;
			label9.Location = new System.Drawing.Point(179, 12);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(175, 31);
			label9.TabIndex = 3;
			label9.Text = "Transaction Info";
			// 
			// panel1
			// 
			panel1.Controls.Add(lbContent);
			panel1.Controls.Add(lbAmount);
			panel1.Controls.Add(lbTime);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Location = new System.Drawing.Point(3, 56);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(513, 242);
			panel1.TabIndex = 0;
			// 
			// lbContent
			// 
			lbContent.ForeColor = System.Drawing.Color.White;
			lbContent.Location = new System.Drawing.Point(143, 117);
			lbContent.Name = "lbContent";
			lbContent.Size = new System.Drawing.Size(358, 126);
			lbContent.TabIndex = 5;
			lbContent.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbAmount
			// 
			lbAmount.Location = new System.Drawing.Point(327, 63);
			lbAmount.Name = "lbAmount";
			lbAmount.Size = new System.Drawing.Size(174, 20);
			lbAmount.TabIndex = 4;
			lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTime
			// 
			lbTime.ForeColor = System.Drawing.Color.White;
			lbTime.Location = new System.Drawing.Point(252, 16);
			lbTime.Name = "lbTime";
			lbTime.Size = new System.Drawing.Size(249, 20);
			lbTime.TabIndex = 3;
			lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = System.Drawing.Color.White;
			label4.Location = new System.Drawing.Point(12, 117);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(64, 20);
			label4.TabIndex = 2;
			label4.Text = "Content:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = System.Drawing.Color.White;
			label3.Location = new System.Drawing.Point(12, 63);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(65, 20);
			label3.TabIndex = 1;
			label3.Text = "Amount:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(12, 16);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(124, 20);
			label2.TabIndex = 0;
			label2.Text = "Transaction Time:";
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
			panelExpenses.Location = new System.Drawing.Point(333, 12);
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
			// Statistic
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.LightGray;
			ClientSize = new System.Drawing.Size(1108, 723);
			Controls.Add(panelExpenses);
			Controls.Add(panelSavings);
			Controls.Add(panelTransactionInfo);
			Controls.Add(panelTransactionList);
			Name = "Statistic";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Statistic";
			panelTransactionList.ResumeLayout(false);
			panelTransactionList.PerformLayout();
			panelTransactionInfo.ResumeLayout(false);
			panelTransactionInfo.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
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
		private System.Windows.Forms.Panel panelTransactionInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flpTransactions;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbAmount;
		private System.Windows.Forms.Label lbContent;
		private GradientPanel panelSavings;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private GradientPanel panelExpenses;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}