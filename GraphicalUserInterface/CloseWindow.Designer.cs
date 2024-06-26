﻿namespace GraphicalUserInterface {
	partial class CloseWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseWindow));
			pictureBox1 = new System.Windows.Forms.PictureBox();
			lbNoti = new System.Windows.Forms.Label();
			btn_Yes = new System.Windows.Forms.Button();
			btn_Cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.warning;
			pictureBox1.Location = new System.Drawing.Point(25, 36);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(64, 64);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// lbNoti
			// 
			lbNoti.AutoSize = true;
			lbNoti.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lbNoti.Location = new System.Drawing.Point(128, 53);
			lbNoti.Name = "lbNoti";
			lbNoti.Size = new System.Drawing.Size(294, 33);
			lbNoti.TabIndex = 1;
			lbNoti.Text = "Do you want to log out?";
			// 
			// btn_Yes
			// 
			btn_Yes.BackColor = System.Drawing.Color.White;
			btn_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
			btn_Yes.DialogResult = System.Windows.Forms.DialogResult.OK;
			btn_Yes.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btn_Yes.ForeColor = System.Drawing.Color.White;
			btn_Yes.Location = new System.Drawing.Point(47, 133);
			btn_Yes.Name = "btn_Yes";
			btn_Yes.Size = new System.Drawing.Size(163, 57);
			btn_Yes.TabIndex = 2;
			btn_Yes.Text = "Log out";
			btn_Yes.UseVisualStyleBackColor = false;
			btn_Yes.Click += btn_Yes_Click;
			btn_Yes.MouseEnter += btn_Yes_MouseEnter;
			btn_Yes.MouseLeave += btn_Yes_MouseLeave;
			// 
			// btn_Cancel
			// 
			btn_Cancel.BackColor = System.Drawing.Color.White;
			btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			btn_Cancel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btn_Cancel.ForeColor = System.Drawing.Color.Black;
			btn_Cancel.Location = new System.Drawing.Point(250, 133);
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new System.Drawing.Size(163, 57);
			btn_Cancel.TabIndex = 3;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = false;
			btn_Cancel.Click += btn_Cancel_Click;
			btn_Cancel.MouseEnter += btn_Cancel_MouseEnter;
			btn_Cancel.MouseLeave += btn_Cancel_MouseLeave;
			// 
			// CloseWindow
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(459, 218);
			Controls.Add(btn_Cancel);
			Controls.Add(btn_Yes);
			Controls.Add(lbNoti);
			Controls.Add(pictureBox1);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "CloseWindow";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Log out";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbNoti;
		private System.Windows.Forms.Button btn_Yes;
		private System.Windows.Forms.Button btn_Cancel;
	}
}