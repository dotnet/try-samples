# LINQ - Projection Operators

The `select` clause of a LINQ query *projects* the output sequence. It transforms each input element into the shape of the output sequence

## Select clause

This sample uses `select` to produce a sequence of ints one higher than those in an existing array of ints. It demonstrates how `select` can modify the input sequence.

``` cs --region select-syntax --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Select a single property

This sample uses `select` to return a sequence of just the names of a list of products.

``` cs --region select-property --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Transform with select

This sample uses `select` to produce a sequence of strings representing the text version of a sequence of ints.

``` cs --region select-transform --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Projections to new types  &raquo;](./projections-2.md) Previous: [Restrictions &laquo;](./restrictions.md)**

**[Home](../README.md)**

