# LINQ - Aggregators

*Aggregator* methods return a single value calculated from all the elements in a sequence. the aggregator methods include `Count`, `Sum`, `Min`, `Max`, `Average`, and `Aggregate`.

## Count all elements in a sequence

This sample uses `Count` to get the number of unique factors of 300.

``` cs --region count-syntax --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Count all elements matching a condition

This sample uses `Count` to get the number of odd ints in the array.


``` cs --region count-conditional --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Count all elements nested in a query

This sample uses `Count` to return a list of customers and how many orders each has.

``` cs --region nested-count --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Count all elements that are members of a group

This sample uses `Count` to return a list of categories and how many products each has.

``` cs --region grouped-count --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Aggregates-Sum &raquo;](./aggregates-1.md) Previous:  [Quantifiers &raquo;](./generators.md)**

**[Home](../README.md)**
