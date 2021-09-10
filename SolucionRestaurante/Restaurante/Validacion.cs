using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Validacion
    {
        public static string PedirStrNoVacio(string mensaje)
        {
            string valor;
            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine("Debe completar el campo");
                }
            } while (valor == "");

            return valor;
        }
    }
}
