using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());   
           int  height = int.Parse(Console.ReadLine()); 
          double percent = double.Parse(Console.ReadLine())/100;
            double volume = length * wide * height;
            Console.WriteLine((volume - volume * percent)/1000);
            

        }
    }
}
