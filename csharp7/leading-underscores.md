# Leading underscores in numeric literals

The implementation of support for digit separators in C# 7.0 didn't allow the _ to be the first character of the literal value. Hex and binary numeric literals may now begin with an _.

```csharp
int binaryValue = 0b_0101_0101;
```

#### Next [Generic constraints &raquo;](./generic-constraints.md) Previous: [Default literal expressions &laquo;](./default-literals.md) Home: [Home](readme.md)
