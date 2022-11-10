namespace TB_Paint.Rutime.Instructions
{
	public class InstScale : Instruction
	{
		public InstScale() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				CurrentImage.Scale = int.Parse(args[0]);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
