using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day5.Classwork
{
    internal class ClassDemo
    {
        int _IdNo;
        string _Name;

        public void SetEmpDetails(int _IdNo, string Name)
        {
            this._IdNo = _IdNo;
            this._Name = Name;
            Console.WriteLine(" Employee deatils saved");
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine($"Id : {_IdNo} \t Name: {_Name}");
        }

        public override string ToString()
        {
            return $"Id : {_IdNo} \t Name : {_Name}";
        }

    }

    class EmployeeMain
    {
        static void Main(string[] args)
        {
                ClassDemo demo = new ClassDemo();
                demo.DisplayEmpDetails();
            
            ClassDemo emp = new ClassDemo();
            emp.SetEmpDetails(1, "Monu");

            Console.WriteLine(emp);
        }
    }
}
