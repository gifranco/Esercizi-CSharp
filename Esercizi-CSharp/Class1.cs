using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_CSharp
{
    public class Utility
    {
        static public void Ferma()
        {
            Console.Write("\nPremi un tasto per continuare ...");
            Console.ReadKey();
        }

        static public void Alt()
        {
            Console.Clear();
            Console.Write("\nPremi un tasto per continuare ...");
            Console.ReadKey();
        }

        static public void Inizia()
        {
            Console.Clear();
            Console.WriteLine();
        }
    }
}
