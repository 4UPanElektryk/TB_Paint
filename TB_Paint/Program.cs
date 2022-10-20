using System;
using System.IO;

namespace TB_Paint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			new InstructionMenager();
			if (args.Length == 1)
			{
				foreach (string item in File.ReadLines(args[0]))
				{
					InstructionMenager.Run(item);
				}
			}
			else
			{
				foreach (string item in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory))
				{
					if (item.EndsWith(".inst"))
					{
						foreach (string lines in File.ReadLines(item))
						{
							InstructionMenager.Run(lines);
						}
					}
				}
			}
		}
	}
}
