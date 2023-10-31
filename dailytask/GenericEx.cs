using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    //internal class Generic<T>
    internal interface GenericEx<T> where T : Exception
    {
       
        /*
        private T[] arr;
        public GenericEx(T[] arr)
        {
            Arr = arr;
        }
        public T[] Arr { get => arr; set => arr = value; }
        public void Disp()
        {
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
                //return item;
            }
        }*/
        /*
        private T val1, val2;
        public GenericEx(T val1, T val2)
        {
            Val1 = val1;
            Val2 = val2;
        }
        public T Val1 { get => val1; set => val1 = value; }
        public T Val2 { get => val2; set => val2 = value; }
        
        */
    }
}
