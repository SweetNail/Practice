using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Valid Parentheses 20
    /// </summary>
    public class ValidParentheses
    {
        /*
            https://leetcode.com/problems/valid-parentheses/?tab=Description
            
            Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
            
            Subscribe to see which companies asked this question.
        */

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach(char c in s.ToArray())
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Pop() != c || !stack.Any())
                    {
                        return false;
                    }
                }
            }

            return !stack.Any();
        }
    }
}
