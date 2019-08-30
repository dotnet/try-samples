# LINQ - Ordering Operators

The `orderby` clause of a LINQ query sorts the output sequence. You can control the properties used for sorting, and specify ascending or descending order.

## orderby multiple properties

This sample uses a compound orderby to sort a list of digits, first by length of their name, and then alphabetically by the name itself.

``` cs --region thenby-syntax --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Multiple ordering with a custom comparer

This sample uses an OrderBy and a ThenBy clause with a custom comparer to sort first by word length and then by a case-insensitive sort of the words in an array.

``` cs --region custom-comparer --session thenby-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

``` cs --region thenby-custom --session thenby-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Multiple ordering descending

This sample uses a compound orderby to sort a list of products, first by category, and then by unit price, from highest to lowest.

``` cs --region thenby-ordering --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Multiple descending order with a custom comparer

This sample uses an OrderBy and a ThenBy clause with a custom comparer to sort first by word length and then by a case-insensitive sort of the words in an array.

``` cs --region custom-comparer --session thenbydesc-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

``` cs --region thenby-custom --session thenbydesc-custom --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

## Reverse the sequence

This sample uses Reverse to create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

``` cs --region reverse --source-file ../src/Orderings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Orderby then by &raquo;](./orderings-3.md) Previous: [Ordering descending &laquo;](./orderings-2.md)**

**[Home](../README.md)**
