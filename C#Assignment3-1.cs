using EmployeeMangementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    public interface IPrintable
    {
        void DisplayEmployeeDetails();
    }
    public class Employee
    {
        public int empid;
        public string empname;
        public float Salary;
        public float GrossSalary;
        public void GetSalaryWithEmployeeDetails()
        {
           Console.WriteLine("Enter Employee Details Like emp_id,emp_name");
            empid = int.Parse(Console.ReadLine());
            empname = Console.ReadLine();
            Console.WriteLine("Enter Salary of an Employe .");
            Salary = float.Parse(Console.ReadLine());
        }
        public virtual void CalculateSalary()
        {

        }

    }
    public class Manager : Employee, IPrintable
    {
        private float PA;
        private float FA;
        private float OA;
        public override void CalculateSalary()
        {
            PA = 8 * Salary / 100;
            FA = 13 * Salary / 100;
            OA = 3 * Salary / 100;
            GrossSalary = Salary + PA + FA + OA;

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Manager Details...");
            Console.WriteLine("emp_id: {0}\nemp_name: {1}\nGrossSalary:{2}", empid, empname, GrossSalary);


        }

    }
    public class MarketingExecutive : Employee, IPrintable

    //inherited Employee class and interface IEmployee

    {
        private int Distance;
        private float TourAllowances;
        private float Telephone_Allowances;
        public override void CalculateSalary() //override method of Employee class
        {
            Console.WriteLine("Enter Distance travelled during Marketing Executive in km");
            Distance = int.Parse(Console.ReadLine());//taking distance input
            TourAllowances = 5 * Distance; //5 rupees per km
            Telephone_Allowances = 1000;
            GrossSalary = Salary + TourAllowances + Telephone_Allowances;

        }
        public void DisplayEmployeeDetails() //implementation of interface method
        {
            Console.WriteLine("Marketing Executive Details....");
            Console.WriteLine("emp_id= {0}\n emp_name={1}\nGross Salary={2}", empid, empname, GrossSalary);
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Manager mg = new Manager();
            MarketingExecutive me = new MarketingExecutive();
            Console.WriteLine("Manager Input");
            mg.GetSalaryWithEmployeeDetails();
            mg.CalculateSalary();
            mg.DisplayEmployeeDetails();
            Console.WriteLine("Marketing Executive Input");
            me.GetSalaryWithEmployeeDetails();
            me.CalculateSalary();
            me.DisplayEmployeeDetails();
            Console.ReadLine();

        }
    }
}

