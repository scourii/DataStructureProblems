using System;
namespace DataStructProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string EvenNew = String.Empty;
            int[] firstArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] secondArray = new int[] {50, 51, 52, 53, 54, 55, 56, 57, 58, 59};
            int total = SumOfArray.SumArray();
            Console.WriteLine($"Sum of your array is: {total}");
            int search = SequenceSearch.Search(10);
            Console.WriteLine($"7 is located at the index value of {search}.");
            SortByDesc Desc = new SortByDesc();
            Console.WriteLine(Desc.SortDesc());
            int[] numbers = new int[] {1, 2, 4, 5, 10, 6, 3, 8, 9, 7};
            Console.WriteLine("\nList of numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            
            RemoveEvenInts.RemoveEven(numbers, 10);
            Console.WriteLine("\nAfter removing evens: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(EvenNew);
            
            // MergeArray
            Console.WriteLine("\nFirst array to be merged:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine("\nSecond array to be merged:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
            Console.WriteLine("\nMerged array:");
            
            int[] mergedArray = MergeArray.Merge(firstArray, secondArray);
            Console.WriteLine(String.Join(" ", mergedArray));
        }
    }
}
