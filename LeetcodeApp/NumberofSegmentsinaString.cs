using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Number of Segments in a String 434
    /// </summary>
    public class NumberofSegmentsinaString
    {
        /*
            https://leetcode.com/problems/number-of-segments-in-a-string/?tab=Description
            Count the number of segments in a string, where a segment is defined to be a contiguous sequence of non-space characters.

            Please note that the string does not contain any non-printable characters.
            
            Example:
            
            Input: "Hello, my name is John"
            Output: 5
        */

        public static int CountSegments(string s)
        {
            int count = 0;

            foreach (char item in s.ToArray())
            {
                int charValue = (int)item;

                if (charValue < 65 || (charValue > 90 && charValue < 97) || charValue > 122)
                {
                    count++;
                }
            }

            return count;
        }

        /*
            public int countSegments(String s) {
                int res=0;
                for(int i=0; i<s.length(); i++)
                    if(s.charAt(i)!=' ' && (i==0 || s.charAt(i-1)==' '))
                    res++;        
                return res;
            }

            Time complexity:  O(n)
            Space complexity: O(1)
        */
    }
}
