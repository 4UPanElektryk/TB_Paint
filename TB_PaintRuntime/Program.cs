using System.IO;

namespace TB_Paint.Rutime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args[0].EndsWith(".cins"))
            {
                InstructionMenager.RunCins(File.ReadAllText(args[0]));
            }
            else
            {
                InstructionMenager.RunCins(args[0]);
            }
        }
    }
}
