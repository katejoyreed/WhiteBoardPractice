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
        public string Compress(string toCompress)
        {
            char[] asArray = toCompress.ToCharArray();
            int charCounter = 0;
            List<string> compressed = new List<string>();
            for (int i = 0; i < asArray.Length; i++)
            {
                
                if(i < asArray.Length - 1)
                {
                    if (asArray[i] != asArray[i + 1] || i == asArray.Length - 1)
                    {
                        charCounter++;
                        string count = charCounter.ToString();
                        compressed.Add(count);
                        string letter = asArray[i].ToString();
                        compressed.Add(letter);
                        charCounter = 0;
                    }
                    else if (asArray[i] == asArray[i + 1])
                    {
                        charCounter++;
                    }
                }
                
            }
            var finalString = new StringBuilder();
            foreach(var x in compressed)
            {
                finalString.Append(x);
            }
            return (finalString.ToString());
        }
        //Palindrome
        public string PalindromeChecker(string palindrome)
        {
            string lower = palindrome.ToLower();
            char[] array = lower.ToCharArray();
            Array.Reverse(array);
            string reversed = new string(array);
            if(reversed == lower)
            {
                string yes = "Yes, " + lower + " is a palindrome";
                return (yes);
            }
            else 
            {
                string no = "No, " + lower + " is not a palindrome";
                return (no);
            }
            
        }
        //Happy Numbers
        public bool HappyNumber(string numToCheck)
        {
            int num = Int32.Parse(numToCheck);
            int rem = 0, sum = 0;
            
            while (sum != 1 && sum != 10 && sum != 4)
            {
                if (num > 0)
                {
                    rem = num % 10;
                    sum = sum + (rem * rem);
                    num = num / 10;
                }
            }
            if (sum == 1 || sum == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //Spin Words with five or more letters
        public string SpinWords(string spin)
        {
            string[] words = spin.Split(' ');
            List<string> sentence = new List<string>();
            foreach(var word in words)
            {
                char[] letters = word.ToCharArray();

                if(letters.Length < 5)
                {
                    sentence.Add(new string(letters));
                }
                else 
                {
                    Array.Reverse(letters);
                    sentence.Add(new string(letters));
                }
            }
            var finalSentence = new StringBuilder();
            foreach(var word in sentence)
            {
                finalSentence.Append(word + " ");
            }
            return finalSentence.ToString();
        }
        
    }
}
