using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Two Sum II - Input array is sorted 167s\
    /// </summary>
    public class TwoSumII_Inputarrayissorted
    {
        /*
            https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/?tab=Description
            Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

            The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
            
            You may assume that each input would have exactly one solution and you may not use the same element twice.
            
            Input: numbers={2, 7, 11, 15}, target=9
            Output: index1=1, index2=2
        */

        public static int[] TwoSum(int[] numbers, int target)
        {
            int targetTemp = 0;
            List<int> result = new List<int>();

            for (int start = 0; start < numbers.Count(); start++)
            {
                result = new List<int>();

                for (int end = start; end < numbers.Count(); end++)
                {
                    result.Add(end);
                    targetTemp += numbers[end];

                    if (targetTemp > target)
                    {
                        break;
                    }

                    if(targetTemp == target)
                    {
                        return result.ToArray();
                    }
                }

                targetTemp = 0;
            }

            return null;
        }

        /*
        vector<int> twoSum(vector<int>& numbers, int target) {
            int lo=0, hi=numbers.size()-1;
            while (numbers[lo]+numbers[hi]!=target){
                if (numbers[lo]+numbers[hi]<target){
                    lo++;
                } else {
                    hi--;
                }
            }
            return vector<int>({lo+1,hi+1});
        }
        */
    }
}
