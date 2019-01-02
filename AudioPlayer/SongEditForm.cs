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

	public partial class SongEditForm : Form {

		private		Song	_song;



		public SongEditForm() {

			InitializeComponent();
		}

		public SongEditForm(int songID) : this() {

			List<Artist>	artists;
			List<Album>		albums;

			_song = Song.All[songID];

			TitleTextBox.Text = _song.Title;

			artists = new List<Artist>(Artist.All.Values);
			ArtistComboBox.DataSource = artists;

			if (_song.Artist != null) {

				ArtistComboBox.SelectedItem = _song.Artist;
				
				albums = new List<Album>(_song.Artist.Albums.Count);
				foreach (int id in _song.Artist.Albums)
					albums.Add(Album.All[id]);

				AlbumComboBox.DataSource = albums;
				if (_song.Album != null)
					AlbumComboBox.SelectedItem = _song.Album;
				else
					AlbumComboBox.SelectedIndex = -1;
			}

			YearNumeric.Value = _song.Year;

			CommentTextBox.Text = _song.Comment;
		}



		private void ArtistComboBox_SelectedValueChanged(object sender, EventArgs e) {

			Artist			artist;
			List<Album>		albums;

			artist = (Artist)ArtistComboBox.SelectedValue;
			albums = new List<Album>(artist.Albums.Count);
			foreach (int id in artist.Albums)
				albums.Add(Album.All[id]);

			AlbumComboBox.DataSource = albums;
			AlbumComboBox.SelectedIndex = 0;
		}



		private void EditButton_Click(object sender, EventArgs e) {

			_song.Title = TitleTextBox.Text;

			if (_song.Artist != null && _song.Artist.ID != ((Artist)ArtistComboBox.SelectedValue).ID) {
				
				_song.Artist.Singles.Remove(_song.ID);
				_song.Artist.Save();
			}
			_song.Artist = (Artist)ArtistComboBox.SelectedValue;

			if (_song.Album == null) {

				_song.Album = (Album)AlbumComboBox.SelectedValue;
				_song.Album.Songs.Add(_song.ID);
				_song.Album.Save();
			}
			else if (_song.Album.ID != ((Album)AlbumComboBox.SelectedValue).ID) {
				
				_song.Album.Songs.Remove(_song.ID);
				_song.Album.Save();
				_song.Album = (Album)AlbumComboBox.SelectedValue;
				_song.Album.Songs.Add(_song.ID);
				_song.Album.Save();
			}

			_song.Year = (int)YearNumeric.Value;

			_song.Comment = CommentTextBox.Text;

			_song.Save();
			
			CloseButton_Click(null, null);
		}

		private void CloseButton_Click(object sender, EventArgs e) {

			foreach (Form form in Application.OpenForms)
				form.Enabled = true;
			Close();
		}
	}
}
