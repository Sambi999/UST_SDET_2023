using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    internal class PhysicalProduct : Product
    {
        public PhysicalProduct(int productId, string? name, double price, int stockQuantity, double weight, string? dimensions) : base(productId, name, price, stockQuantity)
        {
            Weight = weight;
            Dimensions = dimensions;
        }
        public double Weight { get; set; }
        public string? Dimensions { get; set; }
    }
}

