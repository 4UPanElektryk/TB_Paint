using System;
using System.Collections.Generic;
using TB_Paint.Rutime.Instructions;

namespace TB_Paint.Rutime
{
	public class InstructionMenager
	{
		static List<Instruction> _Instructions;
        public static void Initialize()
        {
            _Instructions = new List<Instruction>
            {
                new InstNew(),
                new InstSelect(),
                new InstSet(),
                new InstReplace(),
                new InstLoad(),
                new InstSave(),
                new InstScale(),
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
	}
}
