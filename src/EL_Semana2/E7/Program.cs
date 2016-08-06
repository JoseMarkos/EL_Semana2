using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            distancia de entrada(m): 50000

            Entrada(hora): 1

            Entrada(minutos): 35

            Entrada(segundos): 56

            Resultado esperado:

            Su velocidad en metros / seg es 8.686588

            Su velocidad en km / h es 31.27172

            Su velocidad en millas / h es 19.4355

                */

            double meters, hours, mins, segs, total_segs;
            double v_meters_segs, v_kilo_mins, v_miles_hours;

            meters = OrderNum("Ingrese metros: ");
            hours = OrderNum("Ingrese horas: ");
            mins = OrderNum("Ingrese minutos: ");
            segs = OrderNum("Ingrese segundos: ");

            total_segs = (hours * 60 * 60) + (mins * 60) + segs;

            v_meters_segs = meters / total_segs;

            Console.WriteLine(v_meters_segs);
            EndProgram();
        }

        static double OrderNum(string characters)
        {
            double num;

            Console.WriteLine(characters);
            bool is_num = double.TryParse(Console.ReadLine(), out num);

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
