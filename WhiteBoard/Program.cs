using System;

namespace WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeProblems practice = new PracticeProblems();
            string spin = practice.SpinWords("Welcome to the jungle");
            Console.WriteLine(spin);

            Console.ReadLine();
        }
    }
}
