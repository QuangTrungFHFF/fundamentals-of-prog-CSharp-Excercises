using System;
using System.Collections.Generic;

namespace Exercise05
{
    /// <summary>
    /// A big chain of supermarkets sell millions of products. 
    /// Each of them has a unique number (barcode), producer, name and price. 
    /// What data structure could we use in order to quickly find all products, which cost between 5 and 10 dollars?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var products = new SortedSet<Product>();
            Product product;
            var rnd = new RandomProducts();
            for(int i =0; i<10000;i++)
            {
                product = rnd.Random();
                products.Add(product);
            }
            var items = new SortedSet<Product>();
            var lower = new Product("BSD1000000", " ", " ", 5.0);
            var upper = new Product("BSD9999999", " ", " ", 10.0);
            items = products.GetViewBetween(lower, upper);
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
