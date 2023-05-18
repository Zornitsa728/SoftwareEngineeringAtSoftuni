using System;

namespace P03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for (int i = 0; n > i; i++ )
            {
                int num = int.Parse(Console.ReadLine());
                
                if (num < 200)
                {
                    count++;
                }
                else if (num < 400)
                {
                    count1++;
                }
                else if (num < 600)
                {
                    count2++;
                }
                else if (num <800)
                {
                    count3++;    
                }
                else
                {
                    count4++;   
                }
            }
            
            Console.WriteLine($"{(double)count / n * 100:f2}%");
            Console.WriteLine($"{(double)count1 / n * 100:f2}%");
            Console.WriteLine($"{(double)count2 / n * 100:f2}%");
            Console.WriteLine($"{(double)count3 / n * 100:f2}%");
            Console.WriteLine($"{(double)count4 / n * 100:f2}%");
        }
    }
}
