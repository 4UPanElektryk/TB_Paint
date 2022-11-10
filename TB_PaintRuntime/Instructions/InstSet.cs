using System.Drawing;

namespace TB_Paint.Rutime.Instructions
{
	public class InstSet : Instruction
	{
		public InstSet() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				int[] sel = CurrentImage.SelectedArea;
				Color color = ColorTranslator.FromHtml(args[0]);
				for (int x = sel[0]; x <= sel[2]; x++)
				{
					for (int y = sel[1]; y <= sel[3]; y++)
					{
						CurrentImage.SetPixel(x, y, color);
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
