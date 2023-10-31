using Basic_Programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExcepHandling
    {
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        /*
        public void Divide()
        {
            try
            {
                int[] num = { 10, 20, 30 };
                int res = Num1 / Num2;
                Console.WriteLine(res);

                for (int i = 0; i <= 3; i++)
                {
                    res = num[i] / Num2;
                    Console.WriteLine(res);
                }
            }*/

        public void NumCheck()
        {
            
            if (Num1 >= 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Num1Exception(MyExceptions.exmessageslist["NotHun"]);
            }
        }
        public void NumCheck2()
        { 
            if (Num2 < 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Num2exception(MyExceptions.exmessageslist["NotHun1"]);

            }

        }


       
            /*
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine("Dont give 0 for Denom");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Write(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }

        }

        /*
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public void Divide()
        {
            try
            {
                //int[] num = { 10, 20, 30 };
                double res = Num1 / Num2;
                Console.WriteLine(res);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine("Dont give 0 for Denom");
            }
            
        }*/

    }
}
