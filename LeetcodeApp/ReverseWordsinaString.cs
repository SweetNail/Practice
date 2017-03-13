using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{

    /// <summary>
    /// solution for Reverse Words in a String 151
    /// </summary>
    public class ReverseWordsinaString
    {
        /*
            https://leetcode.com/problems/reverse-words-in-a-string/#/description

            Given an input string, reverse the string word by word.

            For example,
            Given s = "the sky is blue",
            return "blue is sky the".
        */

        public static string ReverseWords(string s)
        {
            StringBuilder sbResult = new StringBuilder();

            for (int i = s.Split(' ').Length; i > 0; i--)
            {
                sbResult.Append(s.Split(' ')[i - 1] + " ");
            }

            return sbResult.ToString().TrimEnd();
        }

        /*
            public String reverseWords(String s) {
                String[] words = s.trim().split(" +");
                Collections.reverse(Arrays.asList(words));

                return String.join(" ", words);
            }
        */
    }
}
