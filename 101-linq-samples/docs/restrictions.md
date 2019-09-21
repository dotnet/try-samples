# LINQ - Restriction Operators

The `where` clause of a LINQ query *restricts* the output sequence. Only the elements that match a condition are added to the output sequence.

## LINQ query structure

This sample uses where to find all elements of an array less than 5. It demonstrates the components of a query, including a `where` clause that filters for small numbers.

``` cs --region where-syntax --source-file ../src/Restrictions.cs --project ../src/Try101LinqSamples.csproj
```

## Filter elements on a property

This sample uses where to find all products that are out of stock. Its `where` clause examines a property of the items in the input sequence.

``` cs --region where-property --source-file ../src/Restrictions.cs --project ../src/Try101LinqSamples.csproj
```

## Filter elements on multiple properties

This sample uses where to find all products that are in stock and cost more than 3.00 per unit.

``` cs --region where-multiple-properties --source-file ../src/Restrictions.cs --project ../src/Try101LinqSamples.csproj
```

## Examine a sequence property of output elements

This sample uses where to find all customers in Washington and then uses the resulting sequence to drill down into their orders.

``` cs --region where-drilldown --source-file ../src/Restrictions.cs --project ../src/Try101LinqSamples.csproj
```

## Filter elements based on position

This sample demonstrates an indexed Where clause that returns digits whose name is shorter than their value.

``` cs --region where-indexed --source-file ../src/Restrictions.cs --project ../src/Try101LinqSamples.csproj
```

Notice that this final example shows the `Where` method rather than the `where` clause. The two forms are equivalent.

**Next: [Projection operators  &raquo;](./projections.md) Previous: [Home &laquo;](../README.md)**
