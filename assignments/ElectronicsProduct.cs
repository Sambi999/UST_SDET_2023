using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ElectronicsProduct : Product
    {
        public ElectronicsProduct(int warrantyPeriod, string? productName, double price, int quantity) : base(productName, price, quantity)
        {
            WarrantyPeriod = warrantyPeriod;

        }



        public int WarrantyPeriod { get; set; }
        public void ElectronicsProductDisplay()
        {
            Console.WriteLine("Warranty : " + WarrantyPeriod);
        }
    }

}
