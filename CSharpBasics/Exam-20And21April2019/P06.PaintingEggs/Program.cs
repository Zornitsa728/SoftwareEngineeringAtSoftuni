using System;

namespace P06.PaintingEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – размер на яйцата – текст с възможности "Large", "Medium" или "Small"
            string eggsSize = Console.ReadLine();
            //Втори ред – цвят на яйцата – текст с възможности "Red", "Green" или "Yellow"
            string eggsColour = Console.ReadLine();
            //Трети ред – брой партиди – цяло число в интервала[1… 350]
            int numbatchOfEggs = int.Parse(Console.ReadLine());

            if (eggsSize == "Large")
            {
                if (eggsColour == "Red")
                {
                    numbatchOfEggs *= 16;
                }
                else if (eggsColour == "Green")
                {
                    numbatchOfEggs *= 12;
                }
                else
                {
                    numbatchOfEggs *= 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsColour == "Red")
                {
                    numbatchOfEggs *= 13;
                }
                else if (eggsColour == "Green")
                {
                    numbatchOfEggs *= 9;
                }
                else
                {
                    numbatchOfEggs *= 7;
                }
            }
            else
            {
                if (eggsColour == "Red")
                {
                    numbatchOfEggs *= 9;
                }
                else if (eggsColour == "Green")
                {
                    numbatchOfEggs *= 8;
                }
                else
                {
                    numbatchOfEggs *= 5;
                }
            }
            //С 35% от крайната цена ще бъдат покрити производствени разходи.
            double expenses = numbatchOfEggs * 0.35;
            double incomes = numbatchOfEggs - expenses;
            Console.WriteLine($"{incomes:f2} leva.");
        }
    }
}
