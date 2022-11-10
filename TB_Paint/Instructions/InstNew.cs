﻿namespace TB_Paint.Instructions
{
	public class InstNew : Instruction
	{
		public InstNew(string name) : base(name) { }
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
