using System;
using System.Collections.Generic;
using System.Linq;
using TB_Paint.Instructions;

namespace TB_Paint
{
	public class InstructionMenager
	{
		public static List<Instruction> _Instructions;
		public static void Initialize()
		{
            _Instructions = new List<Instruction>
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
		public static bool RunCins(string text)
		{
			try
			{
                foreach (string item in text.Split(';'))
                {
                    int cmdid = int.Parse(item.Split(':')[0]);
                    string[] args = item.Split(':')[1].Split(',');
					if (!_Instructions[cmdid].Start(args))
					{
						throw new NotImplementedException("Instruction Read Error");
					}
                }
            }
			catch
			{
				return false;
			}
			
			return true;
		}
		public static bool Run(string text)
		{
			string[] args = text.Split(' ');
			foreach (Instruction item in _Instructions)
			{
				if (item.Name == args[0].ToLower())
				{
					return item.Start(args.Skip(1).ToArray());
				}
			}
			return false;
		}
	}
}
