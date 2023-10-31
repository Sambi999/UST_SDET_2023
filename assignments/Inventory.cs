using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Inventory<T>
    {
        private List<Products<T>> products = new List<Products<T>>();

        public void AddProduct(Products<T> product)
        {
            products.Add(product);
        }
        public bool UpdateProduct(int productid, string? productName, double price, int stockInQuantity)
        {
            Products<T> pro = products.Find(x => x.ProductId == productid);
            if (pro != null)
            {
                pro.ProductName = productName;
                pro.Price = price;
                pro.QuantityInStock = stockInQuantity;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool DeleteProduct(int productid)
        {
            Products<T> prod = products.Find(x => x.ProductId == productid);
            if (prod != null)
            {
                products.Remove(prod);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Products<T> FindProductById(int productid)
        {
            return products.Find(x => x.ProductId == productid);
        }
        public List<Products<T>> FindProductByName(string name)
        {
            return products.FindAll(y => y.ProductName == name);
        }
    }
}
