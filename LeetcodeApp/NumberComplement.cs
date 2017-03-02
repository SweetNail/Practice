using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Number Complement 476
    /// </summary>
    public class NumberComplement
    {
        /*
            The given integer is guaranteed to fit within the range of a 32-bit signed integer.
            You could assume no leading zero bit in the integer’s binary representation.

            Input: 5
            Output: 2
            Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
        
            Input: 1
            Output: 0
            Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.
        */

        public static int FindComplement(int num)
        {
            Stopwatch watch = new Stopwatch();

            double result = 0;

            #region Func

            watch.Start();

            //转换成2进制
            string twoBitNum = Convert.ToString(num, 2);
            //转换成数组
            Char[] numArray = twoBitNum.ToArray();

            for (int i = 0; i < numArray.Count(); i++)
            {
                int item = numArray[i] == (char)'1' ? 0 : 1;

                result += Math.Pow(2, (numArray.Count() - i - 1)) * item;
            }

            watch.Stop();

            #endregion

            long totalSeconds = watch.ElapsedMilliseconds;

            return (int)result;
        }

        /*
        for example:
            100110, its complement is 011001, the sum is 111111. So we only need get the min number large or equal to num, then do substraction

            public int findComplement(int num) 
            {
                int i = 0;
                int j = 0;
        
                while (i < num)
                {
                    i += Math.pow(2, j);
                    j++;
                }
        
                return i - num;
            }
        */
    }
}
