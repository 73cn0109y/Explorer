using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Explorer
{
	public static class Methods
	{
		public enum Corners
		{
			None = -1,
			All = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 4,
			BottomLeft = 8
		}

		public static GraphicsPath RoundedGraphcisPath(Rectangle bounds, int radius, Corners corners = Corners.All)
		{
			int diameter = radius * 2;
			Size size = new Size(diameter, diameter);
			Rectangle arc = new Rectangle(bounds.Location, size);
			GraphicsPath path = new GraphicsPath();

			if (radius == 0 || corners == Corners.None)
			{
				path.AddRectangle(bounds);
				return path;
			}

			if (corners == Corners.All || corners.HasFlag(Corners.TopLeft))
			{
				// top left arc  
				path.AddArc(arc, 180, 90);
			}

			if (corners == Corners.All || corners.HasFlag(Corners.TopRight))
			{
				// top right arc  
				arc.X = bounds.Right - diameter;
				path.AddArc(arc, 270, 90);
			}
			else
			{
				arc.X = bounds.Right;
				path.AddLine(arc.X, arc.Y, bounds.Right, arc.Y);
			}

			if (corners == Corners.All || corners.HasFlag(Corners.BottomRight))
			{
				// bottom right arc  
				arc.Y = bounds.Bottom - diameter;
				path.AddArc(arc, 0, 90);
			}
			else
			{
				arc.Y = bounds.Bottom - diameter;
				path.AddLine(arc.X + diameter, arc.Y, bounds.Right, bounds.Bottom);
			}

			if (corners == Corners.All || corners.HasFlag(Corners.BottomLeft))
			{
				// bottom left arc 
				arc.X = bounds.Left;
				path.AddArc(arc, 90, 90);
			}
			else
			{
				path.AddLine(arc.X, arc.Y, 0, bounds.Bottom);
			}

			path.CloseFigure();
			return path;
		}
	}
}
