using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace TB_Paint
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
			_Image.SetPixel(x, y, color);
		}
		public static Color GetPixel(int x, int y)
		{
			return _Image.GetPixel(x, y);
		}
		public static void Save(string path)
		{
			Bitmap bmp = new Bitmap(_Image.Width * Scale, _Image.Height * Scale);
			Console.WriteLine(Scale);
			for (int x = 0; x < bmp.Height; x++)
			{
				for (int y = 0; y < bmp.Width; y++)
				{
					bmp.SetPixel(x, y, _Image.GetPixel(x / Scale, y / Scale));
				}
			}
			Image tosave = bmp;
			tosave.Save(path, ImageFormat.Png);
		}
		public static void ImportImage(Bitmap bitmap)
		{
			_Image = bitmap;
		}
	}
}
