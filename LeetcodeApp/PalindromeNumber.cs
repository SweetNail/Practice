using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Palindrome Number 9
    /// </summary>
    public class PalindromeNumber
    {
        /*
            https://leetcode.com/problems/palindrome-number/#/description

            Determine whether an integer is a palindrome. Do this without extra space.
        */

        public static bool IsPalindrome(int x)
        {
            for (int i = 0; i < x.ToString().ToArray().Length / 2; i++)
            {
                if (x.ToString().ToArray()[i] != x.ToString().ToArray()[x.ToString().ToArray().Length - i - 1])
                    return false;
            }

            return true;
        }

        /*
            public boolean isPalindrome(int x) {
    
                if (x < 0) return false;
            
                int p = x; 
                int q = 0; 
                
                while (p >= 10){
                    q *=10; 
                    q += p%10; 
                    p /=10; 
                }
                
                return q == x / 10 && p == x % 10;
            }
        */
    }
}
