using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_10__array_
{
    class Program
    {
 

        static void Main(string[] args)
        {
            Utility.Inizia();

            /// jagged array
            int[][] vet = new int[3][];

            vet[0] = new int[1];
            vet[1] = new int[2];
            vet[2] = new int[3];

            Utility.Write_File("c:\\temp\\gino.txt");
            Utility.Read_File("c:\\temp\\gino.txt");

            Utility.Ferma();
        }


    }
}
