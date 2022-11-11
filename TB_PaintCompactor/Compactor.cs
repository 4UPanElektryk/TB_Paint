using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Drawing;
using TB_Paint.Instructions;
using System;

namespace TB_Paint.Compactor
{
	public class Compactor
	{
		public static string FinalString = "";
		public Compactor()
		{
            InstructionMenager._Instructions = new List<Instruction>
            {
                new InstNew("new"),
                new InstSelect("sel"),
                new InstSet("set"),
                new InstReplace("rep"),
                new InstLoad("load"),
                new InstSave("save"),
                new InstScale("scl"),
            };
        }

		public static void Run(string text)
		{
			string[] args = text.Split(' ');
			foreach (Instruction item in InstructionMenager._Instructions)
			{
				if (item.Name == args[0].ToLower())
				{
                    int index = InstructionMenager._Instructions.FindIndex(x => x.Name == args[0].ToLower());
                    FinalString += index + ":" + string.Join(",", args.Skip(1).ToArray()) + ";";
					return;
				}
			}
			throw new NotImplementedException("Instruction Not Found");
		}
		public static void Export(string path)
		{
			File.WriteAllText(path, FinalString);
		}
	}
}
