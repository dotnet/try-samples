# Minimize access to code with local functions

You can now declare local functions that are nested inside other functions. This enables you to minimize the visibility of these functions. There are three obvious use cases for local functions:

- Recursive functions.
- Iterator methods.
- Asynchronous methods.

Let's start with recursive methods. Try the following code  to calculate `6!` (factorial):

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/LocalFunctions.cs --region LocalFunctionFactorial --session Factorial
```

Use this block to try it with different values:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/LocalFunctions.cs --region LocalFunctionFactorialTest --session Factorial
```

Local functions are a great way to implement recursive algorithms. Other common uses are for public iterator methods and public async methods. Both types of methods generate     code that reports errors later than programmers might expect. In the case of iterator methods, any exceptions are observed only when calling code that enumerates the returned sequence. In the case of async methods, any exceptions are only observed when the returned `Task` is awaited.

#### Next [Default literal expressions &raquo;](./default-literals.md) Previous: [Initializers on stackalloc arrays &laquo;](./initialize-stackalloc.md) Home: [Home](readme.md)
