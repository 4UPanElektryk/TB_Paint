using System;
using System.Drawing;

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
            Console.WriteLine("Width: " + _Image.Width);
            Console.WriteLine("Heiht: " + _Image.Height);
			Console.WriteLine("Scale: " + Scale);
            Console.WriteLine("Scaled Width: " + _Image.Width * Scale);
            Console.WriteLine("Scaled Heiht: " + _Image.Height * Scale);
            Image tosave = _Image;
			if (Scale > 1)
			{
				Console.WriteLine("Rescaliing...");
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
	}
}
