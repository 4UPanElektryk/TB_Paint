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
