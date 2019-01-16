using System.Collections;
using System.Collections.Generic;

namespace Alg.Sorting.Tests
{
    public partial class SortingTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 7, 6, 4, 8, 2, 3, 5, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
