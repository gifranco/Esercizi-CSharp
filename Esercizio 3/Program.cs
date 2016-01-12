using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPar = args.Length;

            Utility.Inizia();

            if(numPar == 0)
            {
                Console.WriteLine("Non ci sono parametri in ingresso!!");

            }
            else
            {
                // ... Loop with the foreach keyword.
                int idx = 1;
                foreach (string value in args)
                {
                    Console.Write("parametro n.{0}: ", idx++);
                    Console.Write("{0,20}", value);
                    Console.WriteLine(" - {0,-16:X}", value.GetHashCode());
                }
            }



            Utility.Ferma();
        }
    }
}
