using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignments
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Balance { get; set; }



        public Customer(int customerId, string name,
            string phoneNumber, int balance)
        {
            CustomerId = customerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }
        public Customer() { }





        public void DisplayCustomerDetails()
        {

            Console.WriteLine("Customer Name: " + Name
            + " Customer Id: " + CustomerId +
           " Phone Number: " + PhoneNumber +
           " Balance: " + Balance);

        }

        public bool SearchCustomer(string? phoneNum, Customer customer1)
        {
            if (
                customer1.PhoneNumber.Equals(phoneNum))
            {
                return true;

            }
            else
            {
                return false;

            }
        }







    }

}
