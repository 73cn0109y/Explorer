namespace Explorer.CustomControls.Taskbar
{
	partial class SystemIcon
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
			this.picIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// picIcon
			// 
			this.picIcon.BackColor = System.Drawing.Color.Transparent;
			this.picIcon.Location = new System.Drawing.Point(5, 15);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(30, 30);
			this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			this.picIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picIcon_MouseClick);
			// 
			// SystemIcon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.picIcon);
			this.Name = "SystemIcon";
			this.Size = new System.Drawing.Size(40, 60);
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picIcon;
	}
}
