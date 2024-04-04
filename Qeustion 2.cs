using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubString
{
    internal class SubString
    {
        static void Main()
        {
            //string input1 = "abcabcbb";
            //string input2 = "bbbbb";
            //string input3 = "pwwkew";

            // Either pass the input1, input2 and input3 or pass the strings directly.

            Console.WriteLine(GetLengthOfLongestSubstring("abcabcbb")); 
            Console.WriteLine(GetLengthOfLongestSubstring("bbbbb"));    
            Console.WriteLine(GetLengthOfLongestSubstring("pwwkew"));
            Console.ReadKey();
        }

        static int GetLengthOfLongestSubstring(string inputString)
        {
            int maxLength = 0;
            int left = 0;

            for (int right = 0; right < inputString.Length; right++)
            {
                char currentChar = inputString[right];
                // Checking if the current character has appeared in the substring
                for (int i = left; i < right; i++)
                {
                    if (inputString[i] == currentChar)
                    {
                        left = i + 1;
                        break;
                    }
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
