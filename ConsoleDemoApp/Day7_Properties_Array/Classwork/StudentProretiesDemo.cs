using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day7_Properties_Array.Classwork
{
    internal class StudentProretiesDemo
    {
        int _RollNo;
        string _Name;
        int _Age;
        string _Course;
        static string _College;


        // Stataic Constructor

       static StudentProretiesDemo(){
            _College = "CDAC PATNA";
            }

        public int RollNo
        {
            get
            {
                return _RollNo;
            }

            set
            {
                _RollNo = value;
            }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        // Write Only
        public string Course
        {
            set { _Course = value; }
        }

        // Read Only 

        public string College
        {
            get{ return _College; }
        }

        public int MyProperty { get; set; }

        public override string ToString()
        {
            return $"Name : {_Name} \t Roll No: {_RollNo} \t Age : {_Age} \t Courses: {_Course} \t College: {_College}";
        }
    }

    class StudentProretiesDemoMain
    {
        static void Main(string[] args)
        {
            StudentProretiesDemo demo = new StudentProretiesDemo();
            demo.Name = "Monu";
            demo.Age = 12;
            demo.RollNo = 05;

            Console.WriteLine($" Name : {demo.Name} \t Age : {demo.Age} \t Roll No : {demo.RollNo}");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine(demo);
            Console.WriteLine(">>>>>>>>> <<<<<<<<<<<<<<<<<<<<<<<<");

            StudentProretiesDemo obj1 = new StudentProretiesDemo()
            {
                Name = " Rahul",
                Age = 22,
                RollNo = 23
            };

            StudentProretiesDemo obj2 = new StudentProretiesDemo()
            {
                Name = "Mohit"
               
            };

            StudentProretiesDemo obj3 = new StudentProretiesDemo()
            {
                
                RollNo = 12
            };

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);

            StudentProretiesDemo obj4 = new StudentProretiesDemo();
            obj4.Course = "PGDAC";
       
            Console.WriteLine(obj4);
            // Read only
           //  obj4.College = "jhjjjjj";

            Console.WriteLine(obj4.College);

            StudentProretiesDemo obj5 = new StudentProretiesDemo();
            obj5.MyProperty = 0;
            Console.WriteLine(obj5);
            
            // EXTENSION METHOD TEST
            //Employee employee = new Employee();
            //employee.Display(122);
            //Console.WriteLine(employee);

        }
    }
}
