using Xunit;

namespace Alg.Sorting.Tests
{
    public class BaseSortTest<T> where T : ISort, new()
    {
        private readonly T target;

        public BaseSortTest()
        {
            target = new T();
        }

        [Theory]
        [ClassData(typeof(SortingTestData))]
        public void TestSort(int[] source, int[] expected)
        {
            target.Execute(ref source);
            Assert.Equal(expected, source);
        }
    }
}
