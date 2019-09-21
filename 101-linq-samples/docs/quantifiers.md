# LINQ - Quantifiers

The methods `Any`, and `All` determine of all elements or any elements match a condition.

## Check for any matching elements

This sample uses `Any` to determine if any of the words in the array contain the substring 'ei'.

``` cs --region any-matches --source-file ../src/Quantifiers.cs --project ../src/Try101LinqSamples.csproj
```

## Group by any elements matching a condition

This sample uses `Any` to return a grouped a list of products only for categories that have at least one product that is out of stock.

``` cs --region any-grouped --source-file ../src/Quantifiers.cs --project ../src/Try101LinqSamples.csproj
```

## Check that all elements match a condition

This sample uses `All` to determine whether an array contains only odd numbers.

``` cs --region all-match --source-file ../src/Quantifiers.cs --project ../src/Try101LinqSamples.csproj
```

## Group by all elements matching a condition

This sample uses `All` to return a grouped a list of products only for categories that have all of their products in stock.

``` cs --region all-grouped --source-file ../src/Quantifiers.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Aggregate operations &raquo;](./aggregates.md) Previous:  [Generate sequence elements &raquo;](./generators.md)**

**[Home](../README.md)**
