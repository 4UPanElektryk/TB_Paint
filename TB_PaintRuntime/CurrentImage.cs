using System;
using System.Drawing;

namespace TB_Paint.Rutime
{
	public class CurrentImage
	{
		static private Bitmap _Image;
		static public int[] SelectedArea = new int[4];
		static public int Scale = 1;
		public static void New(int height, int width)
		{
			_Image = new Bitmap(width, height);
		}
		public static void SetPixel(int x, int y, Color color)
		{
			if (_Image != null)
			{
                _Image.SetPixel(x, y, color);
            }
			else
			{
                throw new NotImplementedException("Image is null");
            }
		}
		public static Color GetPixel(int x, int y)
		{
			if (_Image != null)
			{
                return _Image.GetPixel(x, y);
            }
			throw new NotImplementedException("Image is null");
		}
		public static void Save(string path)
		{
			if (_Image == null)
			{
				throw new NotImplementedException("Image is null");
			}
			Image tosave = _Image;
			if (Scale > 1)
			{
				Bitmap bmp = new Bitmap(_Image.Width * Scale, _Image.Height * Scale);
				for (int x = 0; x < bmp.Height; x++)
				{
					for (int y = 0; y < bmp.Width; y++)
					{
						bmp.SetPixel(x, y, _Image.GetPixel(x / Scale, y / Scale));
					}
				}
				tosave = bmp;
				Console.WriteLine("Done.");
			}
			
			tosave.Save(path);
		}
		public static void ImportImage(Bitmap bitmap)
		{
			_Image = bitmap;
		}
        public static Bitmap ExportImage()
        {
            return _Image;
        }
    }
}
