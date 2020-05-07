# LINQ - Grouping Operators with custom comparer

The `group by` and `into` can use custom comparers to separate groups.

These samples use the following custom comparer. It compares two strings to see if they are anagrams. (Anagrams are pairs of words formed from the same letters.)

``` cs --region anagram-comparer --session groupby-custom-comparer --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

## Groupby with a custom comparer


``` cs --region groupby-custom-comparer --session groupby-custom-comparer --source-file ../src/Groupings.cs --project ../src/Try101LinqSamples.csproj
```

**Next: [Nested groupings with a custom comparer &raquo;](./groupings-3.md) Previous: [Groupings &laquo;](./groupings.md)**

**[Home](../README.md)**
