using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Power of Four 342
    /// </summary>
    public class PowerofFour
    {
        /*
            https://leetcode.com/problems/power-of-four/?tab=Description
            Given an integer (signed 32 bits), write a function to check whether it is a power of 4.

            Example:
            Given num = 16, return true. Given num = 5, return false.
            
            Follow up: Could you solve it without loops/recursion?
        */

            /// <summary>
            /// 如果是4的N次方，二进制必为1开头后面有2*n个0
            /// </summary>
            /// <param name="num"></param>
            /// <returns></returns>
        public static bool IsPowerOfFour(int num)
        {
            string twoBitStr = Convert.ToString(num, 2);

            if (twoBitStr.LastIndexOf('1') == 0 && twoBitStr.Length % 2 != 0)
            {
                return true;
            }

            return false;
        }
    }
}
