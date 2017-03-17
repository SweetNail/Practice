using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Product of Array Except Self 238
    /// </summary>
    public class ProductofArrayExceptSelf
    {
        /*
            https://leetcode.com/problems/product-of-array-except-self/#/description

            Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

            Solve it without division and in O(n).
            
            For example, given [1,2,3,4], return [24,12,8,6].
        */

        public static int[] ProductExceptSelf(int[] nums)
        {
            long productSum = 1;
            List<int> result = new List<int>();

            nums.ToList().ForEach(S => productSum *= S);

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)productSum / nums[i];
            }

            return nums;
        }
    }
}
