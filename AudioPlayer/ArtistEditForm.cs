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

	public partial class ArtistEditForm : Form {

		private	Artist	_artist;



		public	ArtistEditForm() {

			InitializeComponent();
		}

		public	ArtistEditForm(int id) : this() {

			_artist = Artist.All[id];
			NameTextBox.Text = _artist.Name;
		}



		private void ImageAddButton_Click(object sender, EventArgs e) {

			this.Enabled = false;
			_artist.SetImage();
			ArtistCoverBox.Image = _artist.Image;
			this.Enabled = true;
		}

		private void EditButton_Click(object sender, EventArgs e) {

			_artist.Name = NameTextBox.Text;
			_artist.Save();

			CloseButton_Click(null, null);
		}

		private void CloseButton_Click(object sender, EventArgs e) {

			foreach (Form form in Application.OpenForms)
				form.Enabled = true;
			Close();
		}
	}
}
