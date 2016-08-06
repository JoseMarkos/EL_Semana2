using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[11] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            ShowFuncionValues(values);
            EndProgram();
        }

        static int OrderNum(string characters)
        {
            int num;

            Console.WriteLine(characters);
            bool is_num = Int32.TryParse(Console.ReadLine(), out num);

            if (!is_num)
            {
                Console.WriteLine("Warning: Ingrese un dato valido! \n");
                return 0;
            }

            return num;
        }

        static void EndProgram()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        static void ShowFuncionValues(int[] array)
        {
            int variable;
            Console.WriteLine("Para la funcion x = y^2 + 2y + 1 ");

            for (int i = 0; i < array.Length; i++)
            {
                variable = (array[i] * array[i]) + (2 * array[i]) + 1;
                Console.WriteLine(variable + " = " + array[i] + "^2 + 2 * " + array[i] + " + 1");
            }
        }
    }
}
