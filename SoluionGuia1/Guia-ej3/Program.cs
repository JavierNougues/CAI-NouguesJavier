using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_ej3
{
    class Program
    {
        // Cuando debugueo me devuelve bien la palabra, ej: neuquen, pero no se porque no la reconoce igual a "word".
        static void Main(string[] args)
        {
            string word, reverseWord = "";
            Console.WriteLine("Ingrese palabra: ");
            word = Console.ReadLine();

            for (int i = word.Length-1; i >= 0; i--)
            {
                reverseWord = word[i].ToString(); 
            }
            if (reverseWord == word) 
            {
                Console.WriteLine("Es capicua.");
            }
            else
            {
                Console.WriteLine("No es capicua.");
            }

            Console.ReadKey();
        }
    }
}
