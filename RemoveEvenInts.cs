using System;

namespace DataStructProblems
{
    public class RemoveEvenInts
    {
        public static int[] RemoveEven(int[] numbers, int size)
        {
            int item = 0;
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[item] = numbers[i];
                    ++item;
                }
            }

            int[] result = new int[item];

            for (int i = 0; i < item; i++)
            {
                result[i] = numbers[i];
            }
            numbers = result;
            return numbers;
        }
    }
}