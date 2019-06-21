using System;

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
    }
}
