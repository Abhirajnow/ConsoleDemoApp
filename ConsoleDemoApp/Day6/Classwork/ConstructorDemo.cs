using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.Classwork
{
    internal class ConstructorDemo
    {
        private int id;
        private string name;
        static int id_no;

        public ConstructorDemo() {
            Console.WriteLine(" Defalut Constructor calleed ...");
            this.id = id_no++;
            this.name = "Admin";
        }

        public ConstructorDemo(int id)
        {
            Console.WriteLine(" Id Constructor called...");
            this.id = id;
            id_no = id + 1 ;
        }

        public ConstructorDemo(string name)
        {
            Console.WriteLine(" Name Constructor called...");
            this.name = name;
            this.id = id_no++;

        }

        public ConstructorDemo(int id, string name)
        {
            Console.WriteLine(" Name  and ID Constructor called...");
            this.name = name;
            this.id = id;
            id_no = id + 1;

        }
        static ConstructorDemo()
        {
            id_no = 1000;
            Console.WriteLine(" static Construor");
            Console.WriteLine(" It is sed to Initialise the class static data feilds");
        }

        public void DisplayData()
        {
            Console.WriteLine($" Id : {id} \t Name :{name}");
         
        }

        public override string ToString()
        {
            return $" Id : {id} \t Name :{name}";
        }


    }

    public class ConstructorDemoMain
    {
        static void Main(string[] args)
        {
            ConstructorDemo obj = new ConstructorDemo();
            obj.DisplayData();

            ConstructorDemo obj1 = new ConstructorDemo(2);
            obj1.DisplayData();

            ConstructorDemo obj2 = new ConstructorDemo("Monu");
            obj2.DisplayData();

            ConstructorDemo obj3 = new ConstructorDemo(100, "Sonu");
            obj3.DisplayData();

            ConstructorDemo obj4 = new ConstructorDemo(105, "Sonu");
            obj4.DisplayData();
        }
    }
}
