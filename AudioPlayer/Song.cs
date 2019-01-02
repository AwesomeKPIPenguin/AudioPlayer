
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using NAudio.Wave;

namespace AudioPlayer {

	[XmlRoot("Song")]
	public class Song : Storable<Song> {

		public int					_artist;
		public int					_album;
		public long					_duration; // in seconds

		public String				Title;
		public String				Path;
		public int					Year;
		public String				Comment;

		[XmlIgnore]
		public TimeSpan				Duration {

			get { return (new TimeSpan(_duration * 10000000)); } // to ticks
			set { _duration = (long)Math.Round(value.TotalSeconds); }
		}

		[XmlIgnore]
		public Album				Album {

			get { return ((_album == -1) ? null : Album.All[_album]); }
			set { _album = (value == null) ? -1 : value.ID; }
		}

		[XmlIgnore]
		public Artist				Artist {

			get { return ((_artist == -1) ? null : Artist.All[_artist]); }
			set { _artist = (value == null) ? -1 : value.ID; }
		}

			

		static						Song() { _savePath = Base.ProjectPath + "saves/songs/"; }

		public						Song() {
		
			_album = -1;
			_artist = -1;
		}

		public						Song(String path) : this() {
			
			ID = Base.Instance.SongCount++;
			Path = path;

			All.Add(this.ID, this);
		}



		static public void ProcessSongsDirectory(String path) {

			// finding and processing all mp3 files in directory (recursively)

			String[]		songs;
			ProcessForm		pForm;

			songs = Directory.GetFiles(path, "*.mp3", SearchOption.AllDirectories);

			pForm = new ProcessForm();
			pForm.Text = "Processing...";
			pForm.TotalCountLabel.Text = "/ " + songs.Length;
			pForm.ProgressBar.Maximum = songs.Length;
			pForm.Show();
			pForm.TextLabel.Refresh();
			pForm.TextLabel.Show();
			pForm.TotalCountLabel.Refresh();
			pForm.TotalCountLabel.Show();
			pForm.ProcessedCountLabel.Refresh();
			pForm.ProcessedCountLabel.Show();
			pForm.ProgressBar.Show();

			for (int i = 0; i < songs.Length; ++i) {
				
				ProcessSong(songs[i]);
				pForm.ProcessedCountLabel.Text = i.ToString();
				pForm.ProgressBar.Value = i;
				pForm.ProcessedCountLabel.Refresh();
				pForm.ProgressBar.Refresh();
			}

			pForm.Dispose();
		}

		static private void ProcessSong(String path) {

			// creating Song instance from mp3 file

			Song			song;
			byte[]			buff;
			FileStream		fs;
			Mp3FileReader	fr;
			String			artist;

			song = new Song(path);
			buff = new byte[128];
			fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			fr = new Mp3FileReader(path);
			song.Duration = fr.TotalTime;

			fs.Seek(-128, SeekOrigin.End);
			fs.Read(buff, 0, 128);

			if (Extract(buff, 0, 3).CompareTo("TAG") == 0) {
				
				song.Title = Extract(buff, 3, 30);
				artist = Extract(buff, 33, 30);
				Album.GetAlbum(song, Extract(buff, 63, 30), artist);
				if (song.Album != null)
					song.Artist = song.Album.Artist;
				else
					song.Artist = Artist.GetArtist(song, artist);
				try { song.Year = int.Parse(Extract(buff, 93, 4)); }
				catch (Exception) { song.Year = 0; }
				song.Comment = Extract(buff, 97, 30);

				if (song.IsDuplicate()) {

					All.Remove(song.ID);
					--(Base.Instance.SongCount);
					fs.Close();
					fr.Close();
					return ;
				}

				song.Save();
				Base.Save();
				fs.Close();
				fr.Close();
			}
		}

		private bool IsDuplicate() => (new List<Song>(All.Values))
			.Find(s => s.ID != this.ID &&
					   s.Title.Equals(this.Title, StringComparison.OrdinalIgnoreCase) &&
					   s.Artist.Name.Equals(this.Artist.Name, StringComparison.OrdinalIgnoreCase)) != null;

		private static String Extract(byte[] buff, int start, int length) {
			
			String	res;
			int		len;

			res = Encoding.Default.GetString(buff, start, length);
			len = res.IndexOf('\0');
			return (res.Substring(0, (len == -1) ? length : len));
		}

		public void Delete() {

			if (Album != null) {

				Album.Songs.Remove(ID);
				Album.Save();
			}
			if (Artist != null) {

				Artist.Singles.Remove(ID);
				Artist.Save();
			}
			foreach (Playlist playlist in Playlist.All.Values) {

				playlist.Songs.Remove(ID);
				playlist.Save();
			}
			All.Remove(ID);
			(new FileInfo(_savePath + ID.ToString() + ".xml")).Delete();

			if (PlayerForm.Form.QueueTable != null)
				PlayerForm.Form.QueueTable.Refresh();
		}

		static public void CheckPathes() {

			List<int>	toDelete;

			toDelete = new List<int>();
			foreach (Song song in All.Values)
				if (!File.Exists(song.Path))
					toDelete.Add(song.ID);
			foreach (int id in toDelete)
				All[id].Delete();
		}



		public override string ToString() => Title;
	}
}
