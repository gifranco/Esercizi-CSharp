using System;
using System.IO;
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

        static public void Read_File(string File_Name)
        {
            // Controllo se il file esiste.
            if (File.Exists(File_Name) == false)
            {
                // Il file non esiste.
                Console.WriteLine("The file does not exists");
                // Esco dalla Sub.
                Environment.Exit(1);
            }
            // Dichiaro l’oggetto oStreamReader per leggere il
            //file.
            StreamReader oStreamReader = new
            StreamReader(File_Name);
            // Mostro tutte le righe del file.
            Console.WriteLine(oStreamReader.ReadToEnd());
            // Chiudo l’oggetto oStreamReader.
            oStreamReader.Close();
        }

        static public void Write_File(string File_to_Write)
        {
            // Dichiaro l’oggetto oStreamWriter per scrivere nel file.
            StreamWriter oStreamWriter = new  StreamWriter(File_to_Write, false);
            // Scrivo la prima riga.
            oStreamWriter.WriteLine("Row 1");
            // Scrivo la seconda riga.
            oStreamWriter.WriteLine("Row 2");
            // Scrivo la terza riga.
            oStreamWriter.WriteLine("Row 3");
            // Chiudo l’ oStreamWriter.
            oStreamWriter.Close();
        }
    }
}
