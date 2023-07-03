using System;
namespace project
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adad Begoooooo");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            calc(a , b , c);    
        }
        private static void calc(int a , int b , int c)
        {
            if (a+b>c && b+c>a && a+c>b)
            {
                if (a==b && a==c)
                {
                    Console.WriteLine(" Azlaaa ");
                }
                else if (a==b && b!=c)
                {
                    Console.WriteLine(" Saghayin ");
                }
                else
                {
                    Console.WriteLine(" Ghaem ");
                }
            }
            else
            {
                Console.WriteLine(" Error ");
            }
        }
    }
}