using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsEx
{
    internal class ThreadExample
    {
        static void Main()
        {
            Thread thread1 = new Thread(T1);
            Thread thread2 = new Thread(T1);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Both threads have completed their work.");
        }
        static void T1()
        {
            for (int i=1; i<=5;  i++)
            {
                Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + "is working: " +i);
                Thread.Sleep(100);//Simulate some work
            }
        }

    }
}
