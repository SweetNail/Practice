using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Largest Number 179
    /// </summary>
    public class LargestNumber
    {
        /*
            https://leetcode.com/problems/largest-number/#/description

            Given a list of non negative integers, arrange them such that they form the largest number.

            For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.
            
            Note: The result may be very large, so you need to return a string instead of an integer.
        */

        public static string LargestNumberFunc(int[] nums)
        {
            int maxValue = nums.Max();
            int weishu = maxValue.ToString().Length + 1;

            List<KeyValuePair<string, int>> resultTemp = new List<KeyValuePair<string, int>>();
            foreach (int value in nums)
            {
                resultTemp.Add(new KeyValuePair<string, int>(value.ToString().PadRight(weishu, '0'), weishu - value.ToString().Length));
            }

            resultTemp = resultTemp.OrderByDescending(S => Convert.ToInt32(S.Key)).ToList();
            StringBuilder sbResult = new StringBuilder();
            resultTemp.ForEach(S => sbResult.Append(S.Key.Substring(0, S.Key.Length - S.Value)));

            return sbResult.ToString();
        }
    }
}
