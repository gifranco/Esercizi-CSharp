//primo programma C#
using System;
/*
csc /Main:primo_giorno.CiaoMondo2 Hello_param.cs

*/
namespace primo_giorno
{
	class CiaoMondo1
	{
		public static void Main(string[] args)
		{
			System.Console.WriteLine("Ciao mondo");
		}
	}
	
	class CiaoMondo2
	{
		public static void Main(string[] args)
		{
			Console.Write("Ciao" );
			foreach(string s in args)
			{
				Console.Write(" ");
				Console.Write(s);
			}
			Console.WriteLine();
		}
	}
}