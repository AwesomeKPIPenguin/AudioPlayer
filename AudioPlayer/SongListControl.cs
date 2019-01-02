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

	public partial class SongListControl : UserControl {

		private		ICollection<int>		_songs;

		public		ICollection<int>		Songs			{

			get { return (_songs); }
			set {
				_songs = value;
				Panel.Controls.Clear();
				if (value != null)
					foreach (int id in value)
						Panel.Controls.Add(new SongListRowControl(id));
			}
		}
		public		SongListRowControl		SelectedRow;



		public		SongListControl() {

			InitializeComponent();
		}



		private void SongListControl_SizeChanged(object sender, EventArgs e) {

			Panel.Size = this.Size;
		}

		private void Panel_Click(object sender, EventArgs e) {

			if (SelectedRow.IsSelected)
				return ;

			foreach (SongListRowControl row in Panel.Controls) {

				if (row.IsSelected) {

					SelectedRow = row;
					break ;
				}
			}
		}
	}
}
