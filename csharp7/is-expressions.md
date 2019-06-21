# Use the type pattern with the is expression

The `is` pattern expression extends the familiar `is` operator to query an object beyond its type.

Try the following code:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/IsExpressions.cs --region IsTypePattern
```

Change the variable declaration to a string instead:

```csharp
object count = "5";
```

Now, the `is` expression is false, so the `else` branch is executed. Try to change `count` to `number` in the else branch:

```csharp
Console.WriteLine($"{number} is not an integer");
```

That change won't compile because `number` isn't assigned in the `else` branch. It's only assigned in the `true` branch of the `if` statement.

In addition to the type pattern, you can use the constant pattern with the `is` statement. Add the following lines before the first `if` statement:

```csharp
if (count is 0)
    Console.WriteLine("count is zero");
```

Modify the declaration of `count` to try different values.

The `is` expression type pattern is useful when you have a small number of types to test against. Often, you may need to test multiple types. That requires the pattern matching `switch` statement.

#### Next: [Pattern matching with switch &raquo;](./switch-patterns.md)   Previous: [Readonly struct types &laquo;](./readonly-struct.md) Home: [Home](readme.md)
