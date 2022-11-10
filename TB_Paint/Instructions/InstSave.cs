﻿namespace TB_Paint.Instructions
{
	public class InstSave : Instruction
	{
		public InstSave(string name) : base(name) { }
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
