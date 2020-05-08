# LINQ - Sequence operations

These operators compare or manipulate entire sequences: `SequenceEqual`, `Concat`, and `Combine`.

## Compare two sequences for equality

This sample uses `SequenceEqual` to see if two sequences match on all elements in the same order.

``` cs --region equal-sequence --source-file ../src/SequenceOperations.cs --project ../src/Try101LinqSamples.csproj
```

Change the order of elements in one sequence and try that sample again:

```csharp
var wordsB = new string[] { "apple", "blueberry", "cherry" };
```

Notice that sequences are equal if they contain the same elements, and those elements are in the same order.

## Concatenate two sequences

This sample uses `Concat` to create one sequence that contains each array's values, one after the other.

``` cs --region concat-series --source-file ../src/SequenceOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Concatenate projections from two sequences

This sample uses `Concat` to create one sequence that contains the names of all customers and products, including any duplicates.

``` cs --region concat-projections --source-file ../src/SequenceOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Combine sequences with zip

This sample calculates the dot product of two integer vectors. It uses `Zip` to calculate the dot product, passing it a lambda function to multiply two arrays, element by element, and sum the result.

``` cs --region dot-product --source-file ../src/SequenceOperations.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Deferred and eager execution &raquo;](./query-execution.md) Previous:  [Aggregates-Average &raquo;](./aggregates-4.md)**

**[Home](../README.md)**
