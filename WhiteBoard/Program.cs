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


            Console.ReadLine();
        }
    }
}
