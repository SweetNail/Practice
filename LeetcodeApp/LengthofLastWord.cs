using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Length of Last Word 58
    /// </summary>
    public class LengthofLastWord
    {
        /*
            https://leetcode.com/problems/length-of-last-word/?tab=Description

            Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

            If the last word does not exist, return 0.
            
            Note: A word is defined as a character sequence consists of non-space characters only.
            
            For example, 
            Given s = "Hello World",
            return 5.
        */

        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            return s.Split(' ').Last().Length;
        }
    }
}
