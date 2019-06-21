# stackalloc arrays support initializers

You've been able to specify the values for elements in an array when you initialize it:

```csharp
var arr = new int[3] {1, 2, 3};
var arr2 = new int[] {1, 2, 3};
```

Now, that same syntax can be applied to arrays that are declared with stackalloc:

```csharp
int* pArr = stackalloc int[3] {1, 2, 3};
int* pArr2 = stackalloc int[] {1, 2, 3};
Span<int> arr = stackalloc [] {1, 2, 3};
```

#### Next: [Local functions &raquo;](./local-functions.md)    Previous: [Expression initializers  &laquo;](./expression-initializers.md) Home: [Home](readme.md)
