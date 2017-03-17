using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Top K Frequent Elements 347
    /// </summary>
    public class TopKFrequentElements
    {
        /*
            https://leetcode.com/problems/top-k-frequent-elements/#/description

            Given a non-empty array of integers, return the k most frequent elements.

            For example,
            Given [1,1,1,2,2,3] and k = 2, return [1,2].
        */

        public static List<int> TopKFrequent(int[] nums, int k)
        {
            int[] temp = new int[10];

            foreach(int i in nums)
            {
                temp[i % 10]++;
            }

            List<int> result = new List<int>();

            foreach(int i in temp.OrderByDescending(S => S).Take(k).ToList())
            {
                result.Add(temp.ToList().IndexOf(i));
            }

            return result;
        }
    }
}
