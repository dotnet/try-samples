# LINQ - Conversion Operators

The methods `ToArray`, `ToList`, `ToDictionary`, and `OfType` provide ways to convert LINQ results to collections.

## Convert to an array

This sample uses `ToArray` to immediately evaluate a sequence into an array.

``` cs --region convert-to-array --source-file ../src/Conversions.cs --project ../src/Try101LinqSamples.csproj
```

## Convert to a list

This sample uses `ToList` to immediately evaluate a sequence into a `List<T>`.

``` cs --region convert-to-list --source-file ../src/Conversions.cs --project ../src/Try101LinqSamples.csproj
```

## Convert to a dictionary

This sample uses `ToDictionary` to immediately evaluate a sequence and a related key expression into a dictionary.

``` cs --region convert-to-dictionary --source-file ../src/Conversions.cs --project ../src/Try101LinqSamples.csproj
```

## Convert elements that match a type

This sample uses `OfType` to return only the elements of the array that are of type `double`.

``` cs --region convert-to-type --source-file ../src/Conversions.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Element operations &raquo;](./elements.md) Previous:  [Intersect and except set operations &raquo;](./sets-2.md)**

**[Home](../README.md)**
