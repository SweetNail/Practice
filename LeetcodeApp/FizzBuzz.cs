using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Fizz Buzz 412
    /// </summary>
    public class FizzBuzz
    {
        /*
            https://leetcode.com/problems/fizz-buzz/
            Write a program that outputs the string representation of numbers from 1 to n.

            But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
        
            Example:

            n = 15,

            Return:
            [
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            ]
        */
        public static List<string> FizzBuzzDisplay(int n)
        {
            List<string> result = new List<string>();

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 15 == 0)
                    {
                        result.Add("FizzBuzz");
                        continue;
                    }
                    if (i % 3 == 0)
                    {
                        result.Add("Fizz");
                        continue;
                    }
                    if (i % 5 == 0)
                    {
                        result.Add("Buzz");
                        continue;
                    }
                    if (i % 3 != 0)
                    {
                        result.Add(i.ToString());
                    }
                }
            }

            return result;
        }

        /*
            public IList<string> FizzBuzz(int n) {
                return Enumerable.Range(1,n).Select(i => i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString()).ToList();
            }  
        */
    }
}
