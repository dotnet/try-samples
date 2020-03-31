using System.Threading;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace ExploreCsharpEight.Tests
{
    [TestFixture]
    public class TasksShould
    {
        [Test]
        public async Task Task_continuation_runs_on_a_thread_pool_thread()
        {
            var beforeThreadId = Thread.CurrentThread.ManagedThreadId;
            await Task.Delay(1);
            
            var afterThreadId = Thread.CurrentThread.ManagedThreadId;
            Check.That(afterThreadId).IsNotEqualTo(beforeThreadId); // Well they can be different
        }

        [Test]
        public async Task Can_force_continuation_take_place_on_the_initial_synchronizationContext()
        {
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());

            var beforeThreadId = Thread.CurrentThread.ManagedThreadId;
            await Task.Run(async () => await Task.Delay(1))
                .ContinueWith((t, o) =>
                {
                    var afterThreadId = Thread.CurrentThread.ManagedThreadId;
                    Check.That(afterThreadId).IsNotEqualTo(beforeThreadId); // Well they can be different


                }, null, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}