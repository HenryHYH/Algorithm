namespace Alg.Sorting
{
    public class MergeSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            var len = arr.Length;
            var result = new int[len];
            Merge(arr, result, 0, len - 1);
        }

        private void Merge(int[] arr, int[] result, int start, int end)
        {
            if (start >= end)
                return;

            var len = end - start;
            var mid = (len / 2) + start;
            var start1 = start;
            var end1 = mid;
            var start2 = mid + 1;
            var end2 = end;
            Merge(arr, result, start1, end1);
            Merge(arr, result, start2, end2);

            var k = start;
            while (start1 <= end1 && start2 <= end2)
                result[k++] = arr[start1] < arr[start2] ? arr[start1++] : arr[start2++];
            while (start1 <= end1)
                result[k++] = arr[start1++];
            while (start2 <= end2)
                result[k++] = arr[start2++];
            for (k = start; k <= end; k++)
                arr[k] = result[k];
        }
    }
}
