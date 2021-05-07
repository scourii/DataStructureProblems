using System;
using System.Collections;

namespace DataStructProblems
{
    class SplitString
    {
        static void SplitStringMethod()
        {
            string name = "Bryan Rodriguez";

            int indexOfFirst = name.IndexOf(' ');
            int indexOfLast = name.Length - indexOfFirst -1;
            string firstname = name.Substring(startIndex: 0, length: indexOfFirst);
            string lastname = name.Substring(startIndex: name.Length - indexOfLast, length: indexOfLast);
            Console.WriteLine($"Firstname: {firstname} Lastname: {lastname}");
            ReadOnlySpan<char> nameasSpan = name.AsSpan();
            var firstnameSpan = nameasSpan[0..indexOfFirst];
            var lastnameSpan = nameasSpan[^indexOfLast..^0];
            Console.WriteLine("Firstname: {0} Lastname: {1}", arg0: firstnameSpan.ToString(), arg1: lastnameSpan.ToString());
        }
    }
}
