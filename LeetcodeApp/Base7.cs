using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Base 7 504 7进制运算
    /// </summary>
    public class Base7
    {
        /*
            https://leetcode.com/problems/base-7/#/description

            Given an integer, return its base 7 string representation.

            Example 1:
                Input: 100
                Output: "202"
            Example 2:
                Input: -7
                Output: "-10"
        */

        public static string ConvertToBase7(int num)
        {
            if (num == 0) return "0";
            StringBuilder sbResult = new StringBuilder();

            bool negative = false;

            if (num < 0)
            {
                negative = true;
            }
            while (num != 0)
            {
                sbResult.Append(Math.Abs(num % 7));
                num = num / 7;
            }

            if (negative)
            {
                sbResult.Append("-");
            }

            return sbResult.ToString();
        }
    }
}
