using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.Classwork
{
    internal class StaticDemo
    {
        public static int id;
        static StaticDemo()
        {
            Console.WriteLine("Static constructor Called ...");
            id = 100;

        }

        public static void Display()
        {
            Console.WriteLine($"{id}");
        }
    }

    class StaticMain
    {
        static void Main(string[] args)
        {
            StaticDemo.Display();
            Console.WriteLine(StaticDemo.id);
        }
    }
}
