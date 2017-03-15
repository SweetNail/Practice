using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Search Insert Position 35
    /// </summary>
    public class SearchInsertPosition
    {
        /*
            https://leetcode.com/problems/search-insert-position/#/description

            Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

            You may assume no duplicates in the array.
            
            Here are few examples.
            [1,3,5,6], 5 → 2
            [1,3,5,6], 2 → 1
            [1,3,5,6], 7 → 4
            [1,3,5,6], 0 → 0
        */

        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                    return i;
            }

            return -1;
        }
    }
}
