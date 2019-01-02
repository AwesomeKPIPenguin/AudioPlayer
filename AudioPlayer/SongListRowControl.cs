using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer {

	public partial class SongListRowControl : UserControl {

		private	bool	_isSelected;

		public	int		SongID;
		public	bool	IsSelected {

			get { return (_isSelected); }
			set {
				_isSelected = value;
				BackColor = (value) ? SystemColors.ControlDarkDark : SystemColors.ControlDark;
			}
		}



		public	SongListRowControl() {
			
			InitializeComponent();
		}

		public	SongListRowControl(int songID) {

			Song	song;

			InitializeComponent();

			SongID = songID;
			song = Song.All[songID];
			TitleLabel.Text = song.Title;
			ArtistLabel.Text = song.Artist.Name;
			TimeLabel.Text = song.Duration.ToString(@"m\:ss");
		}



		private void PlayButton_Click(object sender, EventArgs e) {

			PlayerForm.Form.CurrentSong = Song.All[SongID];
			PlayerForm.Form.Play();
		}

		private void EditButton_Click(object sender, EventArgs e) {

			SongEditForm	editForm;

			editForm = new SongEditForm(SongID);
			editForm.Show();

			foreach (Form form in Application.OpenForms)
				form.Enabled = false;
			editForm.Enabled = true;
		}

		private void DeleteButton_Click(object sender, EventArgs e) {

			DialogResult	res;

			res = MessageBox.Show(
				"Are you sure you want to delete this song? MP3 file won`t be removed",
				"Delete song",
				MessageBoxButtons.YesNo
			);

			if (res == DialogResult.Yes)
				Song.All[SongID].Delete();
		}
	}
}
