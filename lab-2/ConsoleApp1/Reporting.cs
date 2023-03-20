using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reporting
    {
        public void Invoice(Product product)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price per unit: {product.Price}");
            Console.WriteLine($"Quantity: {product.Quantity}");
            Console.WriteLine($"Total price: {product.Quantity * product.Price}");
        }

        public void ReceiptInvoice(Product product)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Receipt Invoice");
            Invoice(product);
        }

        public void ExpenditureInvoice(Product product, int amount)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Expenditure Invoice");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price per unit: {product.Price}");
            Console.WriteLine($"Quantity: {amount}");
            Console.WriteLine($"Total price: {amount * product.Price}");
        }

        public void ShowProducts(Warehouse warehouse)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Warehouse");
            foreach (Product product in warehouse.products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
    }
}
