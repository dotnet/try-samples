using System;
using System.Collections.Generic;

namespace ExploreCsharpSeven
{
    static class TupleUses
    {
        public static int TupleDeclarations()
        {
            #region TupleDeclarations
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");
            #endregion
            return 0;
        }

        public static int DeclareTupleVariable()
        {
            #region DeclareNamesOnTuple
            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");
            #endregion
            return 0;
        }

        public static int InferredTupleNames()
        {
            #region InferMemberNames
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count, label); // element names are "count" and "label"
            Console.WriteLine(pair.count);
            Console.WriteLine(pair.label);
            #endregion
            return 0;
        }

        public static int TupleMinMax()
        {
            #region TupleReturningMethod
            (int Max, int Min) Range(IEnumerable<int> sequence)
            {
                int Min = int.MaxValue;
                int Max = int.MinValue;
                foreach (var n in sequence)
                {
                    Min = (n < Min) ? n : Min;
                    Max = (n > Max) ? n : Max;
                }
                return (Max, Min);
            }

            var numbers = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var range = Range(numbers);
            Console.WriteLine(range);
            #endregion
            return 0;
        }
    }
}
