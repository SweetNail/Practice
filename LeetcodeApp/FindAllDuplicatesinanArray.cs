using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Find All Duplicates in an Array 442
    /// </summary>
    public class FindAllDuplicatesinanArray
    {
        /*
            https://leetcode.com/problems/find-all-duplicates-in-an-array/?tab=Description

            Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

            Find all the elements that appear twice in this array.
            
            Could you do it without extra space and in O(n) runtime?
            
            Example:
            Input:
            [4,3,2,7,8,2,3,1]
            
            Output:
            [2,3]
        */

        /// <summary>
        /// 将对应位置值置为负数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static List<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();

            if (nums == null)
                return result;
            for (int i = 0; i < nums.Length; i++)
            {
                int location = Math.Abs(nums[i]) - 1;

                if (nums[location] < 0)
                {
                    result.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[location] = -nums[location];
                }
            }
            //for (int i = 0; i < nums.Length; i++)
            //    nums[i] = Math.Abs(nums[i]);

            return result;
        }
    }
}
