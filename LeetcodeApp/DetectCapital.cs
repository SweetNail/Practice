using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Detect Capital 520
    /// </summary>
    public class DetectCapital
    {
        /*
            https://leetcode.com/problems/detect-capital/?tab=Description
            Given a word, you need to judge whether the usage of capitals in it is right or not.

            We define the usage of capitals in a word to be right when one of the following cases holds:
            
            All letters in this word are capitals, like "USA".
            All letters in this word are not capitals, like "leetcode".
            Only the first letter in this word is capital if it has more than one letter, like "Google".
            Otherwise, we define that this word doesn't use capitals in a right way.
            
            Example 1:
            Input: "USA"
            Output: True
            Example 2:
            Input: "FlaG"
            Output: False
        */

        public static bool DetectCapitalUse(string word)
        {
            char[] strChar = word.ToArray();
            int maxValue = strChar.Max(S => S);

            if (maxValue > 96)
            {
                return false;
            }

            return true;
        }

        /*
        public boolean detectCapitalUse(String word) {
            return word.matches("[A-Z]+|[a-z]+|[A-Z][a-z]+");
        }
        */
    }
}
