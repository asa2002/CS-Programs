using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Table
{
    internal class Program
    {
        public int size = 9;
        public int emptyArrey = 0;
        public int randomNum = 2;
        public int userNum = 1;
        public double speed;
        private int[,] sudokuFill(int[,] sudoku)
        {
            int userAdad = emptyArrey;
            string userHarf;
            bool dorost = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sudokuPrint(sudoku);
                    do
                    {
                        Console.WriteLine("Adad morede nazar ra vared konid [" + i + "][" + j + "]:");
                        userHarf = Console.ReadLine();
                        if (userHarf == "" || userHarf == " " || userHarf == null)
                        {
                            userAdad = emptyArrey;
                        }
                        else
                        {
                            userAdad = Convert.ToInt32(userHarf);
                        }
                        if (userAdad > 9 || userAdad < 0)
                        {
                            Console.WriteLine("ERROR: Adad bayad beyne 0 ta 9 bashad");
                        }
                        dorost = copyCheck(userAdad, sudoku, i, j);
                        if (dorost && userAdad != emptyArrey)
                        {
                            Console.WriteLine("Adad tekrari dar satr ya sotoon!!");
                        }
                        else
                        {
                            dorost = false;
                        }
                    } while ((userAdad > 9 || userAdad < 0) || dorost);
                    sudoku[i, j] = userAdad;
                }
            }
            return sudoku;
        }
        private void sudokuPrint(int[,] sudoku)
        {
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
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
        private bool sudokuFull(int[,] sudoku)
        {
            for (int i=0; i < size; i++)
            {
                for ( int j = 0; j < size; j++)
                {
                    if (sudoku[i, j] == emptyArrey)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool copyCheck(int num , int[ , ] sudoku , int x , int y)
        {
            bool right = false;
            for (int i = 0;i < size; i++)
            {
                if (sudoku[i , y] == num)
                {
                    right = true;
                }
                if (sudoku[x , i] == num)
                {
                    right = true;
                }
            }
            return right;
        }
        private void sudokuRandom(int[ , ] sudoku , int Sakhti)
        {
            int[] rand = new int[Sakhti];
            Random A = new Random();
            Random B = new Random();
            for (int i = 0; i < size; i++)
            {
                for(int k = 0;k < size; k++)
                {
                    rand[k] = A.Next(0, size);
                }
                for (int j = 0; j < size; j++)
                {
                    if (rand.detaile(j))
                    {
                        for (int z = 0; z < size; z++)
                        {
                            if (!copyCheck(z , sudoku , i , j))
                            {
                                sudoku[i, j] = z;
                            }
                        }
                    }
                }
            }
        }
        private bool restart(int [,] sudoku) 
        {
            Console.Clear();
            sudokuPrint(sudoku);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(speed).TotalMilliseconds);
            Console.WriteLine("----------------------");
            for (int i = 0;i < size; i++)
            {
                for ( int j = 0; j < size; j++)
                {
                    if (sudoku[i, j] == emptyArrey)
                    {
                        for (int n = 1; n <= size; n++)
                        {
                            if (!copyCheck(n , sudoku , i , j))
                            {
                                sudoku[i , j] = n;
                                if (restart(sudoku))
                                {
                                    return true;
                                }
                                else
                                {
                                    sudoku[i , j] = emptyArrey;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] sudoku = new int[size, size];
            int opt = 0;
            Console.WriteLine("Lotfan gozine morede nazar ra entekhab konid :\n" + "1. Por kardan tavasote Karbar\n" + "2. Por kardan tavasote system");
            opt = Convert.ToInt32(Console.ReadLine());
            if (opt == userNum)
            {
                sudoku = sudokuFill(sudoku);
            }
            else
            {
                int sakhti = 0;
                Console.WriteLine("Sakhti morede nazar ra vared konid az beyne 2 ta 4");
                sakhti = Convert.ToInt32(Console.ReadLine());
                sudokuRandom(sudoku, sakhti);
            }
            Console.WriteLine("Sudoku:");
            sudokuPrint(sudoku);

            Console.WriteLine("Speed:\n" + "1. Fast \n" + "2. Slow");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed == 1)
            {
                speed = 0;
            }
            else
            {
                speed = 0.1;
            }
            restart(sudoku);

            Console.WriteLine("Answer : ");
            sudokuPrint(sudoku);

            if (sudokuFull(sudoku))
            {
                Console.WriteLine("solved");
            }
        }
    }
}
