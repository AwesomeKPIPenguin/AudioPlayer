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

	public partial class PlaylistEditForm : Form {
		
		private	Playlist	_playlist;
		private	bool		_isNew;



		public PlaylistEditForm() {

			InitializeComponent();
		}

		public PlaylistEditForm(int id) : this() {

			if (id == -1) {
				
				_isNew = true;
				_playlist = new Playlist();
				Text = "Create Playlist";
				EditButton.Text = "Create";
			}
			else {

				_isNew = false;
				_playlist = Playlist.All[id];
			}

			PlaylistCoverBox.Image = _playlist.Image;

			NameTextBox.Text = _playlist.Name;

			SongsListBox.DataSource = new List<Song>(Song.All.Values);
			for (int i = 0; i < SongsListBox.Items.Count; ++i)
				if (_playlist.Songs.Contains(((Song)SongsListBox.Items[i]).ID))
					SongsListBox.SetItemChecked(i, true);
		}



		private void ImageAddButton_Click(object sender, EventArgs e) {

			this.Enabled = false;
			_playlist.SetImage();
			PlaylistCoverBox.Image = _playlist.Image;
			this.Enabled = true;
		}
		
		private void EditButton_Click(object sender, EventArgs e) {
			
			_playlist.Name = NameTextBox.Text;

			for (int i = 0; i < SongsListBox.Items.Count; ++i) {

				Song	song;

				song = (Song)SongsListBox.Items[i];

				if (SongsListBox.GetItemChecked(i)) {

					if (!_playlist.Songs.Contains(song.ID))
						_playlist.Songs.Add(song.ID);
				}
				else {

					if (_playlist.Songs.Contains(song.ID))
						_playlist.Songs.Remove(song.ID);
				}
			}

			if (_isNew)
				Playlist.All.Add(_playlist.ID, _playlist);
			_playlist.Save();

			Close();
		}

		private void CloseButton_Click(object sender, EventArgs e) {

			Close();
		}

		private void PlaylistEditForm_FormClosed(object sender, FormClosedEventArgs e) {

			foreach (Form form in Application.OpenForms) {
				
				form.Enabled = true;
				form.BringToFront();
			}
		}
	}
}
