using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ClothingProduct : Product
    {
        public string? Size { get; set; }
        public ClothingProduct(string? productName, double price, int quantity, string? size)
            : base(productName, price, quantity)
        {
            Size = size;
        }
        public void DisplayClothing()
        {
            Console.WriteLine("Size :" + Size);
        }
    }
}
