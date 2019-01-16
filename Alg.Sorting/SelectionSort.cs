namespace Alg.Sorting
{
    public class SelectionSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            for (int i = 0, len = arr.Length; i < len; i++)
            {
                int min = i;
                for (int j = i + 1; j < len; j++)
                    if (arr[min] > arr[j])
                        min = j;

                Swap(arr, min, i);
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
