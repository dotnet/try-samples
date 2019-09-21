# LINQ - Partition Operators

`TakeWhile` and `SkipWhile` *partition* an output sequence based a condition instead of a count of elements. You use these to limit the portion of an input sequence transferred to the output sequence.

## TakeWhile syntax

This sample uses `TakeWhile` to return elements starting from the beginning of the array until a number is hit that is not less than 6.

``` cs --region takewhile-syntax --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

## Indexed TakeWhile

This sample uses `TakeWhile` to return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

``` cs --region indexed-takewhile --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

## SkipWhile syntax

This sample uses `SkipWhile` to get the elements of the array starting from the first element divisible by 3.

``` cs --region skipwhile-syntax --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

## Indexed SkipWhile

This sample uses `SkipWhile` to get the elements of the array starting from the first element less than its position.

``` cs --region indexed-skipwhile --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Ordering operations &raquo;](./orderings.md) Previous: [Partitions &laquo;](./partitions.md)**

**[Home](../README.md)**

