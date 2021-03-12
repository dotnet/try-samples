# LINQ - Partition Operators

The methods `Take`, `Skip`, `TakeWhile` and `SkipWhile` *partition* an output sequence. You use these to limit the portion of an input sequence transferred to the output sequence.

## Take elements

This sample uses `Take` to get only the first 3 elements of the array.

``` cs --region take-syntax --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

## Nested Take partitions

This sample uses `Take` to get the first 3 orders from customers in Washington.

``` cs --region nested-take --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

## Skip elements

This sample uses `Skip` to get all but the first 4 elements of the array.

``` cs --region skip-syntax --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

## Nested skip partitions

This sample uses `Skip` to get all but the first 2 orders from customers in Washington.

``` cs --region nested-skip --source-file ../src/Partitions.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Partitions with conditions  &raquo;](./partitions-2.md) Previous: [Restrictions with indexes and conditions &laquo;](./projections-5.md)**

**[Home](../README.md)**

