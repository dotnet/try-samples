# 101 LINQ Samples
![dotnet try Enabled](https://img.shields.io/badge/Try_.NET-Enabled-501078.svg)

<p align ="center">
<img src ="https://user-images.githubusercontent.com/2546640/56708992-deee8780-66ec-11e9-9991-eb85abb1d10a.png" width="350">
</p>

Learn how to use LINQ in your applications with these code samples, covering the entire range of LINQ functionality and demonstrating LINQ with objects, Entity Framework, and XML.

## Exploring LINQ using this tutorial

This tutorial starts with the [fundamentals of LINQ](docs/restrictions.md). You can follow each page in order to explore all the elements of LINQ. Following step-by-step lets you explore LINQ from these fundamental queries through more complicated queries, up to the most complex uses.

Alternatively, if you've got some exposure to LINQ, you can jump to a specific section to refresh your knowledge, or learn techniques you aren't familiar with. Here is the full list of samples:

### [Restriction operators](docs/restrictions.md)

The `where` keyword or `Where` method provide this capability. These operators restrict, or filter, the input sequence to produce an output sequence.

- [Your first query](docs/restrictions.md#where-clause-syntax)
- [Filter using a property of the input sequence](docs/restrictions.md#restrict-elements-based-on-a-property)
- [Filter using multiple conditions](docs/restrictions.md#restrict-elements-based-on-multiple-conditions)
- [Filter and drilldown into the output elements](docs/restrictions.md#drilldown-into-output-elements)
- [Filter using the input sequence index](docs/restrictions.md#using-the-indexed-where-method)

### [Projection operators](docs/projections.md)

The `select` keyword or `Select` method provide this capability. These operators create output sequence elements from input sequence elements. The output elements may be either the same or different types.

- [Fundamentals of select](docs/projections.md#select-clause-syntax)
- [Select one property the input elements](docs/projections.md#select-a-single-property)
- [Transform to an element of another sequence](docs/projections.md#transform-with-select)
- [Select anonymous types or tuples](docs/projections-2.md#select-anonymous-types-or-tuples)
- [Create new types with select](docs/projections-2.md#use-select-to-create-new-types)
- [Select a subset of properties into a new type](docs/projections-2.md#select-a-subset-of-properties)
- [Select the index of source item](docs/projections-3.md#select-with-index-of-item)
- [Combine select and where](docs/projections-3.md#select-combined-with-where)
- [Combine multiple input sequences](docs/projections-4.md#select-from-multiple-input-sequences)
- [Select from related input sequences](docs/projections-4.md#select-from-related-input-sequences)
- [Select multiple sequences with filters](docs/projections-4.md#compound-select-with-where-clause)
- [Select from related sequences ](docs/projections-5.md#compound-select-with-where-and-assignment)
- [Select many with multiple filters](docs/projections-5.md#compound-select-with-multiple-where-clauses)
- [Select many with element index](docs/projections-5.md#compound-select-with-index)

## [Partition operators](docs/partitions.md)

- [Take method syntax](docs/partitions.md#take-syntax)
- [Nested take method call](docs/partitions.md#nested-take-partitions)
- [Skip method syntax](docs/partitions.md#skip-syntax)
- [Nested skip method call](docs/partitions.md#nested-skip-partitions)
- [TakeWhile method syntax](docs/partitions-2.md#takewhile-syntax)
- [Indexed TakeWhile method](docs/partitions-2.md#indexed-takewhile)
- [SkipWhile method syntax](docs/partitions-2.md#skipwhile-syntax)
- [Indexed SkipWhile method](docs/partitions-2.md#indexed-skipwhile)

## [Ordering operators](docs/ordering.md)

- [Orderby syntax](docs/orderings.md#orderby-syntax)
- [Orderby using a single property](docs/orderings.md#orderby-property)
- [Orderby for user defined types](docs/orderings.md#ordering-user-defined-types)
- [Orderby descending syntax](docs/orderings-2.md#orderby-descending-sytnax)
- [Orderby descending for user defined types](docs/orderings-2.md#descending-ordering-user-defined-types)
- [Thenby syntax](docs/orderings-3.md#orderby-multiple-properties)
- [Thenby descending](docs/orderings-3.md#multiple-ordering-descending)
- [Reverse the input sequence](docs/orderings-3.md#reverse-the-sequence)
- [Orderby with a custom compare function](docs/orderings-4.md#ordering-with-a-custom-comparer)
- [Orderby descending with a custom compare function](docs/orderings-4.md#descending-orders-with-a-custom-comparer)
- [Thenby using a comparer](docs/orderings-5.md#multiple-ordering-with-a-custom-comparer)
- [Thenby descending using a comparer](docs/orderings-5.md#multiple-descending-order-with-a-custom-comparer)

## [Grouping operators](docs/groupings.md)

- [Group by syntax](docs/groupings.md#group-by-into-syntax)
- [Group by using a property](docs/groupings.md#groupby-using-a-property)
- [Group by using a key property](docs/groupings.md#grouping-using-a-key-property)
- [Nested group by queries](docs/groupings.md#nested-group-by-queries)
- [Group by using a custom comparer](docs/groupings-2.md)
- [Nested group by using a custom comparer](docs/groupings-3.md)

## [Set Operators](docs/sets.md)

- [Distinct syntax and form](docs/sets.md#distinct-syntax)
- [Find all distinct values of a single property](docs/sets.md#find-distinct-values-of-a-property)
- [Union syntax and form](docs/sets.md#union-syntax)
- [Union of query results](docs/sets.md#union-of-query-results)
- [Intersect syntax and form](docs/sets-2.md#intersect-syntax)
- [Find the intersection of query results](docs/sets-2.md#find-the-intersection-of-query-results)
- [Find the difference of two sets using except](docs/sets-2.md#find-the-difference-of-two-sets)
- [Find the difference of two queries using except](docs/sets-2.md#difference-of-two-queries)

## [Conversion operators](docs/conversions.md)

- [Convert results to an Array](docs/conversions.md#convert-to-array)
- [Convert results to a list](docs/conversions.md#convert-to-list)
- [Convert results to a dictionary](docs/conversions.md#convert-to-dictionary)
- [Convert results based on item type](docs/conversions.md#convert-elements-that-match-a-type)

## [Element operators](docs/elements.md)

- [Retrieve the first element](docs/elements.md#find-the-first-element)
- [Retrieve the first matching element](docs/elements.md#find-the-first-matching-element)
- [Retrieve the first element or default](docs/elements.md#first-element-of-a-possibly-empty-sequence)
- [Retrieve the first matching element or default](docs/elements.md#first-matching-element-or-default)
- [Find an element by position](docs/elements.md#find-element-at-position)

## [Generate sequences](docs/generators.md)

- [Generate a range of numbers](docs/generaotrs.md#create-a-range-of-numbers)
- [Repeat the same number](docs/generaotrs.md#repeat-the-same-number)
