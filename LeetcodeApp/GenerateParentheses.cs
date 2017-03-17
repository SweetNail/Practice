using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Generate Parentheses 22
    /// </summary>
    public class GenerateParentheses
    {
        /*
            https://leetcode.com/problems/generate-parentheses/#/description

            Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

            For example, given n = 3, a solution set is:
            
            [
              "((()))",
              "(()())",
              "(())()",
              "()(())",
              "()()()"
            ]
        */

        public static List<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            GenerateOneByOne("", list, n, n);

            return list;
        }

        public static void GenerateOneByOne(string sublist, List<string> list, int left, int right)
        {
            if (left > right)
            {
                return;
            }
            if (left > 0)
            {
                GenerateOneByOne(sublist + "(", list, left - 1, right);
            }
            if (right > 0)
            {
                GenerateOneByOne(sublist + ")", list, left, right - 1);
            }
            if (left == 0 && right == 0)
            {
                list.Add(sublist);
                return;
            }
        }
    }
}
