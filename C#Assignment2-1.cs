using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class EMPLOYEE
    {

        private int EnplNo;
        private string EmpName;
        private double Salary;
        private double Hra;
        private double Ta;
        private double Da;
        private double Pf;
        private double Tds;
        private double Netsalary;
        private double GrossSalary;

        public void EmployeeDetail()
        {
            Console.WriteLine("ENTER YOUR EMPLOYEE no.,NAME,SALARY=");
            EnplNo = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("EMPLOYEE NO={0}\tEMPLOYEE NAME={1}\tAND\t SALARY={2}", EnplNo, EmpName, Salary);
        }
        public double Calculation()

        {
            GrossSalary = 0;
            if (Salary < 5000)
            {
                Hra = 10 * Salary / 100;
                Ta = 5 * Salary / 100;
                Da = 15 * Salary / 100;
                GrossSalary = Salary + Hra + Ta + Da;
            }

            else if (Salary < 10000)
            {
                Hra = 15 * Salary / 100;
                Ta = 10 * Salary / 100;
                Da = 20 * Salary / 100;
                GrossSalary = Salary + Hra + Ta + Da;
            }

            else if (Salary < 15000)
            {
                Hra = 20 * Salary / 100;
                Ta = 15 * Salary / 100;
                Da = 25 * Salary / 100;
                GrossSalary = Salary + Hra + Ta + Da;
            }
            else if (Salary < 20000)
            {
                Hra = 25 * Salary / 100;
                Ta = 20 * Salary / 100;
                Da = 30 * Salary / 100;
                GrossSalary = Salary + Hra + Ta + Da;
            }
            else if (Salary >= 20000)
            {
                Hra = 30 * Salary / 100;
                Ta = 25 * Salary / 100;
                Da = 35 * Salary / 100;
                GrossSalary = Salary + Hra + Ta + Da;
            }
            return GrossSalary;
        }
        public void Salarycal()
        {
            Console.WriteLine("EMPLOYEE PF,TDS ,SALARY =");
            Double Cal = Calculation();
            Pf = 10 * Cal / 100;
            Tds = 18 * Cal / 100;
            Netsalary = Cal - (Pf + Tds);
            Console.WriteLine("PF={0}\nTDS={1}\nNETSALARY={2}", Pf, Tds, Netsalary);

        }


        public static void Main()
        {
            EMPLOYEE ep = new EMPLOYEE();
            ep.EmployeeDetail();
            Double c = ep.Calculation();
            Console.WriteLine("GROSS SALARY=", c);
            ep.Salarycal();
            Console.ReadLine();
        }
    }
}







