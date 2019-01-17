namespace Alg.Sorting
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var middle = arr[(left + right) / 2];
                var i = left - 1;
                var j = right + 1;

                while (true)
                {
                    while (arr[++i] < middle) ;
                    while (arr[--j] > middle) ;

                    if (i >= j)
                        break;

                    Swap(arr, i, j);
                }

                Sort(arr, left, i - 1);
                Sort(arr, j + 1, right);
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            var tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
