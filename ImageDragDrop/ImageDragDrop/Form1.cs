using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ImageDragDrop
{
	public partial class Form1 : Form
	{
		protected bool validData;
        string path;
        protected Image image;
		protected Thread getImageThread;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			string filename;
			validData = GetFilename(out filename, e);
			if (validData)
			{
				path = filename;
				getImageThread = new Thread(new ThreadStart(LoadImage));
				getImageThread.Start();
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private bool GetFilename(out string filename, DragEventArgs e)
		{
			bool ret = false;
			filename = String.Empty;
			if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
			{
				Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
				if (data != null)
				{
					if ((data.Length == 1) && (data.GetValue(0) is String))
					{
						filename = ((string[])data)[0];
						string ext = Path.GetExtension(filename).ToLower();
						if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
						{
							ret = true;
						}
					}
				}
			}
			return ret;
		}


		protected void LoadImage()
		{
			image = new Bitmap(path);
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			if (validData)
			{
				while (getImageThread.IsAlive)
				{
					Application.DoEvents();
					Thread.Sleep(0);
				}
				pictureBox1.Image = image;
			}
		}
	}
}
