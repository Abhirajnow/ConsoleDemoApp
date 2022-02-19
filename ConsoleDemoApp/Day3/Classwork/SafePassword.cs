using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3.Classwork
{
    internal class SafePassword
    {
        static void Main(string[] args)
        {
            string password ="";
            Console.WriteLine("Enter Password");
            ConsoleKeyInfo key = Console.ReadKey(true);

            while (ConsoleKey.Enter != key.Key)
            {
                Console.Write("*");
                password += key.KeyChar;
                key = Console.ReadKey(true);
               
            }


            Console.WriteLine("\n Password "+password);

        }

    }
}
