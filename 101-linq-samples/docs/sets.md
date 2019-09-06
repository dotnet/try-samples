# LINQ - Set Operators

The methods `Distinct`, `Union`, `Intersect`, and `Except` provide set operations to compare multiple sequences.

## Distinct syntax

This sample uses `Distinct` to remove duplicate elements in a sequence of factors of 300.

``` cs --region distinct-syntax --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Find distinct values of a property

This sample uses Distinct to find the unique Category names.

``` cs --region distinct-property-values --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Union syntax

This sample uses Union to create one sequence that contains the unique values from both arrays.

``` cs --region union-syntax --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Nested group by queries

This sample demonstrates the use of `group by` and `into` nested buckets of orders by customer, year, and month. The result 

``` cs --region nested-groupby --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Grouping with a custom comparer &raquo;](./groupings-2.md) Previous: [Nested groupings with a custom comparer &laquo;](./groupings-3.md)**

**[Home](../README.md)**
