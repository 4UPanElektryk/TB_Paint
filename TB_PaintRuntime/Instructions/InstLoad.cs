using System.Drawing;

namespace TB_Paint.Rutime.Instructions
{
	public class InstLoad : Instruction
	{
		public InstLoad() : base(){ }
		public override bool Start(string[] args)
		{
			try
			{
				CurrentImage.ImportImage(new Bitmap(args[0]));
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
