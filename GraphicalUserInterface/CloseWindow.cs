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
	public partial class CloseWindow : Form {
		public bool IsNotClosed = true;
		public Label Notification = new Label();
		public Button Confirm = new Button();
		public CloseWindow() {
			InitializeComponent();
			Notification = lbNoti;
			Confirm = btn_Yes;
		}

		private void btn_Yes_Click(object sender, EventArgs e) {
			this.Close();
			IsNotClosed = false;
		}

		private void btn_Cancel_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
