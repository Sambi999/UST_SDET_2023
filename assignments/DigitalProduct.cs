using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class DigitalProduct : ElectronicsProduct
    {
        public string? FileFormat { get; set; }
        public DigitalProduct(int warrantyPeriod, string? productName, double price, int quantity, string? fileFormat)
            :base(warrantyPeriod, productName, price, quantity)
        {
        
            FileFormat = fileFormat;
        }
        public void DisplayDigitalProduct()
        {
            Console.WriteLine("File format: " + FileFormat);
        }
    }
}
