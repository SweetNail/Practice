using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Word Pattern 290
    /// </summary>
    public class WordPattern
    {
        /*
            https://leetcode.com/problems/word-pattern/?tab=Description
            Given a pattern and a string str, find if str follows the same pattern.

            Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.
            
            Examples:
            pattern = "abba", str = "dog cat cat dog" should return true.
            pattern = "abba", str = "dog cat cat fish" should return false.
            pattern = "aaaa", str = "dog cat cat dog" should return false.
            pattern = "abba", str = "dog dog dog dog" should return false.
            Notes:
            You may assume pattern contains only lowercase letters, and str contains lowercase letters separated by a single space.
        */

        public static bool WordPatternFunc(string pattern, string str)
        {
            string[] arr = str.Split(' ');
            Dictionary<char, string> dic = new Dictionary<char, string>();

            if (arr.Count() != pattern.Length)
                return false;

            for(int i =0;i<arr.Length;i++)
            {
                char c = pattern.ToArray()[i];

                if(dic.ContainsKey(c))
                {
                    if (dic[c] != arr[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(arr[i]))
                    {
                        return false;
                    }

                    dic.Add(c, arr[i]);
                }
            }

            return true;
        }
    }
}
