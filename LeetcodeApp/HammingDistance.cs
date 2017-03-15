using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    //solution for Hamming Distance 461
    public class HammingDistance
    {
        /*
            https://leetcode.com/problems/hamming-distance/#/description

            The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

            Given two integers x and y, calculate the Hamming distance.
        */

        /// <summary>
        /// 求异或
        /// </summary>
        /// <returns></returns>
        public static int HammingDistanceFunc(int x, int y)
        {
            int temp = x ^ y;

            int result = Convert.ToString(temp, 2).ToArray().Where(S => S == '1').Count();

            return result;
        }
    }
}
