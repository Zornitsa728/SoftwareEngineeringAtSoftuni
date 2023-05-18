using System;

namespace P01.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numbers from 1 to 1000 which ending in 7
            for (int i=7; i<=997; i++)
            {
                if(i %10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
