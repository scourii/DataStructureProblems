using System;
namespace DataStructProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            int total = SumOfArray.SumArray();
            Console.WriteLine($"Sum of your array is: {total}");
            int search = SequenceSearch.Search(10);
            Console.WriteLine($"7 is located at the index value of {search}.");
            SortByDesc Desc = new SortByDesc();
            Console.WriteLine(Desc.SortDesc());
        }
    }
}