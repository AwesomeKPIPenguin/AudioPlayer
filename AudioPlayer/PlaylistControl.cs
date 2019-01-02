using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AudioPlayer {

	public partial class PlaylistControl : UserControl {

		static private readonly		Image		ALBUM_IMG =
			Image.FromFile(Base.ProjectPath + "/images/vinil.png");
		static private readonly		Image		ARTIST_IMG =
			Image.FromFile(Base.ProjectPath + "/images/band.png");
		static private readonly		Image		PLAYLIST_IMG =
			Image.FromFile(Base.ProjectPath + "/images/playlist-big.png");
		static private readonly		Image		PLUS_IMG =
			Image.FromFile(Base.ProjectPath + "/images/plus.png");



		private						Album		_album;
		private						Artist		_artist;
		private						Playlist	_playlist;
		private						bool		_isEmpty;

		public						Album		Album {
			
			get { return(_album); }
			set {

				if (_isEmpty) {

					ToEmpty();
					return ;
				}
				if (value == null)
					return ;
				_album = value;
				_artist = null;
				_playlist = null;
				ImageBox.BackgroundImage = ALBUM_IMG;
				if (value.Image == null && value.ImagePath != null) {
					try {
						value.Image = Image.FromFile(value.ImagePath);
					}
					catch (Exception) { }
				}
				ImageBox.Image = value.Image;
				TitleLabel.Text = value.Title;
			}
		}

		public						Artist		Artist {
			
			get { return(_artist); }
			set {

				if (_isEmpty) {

					ToEmpty();
					return ;
				}
				if (value == null)
					return ;
				_album = null;
				_artist = value;
				_playlist = null;
				ImageBox.BackgroundImage = ARTIST_IMG;
				if (value.Image == null && value.ImagePath != null)
					value.Image = Image.FromFile(value.ImagePath);
				ImageBox.Image = value.Image;
				TitleLabel.Text = value.Name;
			}
		}

		public						Playlist	Playlist {
			
			get { return(_playlist); }
			set {

				if (_isEmpty) {

					ToEmpty();
					return ;
				}
				if (value == null)
					return ;
				_album = null;
				_artist = null;
				_playlist = value;
				ImageBox.BackgroundImage = PLAYLIST_IMG;
				if (value.Image == null && value.ImagePath != null)
					value.Image = Image.FromFile(value.ImagePath);
				ImageBox.Image = value.Image;
				TitleLabel.Text = value.Name;
			}
		}



		private						PlaylistControl() {

			InitializeComponent();
		}

		public						PlaylistControl(Album album, bool isEmpty) : this() {
			
			_isEmpty = isEmpty;
			Album = album;
		}

		public						PlaylistControl(Artist artist, bool isEmpty) : this() {
			
			_isEmpty = isEmpty;
			Artist = artist;
		}

		public						PlaylistControl(Playlist playlist, bool isEmpty) : this() {
			
			_isEmpty = isEmpty;
			Playlist = playlist;
		}



		public void ToEmpty() {

			TitleLabel.Dispose();
			PlayButton.Dispose();
			EditButton.Dispose();
			ContentButton.Dispose();
			ImageBox.Dispose();
			ImageAddButton.Dispose();
			BackgroundImage = PLUS_IMG;
			BackgroundImageLayout = ImageLayout.Center;
			BorderStyle = BorderStyle.FixedSingle;

			Click += EmptyPlaylistControl_Click;
			MouseDown += EmptyPlaylistControl_MouseDown;
			MouseUp += EmptyPlaylistControl_MouseUp;
		}

		public void SetTitle() {

			if (_album != null)
				TitleLabel.Text = _album.Title;
			else if (_artist != null)
				TitleLabel.Text = _artist.Name;
			else if (_playlist != null)
				TitleLabel.Text = _playlist.Name;
		}

		private void ContentButton_Click(object sender, EventArgs e) {

			PlaylistControl		control;

			if (_album != null) {

				SongsForm	contentForm;

				contentForm = new SongsForm(_album);
				
				contentForm.Show();
			}
			else if (_artist != null) {

				FlowLayoutForm	contentForm;

				contentForm = new FlowLayoutForm();

				foreach (int albumID in _artist.Albums) {

					control = new PlaylistControl(Album.All[albumID], false) {

						Margin = new Padding(35)
					};
					contentForm.ListPanel.Controls.Add(control);
				}
				contentForm.Show();
			}
			else if (_playlist != null) {
				
				SongsForm	contentForm;

				contentForm = new SongsForm(_playlist);
				
				contentForm.Show();
			}
		}

		private void ImageAddButton_Click(object sender, EventArgs e) {

			if (_album != null)
				_album.SetImage();
			else if (_artist != null)
				_artist.SetImage();
			else if (_playlist != null)
				_playlist.SetImage();

			foreach (Form form in Application.OpenForms)
				form.Enabled = true;
		}

		private void PlayButton_Click(object sender, EventArgs e) {

			PlayerForm.Form.Pause();
			if (_album != null) {

				PlayerForm.Form.Source = _album.Songs;
			}
			else if (_artist != null) {

				List<int>	songs;

				songs = new List<int>();
				foreach (int id in _artist.Albums)
					songs.AddRange(Album.All[id].Songs);
				PlayerForm.Form.Source = songs;
			}
			else {

				PlayerForm.Form.Source = _playlist.Songs;
			}
			PlayerForm.Form.Play();
		}

		private void EditButton_Click(object sender, EventArgs e) {

			foreach (Form form in Application.OpenForms)
				form.Enabled = false;
			Enabled = true;

			if (_album != null) {

				AlbumEditForm editForm = new AlbumEditForm(_album.ID);
				editForm.Show();
			}
			else if (_artist != null) {
			
				ArtistEditForm editForm = new ArtistEditForm(_artist.ID);
				editForm.Show();
			}
			else {

				PlaylistEditForm editForm = new PlaylistEditForm(_playlist.ID);
				editForm.Show();
			}
		}



		private void EmptyPlaylistControl_MouseUp(object sender, MouseEventArgs e) {
		
			BackColor = SystemColors.ControlDark;
		}

		private void EmptyPlaylistControl_MouseDown(object sender, MouseEventArgs e) {

			BackColor = SystemColors.ControlDarkDark;
		}

		private void EmptyPlaylistControl_Click(object sender, EventArgs e) {
			
			PlaylistEditForm	editForm;

			editForm = new PlaylistEditForm(-1);
			foreach (Form form in Application.OpenForms)
				form.Enabled = false;
			editForm.Show();
		}

		private void PlaylistControl_EnabledChanged(object sender, EventArgs e) {

			// refreshing

			if (!Enabled)
				return;
			SetTitle();
		}
	}
}
