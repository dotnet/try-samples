# LINQ - Generate elements

The methods `Range` and `Repeat` create sequences of integers. These can be the source sequences of queries.

## Create a range of numbers

This sample uses `First` to return the first matching element as a `Product`, instead of as a sequence containing a `Product`.

``` cs --region generate-range --source-file ../src/Generators.cs --project ../src/Try101LinqSamples.csproj
```

## Repeat the same number

This sample uses `First` to find the first element in the array that starts with 'o'.

``` cs --region generate-repeat --source-file ../src/Generators.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Quantifying operations &raquo;](./quantifiers.md) Previous:  [Conversion operations &raquo;](./conversions.md)**

**[Home](../README.md)**
