# LINQ - Projection Operators

The `select` clause of a LINQ query *projects* the output sequence. It transforms each input element into the shape of the output sequence

## Select from multiple input sequences

This sample uses a compound `from` clause to make a query that returns all pairs of numbers from both arrays such that the number from `numbersA` is less than the number from `numbersB`.

``` cs --region select-many-syntax --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Select from related input sequences

This sample uses a compound `from` clause to select all orders where the order total is less than 500.00.

``` cs --region select-many-drilldown --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Compound select with where clause

This sample uses a compound `from` clause to select all orders where the order was made in 1998 or later.

``` cs --region select-many-filter --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Compound projections  &raquo;](./projections-5.md) Previous: [Restrictions with index and where &laquo;](./projections-3.md)**

**[Home](../README.md)**

