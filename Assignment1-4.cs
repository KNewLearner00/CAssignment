using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Swaping
    {
        public static void Main()
        {
            int n1, n2, temp;
            Console.Write("\nInput the First Number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            n2 = int.Parse(Console.ReadLine());
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + n1);
            Console.Write("\nSecond Number : " + n2);
            Console.Read();
        }
    }
}


