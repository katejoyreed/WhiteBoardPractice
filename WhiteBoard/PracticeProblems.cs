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
        public string Capitalize(string stringtoCapitalize)
        {
            string lowerCase = stringtoCapitalize.ToLower();
            char[] asArray = lowerCase.ToCharArray();
            if(asArray.Length >= 1)
            {
                asArray[0] = char.ToUpper(asArray[0]);
            }
            for (int i = 0; i < asArray.Length; i++)
            {
                
                    if (asArray[i] == ' ')
                    {
                        if (char.IsLower(asArray[i + 1]))
                        {
                            asArray[i + 1] = char.ToUpper(asArray[i + 1]);
                        }
                    }
                
                
            }
            return new string(asArray);
        }
        //Compress string of characters

        //Palindrome

        //Happy Numbers

        //Prime Numbers

        //Fibonacci
    }
}
