using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Paint
{
	public class Instruction
	{
		public string Name;
		public Instruction(string name ) { Name = name; }
		public virtual void Start(string[] args)
		{

		}
	}
}
