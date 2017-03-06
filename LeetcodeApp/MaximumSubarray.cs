using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Maximum Subarray 53
    /// </summary>
    public class MaximumSubarray
    {
        /*
            https://leetcode.com/problems/maximum-subarray/?tab=Description
            Find the contiguous subarray within an array (containing at least one number) which has the largest sum.

            For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
            the contiguous subarray [4,-1,2,1] has the largest sum = 6.
        */

        public static int MaxSubArray(int[] nums)
        {
            int max = 0, sum = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (sum < 0)
                    sum = nums[i];
                else
                    sum += nums[i];
                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}
