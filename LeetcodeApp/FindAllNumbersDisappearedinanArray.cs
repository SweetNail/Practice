using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Find All Numbers Disappeared in an Array 448
    /// </summary>
    public class FindAllNumbersDisappearedinanArray
    {
        /*
            https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
            Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

            Find all the elements of [1, n] inclusive that do not appear in this array.
            
            Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
            
            Example:
            
            Input:
            [4,3,2,7,8,2,3,1]
            
            Output:
            [5,6]
        */

        public static List<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> res = new List<int>();
            int n = nums.Count();

            for (int i = 0; i < nums.Count(); i++) nums[(nums[i] - 1) % n] += n;
            for (int i = 0; i < nums.Count(); i++) if (nums[i] <= n) res.Add(i + 1);

            return res;
        }
    }
}
