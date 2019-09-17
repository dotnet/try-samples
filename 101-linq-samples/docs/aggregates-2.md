# LINQ - Aggregators

*Aggregator* methods return a single value calculated from all the elements in a sequence. the aggregator methods include `Count`, `Sum`, `Min`, `Max`, `Average`, and `Aggregate`.

## Find the minimum of a sequence of elements

This sample uses `Min` to get the lowest number in an array.

``` cs --region min-syntax --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find the minimum of a projection

This sample uses `Min` to get the length of the shortest word in an array.

``` cs --region min-projection --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find the minimum in each group

This sample uses `Min` to get the cheapest price among each category's products.

``` cs --region min-grouped --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find all elements matching the minimum

This sample uses `Min` to get the products with the cheapest price in each category.

``` cs --region min-each-group --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Aggregates-Max &raquo;](./aggregates-3.md) Previous:  [Aggregates-Sum &raquo;](./aggregates-1.md)**

**[Home](../README.md)**
