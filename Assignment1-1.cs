using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
      class Program
    {
        static void Main()
        {
            Console.Write(" ENTER A 1st  NUMBER=");
            int num1=Convert.ToInt32( Console.ReadLine());
            Console.Write(" ENTER A 2st  NUMBER=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
          
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1*num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
            Console.ReadLine();
            
        }
        
    }
}
