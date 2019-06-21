# Tuples create light-weight data structures
Tuples are lightweight data structures that contain multiple fields to represent the data members. The fields are not validated, and you cannot define your own methods.

> NOTE:
> Tuples were available before C# 7.0, but they were inefficient and had no language support. This meant that tuple elements could only be referenced as `Item1`, `Item2` and so on. C# 7.0 introduces language support for tuples, which enables semantic names for the fields of a tuple using new more efficient tuple types.

You can create a tuple by assigning a value to each named member:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/TupleUses.cs --region TupleDeclarations
```

The `namedLetters` tuple contains fields referred to as `Alpha` and `Beta`. Those names exist only at compile time and are not preserved at runtime (when inspecting the tuple using reflection, for example).

In a tuple assignment, you can also specify the names of the fields on the right-hand side of the assignment:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/TupleUses.cs --region DeclareNamesOnTuple
```

If you don't specify any names for the tuple members, the member names are inferred from the variable names on the right side of any initialization:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/TupleUses.cs --region InferMemberNames
```

You can specify names for the fields on both the left and right-hand side of the assignment. In that case, the variable uses the names on the left side of the assignment.

Tuples are most useful as return types for `private` and `internal` methods. Tuples provide a simple syntax for those methods to return multiple discrete values. Creating a tuple is more efficient and more productive that creating a class or struct. It has a simpler, lightweight syntax to define a data structure that carries more than one value. The example method below returns the minimum and maximum values found in a sequence of integers. Try the following code:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/TupleUses.cs --region TupleReturningMethod
```

There may be times when you want to unpackage the members of a tuple that were returned from a method.  You can do that by declaring separate variables for each of the values in the tuple. This is called *deconstructing* the tuple. Add the following code in your browser to try it:

```csharp
(int max, int min) = Range(numbers);
Console.WriteLine(max);
Console.WriteLine(min);
```

As you work with tuples, you'll often find that you don't use all of the members of a tuple result. When that happens, you can discard one or more of the returned values by using `_` in place of a variable. Try the following code yourself:

```csharp
(int maxValue, _) = Range(numbers);
Console.WriteLine(max);
```

You can explore more in the [tuples article](https://docs.microsoft.com/dotnet/csharp/tuples) on docs.microsoft.com.

#### Next: [out variable declarations &raquo;](./out-variable-declaration.md)   Previous: [Generic types and pattern matching  &laquo;](./out-variable-declaration.md) Home: [Home](readme.md)
