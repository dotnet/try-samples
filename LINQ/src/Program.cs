using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    ///<summary>This program uses <a href="https://github.com/dotnet/command-line-api/wiki/DragonFruit-overview">System.CommandLine.DragonFruit</a> to accept command line arguments from command line.
    ///<example>Execute: dotnet run --region "HelloWorld" to see the output</example>
    ///</summary>
    public class Program
    {
        ///<param name="region">Takes in the --region option from the code fence options in markdown</param>
        ///<param name="session">Takes in the --session option from the code fence options in markdown</param>
        ///<param name="package">Takes in the --package option from the code fence options in markdown</param>
        ///<param name="project">Takes in the --project option from the code fence options in markdown</param>
        ///<param name="args">Takes in any additional arguments passed in the code fence options in markdown</param>
        ///<see>To learn more see <a href="https://aka.ms/learntdn">our documentation</a></see>
        static int Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            return region switch
            {
                "query-syntax" => QuerySyntax(),
                "generate-source-sequence" => ConsumeSequence(),
                "consume-sequence" => ConsumeSequence(),
                _ => throw new ArgumentException("A --region argument must be passed", nameof(region))
            };
        }

        internal static int QuerySyntax()
        {
            #region query-syntax
            var sequence = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var squaresOfOddNumbers = from n in sequence
                                      where n % 2 == 1
                                      select n * n;

            foreach (var number in squaresOfOddNumbers)
                Console.WriteLine(number);
            #endregion
            return 0;
        }

        internal static int ConsumeSequence()
        {
            #region consume-sequence
            var sequence = GenerateSequence();
            var squaresOfOddNumbers = from n in sequence
                                      where n % 2 == 1
                                      select n * n;

            foreach (var number in squaresOfOddNumbers)
                Console.WriteLine(number);
            #endregion
            return 0;
        }

        #region generate-source-sequence
        internal static IEnumerable<int> GenerateSequence()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"\tProducing {i}");
                yield return i;
            }
        }
        #endregion

    }
}