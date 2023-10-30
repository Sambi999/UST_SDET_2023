using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        private string? CustomerName;
        private int CustomerId;
        private string? PhoneNumber;

        public string? CustomerName1
        {
            get => CustomerName;
            set => CustomerName = value;
        }
        public int CustomerId1
        {
            get => CustomerId;
            set => CustomerId = value;
        }
        public string? PhoneNumber1
        {
            get => PhoneNumber;
            set => PhoneNumber = value;
        }

        public void AddCustomerDetails(string? details)
        {
            PhoneNumber1 = details;
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer ID: " + CustomerId1 + "Customer Name: "
                + CustomerName1 + " Contact Number : " + PhoneNumber1);
        }



    }
}
