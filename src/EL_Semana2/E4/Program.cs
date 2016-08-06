using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            string operation;

            num = OrderNum("Ingrese el numbero1: ");

            Console.WriteLine("Ingrese operacion de entrada: ");
            operation = Console.ReadLine();

            num2 = OrderNum("Ingrese un numbero2: ");
            
            switch (operation)
            {
                case "+":
                    Console.WriteLine("El resultado es: " + Sum(num, num2));
                    break;
                case "-":
                    Console.WriteLine("El resultado es: " + Subtraction(num, num2));
                    break;
                case "*":
                    Console.WriteLine("El resultado es: " + Multiplication(num, num2));
                    break;
                case "/":
                    Console.WriteLine("El resultado es: " + Divition(num, num2));
                    break;
                default:
                    Console.WriteLine("\nWarning: Ingrese operacion valida!");
                    break;
            }

            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        static int Sum(int num, int num2)
        {
            int result = num + num2;
            return result;
        }

        static int Subtraction(int num, int num2)
        {
            int result = num - num2;
            return result;
        }

        static int Multiplication(int num, int num2)
        {
            int result = num * num2;
            return result;
        }

        static int Divition(int num, int num2)
        {
            int result = num / num2;
            return result;
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
    }
}
