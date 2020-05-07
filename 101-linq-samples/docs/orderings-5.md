# Using a custom comparer on multiple sort orderings

The samples on this page use the following custom comparer:

``` cs --region custom-comparer --session orderby-custom-thenby --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Multiple ordering with a custom comparer

This sample uses an `OrderBy` and a `ThenBy` clause with a custom comparer to sort first by word length and then by a case-insensitive sort of the words in an array.

``` cs --region thenby-custom --session orderby-custom-thenby --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Multiple descending order with a custom comparer

This sample uses an `OrderBy` and a `ThenBy` clause with a custom comparer to sort first by word length and then by a case-insensitive sort of the words in an array.

``` cs --region thenby-custom-descending --session orderby-custom-descending-thenby --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Grouping operators &raquo;](./groupings.md) Previous: [Custom comparisons &laquo;](./orderings-4.md)**

**[Home](../README.md)**
