# Attach attributes to the backing fields for auto-implemented properties

This syntax is now supported:

```csharp
[field: SomeThingAboutFieldAttribute]
public int SomeProperty { get; set; }
```

The attribute SomeThingAboutFieldAttribute is applied to the compiler generated backing field for SomeProperty. For more information, see attributes in the C# programming guide.

#### Previous: [New generic constraints &laquo;](./generic-constraints.md) Home: [Home](readme.md)
