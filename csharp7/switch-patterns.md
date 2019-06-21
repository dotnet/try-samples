# Pattern matching in the switch statement

The *match expression* has a familiar syntax, based on the `switch` statement already part of the C# language. Let's start with a small sample based on the `is` expression syntax you explored on the previous page:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/SwitchPatterns.cs --region SwitchTypePattern --session SwitchPatterns
```

You can try that code using the following method call:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/SwitchPatterns.cs --region TestTypeWithSwitch --session SwitchPatterns
```

The preceding code checks for an `int` or `null`. Every other type reached the default case. Add the following two lines to verify the behavior:

```csharp
long longValue = 12;
TestType(longValue);
```

The `switch` expression will convert a nullable type to its corresponding type. Add the following to verify:

```csharp
int? answer = 42;
TestType(answer);
```

You can add any number of other type pattern expressions to the switch statements. Add these before the `null` case:

```csharp
case long l:
    Console.WriteLine($"The object is a long: {l}");
    break;
case double d:
    Console.WriteLine($"The object is a double: {d}");
    break;
case string s when s.StartsWith("This"):
    Console.WriteLine($"This was a string that started with the word 'This': {s}");
    break;
case string s:
    Console.WriteLine($"The object is a string: {s}");
    break;
```

Make sure these work by adding the following tests:

```csharp
double pi = 3.14;
TestType(pi);
string sum = "12";
TestType(sum);
answer = null;
TestType(answer);
```

The match expressions also support constants. This can save time by factoring out simple cases:

```csharp
case 5:
    Console.WriteLine("The object is 5");
    break;
```

You must add the preceding case *before* the `case int:` expression. If you add it after that case, the compiler warns you that it has already been handled by a previous case.

You can add a `when` clause to any pattern case so that you can test other conditions beyond a type or a constant value. Try it by adding the following case above the general `string` case:

```csharp
case string s when s.StartsWith("This"):
    Console.WriteLine($"This was a string that started with the word 'This': {s}");
    break;
```

Test it with something like the following code:

```csharp
string message = "This is a longer message";
TestType(message);
```

The new syntax for pattern matching expressions makes it easier to create dispatch algorithms using a clear and concise syntax based on an object's type or other properties. Pattern matching expressions enable these constructs on data types that are unrelated by inheritance.

You can learn more about pattern matching in the article dedicated to [pattern matching in C#](../../pattern-matching.md).

#### Next: [Generic type expressions &raquo;](./generic-patterns.md)   Previous: [Pattern matching is expressions &laquo;](./is-expressions.md) Home: [Home](readme.md)
