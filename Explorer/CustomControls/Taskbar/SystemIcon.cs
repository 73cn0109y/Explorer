using System;
using System.Drawing;
using System.Windows.Forms;

namespace Explorer.CustomControls.Taskbar
{
	public partial class SystemIcon : UserControl
	{
		public Color ActiveColor { get; set; }

		public Image Image { get { return picIcon.Image; } set { picIcon.Image = value; } }

		public bool Active { get; set; } = false;

		public event EventHandler MouseClickDone;

		public SystemIcon()
		{
			InitializeComponent();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			BackColor = Active ? Color.FromArgb(200, ActiveColor) : Color.FromArgb(100, ActiveColor);

			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
				return;

			BackColor = Active ? ActiveColor : Color.Transparent;

			base.OnMouseLeave(e);
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			Active = !Active;

			BackColor = Active ? Color.FromArgb(200, ActiveColor) : Color.FromArgb(100, ActiveColor);

			MouseClickDone?.Invoke(this, e);

			base.OnMouseClick(e);
		}

		private void picIcon_MouseClick(object sender, MouseEventArgs e)
		{
			OnMouseClick(e);
		}
	}
}
