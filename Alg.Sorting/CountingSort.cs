using System.Linq;

namespace Alg.Sorting
{
    /// <summary>
    /// 计数排序
    /// </summary>
    public class CountingSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            // 排序arr中的n个元素，范围是[0, k)

            int idx = 0;
            int k = arr.Max() + 1; // 模拟，正常需要从参数传入

            var counting = new int[k];

            for (int i = 0, iMax = arr.Length; i < iMax; i++)
                counting[arr[i]]++;

            for (int i = 0; i < k; i++)
            {
                while (counting[i]-- > 0)
                    arr[idx++] = i;
            }
        }
    }
}
