using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Excel Sheet Column Title 168
    /// </summary>
    public class ExcelSheetColumnTitle
    {
        /*
            https://leetcode.com/problems/excel-sheet-column-title/?tab=Description

            Given a positive integer, return its corresponding column title as appear in an Excel sheet.

            For example:
            
                1 -> A
                2 -> B
                3 -> C
                ...
                26 -> Z
                27 -> AA
                28 -> AB 
        */

        public static string ConvertToTitle(int n)
        {
            string res = "";

            while (n != 0)
            {
                char ch = (char)((n - 1) % 26 + 65);
                n = (n - 1) / 26;
                res = ch + res;
            }

            return res;
        }
    }
}
