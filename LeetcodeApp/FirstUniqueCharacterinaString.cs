using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for First Unique Character in a String 387
    /// </summary>
    public class FirstUniqueCharacterinaString
    {
        /*
            https://leetcode.com/problems/first-unique-character-in-a-string/#/description

            Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

            Examples:
            
                s = "leetcode"
                return 0.
                
                s = "loveleetcode",
                return 2.
        */

        public static int FirstUniqChar(string s)
        {
            int[] tempResult = new int[26];

            for (int i = 0; i < s.ToUpper().ToArray().Length; i++)
            {
                if (tempResult[(int)s.ToUpper().ToArray()[i] - 65] == 0)
                {
                    tempResult[(int)s.ToUpper().ToArray()[i] - 65] = i + 1;
                }
                else
                {
                    tempResult[(int)s.ToUpper().ToArray()[i] - 65] = (int)s.ToUpper().ToArray()[i];
                }
            }

            if (tempResult.Where(S => S > 0).ToList().Min() >= 65)
            {
                return -1;
            }

            return tempResult.Where(S => S > 0).ToList().Min() - 1;
        }
    }
}
