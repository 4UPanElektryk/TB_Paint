namespace TB_Paint.Rutime.Instructions
{
	public class InstSelect : Instruction
	{
		public InstSelect() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				if (args.Length == 4)
				{
					for (int i = 0; i < 4; i++)
					{
						CurrentImage.SelectedArea[i] = int.Parse(args[i]);
					}
				}
				if (args.Length == 2)
				{
					for (int i = 0; i < 2; i++)
					{
						CurrentImage.SelectedArea[i] = int.Parse(args[i]);
					}
					for (int i = 2; i < 4; i++)
					{
						CurrentImage.SelectedArea[i] = int.Parse(args[i - 2]);
					}
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
