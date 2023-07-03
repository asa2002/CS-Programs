using System;
namespace project
{
    class Test
    {
        public static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calc(x));
        }
        private static double calc(double x)
        {
            double y = Math.Sqrt(Math.Abs(x) + Math.Sqrt(Math.Abs(x) + Math.Sqrt(Math.Abs(x))));
            return y;
        }
    }
}