using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3.Classwork
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            string name = "Rahul";
            string description = " student of Cdac";

            if(name is string)
                Console.WriteLine(name);

            Type type = typeof(string);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(description.GetType());


            Console.WriteLine(sizeof(int));
            Console.WriteLine("fh"); 
        }
    }
}
