# LINQ - Ordering Operators

The `orderby` clause of a LINQ query sorts the output sequence. You can control the properties used for sorting, and specify ascending or descending order.

## orderby descending sytnax

This sample uses orderby and descending to sort a list of doubles from highest to lowest.

``` cs --region orderbydescending-syntax --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Descending ordering user defined types

This sample uses orderby to sort a list of products by units in stock from highest to lowest.

``` cs --region orderby-descending-type --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Descending orders with a custom comparer

This sample uses an OrderBy clause with a custom comparer to do a case-insensitive descending sort of the words in an array.

The first block is the custom comparer:

``` cs --region custom-comparer --session descending-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

The next block shows its usage:

``` cs --region desc-custom-comparer --session descending-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Orderby then by &raquo;](./orderings-3.md) Previous: [Ordering &laquo;](./orderings.md)**

**[Home](../README.md)**
