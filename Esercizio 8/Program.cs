using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;


namespace Esercizio_8
{
     class Program
    {
        static void Main(string[] args)
        {
            Utility.Inizia();


            Console.WriteLine("The type of sbyte   is {0}.", typeof(sbyte));
            Console.WriteLine("The type of byte    is {0}.", typeof(byte));
            Console.WriteLine("The type of short   is {0}.", typeof(short));
            Console.WriteLine("The type of ushort  is {0}.", typeof(ushort));
            Console.WriteLine("The type of int     is {0}.", typeof(int));
            Console.WriteLine("The type of uint    is {0}.", typeof(uint));
            Console.WriteLine("The type of long    is {0}.", typeof(long));
            Console.WriteLine("The type of ulong   is {0}.", typeof(ulong));
            Console.WriteLine("The type of char    is {0}.", typeof(char));
            Console.WriteLine("The type of float   is {0}.", typeof(float));
            Console.WriteLine("The type of double  is {0}.", typeof(double));
            Console.WriteLine("The type of decimal is {0}.", typeof(decimal));
            Console.WriteLine("The type of bool    is {0}.", typeof(bool));


            int i = 10;
            double f = Convert.ToDouble(i);

            Console.WriteLine("\ni: {0:X}  f: {1:X}", i, Convert.ToInt64(f));

            Utility.Ferma();
        }
    }
}
