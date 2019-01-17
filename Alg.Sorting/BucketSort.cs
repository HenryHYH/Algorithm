using System.Collections.Generic;

namespace Alg.Sorting
{
    /// <summary>
    /// 桶排序
    /// </summary>
    /// <remarks>
    /// 需要满足
    /// 1.均匀分布
    /// 输入数据需要均匀分布在一个给定的范围内。
    /// 2.有序散列函数
    /// 桶必须有是有序的。也就是说，如果i小于j，桶b[i]中的元素要字典序小于桶b[j]中的元素
    /// 桶排序不适合排序随机字符串，但是，它能够被用来排序在区间[0,1)内均匀分配的浮点数
    /// </remarks>
    public class BucketSort : ISort
    {
        public void Execute(ref int[] arr)
        {
            int max = arr[0],
                min = arr[0];

            foreach (var item in arr)
            {
                if (max < item)
                    max = item;
                if (min > item)
                    min = item;
            }

            var bucketNum = max / 10 - min / 10 + 1;
            var buckList = new List<List<int>>();
            // Create bucket
            for (var i = 1; i <= bucketNum; i++)
                buckList.Add(new List<int>());
            // Push into bucket
            for (int i = 0, iMax = arr.Length; i < iMax; i++)
            {
                var idx = IndexFor(arr[i], min, 10);
                buckList[idx].Add(arr[i]);
            }

            InsertionSort insertionSort = new InsertionSort();
            List<int> bucket = null;
            var index = 0;
            for (var i = 0; i < bucketNum; i++)
            {
                bucket = buckList[i];
                var bucketArr = bucket.ToArray();
                insertionSort.Execute(ref bucketArr);
                foreach (var item in bucketArr)
                    arr[index++] = item;
            }
        }

        private int IndexFor(int item, int min, int step)
        {
            return (item - min) / step;
        }
    }
}
