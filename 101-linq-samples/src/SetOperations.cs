using System;
using System.Collections.Generic;
using System.Linq;

namespace Try101LinqSamples
{
    public class SetOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int DistinctSyntax()
        {
            #region distinct-syntax
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            var uniqueFactors = factorsOf300.Distinct();

            Console.WriteLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                Console.WriteLine(f);
            }
            #endregion
            return 0;
        }

        public int DistinctPropertyValues()
        {
            #region distinct-property-values
            List<Product> products = GetProductList();

            var categoryNames = (from p in products
                                 select p.Category)
                                 .Distinct();

            Console.WriteLine("Category names:");
            foreach (var n in categoryNames)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int UnionSyntax()
        {
            #region union-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
    }
}
