using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TB_Paint.Instructions;

namespace TB_Paint
{
    public class InstructionMenager
    {
        static List<Instruction> _Instructions;
        public InstructionMenager()
        {
            _Instructions = new List<Instruction>
            {
                new InstNew("new"),
                new InstSelect("sel"),
                new InstSet("set"),
                new InstReplace("rep"),
                new InstLoad("load"),
                new InstSave("save"),
                new Instruction("//"),
            };
        }
        public static void Run(string text)
        {
            string[] args = text.Split(' ');
            foreach (Instruction item in _Instructions)
            {
                if (item.Name == args[0].ToLower())
                {
                    item.Start(args.Skip(1).ToArray());
                }
            }
        }
    }
}
