# LINQ - Aggregators

*Aggregator* methods return a single value calculated from all the elements in a sequence. the aggregator methods include `Count`, `Sum`, `Min`, `Max`, `Average`, and `Aggregate`.

## Find the maximun of a sequence of elements

This sample uses `Max` to get the highest number in an array.

``` cs --region max-syntax --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find the maximum of a projection

This sample uses `Max` to get the length of the longest word in an array.

``` cs --region max-projection --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find the maximum in each group

This sample uses `Max` to get the most expensive price among each category's products.

``` cs --region max-grouped --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

## Find all elements matching the maximum

This sample uses `Max` to get the products with the most expensive price in each category.

``` cs --region max-each-group --source-file ../src/AggregateOperators.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Aggregates-Average &raquo;](./aggregates-4.md) Previous:  [Aggregates-Min &raquo;](./aggregates-2.md)**

**[Home](../README.md)**
