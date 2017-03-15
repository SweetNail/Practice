using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Valid Anagram 242
    /// </summary>
    public class ValidAnagram
    {
        /*
            https://leetcode.com/problems/valid-anagram/#/solutions

            Given two strings s and t, write a function to determine if t is an anagram of s.

            For example,
            s = "anagram", t = "nagaram", return true.
            s = "rat", t = "car", return false.
        */

        public static bool IsAnagram(string s, string t)
        {
            int[] tempResult = new int[26];

            for (int i = 0; i < s.Length; i++) tempResult[s.ToArray()[i] - 'a']++;
            for (int i = 0; i < t.Length; i++) tempResult[t.ToArray()[i] - 'a']--;

            if (tempResult.Max() > 0)
                return false;

            return true;
        }
    }
}
