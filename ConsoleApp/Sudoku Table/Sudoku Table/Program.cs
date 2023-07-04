using System;
using System.Security.Cryptography;
using System.Linq;


//                                           علی شجاعی امنیه --- کلاس برنامه سازی پیشرفته --- استاد غره الحمید   


namespace App
{
    class Project
    {
        public static int size = 9;               // سایز جدول
        public static int emptyNum = 0;           // آزایه خالی
        public static int randomNum = 2;          // پر کردن عدد رندوم
        public static int userNum = 1;            // پر کردن عدد توسط کاربر
        public static double SPEED;               // سرعت حل

        static void Main()
        {
            int[,] sudoku = new int[size, size];

            // انتخاب پر کردن با کاربر یا بصورت رندوم
            int option = 0;
            Console.WriteLine("Please choose your option between 1 or 2 : \n" + "1. Fill Sudoku by yourself\n" + "2. Fill Sudoku random");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == userNum)
            {
                sudoku = sudokuFiller(sudoku);
            }
            else
            {
                // تعیین درجه سختی 
                int difficulty = 0;
                Console.WriteLine("Enter Difficulty: between 2-4");
                difficulty = Convert.ToInt32(Console.ReadLine());
                fillRandSudoku(ref sudoku, difficulty);
            }

            // چاپ اولیه جدول
            Console.WriteLine("Sudoku:");
            printCurrentSudoku(sudoku);

            // سرعت حل
            Console.WriteLine("Enter the speed that you want for solving:\n" + "1. Fast \n" + "2. Slow");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed == 1)
            {
                SPEED = 0;
            }
            else
            {
                SPEED = 0.1;
            }

            // حل جدول
            solver(ref sudoku);

            // چاپ جواب نهایی
            Console.WriteLine("Answer : ");
            printCurrentSudoku(sudoku);

            // چک کردن پر شدن جدول
            if (isFullSudoku(sudoku))
            {
                System.Console.WriteLine("solved");
            }
        }

        // پر کردن جدول توسط کاربر
        private static int[,] sudokuFiller(int[,] sudoku)
        {
            int userInpInt = emptyNum;
            string userInpStr;
            bool isExists = false;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine("The current sudoku:");
                    printCurrentSudoku(sudoku);
                    do
                    {
                        Console.WriteLine("Enter Num [" + i + "][" + j + "]:");
                        userInpStr = Console.ReadLine();
                        if (
                            userInpStr == "" ||
                            userInpStr == " " ||
                            userInpStr == null)
                        {
                            userInpInt = emptyNum;
                        }
                        else
                        {
                            userInpInt = Convert.ToInt32(userInpStr);
                        }
                        if (userInpInt > 9 || userInpInt < 0)
                        {
                            Console.WriteLine("ERROR: The number most between 0-9");
                        }
                        isExists = checkDuplicateNum(userInpInt, sudoku, i, j);

                        if (isExists && userInpInt != emptyNum)
                        {
                            Console.WriteLine("Repeated number in row or column is prohibited");
                        }
                        else
                        {
                            isExists = false;
                        }
                    } while ((userInpInt > 9 || userInpInt < 0) || isExists);
                    sudoku[i, j] = userInpInt;
                }
            }
            return sudoku;
        }

        // چاپ جدول
        private static void printCurrentSudoku(int[,] sudoku)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(sudoku[i, j]);
                    if (j != 0 || j != size)
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("\n                  \n");
            }
        }
        // چک کردن قوانین تکرار عدد
        private static bool checkDuplicateNum(int num, int[,] sudoku, int x, int y)
        {
            bool isExists = false;
            for (int i = 0; i < size; i++)
            {
                // چک کردن در ستون
                if (sudoku[i, y] == num)
                {
                    isExists = true;
                }
                // چک کردن در سطر
                if (sudoku[x, i] == num)
                {
                    isExists = true;
                }
            }

            return isExists;
        }

        // چک کردن پر بودن جدول
        private static bool isFullSudoku(int[,] sudoku)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (sudoku[i, j] == emptyNum)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // پر کردن بصورت رندوم در جدول
        private static void fillRandSudoku(ref int[,] sudoku, int difficulty)
        {
            int[] rands = new int[difficulty];
            Random r = new Random();
            Random r2 = new Random();
            for (int i = 0; i < size; i++)
            {
                // گرفتن اعداد رندوم
                for (int k = 0; k < difficulty; k++)
                {
                    rands[k] = r.Next(0, size);
                }
                // چک کردن تکرار
                for (int j = 0; j < size; j++)
                {
                    if (rands.Contains(j))
                    {
                        for (int z = 0; z < size; z++)
                        {
                            if (!checkDuplicateNum(z, sudoku, i, j))
                            {
                                sudoku[i, j] = z;
                            }
                        }
                    }
                }
            }
        }

        // تابع بازگشتی جدول برای از سرگیری مراحل
        private static bool solver(ref int[,] sudoku)
        {
            // چاپ مراحل بصورت پشت سرهم
            Console.Clear();
            printCurrentSudoku(sudoku);
            System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(SPEED).TotalMilliseconds);
            Console.WriteLine("----------------------");


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (sudoku[i, j] == emptyNum)
                    {
                        for (int n = 1; n <= size; n++)
                        {
                            // تایید و چاپ عدد در صورت رعایت قوانین تکرار
                            if (!checkDuplicateNum(n, sudoku, i, j))
                            {
                                sudoku[i, j] = n;
                                // خروج از برنامه در صورت حل جدول
                                if (solver(ref sudoku))
                                {
                                    return true;
                                }
                                else
                                {
                                    // خالی کردن خانه قبلی درصورت قرار نگرفتن عدد
                                    sudoku[i, j] = emptyNum;
                                }
                            }
                        }
                        // امکان چاپ تمام اعداد نیست پس به مرحله قبل برمیگردیم
                        return false;
                    }
                }
            }
            // اتمام مراحل و خروج از متود
            return true;
        }

    }
}