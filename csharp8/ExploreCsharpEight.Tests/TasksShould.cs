using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace ExploreCsharpEight.Tests
{
    [TestFixture]
    public class TasksShould
    {
        [Test]
        public async Task Await_multiple_times()
        {
            var result = 5;
            Task<int> pending = SomeMethodAsync(result);
            Check.That(await pending).IsEqualTo(result);
            Check.That(await pending).IsEqualTo(result);
            Check.That(await pending).IsEqualTo(result);
            Check.That(await pending).IsEqualTo(result);
            Check.That(await pending).IsEqualTo(result);
            Check.That(await pending).IsEqualTo(result);
        }

        private async Task<int> SomeMethodAsync(int result)
        {
            await Task.Delay(10);
            return result;
        }
    }
}