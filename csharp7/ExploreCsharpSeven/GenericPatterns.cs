using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreCsharpSeven
{
    static class GenericPatterns
    {
        #region GenericSwitchTypePattern
        public static void TestType(object obj)
        {
            switch (obj)
            {
                case 5:
                    Console.WriteLine("The object is 5");
                    break;
                case int i:
                    Console.WriteLine($"The object is an integer: {i}");
                    break;
                case null:
                    Console.WriteLine($"The object is null");
                    break;
                case long l:
                    Console.WriteLine($"The object is a long: {l}");
                    break;
                case double d:
                    Console.WriteLine($"The object is a double: {d}");
                    break;
                case string s when s.StartsWith("This"):
                    Console.WriteLine($"This was a string that started with the word 'This': {s}");
                    break;
                case string s when s.StartsWith("This"):
                    Console.WriteLine($"This was a string that started with the word 'This': {s}");
                    break;
                case string s:
                    Console.WriteLine($"The object is a string: {s}");
                    break;
                default:
                    Console.WriteLine($"The object is some other type");
                    break;
            }
        }
        #endregion

        public static int CallTestType()
        {
            #region GenericTestTypeWithSwitch
            TestType(5);
            long longValue = 12;
            TestType(longValue);
            int? answer = 42;
            TestType(answer);
            double pi = 3.14;
            TestType(pi);
            string sum = "12";
            TestType(sum);
            answer = null;
            TestType(answer);
            string message = "This is a longer message";
            TestType(message);
            #endregion
            return 0;
        }
    }
}
