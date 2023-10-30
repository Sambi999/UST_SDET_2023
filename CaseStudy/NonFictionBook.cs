using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class NonFictionBook : Book
    {
        public int Edition { get; set; }

        public void DisplayNonFictionDetails()
        {
            Console.WriteLine("Edition : " + Edition);
        }

        public void SearchNonFictionBook()
        {
            Console.WriteLine("Enter the book to be searched");
            string? BookName = Console.ReadLine();
            if (BookName.Equals(Title))
            {
                Console.WriteLine("book available");
            }
            else
            {
                Console.WriteLine("book Not Available");
            }



        }



    }
}
