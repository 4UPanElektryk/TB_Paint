using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TB_Paint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			new InstructionMenager();
			foreach (string item in File.ReadLines(args[0]))
			{
				InstructionMenager.Run(item);
			}
		}
	}
}
