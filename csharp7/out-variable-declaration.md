# Out variable declarations at the assignment location

One technique to ensure references are never set to null is to ensure every local variable of a reference type is initialized when it is declared. This is often referred to as *non-null by construction*. That previously wasn't easy for variables you intend to initialize by passing them to methods as `out` parameters. Starting with C# 7.0, you can declare `out` variables in the argument list of a method call, rather than writing a separate declaration statement. Try the following code:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/OutVariableDeclarations.cs --region OutVariableDeclarations
```

You can change the `int` declaration to a `var` declaration. Change the declaration to the following code:

```csharp
if (int.TryParse(input, out var result))
```

The new syntax provides two important advantages over the existing syntax:

* The code is easier to read.
   - You declare the out variable where you use it, not on another line above.
* No need to assign an initial value.
   - By declaring the `out` variable where it is used in a method call, you can't accidentally use it before it is correctly assigned.

The declared variable's scope is the scope enclosing the `if` statement. This allows you to use the variable afterwards. Modify the last `if` block as shown in the following snippet.

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/OutVariableDeclarations.cs --region OutVariableDeclarationScope
```

In C# 7.1, out variable declarations have been extended to include field initializers, property initializers, constructor initializers, and query clauses. It enables code such as the following example:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/OutVariableDeclarations.cs --region DeclareOutQueryVariable
```

#### Next: [Local functions &raquo;](./local-functions.md)  Previous: [Declare lightweight types with tuples  &laquo;](./declare-tuples.md) Home: [Home](readme.md)
