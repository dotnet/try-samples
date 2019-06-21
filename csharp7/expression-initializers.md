# Extend expression variables in initializers

The syntax added in C# 7.0 to allow out variable declarations has been extended to include field initializers, property initializers, constructor initializers, and query clauses. It enables code such as the following example:

```csharp
public class B
{
   public B(int i, out int j)
   {
      j = i;
   }
}

public class D : B
{
   public D(int i) : base(i, out var j)
   {
      Console.WriteLine($"The value of 'j' is {j}");
   }
}
```

#### Next: [Initalize stackalloc storage &raquo;](./initialize-stackalloc.md)    Previous: [Conditional ref expressions  &laquo;](./conditional-ref-expressions.md) Home: [Home](readme.md)
