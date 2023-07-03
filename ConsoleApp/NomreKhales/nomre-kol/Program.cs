using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomre_kol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input your midterm number :");
            double midterm = Convert.ToDouble(Console.ReadLine());
            Console.Write("input your final number :");
            double final = Convert.ToDouble(Console.ReadLine());
            double show = calc(midterm, final);

            Console.WriteLine("your full number is :",show);
            Console.ReadKey();
        }
        private static double calc(double a, double b)
        {
            double result = (0.35 * a) + (0.65 * b);
            return result;
        }
    }
}
