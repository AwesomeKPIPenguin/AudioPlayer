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

	public partial class FlowLayoutForm : Form {

		public FlowLayoutForm() {

			InitializeComponent();
		}

		private void ListPanel_Click(object sender, EventArgs e) {

			// refreshing

			foreach (PlaylistControl control in ListPanel.Controls)
				control.SetTitle();
		}
	}
}
