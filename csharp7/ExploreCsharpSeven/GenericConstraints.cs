using System;
using System.Collections.Generic;

namespace ExploreCsharpSeven
{
    public static class GenericConstraints
    {
        #region DeclareEnumConstraint
        public static Dictionary<int, string> EnumNamedValues<T>() where T : System.Enum
        {
            var result = new Dictionary<int, string>();
            var values = Enum.GetValues(typeof(T));

            foreach (int item in values)
                result.Add(item, Enum.GetName(typeof(T), item));
            return result;
        }
        #endregion

        #region DeclareEnum
        enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }
        #endregion

        public static int TestEnumNamedValues()
        {
            #region TestMapEnumValues
            var map = EnumNamedValues<Rainbow>();

            foreach (var pair in map)
                Console.WriteLine($"{pair.Key}:\t{pair.Value}");
            #endregion
            return 0;
        }
    }
}
