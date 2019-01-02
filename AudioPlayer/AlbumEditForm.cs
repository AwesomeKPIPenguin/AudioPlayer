using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer {

	public partial class AlbumEditForm : Form {

		private	Album	_album;



		public AlbumEditForm() {

			InitializeComponent();
		}

		public AlbumEditForm(int albumID) : this() {

			List<Artist>	artists;
			List<Song>		songs;

			_album = Album.All[albumID];

			AlbumCoverBox.Image = _album.Image;

			TitleTextBox.Text = _album.Title;

			artists = new List<Artist>(Artist.All.Values);
			ArtistComboBox.DataSource = artists;

			if (_album.Artist != null) {

				ArtistComboBox.SelectedItem = _album.Artist;

				songs = new List<Song>();
				foreach (Song song in Song.All.Values)
					if (song.Artist.ID == _album.Artist.ID)
						songs.Add(song);
				SongsListBox.DataSource = songs;
				for (int i = 0; i < SongsListBox.Items.Count; ++i)
					if (((Song)SongsListBox.Items[i]).Album != null &&
						((Song)SongsListBox.Items[i]).Album.ID == _album.ID)
						SongsListBox.SetItemChecked(i, true);
			}

			YearNumeric.Value = _album.Year;
		}



		private void ImageAddButton_Click(object sender, EventArgs e) {

			this.Enabled = false;
			_album.SetImage();
			AlbumCoverBox.Image = _album.Image;
			this.Enabled = true;
		}
		
		private void EditButton_Click(object sender, EventArgs e) {

			_album.Title = TitleTextBox.Text;
			
			if (_album.Artist == null) {

				_album.Artist = (Artist)ArtistComboBox.SelectedValue;
				_album.Artist.Albums.Add(_album.ID);
				_album.Artist.Save();
			}
			else if (_album.Artist.ID != ((Artist)ArtistComboBox.SelectedValue).ID) {
				
				_album.Artist.Albums.Remove(_album.ID);
				_album.Artist.Save();
				_album.Artist = (Artist)ArtistComboBox.SelectedValue;
				_album.Artist.Albums.Add(_album.ID);
				_album.Artist.Save();
			}

			for (int i = 0; i < SongsListBox.Items.Count; ++i) {

				Song	song;

				song = (Song)SongsListBox.Items[i];

				if (SongsListBox.GetItemChecked(i)) {

					if (!_album.Songs.Contains(song.ID)) {
						
						if (song.Album != null)
							song.Album.Songs.Remove(song.ID);
						else if (song.Artist != null)
							song.Artist.Singles.Remove(song.ID);
						song.Album.Save();
						song.Artist.Save();

						_album.Songs.Add(song.ID);
						song.Album = _album;
						song.Save();
					}
				}
				else {

					if (_album.Songs.Contains(song.ID)) {
						
						_album.Songs.Remove(song.ID);
						song.Album = null;
						song.Save();
					}
				}
			}

			_album.Save();

			CloseButton_Click(null, null);
		}

		private void CloseButton_Click(object sender, EventArgs e) {
			
			foreach (Form form in Application.OpenForms)
				form.Enabled = true;
			Close();
		}
	}
}
