# LINQ - Projection Operators

The `select` clause of a LINQ query *projects* the output sequence. It transforms each input element into the shape of the output sequence

## Select clause syntax

This sample uses select to produce a sequence of ints one higher than those in an existing array of ints. It demonstrates how select can modify the input sequence.

``` cs --region select-syntax --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Select a single property

This sample uses select to return a sequence of just the names of a list of products.

``` cs --region select-property --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Transform with select

This sample uses select to produce a sequence of strings representing the text version of a sequence of ints.

``` cs --region select-transform --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

***Start Page 2 here***

## Select anonymous types or tuples

This sample uses select to produce a sequence of the uppercase and lowercase versions of each word in the original array. The items in the output sequence are *anonymous types*. That means the compiler generates a class for them with the relevant properties, but that type has a name known only to the compiler.

``` cs --region select-case-anonymous --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

Beginning with C# 7, you can also project to *tuples*, using the following syntax. The items in the output sequence are instances of `System.ValueTuple`. The compiler adds metadata to provide meaningful member names.

``` cs --region select-case-tuple --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Use select to create new types

This sample uses select to produce a sequence containing text representations of digits and whether their length is even or odd.

``` cs --region select-new-type --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

You can choose to create either *anonymous types* or *tuples* in these projections, as shown below:

``` cs --region select-new-type-tuple --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

You'll likely see many samples in documentation and articles using anonymous types, because those have been available since C# 3.0. However, the new *tuples* projections have some advantages that you can read about on [Microsoft Docs](https://docs.microsoft.com/dotnet/csharp/tuples). All upcoming samples will use the tuples syntax. However, anonymous types also work.

## Select a subset of properties

This sample uses select to produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

``` cs --region select-subset-properties --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

***Start Page 3 here***

## Select with index of item

This sample uses an indexed Select clause to determine if the value of ints in an array match their position in the array.

``` cs --region select-with-index --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Select combined with where

This sample combines select and where to make a simple query that returns the text form of each digit less than 5.

``` cs --region select-with-where --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

***Start Page 4 here***

## Select from multiple input sequences

This sample uses a compound `from` clause to make a query that returns all pairs of numbers from both arrays such that the number from `numbersA` is less than the number from `numbersB`.

``` cs --region select-many-syntax --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Select from related input sequences

This sample uses a comThis sample uses a compound from clause to select all orders where the order total is less than 500.00.

``` cs --region select-many-drilldown --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Compound select with where clause

This sample uses a compound from clause to select all orders where the order was made in 1998 or later.

``` cs --region select-many-filter --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

***Start Page 5 here***

## Compound select with where and assignment

This sample uses a compound from clause to select all orders where the order total is greater than 2000.00 and uses from assignment to avoid requesting the total twice.


``` cs --region select-many-assignment --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Compound select with multiple where clauses

This sample uses multiple from clauses so that filtering on customers can be done before selecting their orders. This makes the query more efficient by not selecting and then discarding orders for customers outside of Washington.

``` cs --region multiple-where-clauses --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Compound select with index

This sample uses an indexed SelectMany clause to select all orders, while referring to customers by the order in which they are returned from the query.

``` cs --region indexed-select-many --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```


**Next: [Projection operators  &raquo;](./projections.md) Previous: [Restrictions &laquo;](./restrictions.md)**

**[Home](../README.md)**