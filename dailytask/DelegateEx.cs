using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class DelegateEx
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Add(int num1, int num2)
        {
            Num1 += num1;
            Num2 += num2;
            Console.WriteLine(Num1 + Num2);
        }
        public void Sub(int num1, int num2)
        {
            Num1 += num1;
            Num2 += num2;
            Console.WriteLine(Num1 - Num2);
        }
        public int AddR(int num1, int num2)
        { 


            Num1 += num1;
            Num2 += num2;
            return(Num1 + Num2);
        }
            public static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
    }
}
