# LINQ - Aggregators

*Aggregator* methods return a single value calculated from all the elements in a sequence. the aggregator methods include `Count`, `Sum`, `Min`, `Max`, `Average`, and `Aggregate`.

## Sum all numeric elements in a sequence

This sample uses `Sum` to get the total of the numbers in an array.

``` cs --region sum-syntax --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Sum a projection from a sequence

This sample uses `Sum` to get the total number of characters of all words in the array.

``` cs --region sum-of-projection --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Sum all elements that are members of a group

This sample uses `Sum` to get the total units in stock for each product category.

``` cs --region grouped-sum --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Aggregates-Min &raquo;](./aggregates-2.md) Previous:  [Aggregates &raquo;](./aggregates.md)**

**[Home](../README.md)**
