using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class FictionBook : Book
    {
        public string? Category { get; set; }
        public void DisplayFictionDetails()
        {
            Console.WriteLine("Category : " + Category);
        }

        public void SearchFictionBook()
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
