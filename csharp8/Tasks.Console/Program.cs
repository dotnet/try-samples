using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());

            var beforeThreadId = Thread.CurrentThread.ManagedThreadId;
            await Task.Run(async () => await Task.Delay(1))
                .ContinueWith((t, o) =>
                {
                    var afterThreadId = Thread.CurrentThread.ManagedThreadId;
                   
                    Console.WriteLine($"Before = {beforeThreadId}; Continuation = {afterThreadId}");

                }, null, TaskScheduler.FromCurrentSynchronizationContext());

        }
    }
}
