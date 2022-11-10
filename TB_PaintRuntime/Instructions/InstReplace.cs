using System.Drawing;

namespace TB_Paint.Rutime.Instructions
{
	public class InstReplace : Instruction
	{
		public InstReplace() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				int[] sel = CurrentImage.SelectedArea;
				Color ToColor = ColorTranslator.FromHtml(args[1]);
				Color FromColor = ColorTranslator.FromHtml(args[0]);
				for (int x = sel[0]; x <= sel[2]; x++)
				{
					for (int y = sel[1]; y <= sel[3]; y++)
					{
						if (CurrentImage.GetPixel(x, y) == FromColor)
						{
							CurrentImage.SetPixel(x, y, ToColor);
						}
					}
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
