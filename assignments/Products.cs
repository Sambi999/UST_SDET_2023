using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Products<T>
    {
        public Products(int productId, string? productName, double price, int quantityInStock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
