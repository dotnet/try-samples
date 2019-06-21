using System;
using System.Threading.Tasks;

namespace ExploreCsharpSeven
{
    public class Program
    {
        public static int Main(string? region = null,
            string? session = null,
            string? package = null,
            string? project = null,
            string[]? args = null)
        {
            return region switch
            {
                "OutVariableDeclarations" => OutVariableDeclarations.DeclareAtUse(),
                "OutVariableDeclarationScope" => OutVariableDeclarations.ExploreScope(),
                "TupleDeclarations" => TupleUses.TupleDeclarations(),
                "DeclareNamesOnTuple" => TupleUses.DeclareTupleVariable(),
                "TupleReturningMethod" => TupleUses.TupleMinMax(),
                "IsTypePattern" => IsExpressions.ExploreIsPattern(),
                "TestTypeWithSwitch" => SwitchPatterns.CallTestType(),
                "SwitchTypePattern" => SwitchPatterns.CallTestType(),
                "RefFindMethod" => RefLocalsAndReturns.TestRefFind(),
                "RefTestCode" => RefLocalsAndReturns.TestRefFind(),
                "LocalFunctionFactorial" => LocalFunctions.TestLocalFactorial(),
                "LocalFunctionFactorialTest" => LocalFunctions.TestLocalFactorial(),
                "LocalFuntionIteratorMethod" => LocalFunctions.TestSubset(),
                "LocalFunctionIteratorWithLocal" => LocalFunctions.TestSubset(),
                "LocalFunctionsIteratorTest" => LocalFunctions.TestSubset(),
                "PointStructure" => InReadonly.ModifyTheOrigin(),
                "UsePointstructure" => InReadonly.ModifyTheOrigin(),
                "ReadOnlyPoint" => ReadonlyStruct.ModifyTheOrigin(),
                "TestReadOnlyPoint" => ReadonlyStruct.ModifyTheOrigin(),
                "GenericSwitchTypePattern" => GenericPatterns.CallTestType(),
                "GenericTestTypeWithSwitch" => GenericPatterns.CallTestType(),
                "InferMemberNames" => TupleUses.InferredTupleNames(),
                "DeclareOutQueryVariable" => OutVariableDeclarations.OutVarQuery(),
                "DeclareEnumConstraint" =>  GenericConstraints.TestEnumNamedValues(),
                "DeclareEnum" => GenericConstraints.TestEnumNamedValues(),
                "TestMapEnumValues" => GenericConstraints.TestEnumNamedValues(),
                _ => RunAll()
            };
         }

        public static int RunAll()
        {
            OutVariableDeclarations.DeclareAtUse();
            OutVariableDeclarations.ExploreScope();
            TupleUses.TupleDeclarations();
            TupleUses.DeclareTupleVariable();
            TupleUses.TupleMinMax();
            IsExpressions.ExploreIsPattern();
            SwitchPatterns.CallTestType();
            RefLocalsAndReturns.TestRefFind();
            LocalFunctions.TestLocalFactorial();
            LocalFunctions.TestSubset();
            InReadonly.ModifyTheOrigin();
            ReadonlyStruct.ModifyTheOrigin();
            GenericPatterns.CallTestType();
            TupleUses.InferredTupleNames();
            OutVariableDeclarations.OutVarQuery();
            GenericConstraints.TestEnumNamedValues();
            return 0;
        }
    }
}
