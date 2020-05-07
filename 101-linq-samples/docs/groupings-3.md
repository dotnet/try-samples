# LINQ - Nested Grouping Operators with custom comparer

The `group by` and `into` can use custom comparers to separate groups. These queries can be nested.

These samples use the following custom comparer. It compares two strings to see if they are anagrams. (Anagrams are pairs of words formed from the same letters.)

``` cs --region anagram-comparer --session nested-groupby-custom --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

## Groupby with a custom comparer


``` cs --region nested-groupby-custom --session nested-groupby-custom --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Set operations &raquo;](./sets.md) Previous: [Groupings with a custom comparer &laquo;](./orderings-2.md)**

**[Home](../README.md)**
