using System.Drawing;
using System.Windows.Forms;

namespace AutoCaptivePortalLogin.CustomUI
{
	public class RoundedPanel : Panel
	{
		public int CornerRadius { get; set; } = 20;

		public RoundedPanel()
		{
			this.DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var g = e.Graphics;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			using (var path = new System.Drawing.Drawing2D.GraphicsPath())
			{
				Rectangle bounds = this.ClientRectangle;
				path.AddArc(bounds.X, bounds.Y, CornerRadius, CornerRadius, 180, 90);
				path.AddArc(bounds.Right - CornerRadius, bounds.Y, CornerRadius, CornerRadius, 270, 90);
				path.AddArc(bounds.Right - CornerRadius, bounds.Bottom - CornerRadius, CornerRadius, CornerRadius, 0, 90);
				path.AddArc(bounds.X, bounds.Bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);
				path.CloseAllFigures();

				this.Region = new Region(path);
				g.FillPath(new SolidBrush(this.BackColor), path);
			}
		}
	}
}
