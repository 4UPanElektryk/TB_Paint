using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Paint.Instructions
{
	public class InstSelect : Instruction
	{
		public InstSelect(string name) : base(name) { }
		public override void Start(string[] args)
		{
			if (args.Length == 4)
			{
                for (int i = 0; i < 4; i++)
                {
                    CurrentImage.SelectedArea[i] = int.Parse(args[i]);
                }
            }
			if (args.Length == 2)
			{
                for (int i = 0; i < 2; i++)
                {
                    CurrentImage.SelectedArea[i] = int.Parse(args[i]);
                }
                for (int i = 2; i < 4; i++)
                {
                    CurrentImage.SelectedArea[i] = int.Parse(args[i - 2]);
                }
            }
		}
	}
}
