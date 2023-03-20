using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IWarehouse // ISP - Interface segregate the methods that the classes implementing them should have. This allows clients to depend on smaller interfaces rather than larger ones, which promotes loose coupling and easier maintenance.
    {
        void AddProduct(Product product);
        void SellProduct(Product product, int amount);
        void SellProduct(Product product);
        void RemoveProduct(Product product);
    }

    public class Warehouse : IWarehouse // OCP - class is open for extension (e.g., by adding more methods) but closed for modification. This allows the class to be easily extended without affecting its existing functionality.
    {
        public List<Product> products = new List<Product>();
        Reporting reporting = new Reporting();

        public void AddProduct(Product product)
        {
            Product searchedProduct = products.FirstOrDefault(p => p.Name == product.Name);

            if (products.Exists(p => p.Name == product.Name))
            {
                searchedProduct.IncreaseQuantity(product.Quantity);
            }
            else
            {
                products.Add(product);
            }

            reporting.ReceiptInvoice(product);
        }

        public void SellProduct(Product product, int amount) 
        {
            if (amount < product.Quantity)
            {
                product.Quantity -= amount;
            } else if (amount == product.Quantity) {
                RemoveProduct(product);
            }

            int totalQuantity = product.Quantity - amount;

            reporting.ExpenditureInvoice(product, amount);
        }

        public void SellProduct(Product product)
        {
            RemoveProduct(product);
            reporting.ExpenditureInvoice(product, product.Quantity);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
    }
}
