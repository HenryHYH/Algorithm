using System.Collections;
using System.Collections.Generic;

namespace Alg.Searching.Tests
{
    public partial class SearchingTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 2 }, 1, 0 };
            yield return new object[] { new[] { 1, 2 }, 2, 1 };
            yield return new object[] { new[] { 1, 2 }, 3, null };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}