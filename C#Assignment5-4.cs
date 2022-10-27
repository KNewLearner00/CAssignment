using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PushPopStore
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push("5432");

            s.Push("RM");

            s.Push(980.89);

            s.Push(182);

            s.Push("XYZ");

            s.Push(345.67f);

            s.Push(234578.90D);

            foreach (object obj in s)

            {
                WriteLine(obj);
            }

            WriteLine("\n");

            WriteLine("Popping the element from stack {0}", s.Pop());

            ReadLine();
        }
    }
}

