using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Move Zeroes 283
    /// </summary>
    public class MoveZeroes
    {
        /*
            Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

            For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
        */

        public static void MoveZeroesFunc(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;

                    j++;
                }
            }
        }
    }
}
