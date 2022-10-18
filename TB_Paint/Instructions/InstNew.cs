using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Paint.Instructions
{
    public class InstNew : Instruction
    {
        public InstNew(string name) : base(name) { }
        public override void Start(string[] args)
        {
            CurrentImage.New(int.Parse(args[0]), int.Parse(args[1]));
        }
    }
}
