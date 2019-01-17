using Xunit;

namespace Alg.Searching.Tests
{
    public abstract class BaseSearchingTest<T> where T : ISearching, new()
    {
        private readonly ISearching target;

        public BaseSearchingTest()
        {
            target = new T();
        }

        [Theory]
        [ClassData(typeof(SearchingTestData))]
        public virtual void SearchTest(int[] arr, int t, int? expected)
        {
            var actual = target.Execute(arr, t);

            Assert.Equal(expected, actual);
        }
    }
}
