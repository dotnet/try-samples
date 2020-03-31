using System;
using System.Threading.Tasks;

namespace Tasks.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = 5;
            Task<int> pending = SomeMethodAsync(result);

            Console.WriteLine(await pending);
            Console.WriteLine(await pending);
            Console.WriteLine(await pending);
            Console.WriteLine(await pending);
            Console.WriteLine(await pending);
            Console.WriteLine(await pending);
            Console.WriteLine(await pending);

            Console.ReadKey();
        }


        private static async Task<int> SomeMethodAsync(int result)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return result;
        }
    }
}
