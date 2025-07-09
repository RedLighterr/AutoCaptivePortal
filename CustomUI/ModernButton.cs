using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Svg;

namespace AutoCaptivePortalLogin.CustomUI
{
	public class ModernButton : Button
	{
		public Color normalColor { get; set; } = Color.FromArgb(116, 236, 240);
		public Color hoverColor { get; set; } = Color.FromArgb(29, 229, 236);
		public int BorderRadius { get; set; } = 10;
		private string _iconChar;
		public string iconChar
		{
			get => _iconChar;
			set { _iconChar = value; Invalidate(); }
		}
		private Color _iconColor = Color.Black;
		public Color iconColor
		{
			get => _iconColor;
			set { _iconColor = value; Invalidate(); }
		}
		private IconFont _iconFont = IconFont.solid;
		public IconFont iconFont
		{
			get => _iconFont;
			set
			{
				_iconFont = value;
				this.Invalidate(); // değişiklik olduğunda butonu yeniden çiz
			}
		}
		public int IconWidth { get; set; } = 20;
		public int IconHeight { get; set; } = 20;
		public bool centerIcon { get; set; } = false;
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
			this.iconFont = iconFont;
			this.iconChar = iconChar;
			this.Invalidate();
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

				if (_iconChar != null && _iconChar != "")
				{
					string _font = "";

					switch (_iconFont)
					{
						case IconFont.regular:
							_font = "regular";
							break;
						case IconFont.solid:
							_font = "solid";
							break;
						case IconFont.brands:
							_font = "brands";
							break;
						default:
							_font = "solid";
							break;
					}

					string[] paths = { Application.StartupPath, "FontAwesome", "svgs", $"{_font}", $"{_iconChar}.svg" };
					string _path = Path.Combine(paths);

					if (!centerIcon)
					{
						Bitmap iconBitmap = RenderSvgToBitmap(_path, IconWidth, IconHeight, _iconColor);
						pevent.Graphics.DrawImage(iconBitmap, this.Width * 0.05f, this.Height / 2 - IconHeight / 2);

						bounds.X += (int)(this.Width * 0.05f + IconWidth / 2);
					}
					else
					{
						Bitmap iconBitmap = RenderSvgToBitmap(_path, IconWidth, IconHeight, _iconColor);
						pevent.Graphics.DrawImage(iconBitmap, this.Width / 2 - IconWidth / 2, this.Height / 2 - IconHeight / 2);
					}

				}

				// Yazıyı ortala ve çiz
				TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, bounds, this.ForeColor,
				TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}
		}

		private Bitmap RenderSvgToBitmap(string path, int width, int height, Color color)
		{
			SvgDocument svgDoc = SvgDocument.Open(path);
			svgDoc.Width = width;
			svgDoc.Height = height;
			svgDoc.Fill = new SvgColourServer(color);
			return svgDoc.Draw();
		}
	}

	public enum IconFont
	{
		brands,
		regular,
		solid
	}
}
