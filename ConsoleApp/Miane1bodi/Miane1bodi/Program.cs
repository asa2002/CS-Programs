using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miane1bodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Console.WriteLine("Please enter 50 numbers to calculate:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int meian = Calculate(array);
            Console.WriteLine(meian);
            Console.ReadLine();
        }

        static int Calculate(int[] arr)
        {
            Array.Sort(arr);
            int Index = arr.Length / 2;
            int z = 0;
            if (arr.Length % 2 == 0)
            {
                z = (arr[Index - 1] + arr[Index]) / 2;
            }
            else
            {
                z = arr[Index];
            }
            return z;
        }
    }
}
