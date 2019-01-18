using Alg.Problem.StackQueue;
using Xunit;

namespace Alg.Problem.Tests.StackQueue
{
    public class TwoStackQueueTest
    {
        private readonly TwoStackQueue target;

        public TwoStackQueueTest()
        {
            target = new TwoStackQueue();
        }

        [Fact]
        public void Test()
        {
            target.Add(1);
            target.Add(2);
            Assert.Equal(1, target.Peek());
            target.Add(3);
            Assert.Equal(1, target.Poll());
            target.Add(4);
            Assert.Equal(2, target.Poll());
        }
    }
}
