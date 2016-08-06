using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, perimetro, area;
            const double pi = 3.1416;
            
            radio = OrderNum("Ingrese el area: ");

            perimetro = 2 * pi * radio;
            area = pi * (radio * radio);

            Console.WriteLine("\nEl Perimetro del circulo es : " + perimetro);
            Console.WriteLine("El Area del circulo es : " + area);
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
    }
}
