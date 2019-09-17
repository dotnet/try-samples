# LINQ - lazy and eager execution

Learn to specify either eager or lazy query execution.

## Queries execute lazily

The following sample shows how query execution is deferred until the query is enumerated at a foreach statement.

``` cs --region deferred-execution --source-file ../src/QueryExecution.cs --project ../src/Try101LinqSamples.csproj
```

## Request eager query execution

The following sample shows how queries can be executed immediately with operators such as `ToList()`.

``` cs --region eager-execution --source-file ../src/QueryExecution.cs --project ../src/Try101LinqSamples.csproj
```

You can replace the `ToList` call with a `ToArray`. Try it.

## Reuse queries with new results

The following sample shows how, because of deferred execution, queries can be used again after data changes and will then operate on the new data.

``` cs --region reuse-query --source-file ../src/QueryExecution.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Join operators &raquo;](./join-operators.md) Previous:  [sequence-operations &raquo;](./sequence-operations.md)**

**[Home](../README.md)**
