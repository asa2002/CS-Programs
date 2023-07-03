using System;
namespace project
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vared konid ");
            int [ , ] a = new int [50 , 50];
            for(int i = 0 ; i<=49 ; i++)
                for(int j = 0 ; j<=49 ; j++)
                {
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(" ");
                calc(a);
        }
        private static void calc(int[ , ]a)
        {
            int i , j , k , m;
            int sum = 0;
            for (i=0 ; i<=49 ; i++)
            {
                for(j=0 ; j<=49 ; j++)
                {
                    for(k=i ; k<i+2 ; k++)
                    {
                        for(m=j ; m<j+2 ; m++)
                        {
                            sum=sum+a[k,m];
                        }
                    }
                    a[i,j]= sum/9;
                }
            }
            for(i=0 ; i<=49 ; i++)
            {
                for(j=0 ; j<=49 ; j++)
                {
                    Console.WriteLine(a[i,j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}