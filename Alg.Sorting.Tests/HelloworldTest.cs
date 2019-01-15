using Xunit;

namespace Alg.Sorting.Tests
{
    public class HelloworldTest
    {
        private readonly Helloworld target;

        public HelloworldTest()
        {
            target = new Helloworld();
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 4)]
        public void TestGet(int p, int expected)
        {
            Assert.Equal(expected, target.Get(p));
        }
    }
}
