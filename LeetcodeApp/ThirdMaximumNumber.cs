using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Third Maximum Number 414
    /// </summary>
    public class ThirdMaximumNumber
    {
        /*
            https://leetcode.com/problems/third-maximum-number/?tab=Description

            Given a non-empty array of integers, return the third maximum number in this array. If it does not exist, return the maximum number. The time complexity must be in O(n).

            Example 1:
            Input: [3, 2, 1]
            
            Output: 1
            
            Explanation: The third maximum is 1.
            Example 2:
            Input: [1, 2]
            
            Output: 2
            
            Explanation: The third maximum does not exist, so the maximum (2) is returned instead.
            Example 3:
            Input: [2, 2, 3, 1]
            
            Output: 1
            
            Explanation: Note that the third maximum here means the third maximum distinct number.
            Both numbers with value 2 are both considered as second maximum.
        */

        public static int ThirdMax(int[] nums)
        {
            if(nums.Distinct().Count() < 3)
            {
                return nums.Max();
            }

            return nums.Distinct().OrderByDescending(S => S).Skip(2).First();
        }
    }
}
