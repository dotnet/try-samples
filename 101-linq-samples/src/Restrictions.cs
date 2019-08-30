using System;
using System.Collections.Generic;
using System.Linq;

namespace Try101LinqSamples
{
    public class Restrictions
    {
        public List<Product> GetProductList() => Products.ProductList;

        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int LowNumbers()
        {
            #region where-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
            #endregion
            return 0;
        }

        public int ProductsOutOfStock()
        {
            #region where-property
            List<Product> products = GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine($"{product.ProductName} is sold out!");
            }
            #endregion
            return 0;
        }

        public int ExpensiveProductsInStock()
        {
            #region where-multiple-properties
            List<Product> products = GetProductList();

            var expensiveInStockProducts = from prod in products
                                           where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                                           select prod;

            Console.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00.");
            }
            #endregion
            return 0;
        }

        public int DisplayCustomerOrders()
        {
            #region where-drilldown
            List<Customer> customers = GetCustomerList();

            var waCustomers = from cust in customers
                              where cust.Region == "WA"
                              select cust;

            Console.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                Console.WriteLine($"Customer {customer.CustomerID}: {customer.CompanyName}");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine($"  Order {order.OrderID}: {order.OrderDate}");
                }
            }
            #endregion
            return 0;
        }

        public int IndexedWhere()
        {
            #region where-indexed
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($"The word {d} is shorter than its value.");
            }
            #endregion
            return 0;
        }
    }
}
