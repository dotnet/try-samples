# Query evaluation is lazy

In LINQ, query evaluations are *lazy*. That means the output of a LINQ query isn't generated from the code that defines the query. Instead, it's generated when some code requests the results of the query. To illustrate this behavior, let's separate the code that generates an input sequence from the code that runs the sequence.

This first block of code generates an input sequence using the numbers 1 through 9:

``` cs --region generate-source-sequence --source-file ../src/Program.cs --project ../src/LINQ.csproj --session lazy-evaluation-basic
```

This method is an *iterator method* and is explained in more detail below. For now, what's important is that it displays a message for each new item requested.

This next block of code consumes this sequence, using the LINQ query you say on the previous page:

``` cs --region consume-sequence --source-file ../src/Program.cs --project ../src/LINQ.csproj --session lazy-evaluation-basic
```

Click the *Run* button to try it. Pay attention to the order of the messages.

First, notice that the messages generated from creating the sequence are interspersed with the messages to display the output sequence. But more than that, notice how two elements are generated for each output message. When an even element is generated, it doesn't pass the `where` clause. The query asks for the next input element. That one does pass the filter, so its square is computed and displayed.

Modify the code that generates the sequence, or the code that modifies the sequence to explore on your own.  For a few examples, try the following:

1. Modify the generator to create all the even numbers, then all the odd numbers:
```csharp
for (int i = 2; i < 10; i += 2)
{
    Console.WriteLine($"\tProducing {i}");
    yield return i;
}
for (int i = 1; i < 10; i += 2)
{
    Console.WriteLine($"\tProducing {i}");
    yield return i;
}
```
1. Modify the consumer to change which elements are filtered:
```csharp
where n % 2 == 0
```

Try your own ideas.
