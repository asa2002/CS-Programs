using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static int N = 9;

        static void Main(string[] args)
        {
            int[,] sudoku = new int[N, N];

            // دریافت جدول از کاربر
            Console.WriteLine("Enter the Sudoku puzzle (use '0' for empty cells):");
            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine();
                string[] numbers = row.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    sudoku[i, j] = int.Parse(numbers[j]);
                }
            }

            // حل جدول سودوکو
            if (SolveSudoku(sudoku))
            {
                // نمایش جدول حل شده
                Console.WriteLine("Solved Sudoku:");
                PrintSudoku(sudoku);
            }
            else
            {
                Console.WriteLine("No solution exists for the given Sudoku puzzle.");
            }
        }

        static bool SolveSudoku(int[,] sudoku)
        {
            int row, col;
            if (!FindUnassignedLocation(sudoku, out row, out col))
            {
                return true; // تمامی خانه‌ها پر شده‌اند (جدول حل شده)
            }

            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(sudoku, row, col, num))
                {
                    sudoku[row, col] = num; // قرار دادن عدد در خانه

                    if (SolveSudoku(sudoku))
                    {
                        return true; // پیدا کردن حل
                    }

                    sudoku[row, col] = 0; // برگشت از حالت فعلی و پاک کردن عدد قرار داده شده
                }
            }

            return false; // هیچ عددی برای قرار دادن در این خانه مناسب نیست
        }

        static bool FindUnassignedLocation(int[,] sudoku, out int row, out int col)
        {
            for (row = 0; row < N; row++)
            {
                for (col = 0; col < N; col++)
                {
                    if (sudoku[row, col] == 0)
                    {
                        return true; // یافتن خانه‌ای خالی
                    }
                }
            }

            row = -1;
            col = -1;
            return false; // هیچ خانه‌ای خالی وجود ندارد
        }

        static bool IsSafe(int[,] sudoku, int row, int col, int num)
        {
            // بررسی ردیف
            for (int c = 0; c < N; c++)
            {
                if (sudoku[row, c] == num)
                {
                    return false;
                }
            }

            // بررسی ستون
            for (int r = 0; r < N; r++)
            {
                if (sudoku[r, col] == num)
                {
                    return false;
                }
            }

            // بررسی بلاک ۳x۳
            int sqrtN = (int)Math.Sqrt(N);
            int blockStartRow = row - (row % sqrtN);
            int blockStartCol = col - (col % sqrtN);
            for (int r = 0; r < sqrtN; r++)
            {
                for (int c = 0; c < sqrtN; c++)
                {
                    if (sudoku[blockStartRow + r, blockStartCol + c] == num)
                    {
                        return false;
                    }
                }
            }

            return true; // عدد مورد نظر در این موقعیت مناسب است
        }

        static void PrintSudoku(int[,] sudoku)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(sudoku[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
