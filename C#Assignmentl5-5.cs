using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
   internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> employee = new LinkedList<string>();

            //Adding a new employee

            employee.AddFirst("Gita");

            employee.AddFirst("Sita");

            employee.AddFirst("Ram");

            Console.WriteLine("Display the list of  employee\n");

            foreach (string emp in employee)

            {
                Console.WriteLine(emp + "\n");
            }

            Console.WriteLine("Total number of employee in the list : " + employee.Count());

            Console.WriteLine("\n");

            //Searching employee name is it present or not Assignment 5 quetion 5

            Console.WriteLine("The employee Sita is present in linked list : " +
                employee.Contains("Sita"));

            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}


