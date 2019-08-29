using System;

namespace Try101LinqSamples
{
    class Program
    {
        ///<param name="region">Takes in the --region option from the code fence options in markdown</param>
        ///<param name="session">Takes in the --session option from the code fence options in markdown</param>
        ///<param name="package">Takes in the --package option from the code fence options in markdown</param>
        ///<param name="project">Takes in the --project option from the code fence options in markdown</param>
        ///<param name="args">Takes in any additional arguments passed in the code fence options in markdown</param>
        ///<see>To learn more see <a href="https://aka.ms/learntdn">our documentation</a></see>
        static int Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            return region switch
            {
                "where-syntax"              => new Restrictions().LowNumbers(),
                "where-property"            => new Restrictions().ProductsOutOfStock(),
                "where-multiple-properties" => new Restrictions().ExpensiveProductsInStock(),
                "where-drilldown"           => new Restrictions().DisplayCustomerOrders(),
                "where-indexed"             => new Restrictions().IndexedWhere(),
                null                        => RunAll(),
                _                           => MissingRegionTag(region),
            };
        }

        private static int MissingRegionTag(string region)
        {
            Console.WriteLine($"No code snippet configured for {region}");
            return 1;
        }
        private static int RunAll()
        {
            new Restrictions().LowNumbers();
            new Restrictions().ProductsOutOfStock();
            new Restrictions().ExpensiveProductsInStock();
            new Restrictions().DisplayCustomerOrders();
            new Restrictions().IndexedWhere();
            return 0;
        }
    }
}
