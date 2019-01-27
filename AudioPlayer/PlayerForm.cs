
using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;

namespace AudioPlayer {

	public partial class PlayerForm : Form {

		private static	String			imgPath;

		public static	PlayerForm		Form			{ get; private set; }


		private			Song			_currentSong;

		public			SongListControl	QueueTable;
		public			List<int>		Source {

			get { return (_source); }
			set {
				_source = value;
				int[] buff = new int[Source.Count];
				Source.CopyTo(buff);
				_queue = new List<int>(buff);
				if (QueueTable != null)
					QueueTable.Songs = _queue;
				if (_queue.Count > 0)
					CurrentSong = Song.All[_queue[0]];
			}
		}
		public			Song			CurrentSong		{
		
			get { return (_currentSong); }
			set {
				Pause();
				if (_player.PlaybackState != PlaybackState.Stopped)
					_player.Stop();
				_currentSong = value;
				_reader = new AudioFileReader(value.Path);
				_player = new WaveOutEvent();
				_player.Init(_reader);
				TimeBar.Maximum = (int)_reader.TotalTime.TotalMilliseconds;
				SongTitleLabel.Text = value.Title;
				FullTimeLabel.Text = value.Duration.ToString(@"m\:ss");
				try {
					if (value.Album.Image == null)
						value.Album.Image = Image.FromFile(value.Album.ImagePath);
					AlbumCoverBox.Image = value.Album.Image;
				}
				catch (Exception) { AlbumCoverBox.Image = null; }
				ArtistNameLabel.Text = value.Artist.Name;
				AlbumTitleLabel.Text = value.Album.Title;
				AlbumYearLabel.Text = (value.Year == 0) ? String.Empty : value.Year.ToString();

				if (QueueTable != null && QueueTable.Songs != null) {
					
					if (_songRowIndex >= 0 && _songRowIndex < QueueTable.Songs.Count)
						QueueTable.Panel.Controls[_songRowIndex].BackColor = SystemColors.ControlDark;
					_songRowIndex = _queue.IndexOf(value.ID);
					if (_songRowIndex != -1)
						QueueTable.Panel.Controls[_songRowIndex].BackColor = SystemColors.ControlDarkDark;
				}
			}
		}

		private			int				_songRowIndex;
		private			Random			_rnd;
		private			List<int>		_source;
		private			List<int>		_queue;
		private			AudioFileReader	_reader;
		private			WaveOutEvent	_player;
		private			bool			_isPause;
		private			bool			_isMute;
		private			bool			_isRepeat;
		private			bool			_isShuffle;



		static			PlayerForm() {

			imgPath = Base.ProjectPath + "images/";
		}

		public			PlayerForm() {

			InitializeComponent();

			Form = this;

			_rnd = new Random();

			_player = new WaveOutEvent();
			_player.PlaybackStopped += new EventHandler<StoppedEventArgs>(_player_PlaybackStopped);
			_player.Volume = VolumeBar.Value / 100.0f;

			VolumeValueLabel.Text = VolumeBar.Value.ToString();
			_songRowIndex = -1;
			_isPause = true;
			_isMute = false;
			_isRepeat = false;
			_isShuffle = false;

			Base.Load();
			if (Base.Instance == null)
				Base.Instance = new Base();
			Song.Load();
			Album.Load();
			Artist.Load();
			Playlist.Load();

			Song.CheckPathes();



			Source = new List<int>(Song.All.Keys);
			int[] buff = new int[Source.Count];
			Source.CopyTo(buff);
			_queue = new List<int>(buff);
			if (_queue.Count > 0)
				CurrentSong = Song.All[_queue[0]];
			InitQueueTable();
		}



		// Song queue utils

		private void InitQueueTable() {

			QueueTable = new SongListControl {

				Left = 67,
				Top = 215,
				Height = 150,
				Songs = _queue
			};

			Controls.Add(QueueTable);
		}
		


		// Volume handling

		private void VolumeBar_ValueChanged(object sender, EventArgs e) {
			
			// changing label

			VolumeValueLabel.Text = VolumeBar.Value.ToString();

			// changing picture

			if (!_isMute && VolumeBar.Value > VolumeBar.Maximum / 2)
				VolumeButton.Image = Image.FromFile(imgPath + "speaker-2.png");
			else if (_isMute || VolumeBar.Value == 0)
				VolumeButton.Image = Image.FromFile(imgPath + "mute.png");
			else
				VolumeButton.Image = Image.FromFile(imgPath + "speaker-1.png");

			// changing volume

			if (_player != null) {

				_player.Volume = ((TrackBar)sender).Value / 100.0f;
				if (_isMute) _player.Volume = 0.0f;
			}
		}

		private void VolumeButton_Click(object sender, EventArgs e) {

			// changing picture

			if (_isMute) {
				_isMute = false;
				if (VolumeBar.Value > VolumeBar.Maximum / 2)
					VolumeButton.Image = Image.FromFile(imgPath + "speaker-2.png");
				else if (VolumeBar.Value == 0)
					VolumeButton.Image = Image.FromFile(imgPath + "mute.png");
				else
					VolumeButton.Image = Image.FromFile(imgPath + "speaker-1.png");
			}
			else {
				_isMute = true;
				VolumeButton.Image = Image.FromFile(imgPath + "mute.png");
			}

			// muting or unmuting

			if (_player != null)
				_player.Volume = (_isMute) ? 0.0f : VolumeBar.Value / 100.0f;
		}



		// Tool strip button handling

		private void SongsButton_Click(object sender, EventArgs e) {

			new SongsForm(new List<int>(Song.All.Keys)).Show();
		}

		private void AddBtn_Click(object sender, EventArgs e) {

			FolderBrowserDialog		fbd;
			
			fbd = new FolderBrowserDialog();

            AddFoldersMessage.Visible = false;
            this.Enabled = false;
			if (fbd.ShowDialog() == DialogResult.OK) {
				Song.ProcessSongsDirectory(fbd.SelectedPath);
			}
			if (_source == null) {

				Source = new List<int>(Song.All.Keys);
				QueueTable.Songs = _queue;
			}
			this.Enabled = true;
			this.BringToFront();
		}

		private void ShowArtistsButton_Click(object sender, EventArgs e) {

			FlowLayoutForm		form;
			PlaylistControl		control;

			form = new FlowLayoutForm();

			foreach (Artist artist in Artist.All.Values) {

				control = new PlaylistControl(artist, false);
				form.ListPanel.Controls.Add(control);
			}
			form.Show();
		}

		private void ShowPlaylistsButton_Click(object sender, EventArgs e) {

			FlowLayoutForm		form;
			PlaylistControl		control;
			Playlist			nullPlaylist;

			form = new FlowLayoutForm();
			nullPlaylist = null;

			form.ListPanel.Controls.Add(new PlaylistControl(nullPlaylist, true));
			foreach (Playlist playlist in Playlist.All.Values) {

				control = new PlaylistControl(playlist, false);
				form.ListPanel.Controls.Add(control);
			}
			form.Show();
		}



		// Song manipulation buttons

		public void Play() {

			_isPause = false;
			PlayButton.Image = Image.FromFile(imgPath + "pause.png");
			TimeBarUpdateTimer.Start();
			_player.Play();
		}

		public void Pause() {
			
			_isPause = true;
			PlayButton.Image = Image.FromFile(imgPath + "play-button.png");
			TimeBarUpdateTimer.Stop();
			_player.Pause();
		}

		private void Next() {

			int		i;
			bool	isPlaying;
			
			if (_isPause)
				isPlaying = false;
			else
				isPlaying = true;
			_player.Stop();
			if (_isRepeat)
				CurrentSong = CurrentSong;
			else {

				i = _queue.IndexOf(CurrentSong.ID);
				if (i < _queue.Count - 1)
					CurrentSong = Song.All[_queue[i + 1]];
				else
					CurrentSong = Song.All[_queue[0]];
			}
			if (isPlaying)
				Play();
		}

		private void Prev() {

			int		i;
			bool	isPlaying;

			if (_isPause)
				isPlaying = false;
			else
				isPlaying = true;
			_player.Stop();
			if (_isRepeat)
				CurrentSong = CurrentSong;
			else {

				i = _queue.IndexOf(CurrentSong.ID);
				if (i > 0)
					CurrentSong = Song.All[_queue[i - 1]];
				else
					CurrentSong = Song.All[_queue[_queue.Count - 1]];
			}
			if (isPlaying)
				Play();
		}



		private void PlayButton_Click(object sender, EventArgs e) {

			if (_isPause)
				Play();
			else
				Pause();
		}

		private void PrevButton_Click(object sender, EventArgs e) {

			Prev();
		}

		private void NextButton_Click(object sender, EventArgs e) {

			Next();
		}

		private void RepeatButton_Click(object sender, EventArgs e) {

			if (_isRepeat) {

				_isRepeat = false;
				RepeatButton.BackColor = SystemColors.ControlLightLight;
			}
			else {

				_isRepeat = true;
				RepeatButton.BackColor = SystemColors.ControlDark;
			}
		}

		private void ShuffleButton_Click(object sender, EventArgs e) {
			
			int		n;
			int		k;
			int		id;
			
			if (_isShuffle) {

				_isShuffle = false;
				ShuffleButton.BackColor = SystemColors.ControlLightLight;

				// returning original order

				int[] buff = new int[Source.Count];
				Source.CopyTo(buff);
				_queue = new List<int>(buff);
			}
			else {

				_isShuffle = true;
				ShuffleButton.BackColor = SystemColors.ControlDark;
				
				// shuffling

				n = _queue.Count;
				while (n > 1) {
					
					--n;
					k = _rnd.Next(n + 1);
					id = _queue[k];
					_queue[k] = _queue[n];
					_queue[n] = id;
				}
				if (!_isPause)
					Play();
			}

			// updating

			CurrentSong = Song.All[_queue[0]];
			QueueTable.Songs = _queue;
		}



		// Song timing bar handling

		private void _player_PlaybackStopped(object sender, EventArgs e) {

			Next();
		}

		private void TimeBarUpdateTimer_Tick(object sender, EventArgs e) {

			int		value;

			value = (int)_reader.CurrentTime.TotalMilliseconds;
			TimeBar.Value = (value > TimeBar.Maximum) ? TimeBar.Maximum : value;
			if (TimeBar.Value == TimeBar.Maximum)
				Next();
		}

		private void TimeBar_MouseDown(object sender, MouseEventArgs e) {

			if (!_isPause) {

				_player.Pause();
				TimeBarUpdateTimer.Stop();
			}
		}

		private void TimeBar_ValueChanged(object sender, EventArgs e) {

			// changing the location of the current time label to follow the cursor
			CurrentTimeLabel.Left = TimeBar.Location.X + (TimeBar.Width - 28) * TimeBar.Value / TimeBar.Maximum;

			// changing current time label
			CurrentTimeLabel.Text = TimeSpan.FromMilliseconds(TimeBar.Value).ToString(@"m\:ss");
		}

		private void TimeBar_MouseUp(object sender, MouseEventArgs e) {

			if (_reader == null) {

				_reader = new AudioFileReader(CurrentSong.Path);
				_player.Init(_reader);
			}

			// starting player from specified time
			_reader.Position = TimeBar.Value / 1000 * _player.OutputWaveFormat.AverageBytesPerSecond;

			if (!_isPause) {

				_player.Play();
				TimeBarUpdateTimer.Start();
			}
		}



		// Adding image to album

		private void ImageAddButton_Click(object sender, EventArgs e) {

			this.Enabled = false;
			if (CurrentSong.Album != null) {

				CurrentSong.Album.SetImage();
				AlbumCoverBox.Image = CurrentSong.Album.Image;
			}
			this.Enabled = true;
		}



		// Utils

		private void PlayerForm_EnabledChanged(object sender, EventArgs e) {

			// refreshing

			if (!Enabled)
				return ;

			SongTitleLabel.Text = CurrentSong.Title;
			AlbumTitleLabel.Text = (CurrentSong.Album != null) ? CurrentSong.Album.Title : "Unknown";
			AlbumYearLabel.Text = (CurrentSong.Year > 0) ? CurrentSong.Year.ToString() : String.Empty;
			ArtistNameLabel.Text = (CurrentSong.Artist != null) ? CurrentSong.Artist.Name : "Unknown";
			if (QueueTable != null)
				foreach (SongListRowControl row in QueueTable.Panel.Controls) {

					row.TitleLabel.Text = Song.All[row.SongID].Title;
					row.ArtistLabel.Text = (Song.All[row.SongID].Artist != null) ? Song.All[row.SongID].Artist.Name : "Unknown";
				}
		}

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            AddFoldersMessage.Visible = false;
            if (_source.Count == 0)
                AddFoldersMessage.Visible = true;
        }
    }
}
