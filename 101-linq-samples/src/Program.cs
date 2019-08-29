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

                "select-syntax"             => new Projections().SelectSyntax(),
                "select-property"           => new Projections().SelectProperty(),
                "select-transform"          => new Projections().TransformWithSelect(),
                "select-case-anonymous"     => new Projections().SelectByCaseAnonymous(),
                "select-case-tuple"         => new Projections().SelectByCaseTuple(),
                "select-new-type"           => new Projections().SelectAnonymousConstructions(),
                "select-new-type-tuple"     => new Projections().SelectTupleConstructions(),
                "select-subset-properties"  => new Projections().SelectPropertySubset(),
                "select-with-index"         => new Projections().SelectWithIndex(),
                "select-with-where"         => new Projections().SelectWithWhere(),
                "select-many-syntax"        => new Projections().SelectFromMultipleSequences(),
                "select-many-drilldown"     => new Projections().SelectFromChildSequence(),
                "select-many-filter"        => new Projections().SelectManyWithWhere(),
                "select-many-assignment"    => new Projections().SelectManyWhereAssignment(),
                "multiple-where-clauses"    => new Projections().SelectMultipleWhereClauses(),
                "indexed-select-many"       => new Projections().IndexedSelectMany(),

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
            // 1- 5
            new Restrictions().LowNumbers();
            new Restrictions().ProductsOutOfStock();
            new Restrictions().ExpensiveProductsInStock();
            new Restrictions().DisplayCustomerOrders();
            new Restrictions().IndexedWhere();

            // 6 - 19 (+ 2 for tuples)
            new Projections().SelectSyntax();
            new Projections().SelectProperty();
            new Projections().TransformWithSelect();
            new Projections().SelectByCaseAnonymous();
            new Projections().SelectByCaseTuple();
            new Projections().SelectAnonymousConstructions();
            new Projections().SelectTupleConstructions();
            new Projections().SelectPropertySubset();
            new Projections().SelectWithIndex();
            new Projections().SelectWithWhere();
            new Projections().SelectFromMultipleSequences();
            new Projections().SelectFromChildSequence(); 
            new Projections().SelectManyWithWhere();
            new Projections().SelectManyWhereAssignment();
            new Projections().SelectMultipleWhereClauses();
            new Projections().IndexedSelectMany();

            return 0;
        }
    }
}
