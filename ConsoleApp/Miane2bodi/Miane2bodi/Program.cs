using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miane2bodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[50, 50];
            Console.WriteLine("Please enter numbers (50x50):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int meian = Calculate(matrix);
            Console.WriteLine("The median is: " + meian);
            Console.ReadLine();
        }

        static int Calculate(int[,] matrix)
        {
            int[] flattenedArray = new int[matrix.Length];
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    flattenedArray[index++] = matrix[i, j];
                }
            }
            Array.Sort(flattenedArray);
            int Index = flattenedArray.Length / 2;
            int meian = 0;
            if (flattenedArray.Length % 2 == 0)
            {
                meian = (flattenedArray[Index - 1] + flattenedArray[Index]) / 2;
            }
            else
            {
                meian = flattenedArray[Index];
            }
            return meian;
        }
    }
}
