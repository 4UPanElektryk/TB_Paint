﻿namespace TB_Paint.Instructions
{
	public class InstScale : Instruction
	{
		public InstScale(string name) : base(name) { }
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
