using System;
namespace DataStructProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string EvenNew = String.Empty;
            int total = SumOfArray.SumArray();
            Console.WriteLine($"Sum of your array is: {total}");
            int search = SequenceSearch.Search(10);
            Console.WriteLine($"7 is located at the index value of {search}.");
            SortByDesc Desc = new SortByDesc();
            Console.WriteLine(Desc.SortDesc());
            int[] numbers = new int[] {1, 2, 4, 5, 10, 6, 3, 8, 9, 7};
            Console.WriteLine("List of numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(EvenNew);
            RemoveEvenInts.RemoveEven(numbers, 10);
            Console.WriteLine("After removing evens: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(EvenNew);
        }
    }
}
