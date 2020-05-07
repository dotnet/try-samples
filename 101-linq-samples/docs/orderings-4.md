# Using a custom comparer

The samples on this page use the following custom comparer:

``` cs --region custom-comparer --session orderby-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Ordering with a custom comparer

This sample orders the customers using the custom comparer

``` cs --region orderby-custom-comparer --session orderby-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Descending orders with a custom comparer

This sample uses an `OrderBy` clause with a custom comparer to do a case-insensitive descending sort of the words in an array.

``` cs --region desc-custom-comparer --session orderby-custom-descending --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Nested custom comparisons &raquo;](./orderings-5.md) Previous: [Orderby thenby &laquo;](./orderings-3.md)**

**[Home](../README.md)**
