using System;

namespace DataStructProblems
{
    public class SortByDesc
    {
        public string SortDesc()
        {
            string returnString = String.Empty;
            int[] array = new int[] {1, 5, 6, 12, 99, 123, 43, 22, 34, 55, 27};
        
            Array.Sort(array);

            Array.Reverse(array);

            foreach (int i in array)
            {
                returnString = returnString + i + ", ";
            }
            return returnString;

        }
    }
}