using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist1
{
  
    public class EmployeeCollection
    {
        string name;
        int empid;
        double salary;
        public EmployeeCollection(string n, int id, double s)
        {
            this.name = n;
            this.empid = id;
            this.salary = s;
        }
        public override string ToString()
        {
            return
                String.Format("{0,-10} EMPLOYEE ID : {1,6}  SALARY : {2}", name, empid, salary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList e = new ArrayList();

            Console.WriteLine("Add element to the list");

            e.Add(new EmployeeCollection("Taeyong", 111, 32322.50));

            e.Add(new EmployeeCollection("Suga", 333, 30500.70));

            e.Add(new EmployeeCollection("Jungkook", 444, 40600.80));

            e.Add(new EmployeeCollection("Jin", 777, 49999.99));


            Console.WriteLine("Employee Details\n");

            foreach (EmployeeCollection emp in e)

            {
                Console.WriteLine("  " + emp);
            }
          
                Console.ReadLine();
         }
    }
}


