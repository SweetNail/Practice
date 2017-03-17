using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Integer Break 343
    /// </summary>
    public class IntegerBreak
    {
        /*
            https://leetcode.com/problems/integer-break/#/description

            Given a positive integer n, break it into the sum of at least two positive integers and maximize the product of those integers. Return the maximum product you can get.

            For example, given n = 2, return 1 (2 = 1 + 1); given n = 10, return 36 (10 = 3 + 3 + 4).        
        */

        /// <summary>
        /// 不明
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int IntegerBreakFunc(int n)
        {
            if (n == 2) return 1;
            if (n == 3) return 2;
            int product = 1;
            while (n > 4)
            {
                product *= 3;
                n -= 3;
            }
            product *= n;

            return product;
        }
    }
}
