using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Missing Number 268
    /// </summary>
    public class MissingNumber
    {
        /*
            https://leetcode.com/problems/missing-number/?tab=Solutions
            Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

            For example,
            Given nums = [0, 1, 3] return 2.
            
            Note:
            Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity? 
        */

        /// <summary>
        /// 总和 = n*(n+1)/2
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int missingNumber(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }

            return (nums.Count() * (nums.Count() + 1)) / 2 - sum;
        }
    }
}
