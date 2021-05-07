using System;
using System.Collections;

namespace DataStructProblems
{
    public class SequenceSearch
    {
        public static int Search(int searchValue)
        {
            int[] array = new int[] {1, 2, 3, 4, 5, 6, 10, 7, 8, 9};

            for (int i = 0; i < array.Length; i++)
            {
                if (searchValue == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}