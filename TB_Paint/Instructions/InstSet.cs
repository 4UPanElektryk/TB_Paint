using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TB_Paint.Instructions
{
	public class InstSet : Instruction
	{
		public InstSet(string name) : base(name) { }
		public override void Start(string[] args)
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
		}
	}
}
