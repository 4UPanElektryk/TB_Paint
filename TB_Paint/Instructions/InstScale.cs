namespace TB_Paint.Instructions
{
    public class InstScale : Instruction
    {
        public InstScale(string name) : base(name) { }
        public override void Start(string[] args)
        {
            CurrentImage.Scale = int.Parse(args[0]);
        }
    }
}
