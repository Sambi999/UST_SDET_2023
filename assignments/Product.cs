using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Product
    {
        private string? productName;
        private double price;
        private double quantity;

        public Product(string? productName, double price, double quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public string? ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public double SetPrice(double newPrice)
        {

            this.Price = newPrice;
            return newPrice;
        }
        public double ProductValue()
        {
            double totalvalue = price * quantity;
            return totalvalue;
        }
    }

}
    
