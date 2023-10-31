using CaseStudy2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    internal class OrderFulfillment
    {
        public static List<Product>? Products = new();
        public static List<Customer>? Customers = new();
        public static List<Order>? Orders = new();
        public void PlaceOrder(Customer customer, Product product, int quantity)
        {
            if (product.StockQuantity < quantity)
            {
                throw new OrderException("Product out of stock");
            }
            double totalamount = product.Price * quantity;
            int orderid = 1;
            if (Orders != null)
            {
                orderid = Orders.Count + 1;
            }
            Order order = new(orderid, customer, product, quantity, totalamount, false, false);
            Orders?.Add(order);
            customer.PlacedOrders?.Add(order);
            Console.WriteLine("Added to cart");



        }
        public static void ShowTotalCost(Customer customer)
        {
            double totalcost = 0.0;
            if (customer.PlacedOrders != null)
            {
                foreach (var order in customer.PlacedOrders)
                {
                    totalcost += order.TotalAmount;
                }
                Console.WriteLine("Total cost: " + totalcost);
            }
        }
        public static void ProcessPayment(Customer customer, double amount)
        {
            double totalcost = 0.0;
            if (customer.PlacedOrders != null)
            {
                foreach (var order in customer.PlacedOrders)
                {
                    totalcost += order.TotalAmount;
                }
                if (amount >= totalcost)
                {
                    foreach (var order in customer.PlacedOrders)
                    {
                        order.IsPaid = true;
                        order.Product.StockQuantity -= order.Quantity;
                    }
                    Console.WriteLine("Payment success");
                }
                else
                {
                    throw new OrderException("Payment Error. Insufficient balance.");
                }
            }
        }
        public static void DeliverProduct(Customer customer, Product product)
        {
            Order? order = null;
            if (Orders != null)
            {
                foreach (var o in Orders)
                {
                    if (o.Customer == customer && o.Product == product)
                    {
                        order = o;
                        break;
                    }
                }
            }
            if (order != null && order.IsPaid)
            {
                order.IsDelivered = true;

                if (product.GetType() == typeof(PhysicalProduct))
                {
                    PhysicalProduct physicalProduct = (PhysicalProduct)product;
                    double shippingcosts = physicalProduct.Weight * 0.1;
                    Console.WriteLine("Product delivered. Shipping cost: {0}", shippingcosts);
                }
                else if (product.GetType() == typeof(DigitalProduct))
                {
                    DigitalProduct digitalProduct = (DigitalProduct)product;
                    Console.WriteLine("Digital product delivered. Download link: {0}", digitalProduct.DownloadLink);
                }
            }
            else
            {
                throw new OrderException("Error, Order not found or not paid");
            }
        }
        public static void CreateReport()
        {
            _ = new FileStream("D:\\Training Handson\\Basic Solution\\CaseStudy2\\Files\\Order_Report.txt", FileMode.Create, FileAccess.Write);

        }
        public static void DownloadReport(Order order)
        {

            FileInfo fi = new("D:\\Training Handson\\Basic Solution\\CaseStudy2\\Files\\Order_Report.txt");
            if (!fi.Exists)
            {
                CreateReport();
            }
            else
            {
                using StreamWriter str = fi.AppendText();
                str.Write("Customer: " + order.Customer.CustomerName + "  ");
                str.Write("Order ID: " + order.OrderId + "  ");
                str.Write("Product: " + order.Product.Name + "  ");
                str.Write("Paid: " + order.IsPaid + "  ");
                str.Write("Price: " + order.Product.Price);
                str.WriteLine(" ");
            }
        }

    }




}
