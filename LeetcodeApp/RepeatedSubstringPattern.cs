using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Repeated Substring Pattern 459
    /// </summary>
    public class RepeatedSubstringPattern
    {
        /*
            https://leetcode.com/problems/repeated-substring-pattern/?tab=Description
            Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.

            Example 1:
            Input: "abab"
            
            Output: True
            
            Explanation: It's the substring "ab" twice.
            Example 2:
            Input: "aba"
            
            Output: False
            Example 3:
            Input: "abcabcabcabc"
            
            Output: True
            
            Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)
        */

        public static bool RepeatedSubstringPatternFunc(string s)
        {
            int l = s.Count();

            for (int i = l / 2; i >= 1; i--)
            {
                if (l % i == 0)
                {
                    int m = l / i;
                    String subS = s.Substring(0, i);
                    StringBuilder sb = new StringBuilder();

                    for (int j = 0; j < m; j++)
                    {
                        sb.Append(subS);
                    }

                    if (sb.ToString().Equals(s)) return true;
                }
            }

            return false;
        }
    }
}
