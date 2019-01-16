using Xunit;

namespace Alg.Sorting.Tests
{
    public partial class InsertSortTest
    {
        private InsertSort target;

        public InsertSortTest()
        {
            target = new InsertSort();
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
