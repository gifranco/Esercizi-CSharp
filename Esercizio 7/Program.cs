using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_7
{

    class Program
    {
        static void Main()
        {
            Utility.Inizia();
            //
            // Create a local variable of type nullable integer.
            // ... It is initially assigned to null.
            // ... The HasValue property is false.
            //
            int? value = null;
            Console.WriteLine(value.HasValue);
            //
            // Assign the nullable integer to a constant integer.
            // ... The HasValue property is now true.
            // ... You can access the Value property as well.
            //
            value = 1;
            Console.WriteLine(value.HasValue);
            Console.WriteLine(value.Value);
            Console.WriteLine(value);
            if (value == 1)
            {
                Console.WriteLine("True");
            }
            Utility.Ferma();
        }
    }
}
