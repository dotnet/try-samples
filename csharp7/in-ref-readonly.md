# Use ref readonly return statements for large structures

The previous example showed one scenario for using `ref` variables for return values and local variables: You intended to pass by reference so that callers could modify the returned value. Another common scenario is to use pass-by-reference to avoid copying larger structures. Consider this `Point3D` structure:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/InReadonly.cs --region PointStructure --session InReadonly
```

Imagine that this structure is used in an application that creates millions of points, and performs a variety of computations on those points. The size of the `Point3D` structure means the cost of copying those structures is likely larger than the cost of working with references to them. Let's make some modifications to this class to pass instances by references. You'll learn how to do that safely, and enable optimizations from the compiler.

Start by changing the `Origin` property to return a reference to the origin:

```csharp
public static ref Point3D Origin => ref origin;
```

To achieve any performance benefits from this change, modify the code below to declare `start` as a `ref` variable and see what happens:

```csharp
ref var start = ref Point3D.Origin;
```

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/InReadonly.cs --region UsePointstructure --session InReadonly
```

You can prevent this kind of coding error by declaring the `Origin` property to return a `ref readonly` reference:

```csharp
public static ref readonly Point3D Origin => ref origin;
```

The compiler generates an error on the declaration of `start`. Add the `readonly` modifier after `ref` to fix it. That moves the error later where the code modifies `start`. Introduce a new variable instead of modifying `start`.

These two changes show how adding the `readonly` modifier to `ref` variables and returns prevent unintended modifications. There are still changes you can make that enable the compiler to perform more optimizations. The `Translate` method could take its first input as a `ref` argument, but you don't want to allow modifications. Instead, use the `in` modifier to disallow any changes to the point or its members:

```csharp
public static Point3D Translate(in Point3D source, double dX, double dY, double dZ)
```

The primary motivation for adding these features in your code is performance. If you find that copying structures has a negative impact on your application, consider using pass-by-reference and readonly references to minimize the copies.

#### Next: [readonly structs &raquo;](./readonly-struct.md)   Previous: [From values to ref &laquo;](./use-ref-arguments.md) Home: [Home](readme.md)
