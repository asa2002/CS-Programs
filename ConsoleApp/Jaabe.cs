using System;
namespace project
{
    class Test
    {
        public static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());
            int L = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            double show = calc(w,L,h);
            Console.WriteLine(show);
        }
        private double calc(int num1 , int num2 , int num3)
        {
            double Result = num1 * num2 * num3;
            return Result;
        }
    }
}