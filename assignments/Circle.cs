using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    public class Circle :Shape, IDrawable
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public void Draw()
        {
            Console.WriteLine("Circle");
            Console.WriteLine($"Area:{CalculateArea()}");
            Console.WriteLine($"Perimeter:{CalculatePerimeter()}");

        }
    }
    
}
