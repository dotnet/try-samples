# LINQ - Set Operators

The methods `Distinct`, `Union`, `Intersect`, and `Except` provide set operations to compare multiple sequences.

## Find the intersection of two sets

This sample uses `Intersect` to create one sequence that contains the common values shared by both arrays.

``` cs --region intersect-syntax --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Find the intersection of query results

This sample uses `Intersect` to create one sequence that contains the common first letter from both product and customer names.

``` cs --region intersect-different-queries --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Difference of two sets

This sample uses `Except` to create a sequence that contains the values from `numbersA` that are not also in `numbersB`.

``` cs --region except-syntax --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Difference of two queries

This sample uses `Except` to create one sequence that contains the first letters of product names that are not also first letters of customer names.

``` cs --region difference-of-queries --source-file ../src/SetOperations.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Conversion operators &raquo;](./conversions.md) Previous: [Set operations distinct and union &laquo;](./sets.md)**

**[Home](../README.md)**
