using System;
using System.Linq;

namespace Try101LinqSamples
{
    public class QueryExecution
    {
        public int DeferredExecution()
        {
            #region deferred-execution
            // Sequence operators form first-class queries that
            // are not executed until you enumerate over them.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = from n in numbers
                    select ++i;

            // Note, the local variable 'i' is not incremented
            // until each element is evaluated (as a side-effect):
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {i}");
            }
            #endregion
            return 0;
        }

        public int EagerExecution()
        {
            #region eager-execution
            // Methods like ToList() cause the query to be
            // executed immediately, caching the results.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = (from n in numbers
                     select ++i)
                     .ToList();

            // The local variable i has already been fully
            // incremented before we iterate the results:
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {i}");
            }
            #endregion
            return 0;
        }

        public int ReuseQueryDefinition()
        {
            #region reuse-query
            // Deferred execution lets us define a query once
            // and then reuse it later after data changes.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNumbers = from n in numbers
                             where n <= 3
                             select n;

            Console.WriteLine("First run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object,
            // lowNumbers, will be iterating over the new state
            // of numbers[], producing different results:
            Console.WriteLine("Second run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
    }
}
