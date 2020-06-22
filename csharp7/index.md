# What's new in C# 7.0 thru C# 7.3 - exploration

![dotnet try Enabled](https://img.shields.io/badge/Try_.NET-Enabled-501078.svg)

<p align ="center">
<img src ="https://user-images.githubusercontent.com/2546640/56708992-deee8780-66ec-11e9-9991-eb85abb1d10a.png" width="350">
</p>

The themes of these releases are:

## Better control over allocations and copies

The .NET environment manages memory automatically. However, some scenarios require developers to take more control over the memory footprint of their application. This has meant developers needed to write unsafe code. The goal of these features is to enable developers to achieve the performance of unsafe code while writing verifiably safe code. The features that enable these gains are:

- [ref locals and returns](./ref-locals-returns.md)
- [in and ref readonly](./in-ref-readonly.md)
- [readonly struct](./readonly-struct.md)
- [ref struct](./readonly-struct.md#ref-struct-types)

## Pattern matching

Modern applications are often a collection of different programs that execute on multiple machines and platforms. That separates data from the code that consumes the data. A strict object oriented approach doesn't work as well in these systems. **Pattern matching** enables new ways to examine data using its type, shape, or values. The features added for pattern matching are:

- [pattern matching is expressions](./is-expressions.md)
- [pattern matching with switch](./switch-patterns.md)
- [pattern matching on generic type elements](./generic-patterns.md)

## Tuple data types

Tuples combine both of the previous themes: They are lightweight value types that contain multiple members:

- [Create lightweight data structures using tuples](./declare-tuples.md)

## Preparing for nullable reference types

Features were added to C# 7.x that make it easier to adopt nullable reference types in C# 8. These features reduce the locations where you must declare a variable and initialize it later.

- [Declare out variables when assigned](./out-variable-declaration.md)

Many of these use unsafe code, which aren't available in the local `dotnet try` environment. Learn more about them on docs.microsoft.com:

- [fixed fields without pinning](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-3)
- [stackalloc array initializers](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-3#stackalloc-arrays-support-initializers)
- [Conditional ref expressions](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-2#conditional-ref-expressions)

## Improve code organization and readability

Other features improve your ability to write clear code in a variety of scenarios:

- [local functions](local-functions.md)
- [new generic constraints ](generic-constraints.md)

Two other features aren't in this tutorial. Learn more about them on docs.microsoft.com:

- [attributes on backing fields of properties](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-3#attach-attributes-to-the-backing-fields-for-auto-implemented-properties)
- [Async Main methods](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-1#async-main)
- [default literal expressions](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-1#default-literal-expressions)
- [Leading underscores in numeric literals](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-7-2#leading-underscores-in-numeric-literals)

You can try these scenarios and features in C# 7.x by stepping through the different sections of this tutorial. Or, you can select any of the preceding links to go to the feature you want to explore first.

## Next: [ref locals and returns &raquo;](./ref-locals-returns.md)
