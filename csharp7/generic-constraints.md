# Enhanced generic constraints

You can now specify the type System.Enum or System.Delegate as base class constraints for a type parameter.

You can also use the new unmanaged constraint, to specify that a type parameter must be an unmanaged type. An unmanaged type is a type that isn't a reference type and doesn't contain any reference type at any level of nesting.

For more information, see the articles on where generic constraints and constraints on type parameters.

Adding these constraints to existing types is an incompatible change. Closed generic types may no longer meet these new constraints.

#### Next [Attributes on backing fields of properties &raquo;](./backing-fields.md) Previous: [Leading underscores on literals &laquo;](./leading-underscores.md) Home: [Home](readme.md)
