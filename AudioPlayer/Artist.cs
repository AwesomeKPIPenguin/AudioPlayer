
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer {
	
	public class Artist : ImageContaining<Artist> {
	
		public		String			Name;

		public		List<int>		Albums;
		public		List<int>		Singles;



		static		Artist() {
			
			_savePath = Base.ProjectPath + "saves/artists/";
			_imageSavePath = Base.ProjectPath + "images/covers/artist";
		}
		
		public		Artist() { }
		
		public		Artist(String name) {

			ID = Base.Instance.ArtistCount++;
			Name = name;
			Albums = new List<int>();
			Singles = new List<int>();

			All.Add(ID, this);
		}



		public void UniqueAddSingle(Song single) {

			foreach (int id in Singles)
				if (Song.All[id].Title.Equals(
					single.Title, StringComparison.OrdinalIgnoreCase))
					return ;
			Singles.Add(single.ID);
		}

		static public Artist GetArtist(Song song, String name) {

			// finding artist with selected name or creating a new one

			Artist	artist;

			if (name.Equals(String.Empty))
				name = "Unknown Artist";
			artist = (new List<Artist>(All.Values)
				.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase)));
			if (artist == null) {

				artist = new Artist(name);
				if (song.Album == null)
					artist.UniqueAddSingle(song);
				artist.Save();
			}

			return (artist);
		}



		public override string ToString() => Name;
	}
}
