using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HajmeMokaab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = Convert.ToDouble(Console.ReadLine());
            double w = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double show = calc(l, w, h);
            Console.WriteLine(show);
            Console.ReadKey();
        }
        private static double calc(double a, double b, double c)
        {
            double result = a * b * c;
            return result;
        }
    }
}

