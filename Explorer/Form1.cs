using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Size = Screen.PrimaryScreen.Bounds.Size;
			Location = Screen.PrimaryScreen.Bounds.Location;

			notificationPanel1.OpenPosition = notificationPanel1.Location;
			notificationPanel1.HidePosition = new Point(ClientRectangle.Right, notificationPanel1.Location.Y);
		}

		private void picStartButton_MouseClick(object sender, MouseEventArgs e)
		{
			Application.Exit();
		}

		private void systemIcon1_MouseClickDone(object sender, EventArgs e)
		{
			notificationPanel1.AnimateShow();
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			notificationPanel1.Init();

			base.OnHandleCreated(e);
		}
	}
}
