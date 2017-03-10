using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Gray Code 89
    /// </summary>
    public class GrayCode
    {
        /*
            https://leetcode.com/problems/gray-code/?tab=Solutions

            The gray code is a binary numeral system where two successive values differ in only one bit.

            Given a non-negative integer n representing the total number of bits in the code, print the sequence of gray code. A gray code sequence must begin with 0.
            
            For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:
            
            00 - 0
            01 - 1
            11 - 3
            10 - 2
        */

        /// <summary>
        /// 格雷码 标准异或应用场景
        /// 在一组数的编码中，若任意两个相邻的代码只有一位二进制数不同，则称这种编码为格雷码（Gray Code），另外由于最大数与最小数之间也仅一位数不同，即“首尾相连”，因此又称循环码或反射码。
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> grayCode(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 1 << n; i++) result.Add(i ^ i >> 1);

            return result;
        }
    }
}
