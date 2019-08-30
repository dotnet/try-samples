# LINQ - Ordering Operators

The `orderby` clause of a LINQ query sorts the output sequence. You can control the properties used for sorting, and specify ascending or descending order.

## orderby sytnax

This sample uses orderby to sort a list of words alphabetically.

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

## Ordering with a custom comparer

This sample uses an OrderBy clause with a custom comparer to do a case-insensitive sort of the words in an array.

The first block is the custom comparer:

``` cs --region custom-comparer --session orderby-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

The next block shows its usage:

``` cs --region orderby-custom-comparer --session orderby-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Orderby descending &raquo;](./orderings-2.md) Previous: [Partitions with conditions &laquo;](./partitions-2.md)**

**[Home](../README.md)**
