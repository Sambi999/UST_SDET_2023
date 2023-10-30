using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public double ISBN { get; set; }
        public double Price { get; set; }
        public string? Availability { get; set; }
        public void SearchBook()
        {
            Console.WriteLine("Enter the book to be searched");
            string? BookName = Console.ReadLine();
            if (BookName.Equals(Title))
            {
                Console.WriteLine("Book available");

            }
            else
            {
                Console.WriteLine("Book not available");

            }

        }
        public void DisplayBook()
        {
            Console.WriteLine("Title:" + Title + " Author : " + Author + " ISBN: " + ISBN + " Price : " + Price + " Availability : " + Availability);
        }
        
        
    }
}
