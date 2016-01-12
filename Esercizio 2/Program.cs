using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 748;
            Boolean b = true;
            Utility.Inizia();
            Console.WriteLine("Il valore di \"i\" : {0} e quello di \"b\" : {1}", i, b);
            Utility.Ferma();
            Utility.Inizia();
            Console.WriteLine("|{0,5}|", i);
            Console.WriteLine("|{0,-5}|", i);
            Utility.Ferma();
            Utility.Inizia();
            Console.WriteLine("|{0,5:X}|", i);
            Console.WriteLine("|{0,-5:X}|", -i);
            Utility.Ferma();
            Utility.Inizia();
            Console.WriteLine("|{0:##.###}|", 1.23456);
            Console.WriteLine("|{0:####.##}|", 123.456);
            Console.WriteLine("|{0:(+##)###-###-###}|", 98765432123);
            Utility.Ferma();
        }
    }
}
