using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class Program
    {
        static string user, pass, right_user, right_pass;
        static int cont = 1;
   
        static void Main(string[] args)
        {
            right_user = "marcos";
            right_pass = "123";

            Login();
            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static void Login()
        {
            LoginNotice();
            Limited(ValidateValue(user, right_user), ValidateValue(pass, right_pass));
        }

        static void LoginNotice()
        {
            Console.WriteLine("Ingrese usuario: ");
            user = Console.ReadLine();

            Console.WriteLine("Ingrese contrasenha: ");
            pass = Console.ReadLine();

            Console.WriteLine("");
        }

        static bool ValidateValue(string characters, string right_value)
        {
            if (characters != right_value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Limited(bool value1, bool value2)
        {            
            if (cont == 3)
            {
                Console.WriteLine("Has superado los intentos fallidos permitidos.");
            }
            else if (value1 & value2)
            {
                Console.WriteLine("Genial! Has ingresado los datos correctos!!");
            }
            else
            {
                cont = cont + 1;
                Login();
            }
        }
    }
}

