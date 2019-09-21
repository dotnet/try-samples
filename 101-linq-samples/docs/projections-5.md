# LINQ - Projection Operators

The `select` clause of a LINQ query *projects* the output sequence. It transforms each input element into the shape of the output sequence

## Compound select with where and assignment

This sample uses a compound `from` clause to select all orders where the order total is greater than 2000.00 and uses `from` assignment to avoid requesting the total twice.


``` cs --region select-many-assignment --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Compound select with multiple where clauses

This sample uses multiple `from` clauses so that filtering on customers can be done before selecting their orders. This makes the query more efficient by not selecting and then discarding orders for customers outside of Washington.

``` cs --region multiple-where-clauses --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Compound select with index

This sample uses an indexed `SelectMany` clause to select all orders, while referring to customers by the order in which they are returned from the query.

``` cs --region indexed-select-many --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Partition operators  &raquo;](./partitions.md) Previous: [Restrictions from multiple inputs &laquo;](./projections-4.md)**

**[Home](../README.md)**
