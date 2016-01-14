using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.Inizia();

            Console.WriteLine("MIN(byte) = {0}", System.Byte.MinValue);
            Console.WriteLine("MAX(byte) = {0}", System.Byte.MaxValue);

            Console.WriteLine("MIN(Decimal) = {0}", System.Decimal.MinValue);
            Console.WriteLine("MAX(Decimal) = {0}", System.Decimal.MaxValue);
            Console.WriteLine("MIN(long) = {0}", System.Int64.MinValue);
            Console.WriteLine("MAX(long) = {0}", System.Int64.MaxValue);

            // boxing
            long j = 122345L;
            Console.WriteLine(j);
            object obj = j;

            Console.WriteLine(obj);
            // unboxing
            long k = (long)j;
            Console.WriteLine(k);

            var a = "ciao";
            var b = 200UL;
            var c = 1.2345F;
            Console.WriteLine("tipo a: {0}", a.GetType());
            Console.WriteLine("tipo b: {0}", b.GetType());
            Console.WriteLine("tipo c: {0}", c.GetType());

            Utility.Ferma();
        }
    }
}
