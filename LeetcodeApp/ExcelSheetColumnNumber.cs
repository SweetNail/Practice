using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Excel Sheet Column Number 171
    /// </summary>
    public class ExcelSheetColumnNumber
    {
        /*
            https://leetcode.com/problems/excel-sheet-column-number/?tab=Description
            Related to question Excel Sheet Column Title

            Given a column title as appear in an Excel sheet, return its corresponding column number.
            
            For example:
            
            A -> 1
            B -> 2
            C -> 3
            ...
            Z -> 26
            AA -> 27
            AB -> 28 
        */

        public static int TitleToNumber(string s)
        {
            int result = 0;

            for(int i = 1; i <= s.ToArray().Count(); i++)
            {
                result += (int)s.ToArray()[i - 1] - 65 + 26 * (i - 1);
            }

            return result + 1;
        }

        /*
            int result = 0;
            for (int i = 0; i < s.length(); result = result * 26 + (s.charAt(i) - 'A' + 1), i++);
            return result;
        */
    }
}
