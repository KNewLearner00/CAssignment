using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSignment1
{
    internal class CircleArea
    {
        public void circumfrencearea()
        {
            double rad, Area, Circumference;
            const double PI = 3.14;

            Console.WriteLine("Program to calculate the area and circumference of a circle");

            Console.Write("\nEnter the radius of circle ");
            rad = Convert.ToDouble(Console.ReadLine());
            Area = PI * rad * rad;
            Circumference = 2 * PI * rad;
            Console.WriteLine("\nThe area of a circle is {0} ", Area);
            Console.WriteLine("\nThe circumference of a circle is {0}", Circumference);
            Console.ReadLine();
        }


        public static void Main()
        {
            CircleArea ca = new CircleArea();
            ca.circumfrencearea();

        }

    }
}
