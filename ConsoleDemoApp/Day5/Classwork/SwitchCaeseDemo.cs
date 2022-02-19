using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day5.Classwork
{
    internal class SwitchCaeseDemo
    {
        static void Main(string[] args)
        {
            string weekday;
            Console.WriteLine("Enter any week day");
            weekday = Console.ReadLine();

            switch (weekday)
            {
                default:
                    Console.WriteLine(" Please provide valid week day");
                    break;


            }

            int[] vs = { 1, 2, 3, 4 };
            int[] arr = new int[] { 11, 22, 33, 44, 55 };

            Console.WriteLine(" Arrya values are :");

            //Boxing // assigning vale to referance
            object obj = 20; // implicipt
            int y = (int)obj; // unboxing , explicit

            /*
             *  Syntax of for ecah loop
             *  
                     foreach( Type identifier in collection -name)
                {
                    Console.WriteLine(identifier.ToString());
                }
            */
            
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

            foreach (object item in vs)
            {
                
                if((int) item > 2)
                {
                    Console.WriteLine(item);
                } 
            }

            /// var keyword power local scope
            // type ressolve complie time // we generally refer
            foreach (var item in vs)
            {
                
                if (item > 2)
                {
                    Console.WriteLine(item);
                }
            }

            // dynamic obj ( all type of object) global scope class level
            // reslove run time
            foreach (dynamic item in arr)
            {

                if (item > 22)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}
