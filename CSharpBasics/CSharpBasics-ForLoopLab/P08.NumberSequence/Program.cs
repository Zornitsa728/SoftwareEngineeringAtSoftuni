using System;

namespace P08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int biggest = int.MinValue;
           
            for (int i = 0; n>i; i++ )
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= smallest)
                {
                    smallest = num;    
                }
                if (num>= biggest) 
                {
                    biggest = num;  
                }   
            }

            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
