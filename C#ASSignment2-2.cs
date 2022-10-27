using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    { 
            class EMPLOYEE
            {
                public int[] eno = new int[50];
                public string[] ename = new string[50];
                public float[] esalary = new float[50];
                int count = 0;

                public void EmpDetail()
                {
                    int n;
                    Console.WriteLine("ENTER NUMBER OF EMPLOYEE YOU WANT TO INSERT=");

                    n = int.Parse(Console.ReadLine());

                    Console.WriteLine("REGISTER RECORDS OF {0} EMPLOYEE ", n);
                    for (int i = 0; i < n; i++)
                    {
                    Console.WriteLine("ENTER NUMBER ,NAME ,SALARY= ");
                    Console.WriteLine("{0}St EMPLOYEE DETAILS=", (i + 1));
                        eno[i] = int.Parse(Console.ReadLine());
                        ename[i] = Console.ReadLine();
                        esalary[i] = float.Parse(Console.ReadLine());
                        count++;
                    }
                }
                public void printSalary()
                {

                    for (int i = 0; i < count; i++)
                    {
                        float GS = 0;
                        if (esalary[i] < 5000)
                        {

                            float HRA = 10 * esalary[i] / 100;
                            float TA = 5 * esalary[i] / 100;
                            float DA = 15 * esalary[i] / 100;
                            GS = esalary[i] + HRA + TA + DA;
                        }
                        else if (esalary[i] < 10000)
                        {

                            float HRA = 15 * esalary[i] / 100;
                            float TA = 10 * esalary[i] / 100;
                            float DA = 20 * esalary[i] / 100;
                            GS = esalary[i] + HRA + TA + DA;
                        }
                        else if (esalary[i] < 15000)
                        {

                            float HRA = 20 * esalary[i] / 100;
                            float TA = 15 * esalary[i] / 100;
                            float DA = 25 * esalary[i] / 100;
                            GS = esalary[i] + HRA + TA + DA;
                        }
                        else if (esalary[i] < 20000)
                        {

                            float HRA = 25 * esalary[i] / 100;
                            float TA = 20 * esalary[i] / 100;
                            float DA = 30 * esalary[i] / 100;
                            GS = esalary[i] + HRA + TA + DA;

                        }
                        else if (esalary[i] > 20000)
                        {

                            float HRA = 25 * esalary[i] / 100;
                            float TA = 20 * esalary[i] / 100;
                            float DA = 30 * esalary[i] / 100;
                            GS = esalary[i] + HRA + TA + DA;
                        }
                        Console.WriteLine("{0}st EMPLOYEE DETAILS\n EMPLOYEE NO.={1}\n NAME= " +
                            "{2}\n SALARY={3}\n GrossSalary : {4}", i,
                            eno[i], ename[i], esalary[i], GS);
                        Console.ReadLine();
                    }

                }
            }
            static void Main(string[] args)
            {
                EMPLOYEE e = new EMPLOYEE();
                e.EmpDetail();
                e.printSalary();
            }
        }
    }

