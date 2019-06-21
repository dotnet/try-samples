# Local iterator methods

Iterator methods are easier to explore in this environment, so let's use those in this exploration. The following iterator method returns a sequence of letters from a starting letter to an ending letter:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/LocalFunctions.cs --region LocalFuntionIteratorMethod --session IteratorMethod
```

Try the following test code. It makes some invalid calls to the iterator method. Note when the exception is thrown:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/LocalFunctions.cs --region LocalFunctionsIteratorTest --session IteratorMethod
```

The exception is thrown when the code begins iterating the second result set. The code that iterates the first result set has already run. This sample is both small and doesn't change any data structures, so it's harmless and easy to fix. But, in a larger program, where the two iterator objects may be created in different child methods the root cause could be hard to find. If the first iterator method changed data state, it could even cause data corruption. You'd prefer the exception was thrown immediately, before any work is done. You can refactor the code so that the public method validates all arguments, and a local function performs the enumeration. Modify the preceding test code to call `AlphabetSubsetLocal` to observe the differences:

```cs --project ./ExploreCsharpSeven/ExploreCsharpSeven.csproj --source-file ./ExploreCsharpSeven/LocalFunctions.cs --region LocalFunctionIteratorWithLocal --session IteratorMethod
```

The preceding version makes it clear that the local method is referenced only in the context of the outer method. The rules for local functions also ensure that a developer can't accidentally call the local function from another location in the class and bypass the argument validation.

The same technique can be employed with `async` methods to ensure that exceptions arising from argument validation are thrown before the asynchronous
work begins.

#### Next [New generic constraints &raquo;](./generic-constraints.md)    Previous:   [Local functions &laquo;](./local-functions.md) Home: [Home](readme.md)
