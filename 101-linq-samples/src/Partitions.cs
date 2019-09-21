using System;
using System.Collections.Generic;
using System.Linq;

namespace Try101LinqSamples
{
    public class Partitions
    {
        public List<Product> GetProductList() => Products.ProductList;

        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int TakeSyntax()
        {
            #region take-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int NestedTake()
        {
            #region nested-take
            List<Customer> customers = GetCustomerList();

            var first3WAOrders = ( 
                from cust in customers
                from order in cust.Orders
                where cust.Region == "WA"
                select (cust.CustomerID, order.OrderID, order.OrderDate))
                .Take(3);

            Console.WriteLine("First 3 orders in WA:");
            foreach (var order in first3WAOrders)
            {
                Console.WriteLine(order);
            }
            #endregion
            return 0;

        }

        public int SkipSyntax()

        {
            #region skip-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var allButFirst4Numbers = numbers.Skip(4);

            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int NestedSkip()
        {
            #region nested-skip
            List<Customer> customers = GetCustomerList();

            var waOrders = from cust in customers
                           from order in cust.Orders
                           where cust.Region == "WA"
                           select (cust.CustomerID, order.OrderID, order.OrderDate);

            var allButFirst2Orders = waOrders.Skip(2);

            Console.WriteLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
            {
                Console.WriteLine(order);
            }
            #endregion
            return 1;
        }

        public int TakeWhileSyntax()
        {
            #region takewhile-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
            #endregion
            return 0;
        }

        public int IndexedTakeWhile()
        {
            #region indexed-takewhile
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

            Console.WriteLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int SkipWhileSyntax()
        {
            #region skipwhile-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // In the lambda expression, 'n' is the input parameter that identifies each
            // element in the collection in succession. It is is inferred to be
            // of type int because numbers is an int array.
            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int IndexedSkipWhile()
        {
            #region indexed-skipwhile
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

    }
}
