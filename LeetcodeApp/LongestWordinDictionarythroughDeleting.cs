using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Longest Word in Dictionary through Deleting 524
    /// </summary>
    public class LongestWordinDictionarythroughDeleting
    {
        /*
            https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/#/description

            Given a string and a string dictionary, find the longest string in the dictionary that can be formed by deleting some characters of the given string. If there are more than one possible results, return the longest word with the smallest lexicographical order. If there is no possible result, return the empty string.

            Example 1:
            Input:
            s = "abpcplea", d = ["ale","apple","monkey","plea"]
            Output: 
            "apple"

            Example 2:
            Input:
            s = "abpcplea", d = ["a","b","c"]
            Output: 
            "a"
        */

        public static string FindLongestWord(string s, List<string> d)
        {
            Stack<char> stack = new Stack<char>();

            foreach(char c in s.ToArray())
            {
                stack.Push(c);
            }

            d = d.OrderBy(S => S.Length).ToList();

            foreach(string str in d)
            {
                foreach (char c in str.ToArray())
                {
                    if(stack.Peek() == c)
                    {
                        stack.Pop();
                    }
                }
            }

            return string.Empty;
        }
    }
}
