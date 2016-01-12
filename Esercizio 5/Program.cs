using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_5
{
    struct Point3D
    {
        public double x;
        public double y;
        public double z;
        public override string ToString()
        {
            Console.WriteLine("({0:F}, {1:F}, {2:F})", x, y, z);
            return null;
        }
    }

    enum E
    {
        None,
        BoldTag,
        ItalicsTag,
        HyperlinkTag,
    };


    class Program
    {
        static void Main(string[] args)
        {
            Utility.Inizia();
            Point3D p;
            p.x = 1.0F;
            p.y = 1.0F;
            p.z = 1.0F;

            Console.WriteLine(p);

            Utility.Ferma();

            Utility.Inizia();
            // ... These values are enum E types.
            E en1 = E.BoldTag;
            E en2 = E.ItalicsTag;

            if (en1 == E.BoldTag)
            {
                // Will be printed.
                Console.WriteLine("Bold");
            }
            if (en1 == E.HyperlinkTag)
            {
                // Won't be printed.
                Console.WriteLine("Not true");
            }
            Utility.Ferma();

        }
    }
}
