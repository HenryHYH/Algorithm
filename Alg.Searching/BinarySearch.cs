namespace Alg.Searching
{
    public partial class BinarySearch : ISearching
    {
        public int? Execute(int[] arr, int t)
        {
            var low = 0;
            var high = arr.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;

                if (t < arr[mid])
                    high = mid - 1;
                else if (arr[mid] < t)
                    low = mid + 1;
                else
                    return mid;
            }

            return null;
        }
    }
}
