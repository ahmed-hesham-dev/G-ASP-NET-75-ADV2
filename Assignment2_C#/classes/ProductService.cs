using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_C_.classes
{
    internal class ProductService
    {

        public List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;

        }
        public List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        {
            List<string> result = new List<string>();
            foreach (Product product in products)
            {
                result.Add(transform(product));   
            }
            return result;
        }
        public void PrintReport(List<Product> products, Action<Product> printAction)
        {
            foreach (Product product in products)
            {
                printAction(product);   
            }
        }
    }
}
