using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IProduct // ISP - Interface segregate the methods that the classes implementing them should have. This allows clients to depend on smaller interfaces rather than larger ones, which promotes loose coupling and easier maintenance.
    {                  // DIP - Also Warehouse class depends on an abstraction (IWarehouse interface) rather than a concrete implementation. This allows for easier maintenance, testing, and swapping of implementations.
        void ReducePrice(decimal amount);
        void IncreasePrice(decimal amount);
        void ReduceQuantity(int amount);
        void IncreaseQuantity(int amount);
    }

    public class Product : IProduct // SRP - class Product has a single responsibility of representing a product.
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ReducePrice(decimal amount)
        {
            Price -= amount;
        }

        public void IncreasePrice(decimal amount)
        {
            Price += amount;
        }

        public void ReduceQuantity(int amount)
        {
            Quantity -= amount;
        }

        public void IncreaseQuantity(int amount)
        {
            Quantity += amount;
        }
    }
}
