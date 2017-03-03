using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Add Digits
    /// </summary>
    public class AddDigits
    {
        /*
            https://leetcode.com/problems/add-digits/?tab=Description
            Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

            For example:
            
            Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.
            
            Follow up:
            Could you do it without any loop/recursion in O(1) runtime?
        */

        public static int AddDigitsFunc(int num)
        {
            return num == 0 ? 0 : (num % 9 == 0 ? 9 : (num % 9));
        }

        /*
            The essence of this problem is that 10^n ≡ 1 (mod 9), 
            and thus a_n10^n + ... + a_110 + a_0 ≡ a_n + ... + a_1 + a_0 (mod 9). 
            This process can be continued until a number less than 9 is gotten, i.e. num % 9. 
            For any digit n, n = n % 9 unless n = 9. 
            The only confusing case is n % 9 = 0, but addDigits(num) = 0 if and only if num = 0, otherwise it should be 9 in fact.
        */
    }
}
