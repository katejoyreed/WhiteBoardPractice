using System;

namespace WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeProblems practice = new PracticeProblems();
            string reverse = practice.ReverseString("hello");
            Console.WriteLine(reverse);
            string cap = practice.Capitalize("welcome home");
            Console.WriteLine(cap);
            string compressed = practice.Compress("aaabbccccdd");
            Console.WriteLine(compressed);
            string palindromeOne = practice.PalindromeChecker("racecar");
            Console.WriteLine(palindromeOne);
            string palindromeTwo = practice.PalindromeChecker("alpha");
            Console.WriteLine(palindromeTwo);

            Console.ReadLine();
        }
    }
}
