namespace Alg.Sorting
{
    public class BubbleSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            var tmp = 0;
            bool swapped;
            for (int i = 0, iMax = arr.Length; i < iMax; i++)
            {
                swapped = false;
                for (int j = 0; j < iMax - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        if (!swapped)
                            swapped = true;
                    }
                }
                if (!swapped)
                    return;
            }
        }
    }
}
