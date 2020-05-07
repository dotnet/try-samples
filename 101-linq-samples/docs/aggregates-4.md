# LINQ - Aggregators

*Aggregator* methods return a single value calculated from all the elements in a sequence. the aggregator methods include `Count`, `Sum`, `Min`, `Max`, `Average`, and `Aggregate`.

## Find the average of a sequence of elements

This sample uses `Average` to get the average of all numbers in an array.

``` cs --region average-syntax --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find the average of a projection

This sample uses `Average` to get the average length of the words in the array.

``` cs --region average-projection --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find the average in each group

This sample uses `Average` to get the average price of each category's products.

``` cs --region average-grouped --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Compute an aggregate value from all elements of a sequence

This sample uses `Aggregate` to create a running product on the array that calculates the total product of all elements.

``` cs --region aggregate-syntax --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Compute an aggregate value from a seed value and all elements of a sequence

This sample uses `Aggregate` to create a running account balance that subtracts each withdrawal from the initial balance of 100, as long as the balance never drops below 0.

``` cs --region aggregate-seeded --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Sequence operations &raquo;](./sequence-operations.md) Previous:  [Aggregates-Min &raquo;](./aggregates-2.md)**

**[Home](../README.md)**
