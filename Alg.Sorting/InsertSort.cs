namespace Alg.Sorting
{
    public partial class InsertSort
    {
        public void Execute(ref int[] arr)
        {
            for (int i = 1, iMax = arr.Length; i < iMax; i++)
                Insert(ref arr, i, arr[i]);
        }

        private void Insert(ref int[] arr, int pos, int value)
        {
            var i = pos - 1;
            while (i >= 0 && arr[i] > value)
            {
                arr[i + 1] = arr[i];
                i--;
            }

            arr[i + 1] = value;
        }
    }
}
