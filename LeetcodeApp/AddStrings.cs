using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Add Strings 415
    /// </summary>
    public class AddStrings
    {
        /*
            https://leetcode.com/problems/add-strings/#/description

            Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.

            Note:
            
            The length of both num1 and num2 is < 5100.
            Both num1 and num2 contains only digits 0-9.
            Both num1 and num2 does not contain any leading zero.
            You must not use any built-in BigInteger library or convert the inputs to integer directly.
        */

        public static string AddStringsFunc(string num1, string num2)
        {
            return (Convert.ToInt32(num1) + Convert.ToInt32(num2)).ToString();
        }
    }
}
