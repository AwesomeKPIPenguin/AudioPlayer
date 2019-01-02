using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer {

	public class Playlist : ImageContaining<Playlist> {

		public		String		Name;

		public		List<int>	Songs;



		static				Playlist() {
			
			_savePath = Base.ProjectPath + "saves/playlists/";
			_imageSavePath = Base.ProjectPath + "images/playlist";
		}

		public				Playlist() {
			
			ID = Base.Instance.PlaylistCount++;
			Songs = new List<int>();
		}

		public				Playlist(String name) { 
			
			Name = name;
		}



		public void			Add(int songID) {

			if (!Songs.Contains(songID))
				Songs.Add(songID);
		}
	}
}
