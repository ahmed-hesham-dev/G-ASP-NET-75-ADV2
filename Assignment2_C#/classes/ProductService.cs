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

    }
}
