﻿using System;

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
                "where-syntax"                  => new Restrictions().LowNumbers(),
                "where-property"                => new Restrictions().ProductsOutOfStock(),
                "where-multiple-properties"     => new Restrictions().ExpensiveProductsInStock(),
                "where-drilldown"               => new Restrictions().DisplayCustomerOrders(),
                "where-indexed"                 => new Restrictions().IndexedWhere(),

                "select-syntax"                 => new Projections().SelectSyntax(),
                "select-property"               => new Projections().SelectProperty(),
                "select-transform"              => new Projections().TransformWithSelect(),
                "select-case-anonymous"         => new Projections().SelectByCaseAnonymous(),
                "select-case-tuple"             => new Projections().SelectByCaseTuple(),
                "select-new-type"               => new Projections().SelectAnonymousConstructions(),
                "select-new-type-tuple"         => new Projections().SelectTupleConstructions(),
                "select-subset-properties"      => new Projections().SelectPropertySubset(),
                "select-with-index"             => new Projections().SelectWithIndex(),
                "select-with-where"             => new Projections().SelectWithWhere(),
                "select-many-syntax"            => new Projections().SelectFromMultipleSequences(),
                "select-many-drilldown"         => new Projections().SelectFromChildSequence(),
                "select-many-filter"            => new Projections().SelectManyWithWhere(),
                "select-many-assignment"        => new Projections().SelectManyWhereAssignment(),
                "multiple-where-clauses"        => new Projections().SelectMultipleWhereClauses(),
                "indexed-select-many"           => new Projections().IndexedSelectMany(),

                "take-syntax"                   => new Partitions().TakeSyntax(),
                "nested-take"                   => new Partitions().NestedTake(),
                "skip-syntax"                   => new Partitions().SkipSyntax(),
                "nested-skip"                   => new Partitions().NestedSkip(),
                "takewhile-syntax"              => new Partitions().TakeWhileSyntax(),
                "indexed-takewhile"             => new Partitions().IndexedTakeWhile(),
                "skipwhile-syntax"              => new Partitions().SkipWhileSyntax(),
                "indexed-skipwhile"             => new Partitions().IndexedSkipWhile(),

                "orderby-syntax"                => new Orderings().OrderbySyntax(),
                "orderby-property"              => new Orderings().OrderbyProperty(),
                "orderby-user-types"            => new Orderings().OrderByProducts(),
                "custom-comparer"               => session switch
                {
                    "orderby-custom"                    => new Orderings().OrderByWithCustomComparer(),
                    "orderby-custom-descending"         => new Orderings().DescendingCustomComparer(),
                    "orderby-custom-thenby"             => new Orderings().ThenByCustom(),
                    "orderby-custom-descending-thenby"  => new Orderings().CustomThenByDescending(),
                    _                                   => MissingTag(session, false),
                },
                "orderby-custom-comparer"       => new Orderings().OrderByWithCustomComparer(),
                "orderbydescending-syntax"      => new Orderings().OrderByDescendingSyntax(),
                "orderby-descending-type"       => new Orderings().OrderProductsDescending(),
                "desc-custom-comparer"          => new Orderings().DescendingCustomComparer(),
                "thenby-syntax"                 => new Orderings().ThenBySyntax(),
                "thenby-custom"                 => new Orderings().ThenByCustom(),
                "thenby-ordering"               => new Orderings().ThenByDifferentOrdering(),
                "thenby-custom-descending"      => new Orderings().CustomThenByDescending(),
                "reverse"                       => new Orderings().OrderingReversal(),

                "groupby-syntax"                => new Groupings().GroupingSyntax(),
                "groupby-property"              => new Groupings().GroupByProperty(),
                "groupby-category"              => new Groupings().GroupByCategory(),
                "nested-groupby"                => new Groupings().NestedGrouBy(),
                "anagram-comparer"              => session switch
                {
                    "groupby-custom-comparer"   => new Groupings().GroupByCustomComparer(),
                    "nested-groupby-custom"     => new Groupings().NestedGroupByCustom(),
                    _                           => MissingTag(session, false),

                },
                "groupby-custom-comparer"       => new Groupings().GroupByCustomComparer(),
                "nested-groupby-custom"         => new Groupings().NestedGroupByCustom(),

                "distinct-syntax"               => new SetOperations().DistinctSyntax(),
                "distinct-property-values"      => new SetOperations().DistinctPropertyValues(),
                "union-syntax"                  => new SetOperations().UnionSyntax(),
                "union-query-results"           => new SetOperations().UnionOfQueryResults(),
                "intersect-syntax"              => new SetOperations().IntersectSynxtax(),
                "intersect-different-queries"   => new SetOperations().IntersectQueryResults(),
                "difference-of-sets"            => new SetOperations().DifferenceOfSets(),
                "difference-of-queries"         => new SetOperations().DifferenceOfQueries(),

                null                            => RunAll(),
                _                               => MissingTag(region),
            };
        }

        private static int MissingTag(string tag, bool region = true)
        {
            Console.WriteLine($"No code snippet configured for {(region ? "region" : "session")}: {tag}");
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

            // 20 - 27
            new Partitions().TakeSyntax();
            new Partitions().NestedTake();
            new Partitions().SkipSyntax();
            new Partitions().NestedSkip();
            new Partitions().TakeWhileSyntax();
            new Partitions().IndexedTakeWhile();
            new Partitions().SkipWhileSyntax();
            new Partitions().IndexedSkipWhile();

            // Ordering: 28-39
            new Orderings().OrderbySyntax();
            new Orderings().OrderbyProperty();
            new Orderings().OrderByProducts();
            new Orderings().OrderByWithCustomComparer();
            new Orderings().OrderByDescendingSyntax();
            new Orderings().OrderProductsDescending();
            new Orderings().DescendingCustomComparer();
            new Orderings().ThenBySyntax();
            new Orderings().ThenByCustom();
            new Orderings().ThenByDifferentOrdering();
            new Orderings().CustomThenByDescending();
            new Orderings().OrderingReversal();

            // Grouping: 40 - 45
            new Groupings().GroupingSyntax();
            new Groupings().GroupByProperty();
            new Groupings().GroupByCategory();
            new Groupings().NestedGrouBy();
            new Groupings().GroupByCustomComparer();
            new Groupings().NestedGroupByCustom();

            // Set operations: 46 - 53
            new SetOperations().DistinctSyntax();
            new SetOperations().DistinctPropertyValues();
            new SetOperations().UnionSyntax();
            new SetOperations().UnionOfQueryResults();
            new SetOperations().IntersectSynxtax();
            new SetOperations().IntersectQueryResults();
            new SetOperations().DifferenceOfSets();
            new SetOperations().DifferenceOfQueries();
            return 0;
        }
    }
}
