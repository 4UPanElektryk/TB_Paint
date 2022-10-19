using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Paint;
using System.Drawing;

namespace TB_Paint.Instructions
{
    public class InstLoad : Instruction
    {
        public InstLoad(string name) : base(name) { }
        public override void Start(string[] args)
        {
            CurrentImage.ImportImage(new Bitmap(args[0]));
        }
    }
}
