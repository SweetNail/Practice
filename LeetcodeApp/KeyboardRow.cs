using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for KeyboardRow 500
    /// </summary>
    public class KeyboardRow
    {
        /*
            Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.

            Example 1:
                Input: ["Hello", "Alaska", "Dad", "Peace"]
                Output: ["Alaska", "Dad"]
        */
        public static string[] FindWords(string[] words)
        {
            List<string> result = new List<string>();

            #region Func

            Stopwatch watch = new Stopwatch();
            watch.Start();

            //可以用string indexof = -1来判断  减少switch次数
            char[] rowOne = new char[20] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            char[] rowTwo = new char[18] { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] rowTheee = new char[14] { 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            foreach(string str in words)
            {
                bool distinct = true;

                char start = str.ToCharArray()[0];
                int index = rowOne.Contains(start) ? 1 : rowTwo.Contains(start) ? 2 : 3;

                foreach (char c in str.ToCharArray())
                {
                    switch(index)
                    {
                        case 1: if (!rowOne.Contains(c)) distinct = false; break;
                        case 2: if (!rowTwo.Contains(c)) distinct = false; break;
                        case 3: if (!rowTheee.Contains(c)) distinct = false; break;
                        default: break;
                    }
                }

                if(distinct)
                {
                    result.Add(str);
                }
            }

            watch.Stop();
            long totalSeconds = watch.ElapsedMilliseconds;

            #endregion

            return result.ToArray();
        }
    }
}
