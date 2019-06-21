# Conditional ref expressions

Finally, the conditional expression may produce a ref result instead of a value result. For example, you would write the following to retrieve a reference to the first element in one of two arrays:

```csharp
ref var r = ref (arr != null ? ref arr[0] : ref otherArr[0]);
```

The variable `r` is a reference to the first value in either `arr` or `otherArr`.

#### Next: [Expression initializers &raquo;](./expression-initializers.md)    Previous: [Out variable declarations  &laquo;](./out-variable-declarations.md) Home: [Home](readme.md)
