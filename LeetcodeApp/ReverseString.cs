using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Reverse String 344
    /// </summary>
    public class ReverseString
    {
        /*
            https://leetcode.com/problems/reverse-string/?tab=Description
            Write a function that takes a string as input and returns the string reversed.

            Example:
                Given s = "hello", return "olleh".

                Subscribe to see which companies asked this question.
        */

        public static string ReverseStringFunc(string s)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder sbResult = new StringBuilder();

            foreach(char c in s.ToCharArray())
            {
                stack.Push(c);
            }

            while(stack.Any())
            {
                sbResult.Append(stack.Pop());
            }

            return sbResult.ToString();
        }
    }
}
