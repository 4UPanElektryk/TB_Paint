using System;
using System.IO;

namespace TB_Paint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			InstructionMenager.Initialize();
			if (args.Length == 1)
			{
				if (args[0].EndsWith(".inst"))
				{
                    int i = 0;
                    foreach (string line in File.ReadLines(args[0]))
                    {
                        if (!line.StartsWith("//") && line != "")
                        {
                            if (!InstructionMenager.Run(line))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Line Run Error:");
                                Console.WriteLine("File: " + args[0]);
                                Console.WriteLine("Line: " + i);
                                Console.WriteLine(line);
                                Console.ResetColor();
                            }
                        }
                        i++;
                    }
                }
				else if (args[0].EndsWith(".cins"))
                {
					InstructionMenager.RunCins(File.ReadAllText(args[0]));
                }
				else
				{
					Console.WriteLine("Incorrect Instruction File");
				}
			}
			else
			{
				foreach (string item in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory))
				{
					if (item.EndsWith(".inst"))
					{
						int i = 0;
						foreach (string line in File.ReadLines(item))
						{
							if (!line.StartsWith("//") && line != "")
							{
								if (!InstructionMenager.Run(line))
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine("Line Run Error:");
									Console.WriteLine("File: " + item);
									Console.WriteLine("Line: " + i);
									Console.WriteLine(line);
									Console.ResetColor();
								}
							}
							i++;
						}
					}
				}
			}
		}
	}
}
