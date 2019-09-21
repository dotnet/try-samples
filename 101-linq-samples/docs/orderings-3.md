# LINQ - Ordering Operators

The `orderby` clause of a LINQ query sorts the output sequence. You can control the properties used for sorting, and specify ascending or descending order.

## orderby multiple properties

This sample uses a compound `orderby` to sort a list of digits, first by length of their name, and then alphabetically by the name itself.

``` cs --region thenby-syntax --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Multiple ordering descending

This sample uses a compound `orderby` to sort a list of products, first by category, and then by unit price, from highest to lowest.

``` cs --region thenby-ordering --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Reverse the sequence

This sample uses `Reverse` to create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

``` cs --region reverse --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Custom comparisons &raquo;](./orderings-4.md) Previous: [Ordering descending &laquo;](./orderings-2.md)**

**[Home](../README.md)**
