using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Add Binary 67
    /// </summary>
    public class AddBinary
    {
        /*
            https://leetcode.com/problems/add-binary/?tab=Description

            Given two binary strings, return their sum (also a binary string).

            For example,
            a = "11"
            b = "1"
            Return "100".
        */

        public static string AddBinaryFunc(string a, string b)
        {
            int sum = Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2);

            return Convert.ToString(sum, 2);
        }
    }
}
