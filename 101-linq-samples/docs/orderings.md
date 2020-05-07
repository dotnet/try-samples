# LINQ - Ordering Operators

The `orderby` clause of a LINQ query sorts the output sequence. You can control the properties used for sorting, and specify ascending or descending order.

## orderby sorts elements

This sample uses `orderby` to sort a list of words alphabetically.

``` cs --region orderby-syntax --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Orderby using a property

This sample uses orderby to sort a list of words by length.

``` cs --region orderby-property --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Ordering user defined types

This sample uses orderby to sort a list of products by name.

``` cs --region orderby-user-types --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Orderby descending &raquo;](./orderings-2.md) Previous: [Partitions with conditions &laquo;](./partitions-2.md)**

**[Home](../README.md)**
