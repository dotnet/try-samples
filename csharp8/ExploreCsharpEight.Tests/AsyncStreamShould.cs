using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace ExploreCsharpEight.Tests
{
    [TestFixture]
    public class AsyncStreamShould
    {
        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(1);
                yield return i;
            }
        }

        public async Task<IEnumerable<int>> Consume(IAsyncEnumerable<int> stream)
        {
            var list = new List<int>();
            await foreach (var i in stream)
            {
                list.Add(i);
            }

            return list;
        }

        [Test]
        public async Task Can_get_future_list()
        {
            var result = await Consume(GenerateSequence());
            Check.That(result).ContainsExactly(Enumerable.Range(0, 20));
        }
    }
}