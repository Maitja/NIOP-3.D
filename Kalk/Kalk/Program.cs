using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d;
            float q, w, e, r;
            string y, x, v;
            Console.WriteLine("Upišite brojeve za računanje");
            Console.Write("1.");
            y =Console.ReadLine();
            a = Int32.Parse(y);
            Console.Write("2.");
            x = Console.ReadLine();
            b = Int32.Parse(x);
            q = a / b;
            w = a * b;
            e = a + b;
            r = a - b;

            Console.WriteLine("Upišite koju operaciju želite.");
            v=Console.ReadLine();
            Console.WriteLine("\nRiješenje");
            if (v == "/")
            { Console.WriteLine(q); }
            else if (v == "*")
            { Console.WriteLine(w); }
            else if (v == "+")
            { Console.WriteLine(e); }
            else if (v == "-")
            { Console.WriteLine(r); }

            Console.ReadKey();

        }
    }
}
