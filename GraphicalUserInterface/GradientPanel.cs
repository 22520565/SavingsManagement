using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface {
	internal class GradientPanel : Panel {
		public Color RightColor { get; set; }
		public Color LeftColor { get; set; }
		public float Angle { get; set; }
		protected override void OnPaint(PaintEventArgs e) {
			LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.RightColor, this.LeftColor, this.Angle);
			Graphics g = e.Graphics;
			g.FillRectangle(brush, this.ClientRectangle);
			base.OnPaint(e);
		}
	}
}
