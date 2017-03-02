using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Island Perimeter 463
    /// </summary>
    public class IslandPerimeter
    {
        /*
        You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water. Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells). The island doesn't have "lakes" (water inside that isn't connected to the water around the island). One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.

        Example:

            [[0,1,0,0],
            [1,1,1,0],
            [0,1,0,0],
            [1,1,0,0]]

            Answer: 16
            Explanation: The perimeter is the 16 yellow stripes in the image below:

        */

        /// <summary>
        /// 无相邻 有4条  一个相邻3条  2个相邻2条  3个相邻1条  4个相邻0条
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int IslandPerimeterFunc(int[,] grid)
        {
            //根据二维位置存取count
            Dictionary<string, int> dicResult = new Dictionary<string, int>();

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    dicResult.Add(i.ToString() + j.ToString(), 0);

                    if (grid[i,j] == 1)
                    {
                        if (i - 1 >= 0)
                        {
                            if (grid[i - 1, j] == 0)
                                dicResult[i.ToString() + j.ToString()]++;
                        }
                        else
                        {
                            dicResult[i.ToString() + j.ToString()]++;
                        }

                        if (i + 1 < grid.GetLength(0))
                        {
                            if (grid[i + 1, j] == 0)
                                dicResult[i.ToString() + j.ToString()]++;
                        }
                        else
                        {
                            dicResult[i.ToString() + j.ToString()]++;
                        }

                        if (j - 1 >= 0)
                        {
                            if (grid[i, j - 1] == 0)
                                dicResult[i.ToString() + j.ToString()]++;
                        }
                        else
                        {
                            dicResult[i.ToString() + j.ToString()]++;
                        }

                        if (j + 1 < grid.GetLength(1))
                        {
                            if (grid[i, j + 1] == 0)
                                dicResult[i.ToString() + j.ToString()]++;
                        }
                        else
                        {
                            dicResult[i.ToString() + j.ToString()]++;
                        }
                    }
                }
            }

            int result = 0;
            foreach(KeyValuePair<string,int> item in dicResult)
            {
                result += item.Value;
            }

            return result;
        }

        /*
            public static int islandPerimeter(int[][] grid) {
                if (grid == null || grid.length == 0 || grid[0].length == 0) return 0;
                    int result = 0;
                    for (int i = 0; i < grid.length; i++) {
                        for (int j = 0; j < grid[0].length; j++) {
                            if (grid[i][j] == 1) {
                                result += 4;
                                if (i > 0 && grid[i-1][j] == 1) result -= 2;
                                if (j > 0 && grid[i][j-1] == 1) result -= 2;
                    }
                }
            }
                return result;
            }
        */
    }
}
