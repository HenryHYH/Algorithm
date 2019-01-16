namespace Alg.Sorting
{
    /// <summary>
    /// 堆排序
    /// </summary>
    public class HeapSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            BuildHeap(arr, arr.Length);
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, 0, i);
            }
        }

        /// <summary>
        /// 构建二叉树
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="idx"></param>
        /// <param name="max"></param>
        private void Heapify(int[] arr, int idx, int max)
        {
            var left = 2 * idx + 1;
            var right = 2 * idx + 2;
            int largest;

            if (left < max && arr[left] > arr[idx])
                largest = left;
            else
                largest = idx;

            if (right < max && arr[right] > arr[largest])
                largest = right;

            if (largest != idx)
            {
                Swap(arr, idx, largest);
                Heapify(arr, largest, max);
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            var tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        private void BuildHeap(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, i, n);
        }
    }
}
