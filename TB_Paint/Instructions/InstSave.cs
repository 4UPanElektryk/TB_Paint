using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Paint.Instructions
{
    public class InstSave : Instruction
    {
        public InstSave(string name) : base(name) { }
        public override void Start(string[] args)
        {
            CurrentImage.Save(args[0]);
        }
    }
}
