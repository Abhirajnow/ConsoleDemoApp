using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day7_Properties_Array.Classwork
{
    internal static class EmployeeExtrension
    {
        // extension method
        public static void Display( this Employee employee ,int x)
        {
            Console.WriteLine($"{employee.FullName} \t Age : {x}");
        }

        public static void Experiance( this Employee employee , int x)
        {
            Console.WriteLine($" Name : {employee.FullName} Experiance {x}");
        }
    }

    class EmployeeExtrensionMain
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "ARVIND";
            employee.LastName = " AKELA";
            employee.Display(50);
            employee.Experiance(10);
        }
    }
}
