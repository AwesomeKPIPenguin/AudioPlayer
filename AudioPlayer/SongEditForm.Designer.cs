namespace AudioPlayer {
	partial class SongEditForm {
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
			this.TitleLabel = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.AlbumLabel = new System.Windows.Forms.Label();
			this.ArtistLabel = new System.Windows.Forms.Label();
			this.ArtistComboBox = new System.Windows.Forms.ComboBox();
			this.AlbumComboBox = new System.Windows.Forms.ComboBox();
			this.YearNumeric = new System.Windows.Forms.NumericUpDown();
			this.YearLabel = new System.Windows.Forms.Label();
			this.CommentLabel = new System.Windows.Forms.Label();
			this.CommentTextBox = new System.Windows.Forms.TextBox();
			this.EditButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.YearNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(84, 33);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(45, 21);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TitleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleTextBox.Location = new System.Drawing.Point(135, 33);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(250, 20);
			this.TitleTextBox.TabIndex = 1;
			// 
			// AlbumLabel
			// 
			this.AlbumLabel.AutoSize = true;
			this.AlbumLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AlbumLabel.Location = new System.Drawing.Point(63, 128);
			this.AlbumLabel.Name = "AlbumLabel";
			this.AlbumLabel.Size = new System.Drawing.Size(66, 21);
			this.AlbumLabel.TabIndex = 2;
			this.AlbumLabel.Text = "Album:";
			// 
			// ArtistLabel
			// 
			this.ArtistLabel.AutoSize = true;
			this.ArtistLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ArtistLabel.Location = new System.Drawing.Point(74, 77);
			this.ArtistLabel.Name = "ArtistLabel";
			this.ArtistLabel.Size = new System.Drawing.Size(55, 21);
			this.ArtistLabel.TabIndex = 3;
			this.ArtistLabel.Text = "Artist:";
			// 
			// ArtistComboBox
			// 
			this.ArtistComboBox.BackColor = System.Drawing.SystemColors.Control;
			this.ArtistComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ArtistComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ArtistComboBox.FormattingEnabled = true;
			this.ArtistComboBox.Location = new System.Drawing.Point(135, 74);
			this.ArtistComboBox.Name = "ArtistComboBox";
			this.ArtistComboBox.Size = new System.Drawing.Size(250, 29);
			this.ArtistComboBox.TabIndex = 4;
			this.ArtistComboBox.SelectedValueChanged += new System.EventHandler(this.ArtistComboBox_SelectedValueChanged);
			// 
			// AlbumComboBox
			// 
			this.AlbumComboBox.BackColor = System.Drawing.SystemColors.Control;
			this.AlbumComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AlbumComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AlbumComboBox.FormattingEnabled = true;
			this.AlbumComboBox.Location = new System.Drawing.Point(135, 125);
			this.AlbumComboBox.Name = "AlbumComboBox";
			this.AlbumComboBox.Size = new System.Drawing.Size(250, 29);
			this.AlbumComboBox.TabIndex = 5;
			// 
			// YearNumeric
			// 
			this.YearNumeric.BackColor = System.Drawing.SystemColors.Control;
			this.YearNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.YearNumeric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.YearNumeric.Location = new System.Drawing.Point(135, 176);
			this.YearNumeric.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.YearNumeric.Name = "YearNumeric";
			this.YearNumeric.Size = new System.Drawing.Size(125, 23);
			this.YearNumeric.TabIndex = 6;
			// 
			// YearLabel
			// 
			this.YearLabel.AutoSize = true;
			this.YearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.YearLabel.Location = new System.Drawing.Point(78, 175);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(51, 21);
			this.YearLabel.TabIndex = 7;
			this.YearLabel.Text = "Year:";
			// 
			// CommentLabel
			// 
			this.CommentLabel.AutoSize = true;
			this.CommentLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CommentLabel.Location = new System.Drawing.Point(35, 238);
			this.CommentLabel.Name = "CommentLabel";
			this.CommentLabel.Size = new System.Drawing.Size(94, 21);
			this.CommentLabel.TabIndex = 8;
			this.CommentLabel.Text = "Comment:";
			// 
			// CommentTextBox
			// 
			this.CommentTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.CommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CommentTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CommentTextBox.Location = new System.Drawing.Point(135, 239);
			this.CommentTextBox.Multiline = true;
			this.CommentTextBox.Name = "CommentTextBox";
			this.CommentTextBox.Size = new System.Drawing.Size(250, 148);
			this.CommentTextBox.TabIndex = 9;
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.SystemColors.Control;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditButton.Location = new System.Drawing.Point(12, 416);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(100, 35);
			this.EditButton.TabIndex = 10;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.Location = new System.Drawing.Point(301, 416);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(100, 35);
			this.CloseButton.TabIndex = 11;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// SongEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(413, 463);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.CommentTextBox);
			this.Controls.Add(this.CommentLabel);
			this.Controls.Add(this.YearLabel);
			this.Controls.Add(this.YearNumeric);
			this.Controls.Add(this.AlbumComboBox);
			this.Controls.Add(this.ArtistComboBox);
			this.Controls.Add(this.ArtistLabel);
			this.Controls.Add(this.AlbumLabel);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.TitleLabel);
			this.Name = "SongEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Song";
			((System.ComponentModel.ISupportInitialize)(this.YearNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.Label AlbumLabel;
		private System.Windows.Forms.Label ArtistLabel;
		private System.Windows.Forms.ComboBox ArtistComboBox;
		private System.Windows.Forms.ComboBox AlbumComboBox;
		private System.Windows.Forms.NumericUpDown YearNumeric;
		private System.Windows.Forms.Label YearLabel;
		private System.Windows.Forms.Label CommentLabel;
		private System.Windows.Forms.TextBox CommentTextBox;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button CloseButton;
	}
}