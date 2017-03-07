using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Valid Perfect Square 367
    /// </summary>
    public class ValidPerfectSquare
    {
        /*
            https://leetcode.com/problems/valid-perfect-square/?tab=Description
            Given a positive integer num, write a function which returns True if num is a perfect square else False.

            Note: Do not use any built-in library function such as sqrt.
            
            Example 1:
                Input: 16
                Returns: True

            Example 2:
                Input: 14
                Returns: False
        */

        /// <summary>
        /// 平方数等于 1+3+5+7+...+(2n+1)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsPerfectSquare(int num)
        {
            int i = 1;

            while (num > 0)
            {
                num -= i;
                i += 2;
            }

            return num == 0;
        }
    }
}
