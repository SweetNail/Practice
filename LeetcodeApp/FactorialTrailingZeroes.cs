using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Factorial Trailing Zeroes 172
    /// </summary>
    public class FactorialTrailingZeroes
    {
        /*
            https://leetcode.com/problems/factorial-trailing-zeroes/#/solutions

            Given an integer n, return the number of trailing zeroes in n!.
        */

        public static int TrailingZeroes(int n)
        {
            int result = 0;

            while (n > 0)
            {
                n /= 5;
                result += n;
            }

            return result;
        }
    }
}
