using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizi_CSharp;

namespace Esercizio_6
{
     class Program
    {
        [Flags]
        enum RenderType
        {
            None        = 0x0,
            DataUri     = 0x1,
            GZip        = 0x2,
            ContentPage = 0x4,
            ViewPage    = 0x8,
            HomePage    = 0x10 // Next two values could be 0x20, 0x40
        }

        static void Main()
        {
            Utility.Inizia();

            // 1.
            // Set the first type.
            RenderType type1 = RenderType.ContentPage;

            // 2.
            // Set the second type if the condition matches.
            if (true)
            {
                type1 |= RenderType.GZip;
            }

            // 3.
            // Check the enum flags.
            Check(type1);

            // 4.
            // Set a new enum in three statements.
            RenderType type2 = RenderType.ViewPage;
            type2 |= RenderType.DataUri;
            type2 |= RenderType.GZip;

            // 5.
            // See if the enum contains this flag.
            if ((type2 & RenderType.DataUri) == RenderType.DataUri)
            {
                Console.WriteLine("True");
            }

            // 6.
            // See if the enum contains this flag.
            if ((type2 & RenderType.ContentPage) == RenderType.ContentPage)
            {
                throw new Exception();
            }

            // 7.
            // Check the enum flags.
            Check(type2);

            Utility.Ferma();
        }

        static void Check(RenderType type)
        {
            // Switch on the flags.
            switch (type)
            {
                case RenderType.ContentPage | RenderType.DataUri | RenderType.GZip:
                    {
                        Console.WriteLine("content, datauri, gzip");
                        break;
                    }
                case RenderType.ContentPage | RenderType.GZip: // < first match
                    {
                        Console.WriteLine("content, gzip");
                        break;
                    }
                case RenderType.ContentPage:
                    {
                        Console.WriteLine("content");
                        break;
                    }
                case RenderType.ViewPage | RenderType.DataUri | RenderType.GZip: // < second match
                    {
                        Console.WriteLine("view, datauri, gzip");
                        break;
                    }
                case RenderType.ViewPage | RenderType.GZip:
                    {
                        Console.WriteLine("view, gzip");
                        break;
                    }
                case RenderType.ViewPage:
                    {
                        Console.WriteLine("view");
                        break;
                    }
                case RenderType.HomePage | RenderType.DataUri | RenderType.GZip:
                    {
                        Console.WriteLine("home, datauri, gzip");
                        break;
                    }
                case RenderType.HomePage | RenderType.GZip:
                    {
                        Console.WriteLine("home, gzip");
                        break;
                    }
                case RenderType.HomePage:
                    {
                        Console.WriteLine("home");
                        break;
                    }
            }
        }
    }
}
