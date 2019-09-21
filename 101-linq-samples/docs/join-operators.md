# LINQ - Join operations

Learn to use cross `join`, group `join`, and left outer `join` operations in LINQ queries

## Cross join

This sample shows how to efficiently join elements of two sequences based on equality between key expressions over the two.

``` cs --region cross-join --source-file ../src/JoinOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Group join

Using a group `join` you can get all the products that match a given category bundled as a sequence.

``` cs --region group-join --source-file ../src/JoinOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Cross join with group join

The group `join` operator is more general than `join`, as this slightly more verbose version of the cross `join` sample shows.

``` cs --region cross-group-join --source-file ../src/JoinOperations.cs --project ../src/Try101LinqSamples.csproj
```

## Left outer join using group join

A so-called outer join can be expressed with a `group join`. A left outer join is like a cross join, except that all the left hand side elements get included at least once, even if they don't match any right hand side elements. Note how `Vegetables` shows up in the output even though it has no matching products.

``` cs --region left-outer-join --source-file ../src/JoinOperations.cs --project ../src/Try101LinqSamples.csproj
```

**Previous:  [Query execution &raquo;](./query-execution.md)**

**[Home](../README.md)**
