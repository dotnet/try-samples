# 101 LINQ Samples
![dotnet try Enabled](https://img.shields.io/badge/Try_.NET-Enabled-501078.svg)

<p align ="center">
<img src ="https://user-images.githubusercontent.com/2546640/56708992-deee8780-66ec-11e9-9991-eb85abb1d10a.png" width="350">
</p>

## Exploring LINQ using this tutorial

This tutorial starts with the [fundamentals of LINQ](docs/restrictions.md). You can follow each page in order to explore all the elements of LINQ. Following step-by-step lets you explore LINQ from these fundamental queries through more complicated queries, up to the most complex uses.

Alternatively, if you're familiar with LINQ, you can jump to a specific section to refresh your knowledge, or learn new techniques. Here is the full list of samples:

### [Restriction operators](docs/restrictions.md): The `where` keyword

The `where` keyword or `Where` method provide this capability. These operators restrict, or filter, the input sequence to produce an output sequence.

- [Your first query](docs/restrictions.md#linq-query-structure): the structure of a LINQ query.
- [Filter elements on a property](docs/restrictions.md#filter-elements-on-a-property): filter elements based on a single property
- [Filter elements using multiple properties](docs/restrictions.md#filter-elements-on-multiple-properties): test multiple properties to filter elements in a sequence.
- [Filter and drilldown into the output elements](docs/restrictions.md#examine-a-sequence-property-of-output-elements): filter input elements, then drill into a sequence on each output element.
- [Filter input elements based on index](docs/restrictions.md#filter-elements-based-on-position): use an element's position to filter it.

### [Projection operators](docs/projections.md): The `select` keyword

The `select` keyword or `Select` method provide this capability. These operators create output sequence elements from input sequence elements. The output elements may be either the same or different types.

- [Select clause](docs/projections.md#select-clause): Select clause structure
- [Select one property the input elements](docs/projections.md#select-a-single-property): Select a single property from an input element.
- [Transform to an element of another sequence](docs/projections.md#transform-with-select): Map an input sequence element to an output sequence element.
- [Select anonymous types or tuples](docs/projections-2.md#select-anonymous-types-or-tuples): Select output elements that are anonymous types or tuples.
- [Create new types with select](docs/projections-2.md#use-select-to-create-new-types): Construct new properties for output elements.
- [Select a subset of properties into a new type](docs/projections-2.md#select-a-subset-of-properties): Trip the data selected for output elements.
- [Select the index of source item](docs/projections-3.md#select-with-index-of-item): Include an elements position as part of the projection.
- [Combine select and where](docs/projections-3.md#select-combined-with-where): Filter output elements before selecting properties.
- [Combine multiple input sequences](docs/projections-4.md#select-from-multiple-input-sequences): Combine every element of the first sequence with each element of a second input sequence.
- [Select from related input sequences](docs/projections-4.md#select-from-related-input-sequences): Filter on a property of a nested sequence.
- [Select multiple sequences with filters](docs/projections-4.md#compound-select-with-where-clause): Filter on properties of several related input sequences.
- [Select from related sequences ](docs/projections-5.md#compound-select-with-where-and-assignment): Cache a nested sequence to select properties from it.
- [Select many with multiple filters](docs/projections-5.md#compound-select-with-multiple-where-clauses): Filter elements on multiple input sequences.
- [Select many with element index](docs/projections-5.md#compound-select-with-index): Select the index of an input element along with other properties of the element.

## [Partition operators](docs/partitions.md)

Use the `Take`, `Skip`, `TakeWhile` and `SkipWhile` methods to partition the input sequence. You can get a slice of the input sequence as the output sequence.

- [Take the first elements](docs/partitions.md#take-elements): Take no more than a number of elements.
- [Take from nested results](docs/partitions.md#nested-take-partitions): Query nested sources and take a set of results.
- [Skip the first elements](docs/partitions.md#skip-elements): Start enumerating after a set of elements.
- [Skip from nested results](docs/partitions.md#nested-skip-partitions): Query nested sources and skip the first results
- [Take based on a condition](docs/partitions-2.md#takewhile-syntax): Take elements while a condition is true..
- [Indexed TakeWhile method](docs/partitions-2.md#indexed-takewhile): Take based on a condition and the index of an element.
- [Skip based on a condition](docs/partitions-2.md#skipwhile-syntax): Skip elements as long as a condition is true.
- [Indexed SkipWhile method](docs/partitions-2.md#indexed-skipwhile): Skip based on a condition and the index of an element.

## [Ordering operators](docs/orderings.md)

The `orderby` keyword, along with `descending`, and the `OrderBy`, `ThenBy`, `OrderbyDescending` and `ThenByDescending` LINQ queries are used to sort data output.

- [Sort elements](docs/orderings.md#orderby-sorts-elements): Sort elements using the standard sort order.
- [Orderby using a single property](docs/orderings.md#orderby-property): You can sort elements on a single property value
- [Order types you've defined](docs/orderings.md#ordering-user-defined-types): You can use any property that has an ordering relation to order types you've created.
- [Sort in descending order](docs/orderings-2.md#orderby-descending): Add `descending` to sort in descending order
- [Orderby descending on types you define](docs/orderings-2.md#descending-ordering-user-defined-types): With a defined sort order, you can sort in descending order.
- [Thenby to define a secondary sort](docs/orderings-3.md#orderby-multiple-properties): You can define secondary sorts when the primary sort keys are equal.
- [Thenby descending](docs/orderings-3.md#multiple-ordering-descending): Try multiple sort orders in descending order.
- [Reverse the input sequence](docs/orderings-3.md#reverse-the-sequence): The `Reverse` method reverses an input sequence.
- [Orderby with a custom compare function](docs/orderings-4.md#ordering-with-a-custom-comparer): You can define a custom compare function to sort elements.
- [Orderby descending with a custom compare function](docs/orderings-4.md#descending-orders-with-a-custom-comparer): Descending sort can use a custom comparer.
- [Thenby using a comparer](docs/orderings-5.md#multiple-ordering-with-a-custom-comparer): You can mix a standard sort order with a custom comparer.
- [Thenby descending using a comparer](docs/orderings-5.md#multiple-descending-order-with-a-custom-comparer): You can also sort in descending order.

## [Grouping operators](docs/groupings.md)

The `GroupBy` and `into` operators organize a sequence into buckets.

- [Group by into buckets](docs/groupings.md#group-by-into-buckets): Group items into buckets based on a property.
- [Group by using a property](docs/groupings.md#groupby-using-a-property): Group items based on a property of the input sequence.
- [Group by using a key property](docs/groupings.md#grouping-using-a-key-property): Group items based on a key value.
- [Nested group by queries](docs/groupings.md#nested-group-by-queries): Nest groups of buckets into a tree structure.
- [Group by using a custom comparer](docs/groupings-2.md): Group items based on a custom function.
- [Nested group by using a custom comparer](docs/groupings-3.md): Build a nested tree structure based on a custom comparer.

## [Set Operators](docs/sets.md)

These operators provide functionality to compare multiple sets of data. You can find the intersection, union, all distinct elements and the difference between sets.

- [Find distinct elements](docs/sets.md#find-distinct-elements): Build a set of the distinct elements in two sets.
- [Find all distinct values of a single property](docs/sets.md#find-distinct-values-of-a-property): Build a combined set based on values of a single property.
- [Find the union of sets](docs/sets.md#find-the-union-of-sets): Build a set that is the union of two sets.
- [Union of query results](docs/sets.md#union-of-query-results): Find the union of two query results.
- [Find the intersection of sets](docs/sets-2.md#find-the-intersection-of-two-sets): Produce a set that is the intersection of two sets.
- [Find the intersection of query results](docs/sets-2.md#find-the-intersection-of-query-results): Build the intersection of two query result sets.
- [Find the difference of two sets using except](docs/sets-2.md#find-the-difference-of-two-sets): Find elements in the first set that aren't present in the section set.
- [Find the difference of two queries using except](docs/sets-2.md#difference-of-two-queries): Find elements in the first result set that are not present in the second result set.

## [Conversion operators](docs/conversions.md)

Sometimes you want to convert a query result set to a different kind of collection. These operators show how you can do this.

- [Convert results to an Array](docs/conversions.md#convert-to-array): Convert an output sequence to an `Array`.
- [Convert results to a list](docs/conversions.md#convert-to-list): Convert an output sequence to a `List<T>`. 
- [Convert results to a dictionary](docs/conversions.md#convert-to-dictionary): Convert the results of a query to a `Dictionary<TKey, TValue>` based on a property of the output sequence elements.
- [Convert results based on item type](docs/conversions.md#convert-elements-that-match-a-type): Produce an output sequence of only those input elements that match a given type.

## [Element operators](docs/elements.md)

The methods `First`, `FirstOrDefault`, `Last`, `LastOrDefault`, and `ElementAt` retrieve elements based on the position of that element in the sequence.

- [Retrieve the first element](docs/elements.md#find-the-first-element): This examples assumes the sequence has at least one element.
- [Retrieve the first matching element](docs/elements.md#find-the-first-matching-element): Find the first element that matches a condition. At least one matching element must exist.
- [Retrieve the first element or default](docs/elements.md#first-element-of-a-possibly-empty-sequence): Find the first element, or `null`, if the sequence is empty.
- [Retrieve the first matching element or default](docs/elements.md#first-matching-element-or-default): Retrieve the first matching element, or null.
- [Find an element by position](docs/elements.md#find-element-at-position): Retrieve the element at a certain position.

## [Generate sequences](docs/generators.md)

These methods generate sequences of integers.

- [Generate a range of numbers](docs/generators.md#create-a-range-of-numbers): Generate sequential numbers.
- [Repeat the same number](docs/generators.md#repeat-the-same-number): Generate the samve value for each element.

## [Quantifying members](docs/quantifiers.md)

The methods `Any` and `All` test for elements that match a condition. `Any` checks for one element. `All` checks that all elements match the condition.

- [Check if any elements match a condition](docs/quantifiers.md#check-for-any-matching-elements): Does at least one element match a condition?
- [Group elements that match a condition](docs/quantifiers.md#group-by-any-elements-matching-a-condition): Group elements by those that match a conition.
- [Check if all elements match a condition](docs/quantifiers.md#check-that-all-matching-elements): Do all elements match a condition?
- [Group where all elements match a condition](docs/quantifiers.md#group-by-all-elements-matching-a-condition): Group all elements that match a given condition.

## [Aggregator operators](docs/aggregates.md)

There are a number of methods that perform calculations on values in a sequence. Note that some of these methods require that the input sequence is a numeric type. Those methods are noted below.

- [Count all elements in a sequence](docs/aggregates.md#count-all-elements-in-a-sequence): Count all elements works on any type.
- [Count all elements matching a condition in a sequence](docs/aggregates.md#count-all-elements-matching-a-condition): Count all elements that match a conditin.
- [Count all elements from a nested query](docs/aggregates.md#count-all-elements-nested-in-a-query): Count all elements in a nested query result.
- [Count all elements in a group](docs/aggregates.md#count-all-elements-that-are-members-of-a-group): Count all the elements in a group.
- [Sum all elements in a sequence](docs/aggregates-1.md#sum-all-numeric-elements-in-a-sequence): Sum all elements in a sequence of numbers.
- [Sum a projection from sequence](docs/aggregates-1.md#sum-a-projection-from-a-sequence): Sum a numeric projection from a sequence of elements.
- [Sum all elements in a group](docs/aggregates-1.md#sum-all-elements-that-are-members-of-a-group): Sum the numeric elements in a group projection.
- [Find the minimum element in a sequence](docs/aggregates-2.md#find-the-minimum-of-a-sequence-of-elements): Find the minimum value in a numeric sequence.
- [Find the minimum of a projection from a sequence](docs/aggregates-2.md#find-the-minimum-of-a-projection): Find the minimum value of a numeric projection from a sequence.
- [Find the minimum in each group](docs/aggregates-2.md#find-the-minimum-in-each-group): Find the smallest numeric value in a group projection.
- [Find all minimums in a group](docs/aggregates-2.md#find-all-elements-matching-the-minimum): Find all elements that are the minimum numeric value.
- [Find the maximum element in a sequence](docs/aggregates-3.md#find-the-maximum-of-a-sequence-of-elements): Find the maximum of a numeric sequence.
- [Find the maximum of a projection from a sequence](docs/aggregates-3.md#find-the-maximum-of-a-projection): Find the maximum of a numeric projection of a sequence.
- [Find the maximum in each group](docs/aggregates-3.md#find-the-maximum-in-each-group): Find the maximum numeric value in each output group of a query.
- [Find all maximums in a group](docs/aggregates-3.md#find-all-elements-matching-the-maximum): Find all numeric values that match the maximum value.
- [Find the average of all element in a sequence](docs/aggregates-3.md#find-the-average-of-a-sequence-of-elements): Find the average of all numeric values in a sequence.
- [Find the maximum of a projection from a sequence](docs/aggregates-3.md#find-the-average-of-a-projection): Find the maximum of a numeric projection from a sequence.
- [Find the maximum in each group](docs/aggregates-3.md#find-the-average-in-each-group): Find the numeric maximum in each group projection.
- [Compute an aggregate from all elements in a sequence](docs/aggregates-4.md#compute-an-aggregate-value-from-all-elements-of-a-sequence): Compute a single value from all elements in a sequence. These need not be numeric sequences.
- [Compute an aggregate from a seed and elements in a sequence](docs/aggregates-4.md#compute-an-aggregate-value-from-a-seed-value-and-all-elements-of-a-sequence): Compute a single value from a seed value and a sequence. The elements need not be numeric.

## [Sequence operations](docs/sequence-operations.md)

These methods operate on entire sequences rather than elements of a sequence. They compare sequences or create new sequences from combining all elements.

- [Compare two sequences for equality](docs/sequence-operations.md#count-all-elements-in-a-sequence): Do two sequences contain the same elements in the same order?
- [Concatenate two sequences](docs/sequence-operations.md#concatenate-projections-from-two-sequences): Create a new sequence from all elements in two source sequences.
- [Concatenate projections from two sequences](docs/sequence-operations.md#concatenate-projections-from-two-sequences): Create a new sequence from a projection of all elements in two source collections.
- [Combine sequences with zip](docs/sequence-operations.md#combine-sequences-with-zip): Combine two sequences by producing a new elements from pairs of elements in two source sequences.

## [Eager and lazy query execution](docs/query-execution.md)

You can use different query operations to specify eager execution instead of lazy execution.

- [Queries execute lazily](docs/query-execution.md#queries-execute-lazily): This demonstrates the default query execution.
- [Request eager execution](docs/query-execution.md#request-eager-query-execution): This forces eager execution to demonstrate teh difference.
- [Reuse queries with new results](docs/query-execution.md#reuse-queries-with-new-results): Queries executing lazily can produce different results if the source collection changes.

## [Join operations](docs/join-operators.md)

These operations perform similar functions to SQL join operators. These work with any LINQ data source.

- [Cross join](docs/join-operators.md#cross-join): Perform a cross join.
- [Group join](docs/join-operators.md#group-join): Perform a group join.
- [Cross join with group join](docs/join-operators.md#cross-join-with-group-join): Perform a cross join combined with a group join.
- [Left outer join](docs/join-operators.md#left-outer-join-using-group-join): Simulate a left outer join using a group join.
