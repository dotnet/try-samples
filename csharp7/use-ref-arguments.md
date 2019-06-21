# Use ref instead of values

Let's start by modifying the `Find` method to return a reference to an element in matrix. Change the return type of the `Find` method from `(int i, int j)` to `ref int`.

After that change, you'll need to modify both return statements. The first should return the element instead of the indices:

```csharp
return matrix[i,j];
```

Note this doesn't compile. You need to add the `ef` modifier to the return statement. This makes it clear that the code returns a reference, not a value.

```csharp
return ref matrix[i,j];
```

The second `return` should throw an exception instead of returning invalid indices, because you can't return a reference to a "not found" element:

```csharp
throw new InvalidOperationException("Not found");
```

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/RefLocalsAndReturns.cs --region RefFindMethod --session RefUpdates
```

The `Find` method now returns a reference to the found element. This introduces compiler errors in the code that tests this method. Replace the last three lines of the code below with the following code:

```csharp
var valItem = Find(sourceMatrix, (val) => val == 42);
Console.WriteLine(valItem);
valItem = 24;
Console.WriteLine(sourceMatrix[4, 2]);
```

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/RefLocalsAndReturns.cs --region RefTestCode --session RefUpdates
```

Try this code. The value in `sourceMatrix` doesn't change. That's because `valItem` is not declared as a `ref` local variable. Because it's declared as a value, the return value is *copied*. Add the `ref` modifier before `var` in the declaration of `valItem`.  That introces a new compiler error. Add the `ref` modifier before the `Find` method name to fix it:

```csharp
ref var valItem = ref Find(sourceMatrix, (val) => val == 42);
```

When first introduced, you couldn't reassign the reference that a `ref` local variable refers to. Beginning with 7.3, you can reassign a ref local variable. Add the following code to the bottom of the test code:

```csharp
valItem = Find(sourceMatrix, (val) => val == 16);
```

The C# language has three other rules that protect you from misusing the `ref` locals and returns:

* You cannot assign a standard method return value to a `ref` local variable.
* You cannot return a `ref` to a variable whose lifetime does not extend beyond the execution of the method.
* `ref` locals and returns can't be used with async methods.

The addition of ref locals and ref returns enable algorithms that are more efficient by avoiding copying values or performing dereferencing operations multiple times.

#### Next: [in arguments and ref readonly returns &raquo;](./in-ref-readonly.md)   Previous: [ref locals and returns &laquo;](./ref-locals-returns.md) Home: [Home](readme.md)
