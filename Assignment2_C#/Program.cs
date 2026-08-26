using System;
using System.Collections.Generic;
using Assignment2_C_.classes;

namespace Assignment2_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };

            ProductService service = new ProductService();

            #region Task 1: All Electronics products
            //Console.WriteLine("--- Electronics ---");
            //List<Product> electronics = service.SearchProducts(catalog, p => p.Category == "Electronics");
            //foreach (var p in electronics)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

            
            //Console.WriteLine("\n--- Under $50 ---");
            //List<Product> under50 = service.SearchProducts(catalog, p => p.Price < 50);
            //foreach (var p in under50)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

           
            //Console.WriteLine("\n--- In Stock ---");
            //List<Product> inStock = service.SearchProducts(catalog, p => p.Stock > 0);
            //foreach (var p in inStock)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

            //Console.WriteLine("\n--- Clothing Under $100 ---");
            //List<Product> clothingUnder100 = service.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
            //foreach (var p in clothingUnder100)
                //Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

            #endregion



            #region Task 3.1: Print Report

            // Scenario 1: Short Report
            Console.WriteLine("--- Short Report ---");
            service.PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

            // Scenario 2: Detailed Report
            Console.WriteLine("\n--- Detailed Report ---");
            service.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));
            #endregion
            #region Task 3.2: Transform Products

            // Scenario 3: Summary List
            Console.WriteLine("--- Summary List ---");
            List<string> summaries = service.TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
            foreach (var s in summaries)
                Console.WriteLine(s);

            // Scenario 4: Price Label
            Console.WriteLine("\n--- Price Labels ---");
            List<string> labels = service.TransformProducts(catalog, p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}");
            foreach (var l in labels)
                Console.WriteLine(l);
            #endregion

        }
    }
}