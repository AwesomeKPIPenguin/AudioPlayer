
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace AudioPlayer {

	[XmlRoot("Album")]
	public class Album : ImageContaining<Album> {

		public		int				_artist;

		public		String			Title;
		public		int				Year;

		[XmlArray("Songs"), XmlArrayItem(typeof(int), ElementName = "Song")]
		public		List<int>		Songs;

		[XmlIgnore]
		public		Artist			Artist {

			get { return ((_artist == -1) ? null : Artist.All[_artist]); }
			set { _artist = (value == null) ? -1 : value.ID; }
		}




		static		Album() {
			
			_savePath = Base.ProjectPath + "saves/albums/";
			_imageSavePath = Base.ProjectPath + "images/covers/album";
		}

		public		Album() {
			
			_artist = -1;	
		}
		
		public		Album(String title, Artist artist, int year) : this() {
			
			ID = Base.Instance.AlbumCount++;
			Title = title;
			Artist = artist;
			Year = year;
			Songs = new List<int>();

			All.Add(ID, this);
		}



		public bool UniqueAddSong(Song song) {

			foreach (int id in Songs)
				if (Song.All[id].Title.Equals(
					song.Title, StringComparison.OrdinalIgnoreCase))
					return (false);
			Songs.Add(song.ID);
			return (true);
		}

		static public void			GetAlbum(Song song, String albumTitle, String artistName) {

			// finding album with such name and artist or create new with these params
			// if album title is empty string, song considered as single

			Album	album;

			if (albumTitle.Equals(String.Empty))
				return ;
			album = (new List<Album>(All.Values))
				.Find(a => a.Title.Equals(albumTitle, StringComparison.OrdinalIgnoreCase) &&
						   a.Artist.Name.Equals(artistName, StringComparison.OrdinalIgnoreCase));
			song.Album = album;
			if (album == null) {

				album = new Album(albumTitle, null, song.Year);
				song.Album = album;
				album.Artist = Artist.GetArtist(song, artistName);
				album.Artist.Albums.Add(album.ID);
				album.Artist.Save();
			}
			if (album.UniqueAddSong(song))
				album.Save();
		}



		public override string ToString() => Title;
	}
}
