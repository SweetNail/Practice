using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Sum of Two Integers 371
    /// </summary>
    public class SumofTwoIntegers
    {
        /*
            https://leetcode.com/problems/sum-of-two-integers/#/description

            Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.

            Example:
            Given a = 1 and b = 2, return 3.
        */

        #region

        /*

        加法运算：将一个整数用二进制表示，其加法运算就是：相异（^）时，本位为1，进位为0；同为1时本位为0，进位为1；同为0时，本位进位均为0.
        
        所以，不计进位的和为sum = a^b，进位就是arr = a&b,(与sum相加时先左移一位，因为这是进位）。完成加法直到进位为0.
        
        减法运算：a-b  = a+(-b)　　根据补码的特性，各位取反加1即可（注意得到的是相反数，不是该数的补码，因为符号位改变了）
        
        （上面用二进制实现的加减法可以直接应用于负数）
        
        乘法运算：原理上还是通过加法计算。将b个a相加，注意下面实际的代码。
        
        除法运算：除法运算是乘法的逆。看a最多能减去多少个b

        */

        #endregion

        public static int GetSum(int a, int b)
        {
            if (b == 0)
            {//没有进为的时候完成运算
                return a;
            }

            int sum, carry;
            sum = a ^ b;//完成第一步加发的运算
            carry = (a & b) << 1;//完成第二步进位并且左移运算

            return GetSum(sum, carry);//
        }
    }
}
