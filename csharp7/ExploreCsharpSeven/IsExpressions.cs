using System;

namespace ExploreCsharpSeven
{
    static class IsExpressions
    {
        public static int ExploreIsPattern()
        {
            #region IsTypePattern
            object count = 5;

            if (count is int number)
                Console.WriteLine(number);
            else
                Console.WriteLine($"{count} is not an integer");
            #endregion
            return 0;
        }
    }
}
