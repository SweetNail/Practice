using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Rotate Image 48
    /// </summary>
    public class RotateImage
    {
        /*
            https://leetcode.com/problems/rotate-image/?tab=Description

            You are given an n x n 2D matrix representing an image.

            Rotate the image by 90 degrees (clockwise).
            
            Follow up:
            Could you do this in-place?
        */

        public static void Rotate(int[,] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[n - j - 1, i];
                    matrix[n - j - 1, i] = matrix[n - i - 1, n - j - 1];
                    matrix[n - i - 1, n - j - 1] = matrix[j, n - i - 1];
                    matrix[j, n - i - 1] = tmp;
                }
            }
        }
    }
}
