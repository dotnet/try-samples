# LINQ Query Syntax

Click the `run` icon to get started. Try the following LINQ query:

``` cs --region query-syntax --source-file ../src/Program.cs --project ../src/LINQ.csproj
```

The preceding query shows the major sections of a query: a source for the query, a series of transformations, and a projection that produces results. Following the query, the `foreach` loop consumes the data elements produced by the query. Let's look at each of these components in turn.

First, you have the data source:

```csharp
from n in sequence
```

The `from` clause defines the the *range variable*, `n`, and specifies the the *source*, `sequence`. The *source* specifies the producer of all the elements processed in the query. The *range variable* defines a variable that holds each element of the *source* in turn as the query executes.

Next, you write any number of *transformations*:

```csharp
where n % 2 == 1
```

Every *transformation* produces an output sequence from its input sequence. This transformation is a *filter*. The elements from the input sequence that satisfy the condition `n % 2 == 1` are produced as the output sequence. As you work through more lessons in this tutorial, you'll create more complicated transformations.

Finally, every query ends with a *projection*:

```csharp
select n * n;
```

Every query ends with a *projection* that produces either a new sequence, or a single value. This first example produces a sequence where every element is the square of the input sequence.

You can modify any of these sections in the uery and run it yourself.
