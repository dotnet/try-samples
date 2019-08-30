using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Try101LinqSamples
{
    public class Projections
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int SelectSyntax()
        {
            #region select-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne = from n in numbers 
                              select n + 1;

            Console.WriteLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }
            return 0;
            #endregion
        }

        public int SelectProperty()
        {
            #region select-property
            List<Product> products = GetProductList();

            var productNames = from p in products
                               select p.ProductName;

            Console.WriteLine("Product Names:");
            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }
            #endregion
            return 0;
        }

        public int TransformWithSelect()
        {
            #region select-transform
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = from n in numbers
                           select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }
            #endregion
            return 0;
        }

        public int SelectByCaseAnonymous()
        {
            #region select-case-anonymous
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords = from w in words
                                  select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
            }
            #endregion
            return 0;
        }

        public int SelectByCaseTuple()
        {
            #region select-case-tuple
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords = from w in words
                                  select (Upper : w.ToUpper(), Lower : w.ToLower());

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
            }
            #endregion
            return 0;
        }

        public int SelectAnonymousConstructions()
        {
            #region select-new-type
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitOddEvens = from n in numbers
                                select new { Digit = strings[n], Even = (n % 2 == 0) };

            foreach (var d in digitOddEvens)
            {
                Console.WriteLine($"The digit {d.Digit} is {(d.Even ? "even" : "odd")}.");
            }
            #endregion
            return 0;
        }

        public int SelectTupleConstructions()
        {
            #region select-new-type-tuple
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitOddEvens = from n in numbers
                                select (Digit : strings[n], Even : (n % 2 == 0));

            foreach (var d in digitOddEvens)
            {
                Console.WriteLine($"The digit {d.Digit} is {(d.Even ? "even" : "odd")}.");
            }
            #endregion
            return 0;
        }

        public int SelectPropertySubset()
        {
            #region select-subset-properties
            List<Product> products = GetProductList();

            var productInfos = from p in products
                               select (p.ProductName, p.Category, Price : p.UnitPrice);

            Console.WriteLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                Console.WriteLine($"{productInfo.ProductName} is in the category {productInfo.Category} and costs {productInfo.Price} per unit.");
            }
            #endregion
            return 0;
        }

        public int SelectWithIndex()
        {
            #region select-with-index
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace = numbers.Select((num, index) => (Num : num, InPlace : (num == index)));

            Console.WriteLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine($"{n.Num}: {n.InPlace}");
            }
            #endregion
            return 0;
        }

        public int SelectWithWhere()
        {
            #region select-with-where
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNums = from n in numbers
                          where n < 5
                          select digits[n];

            Console.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
            #endregion
            return 0;
        }

        public int SelectFromMultipleSequences()
        {
            #region select-many-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select (a, b);

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b}");
            }
            #endregion
            return 0;
        }

        public int SelectFromChildSequence()
        {
            #region select-many-drilldown
            List<Customer> customers = GetCustomerList();

            var orders = from c in customers
                         from o in c.Orders
                         where o.Total < 500.00M
                         select (c.CustomerID, o.OrderID, o.Total);

            foreach(var order in orders)
            {
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total value: {order.Total}");
            }
            #endregion
            return 1;
        }

        public int SelectManyWithWhere()
        {
            #region select-many-filter
            List<Customer> customers = GetCustomerList();

            var orders = from c in customers
                         from o in c.Orders
                         where o.OrderDate >= new DateTime(1998, 1, 1)
                         select (c.CustomerID, o.OrderID, o.OrderDate);

            foreach (var order in orders)
            {
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total date: {order.OrderDate.ToShortDateString()}");
            }
            #endregion
            return 0;
        }

        public int SelectManyWhereAssignment()
        {
            #region select-many-assignment
            List<Customer> customers = GetCustomerList();

            var orders = from c in customers 
                         from o in c.Orders
                         where o.Total >= 2000.0M
                         select (c.CustomerID, o.OrderID, o.Total);

            foreach (var order in orders)
            {
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total value: {order.Total}");
            }
            #endregion
            return 0;
        }

        public int SelectMultipleWhereClauses()
        {
            #region multiple-where-clauses
            List<Customer> customers = GetCustomerList();

            DateTime cutoffDate = new DateTime(1997, 1, 1);

            var orders = from c in customers
                         where c.Region == "WA"
                         from o in c.Orders
                         where o.OrderDate >= cutoffDate
                         select (c.CustomerID, o.OrderID);

            foreach (var order in orders)
            {
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}");
            }
            #endregion
            return 0;
        }

        public int IndexedSelectMany()
        {
            #region indexed-select-many
            List<Customer> customers = GetCustomerList();

            var customerOrders =
                customers.SelectMany(
                    (cust, custIndex) =>
                    cust.Orders.Select(o => "Customer #" + (custIndex + 1) +
                                            " has an order with OrderID " + o.OrderID));

            foreach (var order in customerOrders)
            {
                Console.WriteLine(order);
            }
            #endregion
            return 0;
        }
    }
}
