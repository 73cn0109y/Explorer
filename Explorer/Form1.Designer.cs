namespace Explorer
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.picStartButton = new System.Windows.Forms.PictureBox();
			this.notificationPanel1 = new Explorer.CustomControls.NotificationPanel();
			this.systemIcon5 = new Explorer.CustomControls.Taskbar.SystemIcon();
			this.systemIcon4 = new Explorer.CustomControls.Taskbar.SystemIcon();
			this.systemIcon3 = new Explorer.CustomControls.Taskbar.SystemIcon();
			this.systemIcon2 = new Explorer.CustomControls.Taskbar.SystemIcon();
			this.systemIcon1 = new Explorer.CustomControls.Taskbar.SystemIcon();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picStartButton)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.systemIcon5);
			this.panel1.Controls.Add(this.systemIcon4);
			this.panel1.Controls.Add(this.systemIcon3);
			this.panel1.Controls.Add(this.systemIcon2);
			this.panel1.Controls.Add(this.systemIcon1);
			this.panel1.Controls.Add(this.picStartButton);
			this.panel1.Location = new System.Drawing.Point(0, 940);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1900, 60);
			this.panel1.TabIndex = 0;
			// 
			// picStartButton
			// 
			this.picStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picStartButton.Image = global::Explorer.Properties.Resources.menu_icon;
			this.picStartButton.Location = new System.Drawing.Point(12, 18);
			this.picStartButton.Name = "picStartButton";
			this.picStartButton.Size = new System.Drawing.Size(30, 30);
			this.picStartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picStartButton.TabIndex = 0;
			this.picStartButton.TabStop = false;
			this.picStartButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picStartButton_MouseClick);
			// 
			// notificationPanel1
			// 
			this.notificationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.notificationPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.notificationPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.notificationPanel1.HidePosition = new System.Drawing.Point(0, 0);
			this.notificationPanel1.Location = new System.Drawing.Point(1488, 12);
			this.notificationPanel1.MinimumSize = new System.Drawing.Size(300, 500);
			this.notificationPanel1.Name = "notificationPanel1";
			this.notificationPanel1.OpenPosition = new System.Drawing.Point(0, 0);
			this.notificationPanel1.Size = new System.Drawing.Size(400, 922);
			this.notificationPanel1.TabIndex = 1;
			// 
			// systemIcon5
			// 
			this.systemIcon5.Active = false;
			this.systemIcon5.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.systemIcon5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.systemIcon5.BackColor = System.Drawing.Color.Transparent;
			this.systemIcon5.Image = global::Explorer.Properties.Resources.taskbar_more;
			this.systemIcon5.Location = new System.Drawing.Point(1664, 0);
			this.systemIcon5.Name = "systemIcon5";
			this.systemIcon5.Size = new System.Drawing.Size(40, 60);
			this.systemIcon5.TabIndex = 6;
			// 
			// systemIcon4
			// 
			this.systemIcon4.Active = false;
			this.systemIcon4.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.systemIcon4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.systemIcon4.BackColor = System.Drawing.Color.Transparent;
			this.systemIcon4.Image = global::Explorer.Properties.Resources.taskbar_mobile;
			this.systemIcon4.Location = new System.Drawing.Point(1710, 0);
			this.systemIcon4.Name = "systemIcon4";
			this.systemIcon4.Size = new System.Drawing.Size(40, 60);
			this.systemIcon4.TabIndex = 5;
			// 
			// systemIcon3
			// 
			this.systemIcon3.Active = false;
			this.systemIcon3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.systemIcon3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.systemIcon3.BackColor = System.Drawing.Color.Transparent;
			this.systemIcon3.Image = global::Explorer.Properties.Resources.taskbar_wifi;
			this.systemIcon3.Location = new System.Drawing.Point(1756, 0);
			this.systemIcon3.Name = "systemIcon3";
			this.systemIcon3.Size = new System.Drawing.Size(40, 60);
			this.systemIcon3.TabIndex = 4;
			// 
			// systemIcon2
			// 
			this.systemIcon2.Active = false;
			this.systemIcon2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.systemIcon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.systemIcon2.BackColor = System.Drawing.Color.Transparent;
			this.systemIcon2.Image = global::Explorer.Properties.Resources.taskbar_battery;
			this.systemIcon2.Location = new System.Drawing.Point(1802, 0);
			this.systemIcon2.Name = "systemIcon2";
			this.systemIcon2.Size = new System.Drawing.Size(40, 60);
			this.systemIcon2.TabIndex = 3;
			// 
			// systemIcon1
			// 
			this.systemIcon1.Active = false;
			this.systemIcon1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
			this.systemIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.systemIcon1.BackColor = System.Drawing.Color.Transparent;
			this.systemIcon1.Image = global::Explorer.Properties.Resources.taskbar_notification;
			this.systemIcon1.Location = new System.Drawing.Point(1848, 0);
			this.systemIcon1.Name = "systemIcon1";
			this.systemIcon1.Size = new System.Drawing.Size(40, 60);
			this.systemIcon1.TabIndex = 2;
			this.systemIcon1.MouseClickDone += new System.EventHandler(this.systemIcon1_MouseClickDone);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Explorer.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1900, 1000);
			this.Controls.Add(this.notificationPanel1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picStartButton)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picStartButton;
		private CustomControls.NotificationPanel notificationPanel1;
		private CustomControls.Taskbar.SystemIcon systemIcon1;
		private CustomControls.Taskbar.SystemIcon systemIcon4;
		private CustomControls.Taskbar.SystemIcon systemIcon3;
		private CustomControls.Taskbar.SystemIcon systemIcon2;
		private CustomControls.Taskbar.SystemIcon systemIcon5;
	}
}

