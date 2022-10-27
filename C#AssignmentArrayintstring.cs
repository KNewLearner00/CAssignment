using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerStringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter size of an array");

            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            string[] stringarray = new string[size];

            Console.WriteLine("Enter int type element in array\n");


            for (int i = 0; i < size; i++)

            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOutput before applying any method \n");

            foreach (int value in arr)

            {
                Console.Write(value + "  ");

            }
            Console.WriteLine("\n");

            int[] arr2 = new int[size];

            Array.Copy(arr, arr2, size);//Copy() Method


            Console.WriteLine("After copying one array in array2\n");

            foreach (int val in arr2)
            {
                Console.Write(val + "  ");

            }

            Console.WriteLine("\nafter clearing array2\n");

            Array.Clear(arr2, 0, size);//clear method to clear array2


            foreach (int val in arr2)

            {
                Console.Write(val + "  ");

            }

            Console.WriteLine();

            Array.Reverse(arr);//After reversing array

            foreach (int val in arr)
            {
                Console.Write(val + "  ");
            }


            Console.WriteLine("\n");

            Array.Sort(arr);//sorting array

            Console.WriteLine("\nAfter Sorting array\n");

            foreach (int val in arr)
            {
                Console.Write(val + "  ");
            }

            Console.WriteLine("\nInsert string in string array\n");

            for (int i = 0; i < size; i++)

            {
                stringarray[i] = Console.ReadLine();
            }

            Console.WriteLine("Output of String_array before appplying any method\n");

            foreach (string ele in stringarray)
            {
                Console.Write(ele + "  ");
            }

            Console.WriteLine("\n");

            Array.Reverse(stringarray);

            Console.WriteLine("After Reversing string array\n");

            foreach (string element in stringarray)

            {
                Console.Write(element + "  ");
            }

            Console.WriteLine("\n");



            Array.Sort(stringarray);

            Console.WriteLine("\nAfter sorting  string_array\n");

            foreach (string element in stringarray)

            {
                Console.Write(element + "  ");
            }

            Console.WriteLine("\n");


            string[] stringarray2 = new string[size];

            Array.Copy(stringarray, stringarray2, size);

            Console.WriteLine("\nAfter copying  array_string into array_string2\n");


            foreach (string ele in stringarray2)

            {
                Console.Write(ele + "  ");

            }

            Console.WriteLine("\nafter clearing\n");

            Array.Clear(stringarray, 0, size);

            foreach (string ele in stringarray)

            {
                Console.Write(ele + "  ");

            }
             Console.ReadLine();

        }
    }
}


