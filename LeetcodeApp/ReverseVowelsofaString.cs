using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Reverse Vowels of a String 345
    /// </summary>
    public class ReverseVowelsofaString
    {
        /*
            https://leetcode.com/problems/reverse-vowels-of-a-string/#/description
                
            Write a function that takes a string as input and reverse only the vowels of a string.

            Example 1:
            Given s = "hello", return "holle".
            
            Example 2:
            Given s = "leetcode", return "leotcede".  
        */

        public static string ReverseVowels(string s)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            Stack<char> vowelsTemp = new Stack<char>();

            foreach (char c in s.ToArray())
            {
                if (vowels.Contains(c))
                    vowelsTemp.Push(c);
            }

            StringBuilder sbResult = new StringBuilder();

            for (int i = 0; i < s.ToArray().Length; i++)
            {
                if (vowels.Contains(s.ToArray()[i]))
                {
                    sbResult.Append(vowelsTemp.Pop());
                }
                else
                {
                    sbResult.Append(s.ToArray()[i]);
                }
            }

            return sbResult.ToString();
        }
    }
}
