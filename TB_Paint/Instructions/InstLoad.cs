﻿using System.Drawing;

namespace TB_Paint.Instructions
{
	public class InstLoad : Instruction
	{
		public InstLoad(string name) : base(name) { }
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
