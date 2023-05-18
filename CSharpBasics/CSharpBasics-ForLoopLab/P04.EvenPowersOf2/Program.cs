using System;

namespace P04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //печата четните степени на 2 
            int n = int.Parse(Console.ReadLine());
            for (int i =0; n>=i; i+=2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        
        }
    }
}
