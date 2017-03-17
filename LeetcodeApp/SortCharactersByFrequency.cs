using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Sort Characters By Frequency 451
    /// </summary>
    public class SortCharactersByFrequency
    {
        /*
            https://leetcode.com/problems/sort-characters-by-frequency/#/description

            Given a string, sort it in decreasing order based on the frequency of characters.

            Example 1:
            
            Input:
            "tree"
            
            Output:
            "eert"
            
            Explanation:
            'e' appears twice while 'r' and 't' both appear once.
            So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
            Example 2:
            
            Input:
            "cccaaa"
            
            Output:
            "cccaaa"
            
            Explanation:
            Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
            Note that "cacaca" is incorrect, as the same characters must be together.
            Example 3:
            
            Input:
            "Aabb"
            
            Output:
            "bbAa"
            
            Explanation:
            "bbaA" is also a valid answer, but "Aabb" is incorrect.
            Note that 'A' and 'a' are treated as two different characters.
        */

        public static string FrequencySort(string s)
        {
            Dictionary<char, int> tempResult = new Dictionary<char, int>();

            foreach (char c in s.ToArray())
            {
                if (tempResult.Keys.Contains(c))
                {
                    tempResult[c]++;
                }
                else
                {
                    tempResult.Add(c, 1);
                }
            }

            StringBuilder sbResult = new StringBuilder();
            tempResult.OrderByDescending(S => S.Value).ToList().ForEach(S => { int i = S.Value; while (i > 0) { sbResult.Append(S.Key); i--; } });

            return sbResult.ToString();
        }
    }
}
