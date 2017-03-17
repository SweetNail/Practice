using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Lexicographical Numbers 386
    /// </summary>
    public class LexicographicalNumbers
    {
        /*
            https://leetcode.com/problems/lexicographical-numbers/#/description

            Given an integer n, return 1 - n in lexicographical order.

            For example, given 13, return: [1,10,11,12,13,2,3,4,5,6,7,8,9].
            
            Please optimize your algorithm to use less time and space. The input size may be as large as 5,000,000.
        */

        public static List<int> LexicalOrder(int n)
        {
            List<int> list = new List<int>();
            int curr = 1;

            for (int i = 1; i <= n; i++)
            {
                list.Add(curr);

                if (curr * 10 <= n)
                {
                    curr *= 10;
                }
                else if (curr % 10 != 9 && curr + 1 <= n)
                {
                    curr++;
                }
                else
                {
                    while ((curr / 10) % 10 == 9)
                    {
                        curr /= 10;
                    }

                    curr = curr / 10 + 1;
                }
            }

            return list;
        }
    }
}
