# LINQ - Grouping Operators

The `group by` and `into` keywords provide grouping constructs to organize elements of the input sequence into buckets.

## Group by into buckets

This sample demonstrates the use of `group by` and `into` to create buckets based on the remainder of an integer when dividing it by 5.

``` cs --region groupby-syntax --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

## Groupby using a property

This sample uses `group by` to partition a list of words by their first letter.

``` cs --region groupby-property --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

## Grouping using a key property

This sample uses `group by` to partition a list of products by category.

``` cs --region groupby-category --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

## Nested group by queries

This sample demonstrates the use of `group by` and `into` nested buckets of orders by customer, year, and month. The result 

``` cs --region nested-groupby --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Grouping with a custom comparer &raquo;](./groupings-2.md) Previous: [Nested custom comparisons &laquo;](./orderings-5.md)**

**[Home](../README.md)**
