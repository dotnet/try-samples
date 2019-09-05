using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Try101LinqSamples
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Order[] Orders { get; set; }
        public override string ToString() => 
            $"{CustomerID} {CompanyName}\n{Address}\n{City}, {Region} {PostalCode} {Country}\n{Phone}";
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public override string ToString() => $"{OrderID}: {OrderDate:d} for {Total:C2}";
    }

    public static class Customers
    {
        public static List<Customer> CustomerList { get; } =
            (from e in XDocument.Parse(InputValues.CustomersXml).Root.Elements("customer")
             select new Customer
             {
                 CustomerID = (string)e.Element("id"),
                 CompanyName = (string)e.Element("name"),
                 Address = (string)e.Element("address"),
                 City = (string)e.Element("city"),
                 Region = (string)e.Element("region"),
                 PostalCode = (string)e.Element("postalcode"),
                 Country = (string)e.Element("country"),
                 Phone = (string)e.Element("phone"),
                 Orders = (
                    from o in e.Elements("orders").Elements("order")
                    select new Order
                    {
                        OrderID = (int)o.Element("id"),
                        OrderDate = (DateTime)o.Element("orderdate"),
                        Total = (decimal)o.Element("total")
                    }).ToArray()
             }).ToList();
    }
}
