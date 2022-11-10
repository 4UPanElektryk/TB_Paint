﻿namespace TB_Paint
{
	public class Instruction
	{
		public string Name;
		public Instruction(string name) { Name = name; }
		public virtual bool Start(string[] args)
		{
			return true;
		}
	}
}
