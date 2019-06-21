using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreCsharpSeven
{
    class LocalFunctions
    {
        #region LocalFunctionFactorial
        public static int CalculateFactorial(int n)
        {
            return nthFactorial(n);

            int nthFactorial(int number) => (number < 2) ?
                1 : number * nthFactorial(number - 1);
        }
        #endregion

        public static int TestLocalFactorial()
        {
            #region LocalFunctionFactorialTest
            Console.WriteLine(CalculateFactorial(6));
            #endregion
            return 0;
        }

        #region LocalFuntionIteratorMethod
        static IEnumerable<char> AlphabetSubset(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
            for (var c = start; c < end; c++)
                yield return c;
        }
        #endregion

        #region LocalFunctionIteratorWithLocal
        static IEnumerable<char> AlphabetSubsetLocal(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }
        #endregion



        public static int TestSubset()
        {
            #region LocalFunctionsIteratorTest
            try
            {
                var resultSet1 = AlphabetSubset('d', 'r');
                var resultSet2 = AlphabetSubset('f', 'a');
                Console.WriteLine("iterators created");
                foreach (var thing1 in resultSet1)
                    Console.Write($"{thing1}, ");
                Console.WriteLine();
                foreach (var thing2 in resultSet2)
                    Console.Write($"{thing2}, ");
                Console.WriteLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Caught an argument exception");
            }
            return 1;
            #endregion
        }

    }
}
