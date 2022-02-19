using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.Classwork
{
    internal class Point
    {
        int x;
        int y;

        //public Point()
        //{
        //    this.x = 0;
        //    this.y = 0;
        //}

        public Point(int x= 0, int y=0)
        {
            this.x = x;
            this.y = y; 
        }

        public override string ToString()
        {
            return $"Point({x},{y})";
        }

        /*
         * In operator overlaoding function must be public andd static
         * Minimum Number of paramaer is same as type of operator
         * For Uninary (one), Binary ( two)
         * 
         */
        public static Point operator +(Point obj1 , Point obj2)
        {
            int x = obj1.x + obj2.x;
            int y = obj1.y + obj2.y;
            return new Point(x, y);
        }

        //  - Overloading
        public static Point operator -(Point obj1, Point obj2)
        {
            return new Point(obj1.x -obj2.x,obj1.y -obj2.y);
        }

        //  * Overloading
        public static Point operator *(Point obj1, Point obj2)
        {
            return new Point(obj1.x * obj2.x, obj1.y * obj2.y);
        }

        // Distructor 

        ~Point()
        {
            Console.WriteLine("Destructor is called");
        }
    }

    class PointMain
    {

        static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine(point);

            Point point1 = new Point(20);
            Console.WriteLine(point1);

            Point point2 = new Point(y:40);
            Console.WriteLine(point2);

            Point point3 = new Point(30,50);
            Console.WriteLine(point3);

            Point point4 = new Point(y:40,x:90);
            Console.WriteLine(point4);

            Point point5 = point3 + point4;
            Console.WriteLine(point5);


        }

    }
}
