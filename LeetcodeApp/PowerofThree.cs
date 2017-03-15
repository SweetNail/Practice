using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for 326
    /// </summary>
    public class PowerofThree
    {
        /*
            https://leetcode.com/problems/power-of-three/#/description

            Given an integer, write a function to determine if it is a power of three.
        */

        public static bool IsPowerOfThree(int n)
        {
            if (n > 1)
                while (n % 3 == 0) n /= 3;

            return n == 1;
        }
    }
}
