using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TB_Paint.Compactor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (!File.Exists("TB_Paint.exe"))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine();
				Console.ResetColor();
				return;
			}
			new Compactor();
			int i = 0;
			bool founderrors = false;
			foreach (string line in File.ReadAllLines(args[0]))
			{
				try
				{
					Compactor.Run(line);
				}
				catch
				{
					founderrors = true;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Line Compactor Error:");
					Console.WriteLine("Invalid Syntax! Line: " + i);
					Console.WriteLine(line);
					Console.ResetColor();
					break;
				}
				i++;
			}
			if (founderrors)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Found errors while compacting.");
                Console.WriteLine("Depending on severity, those instructions may not run.");
				Console.ResetColor();
            }
			Compactor.Export(args[1]);
		}
	}
}
