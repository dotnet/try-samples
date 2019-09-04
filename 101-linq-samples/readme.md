# 101 LINQ Samples
![dotnet try Enabled](https://img.shields.io/badge/Try_.NET-Enabled-501078.svg)

<p align ="center">
<img src ="https://user-images.githubusercontent.com/2546640/56708992-deee8780-66ec-11e9-9991-eb85abb1d10a.png" width="350">
</p>

Learn how to use LINQ in your applications with these code samples, covering the entire range of LINQ functionality and demonstrating LINQ with objects, Entity Framework, and XML.

## Lessons in this tutorial

These lessons are organized according to the operations used:

### [Restriction operators](docs/restrictions.md)

These operators restrict, or filter, the input sequence to produce an output sequence.

- [Where clause syntax](docs/restrictions.md#where-clause-syntax)
- [Where clause using a property](docs/restrictions.md#restrict-elements-based-on-a-property)
- [Where clause with multiple conditions](docs/restrictions.md#restrict-elements-based-on-multiple-conditions)
- [Where clause drilldown into results](docs/restrictions.md#drilldown-into-output-elements)
- [Where clause with element index](docs/restrictions.md#using-the-indexed-where-method)

### [Projection operators](docs/projections.md)

- [Select clause syntax](docs/projections.md#select-clause-syntax)
- [Select a single property](docs/projections.md#select-a-single-property)
- [Transform types with select](docs/projections.md#transform-with-select)
- [Select a new type](docs/projections-2.md#select-anonymous-types-or-tuples)
- [Create new types with select](docs/projections-2.md#use-select-to-create-new-types)
- [Select a subset of properties](docs/projections-2.md#select-a-subset-of-properties)
- [Select including the index of source item](docs/projections-3.md#select-with-index-of-item)
- [Combine select and where](docs/projections-3.md#select-combined-with-where)
- [Select from multiple sequences](docs/projections-4.md#select-from-multiple-input-sequences)
- [Select from related input sequences](docs/projections-4.md#select-from-related-input-sequences)
- [Select multiple sequences with where](docs/projections-4.md#compound-select-with-where-clause)
- [Select many with assignment](docs/projections-5.md#compound-select-with-where-and-assignment)
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

## [Ordering Operators](docs/ordering.md)

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
