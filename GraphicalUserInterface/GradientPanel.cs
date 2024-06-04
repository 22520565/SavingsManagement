namespace GraphicalUserInterface;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    public Color RightColor { get; set; }

    public Color LeftColor { get; set; }

    public float Angle { get; set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (e is not null)
        {
            using LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.RightColor, this.LeftColor, this.Angle);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
