using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStructureEnum1_6
{
    public enum BookType
    {
        Magazine,
        Novel,
        ReferenceBook,
        Miscellaneous
    }
    struct Book
    {
        public string bookId;
        public string title;
        public string booktype;
        public string price;

    }
    public class AboutBook
    {
        public static void Main()
        {
            int Nobook = 50;
            Book[] books = new Book[Nobook];
            int i, j, num, t = 0;
            Console.Write("Enter the number of book to be stored : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter {0} elements in the array \n\n", num);

            for (j = 0; j < num; j++)
            {
                Console.WriteLine("Information of book {0} :", t);

                Console.Write("Enter Id of the book : ");
                books[j].bookId = Console.ReadLine();

                Console.Write("Enter Title of the book : ");
                books[j].title = Console.ReadLine();


                Console.WriteLine("**************************************");


                Console.WriteLine("Select Type of the book : ");

                foreach (int b in Enum.GetValues(typeof(BookType)))

                    Console.WriteLine((BookType)b);



                Console.Write("Enter Book Type : ");

                //actionbook = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine((BookType)actionbook);

                books[j].booktype = Console.ReadLine();


                Console.WriteLine("**************************************");

                Console.Write("Enter the Price of the book : ");
                books[j].price = Console.ReadLine();
                t++;
                Console.WriteLine();
            }

            for (i = 0; i < num; i++)
            {
                Console.WriteLine("{0}: BookId = {1},  Title = {2} ,BookType = {3}, Price = {4} ", i + 1, books[i].bookId, books[i].title, books[i].booktype, books[i].price);
               
                Console.ReadLine();
            }
        }
    }
}
       
            
   

    


