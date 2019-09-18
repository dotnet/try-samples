# LINQ - Element Operators

The methods `First`, `FirstOrDefault`, and `ElementAt` provide ways to select a single element by position.

## Find the first element

This sample uses `First` to return the first matching element as a `Product`, instead of as a sequence containing a `Product`.

``` cs --region first-element --source-file ../src/ElementOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Find the first matching element

This sample uses `First` to find the first element in the array that starts with 'o'.

``` cs --region first-matching-element --source-file ../src/ElementOperations.cs --project ../src/Try101LinqSamples.csproj
```

## First element of a possibly empty sequence

This sample uses `FirstOrDefault` to try to return the first element of the sequence, unless there are no elements, in which case the default value for that type is returned.

``` cs --region first-or-default --source-file ../src/ElementOperations.cs --project ../src/Try101LinqSamples.csproj
```

## First matching element or default

This sample uses `FirstOrDefault` to return the first product whose `ProductID` is `789` as a single `Product` object, unless there is no match, in which case `null` is returned.

``` cs --region first-matching-or-default --source-file ../src/ElementOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Find element at position

This sample uses `ElementAt` to retrieve the second number greater than 5 from an array.

``` cs --region element-at --source-file ../src/ElementOperations.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Generate sequences &raquo;](./generators.md) Previous:  [Conversion operations &raquo;](./conversions.md)**

**[Home](../README.md)**
