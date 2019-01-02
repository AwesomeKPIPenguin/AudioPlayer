using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AudioPlayer {

	public class ImageContaining<T> : Storable<T> where T : ImageContaining<T>, new() {

		static protected	String	_imageSavePath;

		public				String	ImagePath;

		[XmlIgnore]
		public				Image	Image;



		public void SetImage() {

			OpenFileDialog	dialog;
			String			newPath;

			dialog = new OpenFileDialog {

				Filter = "Pick image (*.png, *.jpg) | *.png; *.jpg"
			};

			if (dialog.ShowDialog() == DialogResult.OK) {

				newPath = _imageSavePath + "-" + ID + Path.GetExtension(dialog.FileName);
				if (Image != null)
					Image.Dispose();
				File.Copy(dialog.FileName, newPath, true);
				ImagePath = newPath;
				Image = Image.FromFile(newPath);
				Save();
			}
		}



		static public new void Load() {

			Storable<T>.Load();

			foreach (T obj in All.Values) {

				if (obj.ImagePath != null && File.Exists(obj.ImagePath)) {

					obj.Image = Image.FromFile(obj.ImagePath);
				}
				else {

					obj.ImagePath = null;
					obj.Save();
				}
			}
		}
	}
}
