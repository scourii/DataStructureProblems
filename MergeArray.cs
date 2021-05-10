using System.Linq;
using System;

namespace DataStructProblems
{
    public class MergeArray
    {
        public static int[] Merge(int[] firstArray, int[] secondArray)
        {
            int[] mergeArray = firstArray.Concat(secondArray).ToArray();
            return mergeArray;
        }
    }
}
