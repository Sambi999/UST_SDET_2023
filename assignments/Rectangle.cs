using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace assignments
{
    public class Rectangle : Shape, IDrawable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
        public void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine($"Area:{CalculateArea()}");
            Console.WriteLine($"Perimeter:{CalculatePerimeter()}");
        }
    }
}
