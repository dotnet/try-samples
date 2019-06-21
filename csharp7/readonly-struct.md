# Declare readonly structs for immutable value types

The intent of the `Point3D` structure is that it is immutable. It's public interface appears to be immutable. However, the compiler can't discern that intent, and that has implications. Most importantly, the compiler can't help you enforce that design intent. A human reader can look at the code and determine that you intend it to be immutable, but that's only a convention. In addition, the compiler must assume that a `Point3D` is not immutable. That means the compiler will create a *defensive copy* when a readonly reference to a `Point3D` accesses a member. Let's look at the `Point3D` structure one more time:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/ReadonlyStruct.cs --region ReadOnlyPoint --session ReadOnlyStruct
```

Change the declaration of `Point3D` by adding the `readonly` modifier:

```csharp
public readonly struct Point3D
```

This has two advantages. First, it exposes any accidental modifications of the struct. You can see this in the error in `ComputeDistance`. Refactor that method, and remove the `distance` member field so that `Point3D` struct us completely immutuble. Second, the compiler can take advantage of the knowledge that `Point3D` is immutable to skip any defensive copies.

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/ReadonlyStruct.cs --region TestReadOnlyPoint --session ReadOnlyStruct
```

Declaring a struct using the readonly modifier informs the compiler that your intent is to create an immutable type. The compiler enforces that design decision with the following rules:

- All field members must be readonly
- All properties must be read-only, including auto-implemented properties.

These two rules are sufficient to ensure that no member of a readonly struct modifies the state of that struct. The struct is immutable. Declare your structs as `readonly` whenever your design intent is to create an immutable value type. Any performance improvements are an added benefit. The readonly struct clearly expresses your design intent.

## ref struct types

A related language feature is the ability to declare a value type that must be constrained to a single stack frame. This restriction enables the compiler to make several optimizations. The primary motivation for this feature was `Span<T>` and related structures. You'll achieve performance improvements from these enhancements by using new and updated .NET APIs that make use of the `Span<T>` type. You can combine these features to create `ref readonly struct` types, such as `ReadonlySpan<T>`.

#### Next: [Pattern matching is expressions &raquo;](./is-expressions.md)   Previous: [in arguments and ref readonly returns &laquo;](./in-ref-readonly.md) Home: [Home](readme.md)
