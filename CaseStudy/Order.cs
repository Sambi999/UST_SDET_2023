using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order:Customer
    {
        public int OrderId { get; set; }

        public Book? Books { get; set; }


        public void PlaceOrder(Book book)
        {
            Console.WriteLine("Ordering by: " + CustomerName1, CustomerId1);
            Console.WriteLine("Book Ordered : " + book.Title, book.Author);
        }
        public double CalculateCost(Book book)
        {
            double totalCost = book.Price;
            return totalCost;
        }

    }
}

