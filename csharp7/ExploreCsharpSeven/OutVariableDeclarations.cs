using System;
using System.Linq;

namespace ExploreCsharpSeven
{
    static class OutVariableDeclarations
    {
        public static int DeclareAtUse()
        {
            #region OutVariableDeclarations
            var input = "1234";
            if (int.TryParse(input, out int result))
                Console.WriteLine(result);
            else
                Console.WriteLine("Could not parse input");
            #endregion
            return 0;
        }

        public static int ExploreScope()
        {
            #region OutVariableDeclarationScope
            var input = "1234";
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Could not parse input");
                return 1;
            }
            Console.WriteLine(result);
            #endregion
            return 0;
        }

        public static int OutVarQuery()
        {
            #region DeclareOutQueryVariable
            string[] input = { "1", "2", "3", "4", "five", "6", "7" };
            var numbers = from s in input
                          select (success: int.TryParse(s, out int result), result);
            foreach (var item in numbers)
                Console.WriteLine($"{(item.success ? "Success  result is: " : "Failed to parse")}\t{(item.success ? item.result.ToString() : string.Empty)}");
            #endregion
            return 0;
        }
    }
}
