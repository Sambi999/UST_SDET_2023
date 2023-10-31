using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal abstract class Vehicle
    {
        public int Vehnum { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? type {  get; set; }
        public abstract string? setTypeForVeh();
        public void Disp()
        {
            Console.WriteLine(Vehnum + " " + Brand + " " + Model);
        }
    }
}
