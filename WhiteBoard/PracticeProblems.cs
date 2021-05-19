using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteBoard
{
    class PracticeProblems
    {
        //Reverse a string

        public string ReverseString (string thingToReverse)
        {
            char[] stringAsArray = thingToReverse.ToCharArray();
            Array.Reverse(stringAsArray);
            return new string(stringAsArray);
        }

        //Capitalize first letter of every word

        //Compress string of characters

        //Palindrome

        //Happy Numbers

        //Prime Numbers

        //Fibonacci
    }
}
