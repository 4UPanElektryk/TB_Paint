using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Paint.Instructions
{
	public class InstReplace : Instruction
	{
		public InstReplace(string name) : base(name) { }
		public override void Start(string[] args)
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
		}
	}
}
