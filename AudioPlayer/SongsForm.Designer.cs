namespace AudioPlayer {
	partial class SongsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.SongList = new AudioPlayer.SongListControl();
			this.SuspendLayout();
			// 
			// SongList
			// 
			this.SongList.Location = new System.Drawing.Point(12, 12);
			this.SongList.Name = "SongList";
			this.SongList.Size = new System.Drawing.Size(580, 437);
			this.SongList.Songs = null;
			this.SongList.TabIndex = 0;
			// 
			// SongsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(609, 461);
			this.Controls.Add(this.SongList);
			this.Name = "SongsForm";
			this.Text = "Songs";
			this.ResumeLayout(false);

		}

		#endregion

		private SongListControl SongList;
	}
}