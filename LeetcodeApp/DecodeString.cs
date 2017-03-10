using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Decode String 394
    /// </summary>
    public class DecodeString
    {
        /*
            https://leetcode.com/problems/decode-string/?tab=Description

            Given an encoded string, return it's decoded string.

            The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.
            
            You may assume that the input string is always valid; No extra white spaces, square brackets are well-formed, etc.
            
            Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there won't be input like 3a or 2[4].
            
            Examples:
            
            s = "3[a]2[bc]", return "aaabcbc".
            s = "3[a2[c]]", return "accaccacc".
            s = "2[abc]3[cd]ef", return "abcabccdcdcdef".
        */

        public static string DecodeStringFunc(string s)
        {
            string result = string.Empty;
            Stack<int> countStack = new Stack<int>();
            Stack<string> resultStack = new Stack<string>();

            int index = 0;
            while (index < s.Length)
            {
                if (Char.IsDigit(s.ToArray()[index]))
                {
                    int count = 0;

                    while (Char.IsDigit(s.ToArray()[index]))
                    {
                        count = 10 * count + (s.ToArray()[index] - '0');
                        index++;
                    }

                    countStack.Push(count);
                }
                else if(s.ToArray()[index] == '[')
                {
                    resultStack.Push(result);
                    result = "";
                    index++;
                }
                else if(s.ToArray()[index] == ']')
                {
                    StringBuilder sb = new StringBuilder(resultStack.Pop());
                    int repeatTimes = countStack.Pop();

                    for(int i =0;i <repeatTimes;i++)
                    {
                        sb.Append(result);
                    }

                    result = sb.ToString();
                    index++;
                }
                else
                {
                    result += s.ToArray()[index];
                }
            }

            return result;
        }
    }
}
