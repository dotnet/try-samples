# Additional improvements

The following block of code demonstrates a few of the additional improvements that make code easier:



Default literal expressions are an enhancement to default value expressions. These expressions initialize a variable to the default value. Where you previously would write:

```csharp
Func<string, bool> whereClause = default(Func<string, bool>);
```

You can now omit the type on the right-hand side of the initialization:

```csharp
Func<string, bool> whereClause = default;
```

You can learn more about this enhancement in the C# Programming Guide article on default value expressions.

This enhancement also changes some of the parsing rules for the default keyword.

# Leading underscores in numeric literals

The implementation of support for digit separators in C# 7.0 didn't allow the _ to be the first character of the literal value. Hex and binary numeric literals may now begin with an _.

```csharp
int binaryValue = 0b_0101_0101;
```

# Attach attributes to the backing fields for auto-implemented properties

This syntax is now supported:

```csharp
[field: SomeThingAboutFieldAttribute]
public int SomeProperty { get; set; }
```

The attribute SomeThingAboutFieldAttribute is applied to the compiler generated backing field for SomeProperty. For more information, see attributes in the C# programming guide.

#### Previous: [New generic constraints &laquo;](./generic-constraints.md) Home: [Home](readme.md)
