namespace AudioPlayer {
	partial class AlbumEditForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumEditForm));
			this.CloseButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.SongsLabel = new System.Windows.Forms.Label();
			this.YearLabel = new System.Windows.Forms.Label();
			this.YearNumeric = new System.Windows.Forms.NumericUpDown();
			this.ArtistComboBox = new System.Windows.Forms.ComboBox();
			this.ArtistLabel = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.ImageAddButton = new System.Windows.Forms.Button();
			this.AlbumCoverBox = new System.Windows.Forms.PictureBox();
			this.SongsListBox = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.YearNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AlbumCoverBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.Location = new System.Drawing.Point(301, 612);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(100, 35);
			this.CloseButton.TabIndex = 23;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.SystemColors.Control;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditButton.Location = new System.Drawing.Point(12, 612);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(100, 35);
			this.EditButton.TabIndex = 22;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// SongsLabel
			// 
			this.SongsLabel.AutoSize = true;
			this.SongsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SongsLabel.Location = new System.Drawing.Point(48, 350);
			this.SongsLabel.Name = "SongsLabel";
			this.SongsLabel.Size = new System.Drawing.Size(59, 21);
			this.SongsLabel.TabIndex = 20;
			this.SongsLabel.Text = "Songs:";
			// 
			// YearLabel
			// 
			this.YearLabel.AutoSize = true;
			this.YearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.YearLabel.Location = new System.Drawing.Point(52, 519);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(51, 21);
			this.YearLabel.TabIndex = 19;
			this.YearLabel.Text = "Year:";
			// 
			// YearNumeric
			// 
			this.YearNumeric.BackColor = System.Drawing.SystemColors.Control;
			this.YearNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.YearNumeric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.YearNumeric.Location = new System.Drawing.Point(113, 517);
			this.YearNumeric.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.YearNumeric.Name = "YearNumeric";
			this.YearNumeric.Size = new System.Drawing.Size(125, 23);
			this.YearNumeric.TabIndex = 18;
			// 
			// ArtistComboBox
			// 
			this.ArtistComboBox.BackColor = System.Drawing.SystemColors.Control;
			this.ArtistComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ArtistComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ArtistComboBox.FormattingEnabled = true;
			this.ArtistComboBox.Location = new System.Drawing.Point(113, 300);
			this.ArtistComboBox.Name = "ArtistComboBox";
			this.ArtistComboBox.Size = new System.Drawing.Size(250, 29);
			this.ArtistComboBox.TabIndex = 16;
			// 
			// ArtistLabel
			// 
			this.ArtistLabel.AutoSize = true;
			this.ArtistLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ArtistLabel.Location = new System.Drawing.Point(52, 303);
			this.ArtistLabel.Name = "ArtistLabel";
			this.ArtistLabel.Size = new System.Drawing.Size(55, 21);
			this.ArtistLabel.TabIndex = 15;
			this.ArtistLabel.Text = "Artist:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TitleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleTextBox.Location = new System.Drawing.Point(113, 259);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(250, 20);
			this.TitleTextBox.TabIndex = 13;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(62, 259);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(45, 21);
			this.TitleLabel.TabIndex = 12;
			this.TitleLabel.Text = "Title:";
			// 
			// ImageAddButton
			// 
			this.ImageAddButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ImageAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageAddButton.BackgroundImage")));
			this.ImageAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ImageAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ImageAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ImageAddButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImageAddButton.Location = new System.Drawing.Point(283, 195);
			this.ImageAddButton.Name = "ImageAddButton";
			this.ImageAddButton.Size = new System.Drawing.Size(30, 30);
			this.ImageAddButton.TabIndex = 26;
			this.ImageAddButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.ImageAddButton.UseVisualStyleBackColor = false;
			this.ImageAddButton.Click += new System.EventHandler(this.ImageAddButton_Click);
			// 
			// AlbumCoverBox
			// 
			this.AlbumCoverBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.AlbumCoverBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlbumCoverBox.BackgroundImage")));
			this.AlbumCoverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.AlbumCoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AlbumCoverBox.Location = new System.Drawing.Point(113, 25);
			this.AlbumCoverBox.Name = "AlbumCoverBox";
			this.AlbumCoverBox.Size = new System.Drawing.Size(200, 200);
			this.AlbumCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AlbumCoverBox.TabIndex = 25;
			this.AlbumCoverBox.TabStop = false;
			// 
			// SongsListBox
			// 
			this.SongsListBox.BackColor = System.Drawing.SystemColors.Control;
			this.SongsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SongsListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SongsListBox.FormattingEnabled = true;
			this.SongsListBox.Location = new System.Drawing.Point(113, 350);
			this.SongsListBox.Name = "SongsListBox";
			this.SongsListBox.ScrollAlwaysVisible = true;
			this.SongsListBox.Size = new System.Drawing.Size(250, 154);
			this.SongsListBox.Sorted = true;
			this.SongsListBox.TabIndex = 28;
			// 
			// AlbumEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(413, 659);
			this.Controls.Add(this.SongsListBox);
			this.Controls.Add(this.ImageAddButton);
			this.Controls.Add(this.AlbumCoverBox);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.SongsLabel);
			this.Controls.Add(this.YearLabel);
			this.Controls.Add(this.YearNumeric);
			this.Controls.Add(this.ArtistComboBox);
			this.Controls.Add(this.ArtistLabel);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.TitleLabel);
			this.Name = "AlbumEditForm";
			this.Text = "Edit Album";
			((System.ComponentModel.ISupportInitialize)(this.YearNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AlbumCoverBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Label SongsLabel;
		private System.Windows.Forms.Label YearLabel;
		private System.Windows.Forms.NumericUpDown YearNumeric;
		private System.Windows.Forms.ComboBox ArtistComboBox;
		private System.Windows.Forms.Label ArtistLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Button ImageAddButton;
		private System.Windows.Forms.PictureBox AlbumCoverBox;
		private System.Windows.Forms.CheckedListBox SongsListBox;
	}
}