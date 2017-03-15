using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Longest Palindrome 409
    /// </summary>
    public class LongestPalindrome
    {
        /*
            https://leetcode.com/problems/longest-palindrome/#/description

            Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.

            This is case sensitive, for example "Aa" is not considered a palindrome here.
            
            Note:
            Assume the length of given string will not exceed 1,010.
            
            Example:
            
            Input:
            "abccccdd"
            
            Output:
            7
            
            Explanation:
            One longest palindrome that can be built is "dccaccd", whose length is 7.
        */

        public static int LongestPalindromeFunc(string s)
        {
            int[] tempResult = new int[26];

            foreach(char c in s.ToUpper().ToArray())
            {
                tempResult[(int)c-65]++;
            }

            int result = 0;

            foreach(int i in tempResult)
            {
                result += i / 2;
            }

            if (tempResult.FirstOrDefault(S => S % 2 == 1) != 0)
                return result * 2 + 1;

            return result * 2;
        }
    }
}
