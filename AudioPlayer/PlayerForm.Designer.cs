namespace AudioPlayer {
	partial class PlayerForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button PrevButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            System.Windows.Forms.Button NextButton;
            this.PlayButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.RepeatButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SongsButton = new System.Windows.Forms.ToolStripButton();
            this.ShowArtistsButton = new System.Windows.Forms.ToolStripButton();
            this.ShowPlaylistsButton = new System.Windows.Forms.ToolStripButton();
            this.VolumeButton = new System.Windows.Forms.ToolStripButton();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.AlbumCoverBox = new System.Windows.Forms.PictureBox();
            this.FullTimeLabel = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.SongTitleLabel = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.TimeBarUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.VolumeValueLabel = new System.Windows.Forms.Label();
            this.ImageAddButton = new System.Windows.Forms.Button();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.AlbumTitleLabel = new System.Windows.Forms.Label();
            this.AlbumYearLabel = new System.Windows.Forms.Label();
            this.AddFoldersMessage = new System.Windows.Forms.Label();
            PrevButton = new System.Windows.Forms.Button();
            NextButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevButton
            // 
            PrevButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            PrevButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            PrevButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            PrevButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PrevButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            PrevButton.Image = ((System.Drawing.Image)(resources.GetObject("PrevButton.Image")));
            PrevButton.Location = new System.Drawing.Point(388, 657);
            PrevButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new System.Drawing.Size(73, 68);
            PrevButton.TabIndex = 7;
            PrevButton.UseVisualStyleBackColor = false;
            PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            NextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            NextButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            NextButton.Location = new System.Drawing.Point(564, 657);
            NextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(73, 68);
            NextButton.TabIndex = 8;
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.Location = new System.Drawing.Point(469, 651);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(87, 80);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShuffleButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShuffleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.ShuffleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ShuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShuffleButton.Image = ((System.Drawing.Image)(resources.GetObject("ShuffleButton.Image")));
            this.ShuffleButton.Location = new System.Drawing.Point(103, 663);
            this.ShuffleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(73, 68);
            this.ShuffleButton.TabIndex = 5;
            this.ShuffleButton.UseVisualStyleBackColor = false;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // RepeatButton
            // 
            this.RepeatButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RepeatButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.RepeatButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.RepeatButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RepeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepeatButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RepeatButton.Image = ((System.Drawing.Image)(resources.GetObject("RepeatButton.Image")));
            this.RepeatButton.Location = new System.Drawing.Point(823, 663);
            this.RepeatButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(73, 68);
            this.RepeatButton.TabIndex = 6;
            this.RepeatButton.UseVisualStyleBackColor = false;
            this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SongsButton,
            this.ShowArtistsButton,
            this.ShowPlaylistsButton,
            this.VolumeButton,
            this.AddBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(67, 752);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SongsButton
            // 
            this.SongsButton.AutoSize = false;
            this.SongsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SongsButton.Image = ((System.Drawing.Image)(resources.GetObject("SongsButton.Image")));
            this.SongsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SongsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SongsButton.Name = "SongsButton";
            this.SongsButton.Size = new System.Drawing.Size(45, 55);
            this.SongsButton.Text = "toolStripButton1";
            this.SongsButton.ToolTipText = "Songs";
            this.SongsButton.Click += new System.EventHandler(this.SongsButton_Click);
            // 
            // ShowArtistsButton
            // 
            this.ShowArtistsButton.AutoSize = false;
            this.ShowArtistsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowArtistsButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowArtistsButton.Image")));
            this.ShowArtistsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowArtistsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowArtistsButton.Name = "ShowArtistsButton";
            this.ShowArtistsButton.Size = new System.Drawing.Size(45, 55);
            this.ShowArtistsButton.Text = "toolStripButton2";
            this.ShowArtistsButton.ToolTipText = "Artists";
            this.ShowArtistsButton.Click += new System.EventHandler(this.ShowArtistsButton_Click);
            // 
            // ShowPlaylistsButton
            // 
            this.ShowPlaylistsButton.AutoSize = false;
            this.ShowPlaylistsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowPlaylistsButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowPlaylistsButton.Image")));
            this.ShowPlaylistsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPlaylistsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowPlaylistsButton.Name = "ShowPlaylistsButton";
            this.ShowPlaylistsButton.Size = new System.Drawing.Size(45, 55);
            this.ShowPlaylistsButton.Text = "toolStripButton2";
            this.ShowPlaylistsButton.ToolTipText = "Playlists";
            this.ShowPlaylistsButton.Click += new System.EventHandler(this.ShowPlaylistsButton_Click);
            // 
            // VolumeButton
            // 
            this.VolumeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VolumeButton.AutoSize = false;
            this.VolumeButton.AutoToolTip = false;
            this.VolumeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VolumeButton.Image = ((System.Drawing.Image)(resources.GetObject("VolumeButton.Image")));
            this.VolumeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VolumeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(45, 60);
            this.VolumeButton.ToolTipText = "Volume On/Off";
            this.VolumeButton.Click += new System.EventHandler(this.VolumeButton_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = false;
            this.AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(45, 55);
            this.AddBtn.Text = "toolStripButton2";
            this.AddBtn.ToolTipText = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TimeBar
            // 
            this.TimeBar.AutoSize = false;
            this.TimeBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeBar.Location = new System.Drawing.Point(84, 582);
            this.TimeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeBar.Maximum = 240;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(812, 31);
            this.TimeBar.TabIndex = 1;
            this.TimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeBar.ValueChanged += new System.EventHandler(this.TimeBar_ValueChanged);
            this.TimeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeBar_MouseDown);
            this.TimeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TimeBar_MouseUp);
            // 
            // AlbumCoverBox
            // 
            this.AlbumCoverBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AlbumCoverBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlbumCoverBox.BackgroundImage")));
            this.AlbumCoverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AlbumCoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumCoverBox.Location = new System.Drawing.Point(89, 15);
            this.AlbumCoverBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlbumCoverBox.Name = "AlbumCoverBox";
            this.AlbumCoverBox.Size = new System.Drawing.Size(266, 246);
            this.AlbumCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumCoverBox.TabIndex = 9;
            this.AlbumCoverBox.TabStop = false;
            // 
            // FullTimeLabel
            // 
            this.FullTimeLabel.AutoSize = true;
            this.FullTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FullTimeLabel.Location = new System.Drawing.Point(847, 555);
            this.FullTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullTimeLabel.Name = "FullTimeLabel";
            this.FullTimeLabel.Size = new System.Drawing.Size(41, 20);
            this.FullTimeLabel.TabIndex = 10;
            this.FullTimeLabel.Text = "0:00";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CurrentTimeLabel.Location = new System.Drawing.Point(84, 617);
            this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(41, 20);
            this.CurrentTimeLabel.TabIndex = 12;
            this.CurrentTimeLabel.Text = "0:00";
            // 
            // SongTitleLabel
            // 
            this.SongTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTitleLabel.Location = new System.Drawing.Point(80, 496);
            this.SongTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SongTitleLabel.Name = "SongTitleLabel";
            this.SongTitleLabel.Size = new System.Drawing.Size(687, 59);
            this.SongTitleLabel.TabIndex = 13;
            // 
            // VolumeBar
            // 
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VolumeBar.Location = new System.Drawing.Point(16, 484);
            this.VolumeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(35, 187);
            this.VolumeBar.TabIndex = 15;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 100;
            this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // TimeBarUpdateTimer
            // 
            this.TimeBarUpdateTimer.Tick += new System.EventHandler(this.TimeBarUpdateTimer_Tick);
            // 
            // VolumeValueLabel
            // 
            this.VolumeValueLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VolumeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VolumeValueLabel.Location = new System.Drawing.Point(0, 454);
            this.VolumeValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VolumeValueLabel.Name = "VolumeValueLabel";
            this.VolumeValueLabel.Size = new System.Drawing.Size(65, 26);
            this.VolumeValueLabel.TabIndex = 17;
            this.VolumeValueLabel.Text = "0";
            this.VolumeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageAddButton
            // 
            this.ImageAddButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImageAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageAddButton.BackgroundImage")));
            this.ImageAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ImageAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageAddButton.Location = new System.Drawing.Point(316, 224);
            this.ImageAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImageAddButton.Name = "ImageAddButton";
            this.ImageAddButton.Size = new System.Drawing.Size(40, 37);
            this.ImageAddButton.TabIndex = 18;
            this.ImageAddButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ImageAddButton.UseVisualStyleBackColor = false;
            this.ImageAddButton.Click += new System.EventHandler(this.ImageAddButton_Click);
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArtistNameLabel.Location = new System.Drawing.Point(367, 26);
            this.ArtistNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(469, 38);
            this.ArtistNameLabel.TabIndex = 19;
            // 
            // AlbumTitleLabel
            // 
            this.AlbumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumTitleLabel.Location = new System.Drawing.Point(367, 112);
            this.AlbumTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumTitleLabel.Name = "AlbumTitleLabel";
            this.AlbumTitleLabel.Size = new System.Drawing.Size(469, 38);
            this.AlbumTitleLabel.TabIndex = 20;
            // 
            // AlbumYearLabel
            // 
            this.AlbumYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumYearLabel.Location = new System.Drawing.Point(396, 197);
            this.AlbumYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumYearLabel.Name = "AlbumYearLabel";
            this.AlbumYearLabel.Size = new System.Drawing.Size(463, 38);
            this.AlbumYearLabel.TabIndex = 21;
            this.AlbumYearLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddFoldersMessage
            // 
            this.AddFoldersMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddFoldersMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddFoldersMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFoldersMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoldersMessage.Location = new System.Drawing.Point(48, 224);
            this.AddFoldersMessage.Name = "AddFoldersMessage";
            this.AddFoldersMessage.Size = new System.Drawing.Size(290, 54);
            this.AddFoldersMessage.TabIndex = 22;
            this.AddFoldersMessage.Text = "Seems empty. Add some music folders to start using player!";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 752);
            this.Controls.Add(this.AddFoldersMessage);
            this.Controls.Add(this.AlbumYearLabel);
            this.Controls.Add(this.AlbumTitleLabel);
            this.Controls.Add(this.ArtistNameLabel);
            this.Controls.Add(this.ImageAddButton);
            this.Controls.Add(this.VolumeValueLabel);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.SongTitleLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.FullTimeLabel);
            this.Controls.Add(this.AlbumCoverBox);
            this.Controls.Add(NextButton);
            this.Controls.Add(PrevButton);
            this.Controls.Add(this.RepeatButton);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.EnabledChanged += new System.EventHandler(this.PlayerForm_EnabledChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton SongsButton;
		private System.Windows.Forms.ToolStripButton ShowArtistsButton;
		private System.Windows.Forms.TrackBar TimeBar;
		private System.Windows.Forms.PictureBox AlbumCoverBox;
		private System.Windows.Forms.Label FullTimeLabel;
		private System.Windows.Forms.Label CurrentTimeLabel;
		private System.Windows.Forms.Label SongTitleLabel;
		private System.Windows.Forms.ToolStripButton ShowPlaylistsButton;
		private System.Windows.Forms.ToolStripButton AddBtn;
		private System.Windows.Forms.ToolStripButton VolumeButton;
		private System.Windows.Forms.TrackBar VolumeBar;
		private System.Windows.Forms.Timer TimeBarUpdateTimer;
		private System.Windows.Forms.Label VolumeValueLabel;
		private System.Windows.Forms.Button RepeatButton;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Button ShuffleButton;
		private System.Windows.Forms.Button ImageAddButton;
		private System.Windows.Forms.Label ArtistNameLabel;
		private System.Windows.Forms.Label AlbumTitleLabel;
		private System.Windows.Forms.Label AlbumYearLabel;
        private System.Windows.Forms.Label AddFoldersMessage;
    }
}

