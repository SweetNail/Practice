using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Permutations 46
    /// </summary>
    public class Permutations
    {
        /*
            https://leetcode.com/problems/permutations/?tab=Description

            Given a collection of distinct numbers, return all possible permutations.

            For example,
                [1,2,3] have the following permutations:
                [
                  [1,2,3],
                  [1,3,2],
                  [2,1,3],
                  [2,3,1],
                  [3,1,2],
                  [3,2,1]
                ]
        */

        /// <summary>
        /// 未解
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static List<List<int>> PermuteFunc(int[] nums)
        {
            List<List<int>> ans = new List<List<int>>();
            if (nums.Length == 0) return ans;
            List<int> l0 = new List<int>();
            l0.Add(nums[0]);
            ans.Add(l0);

            for (int i = 1; i < nums.Length; ++i)
            {
                List<List<int>> new_ans = new List<List<int>>();

                for (int j = 0; j <= i; ++j)
                {
                    for (int k = 0; k < ans.Count(); k++)
                    {
                        List<int> new_l = new List<int>(ans[k]);
                        new_l.Insert(j, nums[i]);
                        new_ans.Add(new_l);
                    }
                }

                ans = new_ans;
            }

            return ans;
        }
    }
}
