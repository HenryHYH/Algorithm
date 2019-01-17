namespace Alg.Searching
{
    /// <summary>
    /// 顺序查找
    /// </summary>
    public partial class SequentialSearch : ISearching
    {
        public int? Execute(int[] arr, int t)
        {
            for (int i = 0, iMax = arr.Length; i < iMax; i++)
                if (arr[i] == t)
                    return i;

            return null;
        }
    }
}
