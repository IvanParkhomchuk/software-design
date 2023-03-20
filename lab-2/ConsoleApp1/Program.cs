using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money amount = new Money(10, 99); // create a new Money object with whole part 10 and penny part 99

            amount.ShowSum(); // output the amount as a decimal value

            amount.SetWholePart(20); // set the whole part to 20

            amount.SetFractionalPart(50); // set the penny part to 50

            amount.ShowSum(); // output the updated amount as a decimal value

            // Create some products
            Product apple = new Product("Apple", 1.50M, 10);
            Product banana = new Product("Banana", 2.00M, 5);
            Product cherry = new Product("Cherry", 3.00M, 2);

            // Create a warehouse
            Warehouse warehouse = new Warehouse();

            // Add the products to the warehouse
            warehouse.AddProduct(apple);
            warehouse.AddProduct(banana);
            warehouse.AddProduct(cherry);

            // Show the initial state of the warehouse
            Reporting reporting = new Reporting();
            reporting.ShowProducts(warehouse);

            // Sell some products
            warehouse.SellProduct(apple, 5);
            warehouse.SellProduct(banana, 3);

            // Show the updated state of the warehouse
            reporting.ShowProducts(warehouse);

            Console.ReadLine();
        }
    }
}
