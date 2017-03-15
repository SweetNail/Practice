using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Single Number 136
    /// </summary>
    public class SingleNumber
    {
        /*
            https://leetcode.com/problems/single-number/#/description

            Given an array of integers, every element appears twice except for one. Find that single one.
        */

        /// <summary>
        /// 异或  a ^ b ^ a = b   a^a = 0  a^0 = a
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumberFunc(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}
