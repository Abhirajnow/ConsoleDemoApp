using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3
{
    internal class Three
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Day Three");

            Console.WriteLine("Press any key ");
            ConsoleKeyInfo key = Console.ReadKey();

            //Console Key
            Console.WriteLine(" \nPressed Key : " +key.Key);
            Console.WriteLine(" Key Char : " + key.KeyChar);
        }
    }
}
