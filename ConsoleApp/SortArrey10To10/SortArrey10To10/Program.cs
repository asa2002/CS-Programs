using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrey10To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];


            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int k = i + 1; k < 10; k++)
                    {
                        if (array[i, j] > array[k, j])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[k, j];
                            array[k, j] = temp;
                        }
                    }
                }
            }


            Console.WriteLine("Sorted array:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
