using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = new string[3];

            Console.WriteLine("Ingrese letra1: ");
            letters[0] = Console.ReadLine();

            Console.WriteLine("Ingrese letra2: ");
            letters[1] = Console.ReadLine();

            Console.WriteLine("Ingrese letra3: ");
            letters[2] = Console.ReadLine();

            ReversePrintArray(letters);
            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static void ReversePrintArray(string[] array_name)
        {
            Array.Reverse(array_name);
            Console.WriteLine("");

            for (int i = 0; i < array_name.Length; i++)
            {
                Console.WriteLine(array_name[i]);
            }
        }

    }
}
