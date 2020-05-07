using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Try101LinqSamples
{
    public class Quantifiers
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int AnyMatchingElements()
        {
            #region any-matches
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine($"There is a word that contains in the list that contains 'ei': {iAfterE}");
            #endregion
            return 0;
        }

        public int GroupedAnyMatchedElements()
        {
            #region any-grouped
            List<Product> products = GetProductList();
            var productGroups = from p in products
                                group p by p.Category into g
                                where g.Any(p => p.UnitsInStock == 0)
                                select (Category: g.Key, Products: g);
            
            foreach(var group in productGroups)
            {
                Console.WriteLine(group.Category);
                foreach(var product in group.Products)
                {
                    Console.WriteLine($"\t{product}");
                }
            }
            #endregion
            return 0;
        }

        public int AllMatchedElements()
        {
            #region all-match
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine($"The list contains only odd numbers: {onlyOdd}");
            #endregion
            return 0;
        }

        public int GroupedAllMatchedElements()
        {
            #region all-grouped
            List<Product> products = GetProductList();

            var productGroups = from p in products
                                group p by p.Category into g
                                where g.All(p => p.UnitsInStock > 0)
                                select (Category: g.Key, Products: g);

            foreach (var group in productGroups)
            {
                Console.WriteLine(group.Category);
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"\t{product}");
                }
            }
            #endregion
            return 0;
        }
    }
}
