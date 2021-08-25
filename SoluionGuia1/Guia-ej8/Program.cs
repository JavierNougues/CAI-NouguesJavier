using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia1, mes1, ano1, dia2, mes2, ano2, result;

            Console.WriteLine("Fecha1, ingrese dia: ");
            Console.WriteLine("Fecha1, ingrese mes: ");
            Console.WriteLine("Fecha1, ingrese año: ");

            dia1 = int.Parse(Console.ReadLine());
            if (dia1 > 30 || dia1 < 1)
            {
                Console.WriteLine("Dia no valido.");
            }

            mes1 = int.Parse(Console.ReadLine());
            if (mes1 > 12 || mes1 < 1)
            {
                Console.WriteLine("Mes no valido.");
            }

            ano1 = int.Parse(Console.ReadLine());
            /*if (ano1.lengh > 4)
            {
                Console.WriteLine("Año no valido.");
            }*/

            Console.WriteLine("Fecha2, ingrese dia: ");
            Console.WriteLine("Fecha2, ingrese mes: ");
            Console.WriteLine("Fecha2, ingrese año: ");

            dia2 = int.Parse(Console.ReadLine());
            if (dia2 > 30 || dia2 < 1)
            {
                Console.WriteLine("Dia no valido.");
            }

            mes2 = int.Parse(Console.ReadLine());
            if (mes2 > 12 || mes2 < 1)
            {
                Console.WriteLine("Mes no valido.");
            }

            ano2 = int.Parse(Console.ReadLine());
            /*if (ano2.lengh > 4)
                {
                    Console.WriteLine("Año no valido.");
                }*/

      
            result = (dia1 * mes1 * ano1) - (dia2 * mes2 * ano2);

            Console.WriteLine("La diferencia es de: " + result + " dias.");
            Console.ReadKey();
        }
    }
}
