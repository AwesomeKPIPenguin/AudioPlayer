
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace AudioPlayer {

	// class for storing useful static variables and counters for other classes' instances' IDs
	//
	// completely unsafe class (in terms of accessability) due to need of serialization

	[XmlRoot("Base")]
	public class Base {

		static public String	ProjectPath { get; }



		public static Base		Instance;

		public int				SongCount;
		public int				AlbumCount;
		public int				ArtistCount;
		public int				PlaylistCount;


		
		static					Base() {

			ProjectPath = "C:/Users/domelche/OneDrive/Projects/C#/3 - 1/AudioPlayer/";
            Directory.CreateDirectory(ProjectPath + "saves/songs");
            Directory.CreateDirectory(ProjectPath + "saves/albums");
            Directory.CreateDirectory(ProjectPath + "saves/artists");
            Directory.CreateDirectory(ProjectPath + "saves/playlists");
            Directory.CreateDirectory(ProjectPath + "saves/counters");
        }

		public					Base() {

			SongCount = 0;
			AlbumCount = 0;
			ArtistCount = 0;
			PlaylistCount = 0;
		}



		public static void		Save() {

			XmlSerializer	ser;
			FileStream		fs;

			ser = new XmlSerializer(typeof(Base));
			fs = new FileStream(ProjectPath + "saves/counters/base.xml", FileMode.Create);
			ser.Serialize(fs, Instance);
			fs.Close();
		}

		public static void		Load() {

			XmlSerializer	ser;
			FileStream		fs;

			ser = new XmlSerializer(typeof(Base));
			try {
				fs = new FileStream(ProjectPath + "saves/counters/base.xml", FileMode.Open);
			}
			catch (Exception) {
				Instance = null;
				return;
			}
			Instance = (Base)ser.Deserialize(fs);
			fs.Close();
		}
	}
}
