
using System;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

namespace AudioPlayer {
	
	public abstract class Storable<T> where T : Storable<T>, new() {

		static public		Dictionary<int, T>		All			{ get; }
		static protected	String					_savePath;

		public				int						ID;



		static				Storable() {
			
			All = new Dictionary<int, T>();
			_savePath = String.Empty;
		}



		public void Save() {

			XmlSerializer	ser;
			FileStream		fs;

			ser = new XmlSerializer(typeof(T));
			fs = new FileStream(_savePath + ID.ToString() + ".xml", FileMode.Create);
			ser.Serialize(fs, this);
			fs.Close();
		}

		static public void Load() {

			XmlSerializer	ser;
			DirectoryInfo	dir;
			FileInfo[]		files;
			FileStream		fs;
			T				item;

			item = new T();
			ser = new XmlSerializer(typeof(T));
			dir = new DirectoryInfo(_savePath);
			files = dir.GetFiles("*.xml");

			foreach (FileInfo file in files) {

				fs = new FileStream(file.FullName, FileMode.Open);
				item = (T)ser.Deserialize(fs);
				All.Add(item.ID, item);
				fs.Close();
			}
		}

		static private void Delete(FileInfo file) {

			file.Delete();
		}
	}
}
