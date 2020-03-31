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
                "except-syntax"                 => new SetOperations().DifferenceOfSets(),

                "convert-to-array"              => new Conversions().ConvertToArray(),
                "convert-to-list"               => new Conversions().ConvertToList(),
                "convert-to-dictionary"         => new Conversions().ConvertToDictionary(),
                "convert-to-type"               => new Conversions().ConvertSelectedItems(),

                "first-element"                 => new ElementOperations().FirstElement(),
                "first-matching-element"        => new ElementOperations().FirstMatchingElement(),
                "first-or-default"              => new ElementOperations().MaybeFirstElement(),
                "first-matching-or-default"     => new ElementOperations().MaybeFirstMatchingElement(),
                "element-at"                    => new ElementOperations().ElementAtPosition(),

                "generate-range"                => new Generators().RangeOfIntegers(),
                "generate-repeat"               => new Generators().RepeatNumber(),

                "any-matches"                   => new Quantifiers().AnyMatchingElements(),
                "any-grouped"                   => new Quantifiers().GroupedAnyMatchedElements(),
                "all-match"                     => new Quantifiers().AllMatchedElements(),
                "all-grouped"                   => new Quantifiers().GroupedAllMatchedElements(),

                "count-syntax"                  => new AggregateOperators().CountSyntax(),
                "count-conditional"             => new AggregateOperators().CountConditional(),
                "nested-count"                  => new AggregateOperators().NestedCount(),
                "grouped-count"                 => new AggregateOperators().GroupedCount(),
                "sum-syntax"                    => new AggregateOperators().SumSyntax(),
                "sum-of-projection"             => new AggregateOperators().SumProjection(),
                "grouped-sum"                   => new AggregateOperators().SumGrouped(),
                "min-syntax"                    => new AggregateOperators().MinSyntax(),
                "min-projection"                => new AggregateOperators().MinProjection(),
                "min-grouped"                   => new AggregateOperators().MinGrouped(),
                "min-each-group"                => new AggregateOperators().MinEachGroup(),
                "max-syntax"                    => new AggregateOperators().MaxSyntax(),
                "max-projection"                => new AggregateOperators().MaxProjection(),
                "max-grouped"                   => new AggregateOperators().MaxGrouped(),
                "max-each-group"                => new AggregateOperators().MaxEachGroup(),
                "average-syntax"                => new AggregateOperators().AverageSyntax(),
                "average-projection"            => new AggregateOperators().AverageProjection(),
                "average-grouped"               => new AggregateOperators().AverageGrouped(),
                "aggregate-syntax"              => new AggregateOperators().AggregateSyntax(),
                "aggregate-seeded"              => new AggregateOperators().SeededAggregate(),

                "concat-series"                 => new SequenceOperations().ConcatSeries(),
                "concat-projections"            => new SequenceOperations().ConcatProjection(),
                "equal-sequence"                => new SequenceOperations().EqualSequence(),
                "dot-product"                   => new SequenceOperations().DotProduct(),

                "deferred-execution"            => new QueryExecution().DeferredExecution(),
                "eager-execution"               => new QueryExecution().EagerExecution(),
                "reuse-query"                   => new QueryExecution().ReuseQueryDefinition(),

                "cross-join"                    => new JoinOperations().CrossJoinQuery(),
                "group-join"                    => new JoinOperations().GroupJoinQquery(),
                "cross-group-join"              => new JoinOperations().CrossGroupJoin(),
                "left-outer-join"               => new JoinOperations().LeftOuterJoin(),

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

            // Conversion Operators: 54 - 57
            new Conversions().ConvertToArray();
            new Conversions().ConvertToList();
            new Conversions().ConvertToDictionary();
            new Conversions().ConvertSelectedItems();

            // Element operators: 58-64 (60 is missing.)
            new ElementOperations().FirstElement();
            new ElementOperations().FirstMatchingElement();
            new ElementOperations().MaybeFirstElement();
            new ElementOperations().MaybeFirstMatchingElement();
            new ElementOperations().ElementAtPosition();

            // Generator operators: 65,66
            new Generators().RangeOfIntegers();
            new Generators().RepeatNumber();

            // Quantifiers: 67 - 72 (68 and 71 are missing)
            new Quantifiers().AnyMatchingElements();
            new Quantifiers().GroupedAnyMatchedElements();
            new Quantifiers().AllMatchedElements();
            new Quantifiers().GroupedAllMatchedElements();

            // Aggregators: 73 - 93 (75 is missing)
            new AggregateOperators().CountSyntax();
            new AggregateOperators().CountConditional();
            new AggregateOperators().NestedCount();
            new AggregateOperators().GroupedCount();
            new AggregateOperators().SumSyntax();
            new AggregateOperators().SumProjection();
            new AggregateOperators().SumGrouped();
            new AggregateOperators().MinSyntax();
            new AggregateOperators().MinProjection();
            new AggregateOperators().MinGrouped();
            new AggregateOperators().MinEachGroup();
            new AggregateOperators().MaxSyntax();
            new AggregateOperators().MaxProjection();
            new AggregateOperators().MaxGrouped();
            new AggregateOperators().MaxEachGroup();
            new AggregateOperators().AverageSyntax();
            new AggregateOperators().AverageProjection();
            new AggregateOperators().AverageGrouped();
            new AggregateOperators().AggregateSyntax();

            // Miscellaneous:
            new SequenceOperations().ConcatSeries();
            new SequenceOperations().ConcatProjection();
            new SequenceOperations().EqualSequence();
            new SequenceOperations().Linq97();

            new QueryExecution().DeferredExecution();
            new QueryExecution().EagerExecution();
            new QueryExecution().ReuseQueryDefinition();

            new JoinOperations().CrossJoinQuery();
            new JoinOperations().GroupJoinQquery();
            new JoinOperations().CrossGroupJoin();
            new JoinOperations().LeftOuterJoin();

            return 0;
        }
    }
}
