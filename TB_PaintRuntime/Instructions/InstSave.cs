namespace TB_Paint.Rutime.Instructions
{
	public class InstSave : Instruction
	{
		public InstSave() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				CurrentImage.Save(args[0]);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
