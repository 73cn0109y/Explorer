namespace Explorer.CustomControls
{
	partial class NotificationPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.animationTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// animationTimer
			// 
			this.animationTimer.Interval = 10;
			this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
			// 
			// NotificationPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(300, 500);
			this.Name = "NotificationPanel";
			this.Size = new System.Drawing.Size(300, 500);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer animationTimer;
	}
}
