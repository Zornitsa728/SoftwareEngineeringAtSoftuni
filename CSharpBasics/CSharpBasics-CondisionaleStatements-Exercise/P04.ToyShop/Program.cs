using System;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            double priceForVacantion = double.Parse(Console.ReadLine());
             //2.Брой пъзели - цяло число в интервала[0… 1000]
             int puzzles = int.Parse(Console.ReadLine());   
             //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
             int speakingDolls = int.Parse(Console.ReadLine());
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            int teddyBears = int.Parse(Console.ReadLine()); 
             //5.Брой миньони - цяло число в интервала[0 … 1000]
             int minions = int.Parse(Console.ReadLine());
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            int trucks = int.Parse(Console.ReadLine());
            double sum = puzzles*2.60 + speakingDolls*3 + teddyBears*4.10 + minions*8.20 + trucks*2;
            int allToys = puzzles + speakingDolls + teddyBears + minions + trucks;
            if (allToys >= 50)
            {
                sum = sum-(sum * 0.25);
            }
            sum = sum - (sum*0.10);

             if (sum >=priceForVacantion)
            {
                Console.WriteLine($"Yes! {sum- priceForVacantion:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceForVacantion-sum:F2} lv needed.");
            }
            


        }
    }
}
