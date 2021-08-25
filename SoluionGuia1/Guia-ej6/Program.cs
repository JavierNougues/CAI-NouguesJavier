using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;

            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero:");
            b = int.Parse(Console.ReadLine());

            r = (a + b) * (a - b);

            Console.WriteLine(r);

            Console.ReadKey();

        }
    }
}
