using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Explorer.CustomControls
{
	public partial class NotificationPanel : UserControl
	{
		public Point OpenPosition { get; set; }
		public Point HidePosition { get; set; }

		private bool ShowAnimation = false;

		public NotificationPanel()
		{
			InitializeComponent();
		}

		public void AnimateShow()
		{
			if (!animationTimer.Enabled)
				animationTimer.Enabled = true;

			ShowAnimation = !ShowAnimation;

			animationTimer.Start();
		}

		public void Init()
		{
			Location = HidePosition;
			Visible = false;
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			Region = new Region(Methods.RoundedGraphcisPath(ClientRectangle, 10));

			base.OnHandleCreated(e);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			Region = new Region(Methods.RoundedGraphcisPath(ClientRectangle, 10));

			base.OnSizeChanged(e);
		}

		private void animationTimer_Tick(object sender, EventArgs e)
		{
			if (ShowAnimation)
			{
				if (!Visible)
					Visible = true;

				if(Location.X <= OpenPosition.X || Location.X - 20 <= OpenPosition.X)
				{
					animationTimer.Stop();
					Location = OpenPosition;
					return;
				}

				Location = new Point(Location.X - 20, Location.Y);
			}
			else
			{
				if(Location.X >= HidePosition.X || Location.X + 20 >= HidePosition.X)
				{
					Visible = false;
					animationTimer.Stop();
					Location = HidePosition;
					return;
				}

				Location = new Point(Location.X + 20, Location.Y);
			}
		}
	}
}
