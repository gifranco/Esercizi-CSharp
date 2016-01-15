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

            Utility.Inizia();

            int? num = null;

            // Is the HasValue property true?
            if (num.HasValue)
            {
                System.Console.WriteLine("num = " + num.Value);
            }
            else
            {
                System.Console.WriteLine("num = Null");
            }

            // y is set to zero
            int y = num.GetValueOrDefault();

            // num.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                y = num.Value;
            }
            catch (System.InvalidOperationException e)
            {
                System.Console.WriteLine(e.Message);
            }
            Utility.Ferma();

        }
    }
}
