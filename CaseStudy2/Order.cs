using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    internal class Order
    {
        public Order(int orderId, Customer customer, Product product, int quantity, double totalAmount, bool isPaid, bool isDelivered)
        {
            OrderId = orderId;
            Customer = customer;
            Product = product;
            Quantity = quantity;
            TotalAmount = totalAmount;
            IsPaid = isPaid;
            IsDelivered = isDelivered;
        }
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDelivered { get; set; }
    }
}

