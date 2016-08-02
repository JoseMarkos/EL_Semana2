using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string character;
            int triangle_width;

            Console.WriteLine("Ingrese un numbero: ");
            character = Console.ReadLine();

            Console.WriteLine("Ingrese el ancho del triangulo: ");
            triangle_width = Int32.Parse(Console.ReadLine());

            PrintTriangle(character, triangle_width);
            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        
        static void PrintTriangle(string character, int triangle_width)
        {
            Console.WriteLine(".......................");

            for (int i = triangle_width; i > 0; i--)
            {
                PrintTriangleRow(character, i);
            }
        }

        static void PrintTriangleRow(string character, int row_width)
        {
            for (int i = 0; i < row_width; i++)
            {
                Console.Write(character);
            }

            Console.WriteLine("");
        }
    }
}

