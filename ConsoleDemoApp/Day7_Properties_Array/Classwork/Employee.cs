using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day7_Properties_Array.Classwork
{
    internal class Employee
    {
        int _Age;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        
        public int Age
        {
            get => _Age;
            set => _Age = value;
        }
    
    }

    class EmployeeMain
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Ravi",
                LastName = "Ranjan",
                Age = 22
            };

           
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.FullName);
          

        }
    }
}
