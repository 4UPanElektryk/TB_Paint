namespace TB_Paint.Rutime.Instructions
{
	public class InstNew : Instruction
	{
		public InstNew() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				CurrentImage.New(int.Parse(args[0]), int.Parse(args[1]));
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
