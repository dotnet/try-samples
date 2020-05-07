# LINQ - Projection Operators

The `select` clause of a LINQ query *projects* the output sequence. It transforms each input element into the shape of the output sequence

## Select anonymous types or tuples

This sample uses `select` to produce a sequence of the uppercase and lowercase versions of each word in the original array. The items in the output sequence are *anonymous types*. That means the compiler generates a class for them with the relevant properties, but that type has a name known only to the compiler.

``` cs --region select-case-anonymous --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

Beginning with C# 7, you can also project to *tuples*, using the following syntax. The items in the output sequence are instances of `System.ValueTuple`. The compiler adds metadata to provide meaningful member names.

``` cs --region select-case-tuple --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

## Use select to create new types

This sample uses `select` to produce a sequence containing text representations of digits and whether their length is even or odd.

``` cs --region select-new-type --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

You can choose to create either *anonymous types* or *tuples* in these projections, as shown below:

``` cs --region select-new-type-tuple --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

You'll likely see many samples in documentation and articles using anonymous types, because those have been available since C# 3.0. However, the new *tuples* projections have some advantages that you can read about on [Microsoft Docs](https://docs.microsoft.com/dotnet/csharp/tuples). All upcoming samples will use the tuples syntax. However, anonymous types also work.

## Select a subset of properties

This sample uses `select` to produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

``` cs --region select-subset-properties --source-file ../src/Projections.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Projection with index and where  &raquo;](./projections-3.md) Previous: [Projections &laquo;](./projections.md)**

**[Home](../README.md)**
