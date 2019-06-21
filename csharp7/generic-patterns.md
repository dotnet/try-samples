# Pattern matching on generic type parameters

Looking at the `TestType` method on the previous page, you may be concerned about runtime type checking and possible boxing and unboxing concerns. Starting with C# 7.1, you can alleviate those concerns using generics.

Beginning with C# 7.1, the pattern expression for is and the switch type pattern may have the type of a generic type parameter. This can be most useful when checking types that may be either struct or class types, and you want to avoid boxing.

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/GenericPatterns.cs --region GenericSwitchTypePattern --session GenericSwitchPatterns
```

Modify the declaration of `TestType` so it is a generic method:

```csharp
public static void TestType<T>(T obj)
```

The test code follows.

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/GenericPatterns.cs --region GenericTestTypeWithSwitch --session GenericSwitchPatterns
```

#### Next: [declare tuples &raquo;](./declare-tuples.md)   Previous: [Pattern matching switch expressions &laquo;](./switch-patterns.md) Home: [Home](readme.md)
