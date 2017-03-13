using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Restore IP Addresses 93
    /// </summary>
    public class RestoreIPAddresses
    {
        /*
            https://leetcode.com/problems/restore-ip-addresses/#/solutions

            Given a string containing only digits, restore it by returning all possible valid IP address combinations.

            For example:
            Given "25525511135",
            
            return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)
        */

        public static List<string> RestoreIpAddressesFunc(string s)
        {
            List<string> result = new List<string>();
            int len = s.Length;

            for (int i = 1; i < 4 && i < len - 2; i++)
            {
                for (int j = i + 1; j < i + 4 && j < len - 1; j++)
                {
                    for (int k = j + 1; k < j + 4 && k < len; k++)
                    {
                        string s1 = s.Substring(0, i), s2 = s.Substring(i, j - i), s3 = s.Substring(j, k - j), s4 = s.Substring(k, len - k);

                        if (isValid(s1) && isValid(s2) && isValid(s3) && isValid(s4))
                        {
                            result.Add(s1 + "." + s2 + "." + s3 + "." + s4);
                        }
                    }
                }
            }

            return result;
        }

        public static bool isValid(string s)
        {
            if (s.Length > 3 || s.Length == 0 || (s.ToArray()[0] == '0' && s.Length > 1) || Convert.ToInt16(s) > 255)
                return false;
            return true;
        }
    }
}
