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

	public partial class SongsForm : Form {

		public SongsForm() {

			InitializeComponent();

			SongList.Panel.Size = this.Size;
		}

		public SongsForm(List<int> songs) : this() {

			SongList.Songs = songs;
		}

		public SongsForm(Album album) : this() {

			SongList.Songs = album.Songs;
		}

		public SongsForm(Playlist playlist) : this() {

			SongList.Songs = playlist.Songs;
		}
	}
}
