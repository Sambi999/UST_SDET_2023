using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {
        /*
       public static List<string> exmessageslist = new List<string>()
        {
            "Dont give 0 for Denom ",
            "Index is out of Range",
            "Unknown Exception"
        };*/

        public static Dictionary<string, string> exmessageslist =
            new Dictionary<string, string>()
            {
                {"NotHun", "Age is less" },
                { "NotHun1", "Age is more"}
            };
        
       
        //exmessageslist.Add("IOR", "Index is out of Range");
        //exmessageslist.Add("Div 0", "Dont give 0 for Denom");
        //exmessageslist.Add("UE", "Unknown Exception");
        //exmessageslist.Add("NotHun", "Age is less");
        //exmessageslist.Add("NotHun1", "Age is more");


    }
    internal class Num1Exception : Exception
    {
        public Num1Exception(string message) : base(message)
        {

        }
    }
    internal class Num2exception : Exception
    {
        public Num2exception(string message) : base(message)
        {

        }
    }

}
        


