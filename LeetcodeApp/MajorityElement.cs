using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Majority Element 169
    /// </summary>
    public class MajorityElement
    {
        /*
            https://leetcode.com/problems/majority-element/#/description

            Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

            You may assume that the array is non-empty and the majority element always exist in the array.
        */

        public static int MajorityElementFunc(int[] nums)
        {
            int count = 0, ret = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                    ret = nums[i];
                if (nums[i] != ret)
                    count--;
                else
                    count++;
            }

            return ret;
        }
    }
}
