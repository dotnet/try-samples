# LINQ - Projection Operators

The `select` clause of a LINQ query *projects* the output sequence. It transforms each input element into the shape of the output sequence

## Select with index of item

This sample uses an indexed `Select` clause to determine if the value of ints in an array match their position in the array.

``` cs --region select-with-index --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Select combined with where

This sample combines `select` and `where` to make a simple query that returns the text form of each digit less than 5.

``` cs --region select-with-where --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Projections from multiple inputs  &raquo;](./projections-4.md) Previous: [Projects to new types &laquo;](./projections-2.md)**

**[Home](../README.md)**
