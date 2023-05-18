using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Бюджетът на Петър - реално число в интервала [0.0…100000.0]
            double budget = double.Parse(Console.ReadLine());
            //2.Броят видеокарти - цяло число в интервала[0…100]
            int graphicsCard = int.Parse(Console.ReadLine());
            //3.Броят процесори - цяло число в интервала[0…100]
            int processor = int.Parse(Console.ReadLine());
            //4.Броят рам памет -цяло число в интервала[0…100]
            double ram = double.Parse(Console.ReadLine());
            double graphicsCardPrice = graphicsCard*250; //Видеокарта – 250 лв./ бр.
            double processorsPrice = (graphicsCardPrice * 0.35)*processor;//Процесор – 35 % от цената на закупените видеокарти/ бр.
            ram = (graphicsCardPrice* 0.1)*ram; //Рам памет – 10 % от цената на закупените видеокарти/ бр.
            double totalSum = graphicsCardPrice + processorsPrice + ram;
            //Ако броя на видеокартите е по-голям от този на процесорите получава 15 % отстъпка от крайната сметка.
            if (graphicsCard>processor)
            {
                totalSum -= totalSum * 0.15;
            }
            if (budget>=totalSum)
            {
                Console.WriteLine($"You have {budget-totalSum:F2} leva left!");
            }
            else if (budget<totalSum)
            {
                Console.WriteLine($"Not enough money! You need {totalSum-budget:F2} leva more!");
            }

        }
    }
}
