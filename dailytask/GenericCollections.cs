using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenericCollections
    {
        /*   
           public void ListHandling()
           {
               List<int> numbers = new List<int>();

               numbers.Add(100);
               numbers.Add(200);
               numbers.Add(130);

               /*for (int i = 0; i < arrayList.Count; i++)
               {
                   Console.WriteLine(arrayList[i]);
               }*/
        /*
               numbers.Add(66);
               numbers.Add(55);
               numbers.Add(1234);

               foreach (int item in numbers)
               {
                   Console.WriteLine(item);
               }
               numbers.Reverse();
               foreach (int item in numbers)
               {
                   Console.WriteLine(item);
               }

               numbers.RemoveAt(3);
               foreach (int item in numbers)
               {
                   Console.WriteLine(item);
               }
               numbers.Sort();
               foreach (int item in numbers)
               {
                   Console.WriteLine(item);
               }
               Console.WriteLine(numbers.Contains(100));
               Console.WriteLine(numbers.IndexOf(200));
               numbers.Clear();
               foreach (int item in numbers)
               {
                   Console.WriteLine(item);
               }



           }
           */
        /*
        public void Stackhandling()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push("GG");
            st.Push(12.34);
            st.Push(66);
            st.Push(99);
            foreach (int item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pop " + st.Pop());
            foreach (int item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek" + st.Peek());
            foreach (int item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + st.Count);

        }*/
        public void Dicthandling()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "30");
            dict.Add(5, "AA");
            dict.Add(4, "BB");

            foreach (int item in dict.Keys)
            {
                Console.WriteLine(dict.ElementAt(item));
            }
            dict.Remove(3);
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dict.ContainsKey(6));
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + dict.Count);

        }
        /*public void SLHandling()
        {
            SortedList sl = new SortedList();

            sl.Add(3, 30);
            sl.Add(4, "AA");

            sl.Add(1, 10);
            sl.Add(2, 20);
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }

        }*/
    }


}
