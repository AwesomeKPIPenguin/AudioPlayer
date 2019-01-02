namespace AudioPlayer {
	partial class PlaylistEditForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistEditForm));
			this.SongsListBox = new System.Windows.Forms.CheckedListBox();
			this.ImageAddButton = new System.Windows.Forms.Button();
			this.PlaylistCoverBox = new System.Windows.Forms.PictureBox();
			this.CloseButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.SongsLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistCoverBox)).BeginInit();
			this.SuspendLayout();
			// 
			// SongsListBox
			// 
			this.SongsListBox.BackColor = System.Drawing.SystemColors.Control;
			this.SongsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SongsListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SongsListBox.FormattingEnabled = true;
			this.SongsListBox.Location = new System.Drawing.Point(107, 315);
			this.SongsListBox.Name = "SongsListBox";
			this.SongsListBox.ScrollAlwaysVisible = true;
			this.SongsListBox.Size = new System.Drawing.Size(250, 154);
			this.SongsListBox.Sorted = true;
			this.SongsListBox.TabIndex = 40;
			// 
			// ImageAddButton
			// 
			this.ImageAddButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ImageAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageAddButton.BackgroundImage")));
			this.ImageAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ImageAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ImageAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ImageAddButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImageAddButton.Location = new System.Drawing.Point(277, 206);
			this.ImageAddButton.Name = "ImageAddButton";
			this.ImageAddButton.Size = new System.Drawing.Size(30, 30);
			this.ImageAddButton.TabIndex = 39;
			this.ImageAddButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.ImageAddButton.UseVisualStyleBackColor = false;
			this.ImageAddButton.Click += new System.EventHandler(this.ImageAddButton_Click);
			// 
			// PlaylistCoverBox
			// 
			this.PlaylistCoverBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PlaylistCoverBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaylistCoverBox.BackgroundImage")));
			this.PlaylistCoverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.PlaylistCoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PlaylistCoverBox.Location = new System.Drawing.Point(107, 36);
			this.PlaylistCoverBox.Name = "PlaylistCoverBox";
			this.PlaylistCoverBox.Size = new System.Drawing.Size(200, 200);
			this.PlaylistCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PlaylistCoverBox.TabIndex = 38;
			this.PlaylistCoverBox.TabStop = false;
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.Location = new System.Drawing.Point(301, 542);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(100, 35);
			this.CloseButton.TabIndex = 37;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.SystemColors.Control;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditButton.Location = new System.Drawing.Point(12, 542);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(100, 35);
			this.EditButton.TabIndex = 36;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// SongsLabel
			// 
			this.SongsLabel.AutoSize = true;
			this.SongsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SongsLabel.Location = new System.Drawing.Point(42, 315);
			this.SongsLabel.Name = "SongsLabel";
			this.SongsLabel.Size = new System.Drawing.Size(59, 21);
			this.SongsLabel.TabIndex = 35;
			this.SongsLabel.Text = "Songs:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameTextBox.Location = new System.Drawing.Point(107, 270);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(250, 20);
			this.NameTextBox.TabIndex = 30;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(39, 269);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(62, 21);
			this.NameLabel.TabIndex = 29;
			this.NameLabel.Text = "Name:";
			// 
			// PlaylistEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(413, 589);
			this.Controls.Add(this.SongsListBox);
			this.Controls.Add(this.ImageAddButton);
			this.Controls.Add(this.PlaylistCoverBox);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.SongsLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Name = "PlaylistEditForm";
			this.Text = "Edit Playlist";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlaylistEditForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.PlaylistCoverBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox SongsListBox;
		private System.Windows.Forms.Button ImageAddButton;
		private System.Windows.Forms.PictureBox PlaylistCoverBox;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Label SongsLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label NameLabel;
	}
}