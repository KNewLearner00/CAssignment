using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student
    {        static void Main()
        {
          String name;
          int marks;
          int higest = 0; 
          
           for (int y=1; y<=5; y++)
            {
                Console.WriteLine("enter name=");
                name = Console.ReadLine();
                Console.WriteLine("enter Marks Obtained=");
                    marks = int .Parse(Console.ReadLine());
                 if (marks<0 || marks>100)
                {
                    Console.WriteLine(" INVALID");
                    int newmarks = int.Parse(Console.ReadLine());
                    marks = newmarks;
                       }
                if ( marks> higest)
                {
                    higest = marks;

                }
            }
            
            Console.WriteLine("Graeter=" + higest);
            Console.ReadLine();
        

        }

    }
}
