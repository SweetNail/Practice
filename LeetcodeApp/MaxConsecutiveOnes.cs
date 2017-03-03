using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Max Consecutive Ones 485
    /// </summary>
    public class MaxConsecutiveOnes
    {
        /*
            https://leetcode.com/problems/max-consecutive-ones/?tab=Description
            Given a binary array, find the maximum number of consecutive 1s in this array.

            Example 1:
            Input: [1,1,0,1,1,1]
            Output: 3
            Explanation: The first two digits or the last three digits are consecutive 1s.
                The maximum number of consecutive 1s is 3.
            
            Note:
            The input array will only contain 0 and 1.
            The length of input array is a positive integer and will not exceed 10,000
        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int tempResult = 0;

            for (int start = 0; start < nums.Count(); )
            {
                for (int end = start; end < nums.Count(); end++)
                {
                    if (nums[end] == nums[start])
                    {
                        tempResult++;
                    }
                    else
                    {
                        if (tempResult > result)
                        {
                            result = tempResult;
                        }

                        tempResult = 0;
                        start = end;
                        break;
                    }

                    if ((end + 1) == nums.Count())
                    {
                        start = nums.Count();
                    }
                }
            }

            if (tempResult > result)
            {
                result = tempResult;
            }

            return result;
        }

        /*
        public int findMaxConsecutiveOnes(int[] nums) {
            int maxHere = 0, max = 0;
            for (int n : nums)
                max = Math.max(max, maxHere = n == 0 ? 0 : maxHere + 1);
            return max; 
        } 

        110111
        ^ maxHere = 1
        
        110111
        .^ maxHere = 2
        
        110111
        ..^ maxHere = 0
        
        110111
        ...^ maxHere = 1
        
        110111
        ....^ maxHere = 2
        
        110111
        .....^ maxHere = 3
        */
    }
}
