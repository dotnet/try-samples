# What's new in C# 7.0 thru C# 7.3 - exploration

This exploration enables you to experiment with the features that have been released in C# 7.0, and the following point releases through C# 7.3. You can try the code in the samples, modify it, and see the effects of using the new features in a variety of scenarios. Some of the features added in the point releases are enhancements and improvements to features first available in C# 7.0. This exploration is organized around the themes across all the C# 7.x features, rather than by release. As you explore each area, enhancements that are available in later point releases are noted.

The themes of these releases are:

## Better control over allocations and copies

The .NET environment manages memory automatically. However, some scenarios require developers to take more control over the memory footprint of their application. This has meant developers needed to write unsafe code. The goal of these features is to enable developers to achieve the performance of unsafe code while writing verifiably safe code. The features that enable these gains are:

- [ref locals and returns](./ref-locals-returns.md)
- [in and ref readonly](./in-ref-readonly.md)
- [readonly struct](./readonly-struct.md)
- [ref struct](./readonly-struct#ref-struct-types.md)

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
- [Conditional ref expressions - 7.2](./conditional-ref-expressions.md)  START HERE 
- [more expression variables in initializers - 7.3](expression-initializers.md)
- [initializers on stackalloc arrays - 7.3](initialize-stackalloc.md)

## Improve code organization and readability

Other features improve your ability to write clear code in a variety of scenarios:

- [local functions](local-functions.md)
- [default literal expressions - 7.1](default-literals.md)
- [Leading underscores in numeric literals - 7.2](leading-underscores.md)
- [new generic constraints - 7.3](generic-constraints.md)
- [attributes on backing fields of properties - 7.3](backing-fields.md)

This exploration doesn't include examples for an `async Main` method, because the `Main` method is part of the scaffolding project for the explorations.
- [fixed fields without pinning - 7.3](./unpinned-fixed.md)
- [non trailing named arguments - 7.2](more-named-arguments.md)
- [private protected access modifier - 7.2](private-protected.md)

You can try these scenarios and features in C# 7.x by stepping through the different sections of this tutorial. Or, you can select any of the preceding links to go to the feature you want to explore first.

## Next: [ref locals and returns &raquo;](./ref-locals-returns.md)
