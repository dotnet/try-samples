# Optimize memory storage using ref locals and returns

This feature enables algorithms that use and return references to variables defined elsewhere. These features can be used to avoid copying values when passing them to methods, or returning them from methods. By passing and returning references to storage, copies are minimized.

One example is with large matrices and finding a single location with certain characteristics. Let's start by examining a method that returns the two indices that reference a single location in the matrix:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/RefLocalsAndReturns.cs --region RefFindMethod --session RefLocals
```

You can test this method using the following code:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/RefLocalsAndReturns.cs --region RefTestCode --session RefLocals
```

This `Find` method returns the indices to the item in the matrix. That leads callers to write code that uses those indices to dereference the matrix and modify a single element. You'd rather write a method that returns a *reference* to the element of the matrix that you want to change.

Let's walk through a series of changes to demonstrate the ref local feature and show how to create a method that returns a reference to internal storage. Along the way, you'll learn the rules of the ref return and ref local feature that protect you from accidentally misusing it.

#### Next: [From values to references &raquo;](./use-ref-arguments.md)   Home: [Home](readme.md)
