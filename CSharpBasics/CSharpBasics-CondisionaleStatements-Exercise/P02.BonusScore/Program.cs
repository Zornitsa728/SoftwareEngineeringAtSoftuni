using System;
using System.Data;

namespace P02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startUpPoints = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            
            if (startUpPoints<=100) 
            {
                bonus = 5;
            }
            else if (startUpPoints <= 1000)
            {
                bonus = startUpPoints * 0.20;
            }
            else if(startUpPoints > 1000) 
            {
                bonus = startUpPoints * 0.10;
            }

            if (startUpPoints % 2 == 0) 
            {
                bonus += 1;
            }
            else if (startUpPoints % 10 == 5) 
            {
                bonus += 2;
            }
                Console.WriteLine(bonus);
                Console.WriteLine(bonus + startUpPoints);
              








        }
    }
}
