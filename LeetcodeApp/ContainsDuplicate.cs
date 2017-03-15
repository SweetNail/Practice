using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Contains Duplicate 217
    /// </summary>
    public class ContainsDuplicate
    {
        /*
            https://leetcode.com/problems/contains-duplicate/#/description

            查找数组中是否有重复
            Given an array of integers, find if the array contains any duplicates. Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        */

        public static bool ContainsDuplicateFunc(int[] nums)
        {
            HashSet<int> tempResult = new HashSet<int>();

            foreach(int i in nums)
            {
                if (!tempResult.Add(i))
                    return false;
            }

            return true;
        }
    }
}
