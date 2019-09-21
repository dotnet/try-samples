# LINQ - Set Operators

The methods `Distinct`, `Union`, `Intersect`, and `Except` provide set operations to compare multiple sequences.

## Find distinct elements

This sample uses `Distinct` to remove duplicate elements in a sequence of factors of 300.

``` cs --region distinct-syntax --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Find distinct values of a property

This sample uses `Distinct` to find the unique Category names.

``` cs --region distinct-property-values --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Find the union of sets

This sample uses `Union` to create one sequence that contains the unique values from both arrays.

``` cs --region union-syntax --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Union of query results

This sample uses `Union` to create one sequence that contains the unique first letter from both product and customer names. It shows how you can combine the results of two different queries that produce the same element type.


``` cs --region union-query-results --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Intersect and except set operations &raquo;](./sets-2.md) Previous: [Nested groupings with a custom comparer &laquo;](./groupings-3.md)**

**[Home](../README.md)**
