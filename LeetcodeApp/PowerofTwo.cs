using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Power of Two 231
    /// </summary>
    public class PowerofTwo
    {
        /*
            https://leetcode.com/problems/power-of-two/#/description

            Given an integer, write a function to determine if it is a power of two.
        */

            /// <summary>
            /// N^2 = 1+3+5+7+...+(2n-1)
            /// </summary>
            /// <param name="n"></param>
            /// <returns></returns>
        public static bool IsPowerOfTwo(int n)
        {
            for(int i = 1; ;i++)
            {
                if (n > 0)
                {
                    n -= 2 * i - 1;

                    if (n == 0)
                        return true;

                    if (n < 0)
                        return false;
                }
            }
        }

        /*
            public boolean isPowerOfTwo(int n) {
                return ((n & (n-1))==0 && n>0);
            }
        */
    }
}
