using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Classe di tools per la soluzione "Esercizi-CSharp"
/// </summary>
namespace Esercizi_CSharp
{
    public class Utility
    {
        static public void Ferma()
        {
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
