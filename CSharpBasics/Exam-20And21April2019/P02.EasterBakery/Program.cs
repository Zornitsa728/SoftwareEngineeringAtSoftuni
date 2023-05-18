using System;

namespace P02.EasterBakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цена на брашното за един килограм – реално число в интервала[0.00 … 10000.00]
            double priceFlourForKilogram = double.Parse(Console.ReadLine());
            //Килограми на брашното – реално число в интервала[0.00 … 10000.00]
            double kilogramsFlour = double.Parse(Console.ReadLine());
            //Килограми на захарта – реално число в интервала[0.00 … 10000.00]
            double kilogramsSugar = double.Parse(Console.ReadLine());
            //Брой кори с яйца – цяло число в интервала[0 … 10000]
            int eggs = int.Parse(Console.ReadLine());
            //Пакети мая  – цяло число в интервала[0 … 10000]
            int yeast = int.Parse(Console.ReadLine());
            double price = 0;

            double priceForSugar = priceFlourForKilogram - (priceFlourForKilogram * 0.25);
             //цената на килограм захар е с 25% по-ниска от тази на килограм брашно
            double priceForEggs = priceFlourForKilogram + (priceFlourForKilogram * 0.1);
            priceForEggs *= eggs; //цената на една кора с яйца е с 10 % по - висока от цената на килограм брашно
            double priceForYeast = priceForSugar - (priceForSugar * 0.8); //с 80 % по - ниска от цената на килограм захар
            priceForYeast*= yeast;
            priceForSugar *= kilogramsSugar;
            priceFlourForKilogram *= kilogramsFlour;
            price = priceForEggs + priceForSugar + priceForYeast + priceFlourForKilogram;
            Console.WriteLine($"{price:f2}");
            


        }
    }
}
