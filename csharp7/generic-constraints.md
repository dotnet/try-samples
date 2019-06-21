# Enhanced generic constraints

some of the restrictions on generic constraints have been removed. You can now specify the type `System.Enum` or `System.Delegate` as base class constraints for a type parameter.

You can also use the new `unmanaged` constraint, to specify that a type parameter must be an `unmanaged` type. An `unmanaged` type is a type that isn't a reference type and doesn't contain any reference type at any level of nesting.

Consider the following generic method that builds a dictionary of all the values in an enum mapped to the string representations:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/GenericConstraints.cs --region DeclareEnumConstraint --session Generics
```

Next, declare an `enum` type:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/GenericConstraints.cs --region DeclareEnum --session Generics
```

Finally, test how it works:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/GenericConstraints.cs --region TestMapEnumValues --session Generics
```

Modify the `enum` values, or the method declaration or test code to experiment on your own.

####  Previous: [Local functions &laquo;](./local-functions.md) Home: [Home](readme.md)
