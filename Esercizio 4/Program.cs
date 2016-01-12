using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_4
{


    class Program
    {
        static void Main(string[] args)
        {
            Utility.Inizia();

            byte v1 = new byte();
            v1 = 10;
            Console.WriteLine("{0,-16:X}|{1}|{2}",v1.GetHashCode(), v1.GetType(), v1.GetTypeCode());

            sbyte v2 = new sbyte();
            v2 = 11;
            Console.WriteLine("{0,-16:X}|{1}|{2}", v2.GetHashCode(), v2.GetType(), v2.GetTypeCode());

            short v3 = new short();
            v3 = 12;
            Console.WriteLine("{0,-16:X}|{1}|{2}", v3.GetHashCode(), v3.GetType(), v3.GetTypeCode());

            ushort v4 = new ushort();
            v4 = 13;
            Console.WriteLine("{0,-16:X}|{1}|{2}", v4.GetHashCode(), v4.GetType(), v4.GetTypeCode());

            float v5 = new float();
            v5 = 14.0F;
            Console.WriteLine("{0,-16:X}|{1}|{2}", v5.GetHashCode(), v5.GetType(), v5.GetTypeCode());

            double v6 = new double();
            v6 = 14.0D;
            Console.WriteLine("{0,-16:X}|{1}|{2}", v6.GetHashCode(), v6.GetType(), v6.GetTypeCode());

            decimal v7 = new decimal();
            v7 = 15.0M;
            Console.WriteLine("{0,-16:X}|{1}|{2}", v7.GetHashCode(), v7.GetType(), v7.GetTypeCode());

            Console.WriteLine("The size of sbyte   is {0}.", sizeof(sbyte  ));
            Console.WriteLine("The size of byte    is {0}.", sizeof(byte   ));
            Console.WriteLine("The size of short   is {0}.", sizeof(short  ));
            Console.WriteLine("The size of ushort  is {0}.", sizeof(ushort ));
            Console.WriteLine("The size of int     is {0}.", sizeof(int    ));
            Console.WriteLine("The size of uint    is {0}.", sizeof(uint   ));
            Console.WriteLine("The size of long    is {0}.", sizeof(long   ));
            Console.WriteLine("The size of ulong   is {0}.", sizeof(ulong  ));
            Console.WriteLine("The size of char    is {0}.", sizeof(char   ));
            Console.WriteLine("The size of float   is {0}.", sizeof(float  ));
            Console.WriteLine("The size of double  is {0}.", sizeof(double ));
            Console.WriteLine("The size of decimal is {0}.", sizeof(decimal));
            Console.WriteLine("The size of bool    is {0}.", sizeof(bool   ));

            Utility.Ferma();                       
        }                                          
    }
}
