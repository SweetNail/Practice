using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Sudoku Solver 37
    /// </summary>
    public class SudokuSolver
    {
        /*
            https://leetcode.com/problems/sudoku-solver/#/solutions

            Write a program to solve a Sudoku puzzle by filling the empty cells.

            Empty cells are indicated by the character '.'.
            
            You may assume that there will be only one unique solution.
        */

        public static void solveSudoku(char[][] board)
        {
            if (board == null || board.Length == 0)
                return;

            solve(board);
        }

        public static bool solve(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            //trial. Try 1 through 9
                            if (isValid(board, i, j, c))
                            {
                                board[i][j] = c; //Put c for this cell

                                if (solve(board))
                                    return true; //If it's the solution return true
                                else
                                    board[i][j] = '.'; //Otherwise go back
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        private static bool isValid(char[][] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] != '.' && board[i][col] == c) return false; //check row
                if (board[row][i] != '.' && board[row][i] == c) return false; //check column
                if (board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] != '.' &&
    board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] == c)
                    return false; //check 3*3 block
            }
            return true;
        }
    }
}
