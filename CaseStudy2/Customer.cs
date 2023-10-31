using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    internal class Customer
    {
        //private int customerId;
        //private string? customerName;
        //private string? contactDetails;

        public Customer(int customerId, string? customerName, string? contactDetails)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            ContactDetails = contactDetails;
        }

        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactDetails { get; set; }
        public List<Order>? PlacedOrders = new();
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer ID: {0}\nCustomer Name: {1}\nCustomer Details: {2}", CustomerId, CustomerName, ContactDetails);
        }

    }




}


