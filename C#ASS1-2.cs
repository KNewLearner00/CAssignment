using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
 class Array
    {

        public static void main()
        {
            int[] a = int[10];
            int i, n, sum = 0;
            Console.WriteLine(" Sum of the Array.");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" input the 10");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum += a[i];
    
        }
            Console.WriteLine("sum of all element=", sum);
    
        }
    }


}
