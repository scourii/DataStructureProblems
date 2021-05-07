using System;
using System.Collections.Generic;

namespace DataStructProblems
{
    public class SumOfArray
    {
        public static int SumArray()
        {
            int sum = 0;
            int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;

        }
    }
}