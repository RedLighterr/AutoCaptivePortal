using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AutoCaptivePortalLogin.CustomUI
{
	public class ModernButton : Button
	{
		public Color normalColor { get; set; } = Color.FromArgb(116, 236, 240);
		public Color hoverColor { get; set; } = Color.FromArgb(29, 229, 236);
		public int BorderRadius { get; set; } = 10;
		private bool isHovering = false;

		public ModernButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.BackColor = normalColor;
			this.ForeColor = Color.Black;
			this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular);
			this.Cursor = Cursors.Hand;
			this.UseVisualStyleBackColor = false;
			this.Padding = new Padding(2);
			this.Margin = new Padding(12);
			this.TextImageRelation = TextImageRelation.ImageBeforeText;
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			isHovering = true;
			this.BackColor = hoverColor;
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			isHovering = false;
			this.BackColor = normalColor;
			base.OnMouseLeave(e);
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			using (GraphicsPath path = new GraphicsPath())
			{
				using (Pen pen = new Pen(Color.White, 2))
					pevent.Graphics.DrawPath(pen, path);

				Rectangle bounds = this.ClientRectangle;
				int radius = BorderRadius;

				path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
				path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
				path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
				path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
				path.CloseAllFigures();

				this.Region = new Region(path);

				// Arka planı boya
				using (SolidBrush brush = new SolidBrush(this.BackColor))
					pevent.Graphics.FillPath(brush, path);

				// Yazıyı ortala ve çiz
				TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, bounds, this.ForeColor,
				TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}
		}
	}
}
