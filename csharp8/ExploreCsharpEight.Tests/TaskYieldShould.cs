using System.Threading;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace ExploreCsharpEight.Tests
{
    [TestFixture]
    public class TaskYieldShould
    {
        [Test]
        public async Task Without_task_yield_actually_get_a_real_blocking_method_call()
        {
            var capture = Thread.CurrentThread.ManagedThreadId;
            var threadOfAsyncOp = await DoFakeAsync();
            Check.That(threadOfAsyncOp).IsEqualTo(capture);
        }

        [Test]
        public async Task With_task_yield()
        {
            var capture = Thread.CurrentThread.ManagedThreadId;

            await Task.Yield(); // Task.Yield force to the await operation to start in a different thread.
                                // https://stackoverflow.com/questions/22645024/when-would-i-use-task-yield

            var threadOfAsyncOp = await DoFakeAsync();
            Check.That(threadOfAsyncOp).IsNotEqualTo(capture);
        }

        /// <summary>
        /// Nothing can ensure under the cover of async modifier, it is really a non blocking operation.
        /// </summary>
        /// <returns></returns>
        private async Task<int> DoFakeAsync()
        {
            Thread.Sleep(1);
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}