using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Roman to Integer 13
    /// </summary>
    public class RomantoInteger
    {
        /*
            https://leetcode.com/problems/roman-to-integer/#/description

            Given a roman numeral, convert it to an integer.

            Input is guaranteed to be within the range from 1 to 3999.
        */

        public static int RomanToInt(string s)
        {
            int sum = 0;

            if (s.IndexOf("IV") != -1) { sum -= 2; }
            if (s.IndexOf("IX") != -1) { sum -= 2; }
            if (s.IndexOf("XL") != -1) { sum -= 20; }
            if (s.IndexOf("XC") != -1) { sum -= 20; }
            if (s.IndexOf("CD") != -1) { sum -= 200; }
            if (s.IndexOf("CM") != -1) { sum -= 200; }

            char[] c = s.ToArray();
            int count = 0;

            for (; count <= s.Length - 1; count++)
            {
                if (c[count] == 'M') sum += 1000;
                if (c[count] == 'D') sum += 500;
                if (c[count] == 'C') sum += 100;
                if (c[count] == 'L') sum += 50;
                if (c[count] == 'X') sum += 10;
                if (c[count] == 'V') sum += 5;
                if (c[count] == 'I') sum += 1;

            }

            return sum;
        }
    }
}
