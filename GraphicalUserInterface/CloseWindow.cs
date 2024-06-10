namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Windows.Forms;

public partial class CloseWindow : Form {
	public bool IsNotClosed { get; set; } = true;
	public Label Notification { get; set; } = new Label();
	public Button Confirm { get; set; } = new Button();

	public CloseWindow() {
		InitializeComponent();
		Notification = lbNoti;
		Confirm = btn_Yes;
		this.btn_Yes.BackColor = Color.FromArgb(23, 33, 175);
	}

	private void btn_Yes_Click(object sender, EventArgs e) {
		this.Close();
		IsNotClosed = false;
	}

	private void btn_Cancel_Click(object sender, EventArgs e) {
		this.Close();
	}

	private void btn_Yes_MouseEnter(object sender, EventArgs e) {
		this.btn_Yes.BackColor = Color.FromArgb(74, 131, 248);

	}

	private void btn_Yes_MouseLeave(object sender, EventArgs e) {
		this.btn_Yes.BackColor = Color.FromArgb(23, 33, 175);
	}

	private void btn_Cancel_MouseEnter(object sender, EventArgs e) {
		this.btn_Cancel.BackColor = Color.FromArgb(226, 55, 52);
		this.btn_Cancel.ForeColor = Color.White;
	}

	private void btn_Cancel_MouseLeave(object sender, EventArgs e) {
		this.btn_Cancel.BackColor = Color.White;
		this.btn_Cancel.ForeColor = Color.Black;
	}
}
