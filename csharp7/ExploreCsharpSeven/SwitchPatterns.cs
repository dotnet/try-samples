using System;

namespace ExploreCsharpSeven
{
    static class SwitchPatterns
    {
        #region SwitchTypePattern
        public static void TestType(object obj)
        {
            switch (obj)
            {
                case int i:
                    Console.WriteLine($"The object is an integer: {i}");
                    break;
                case null:
                    Console.WriteLine($"The object is null");
                    break;
                default:
                    Console.WriteLine($"The object is some other type");
                    break;
            }
        }
        #endregion

        public static int CallTestType()
        {
            #region TestTypeWithSwitch
            TestType(5);
            #endregion
            return 0;
        }
    }
}
