using System;

namespace P01.TennisEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Цена на една тенис ракета – реално число в интервала [0.00…100000.00]
            double priceTennisRacket = double.Parse(Console.ReadLine());
            //•	Брой тенис ракети - цяло число в интервала[0…100]
            int numTennisRacket = int.Parse(Console.ReadLine());
            //•	Брой чифтове маратонки - цяло число в интервала[0…100] 1 чифт маратонки = 1/6 от цената на една тенис ракета
            int numShoes = int.Parse(Console.ReadLine());
            //и друга екипировка, на стойност 20% от общата цена на закупените ракети и маратонки.

            double priceShoes = priceTennisRacket / 6; 
            double totalPrice = priceTennisRacket* numTennisRacket + priceShoes * numShoes;
            totalPrice += totalPrice * 0.2;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice/8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPrice*7/8)}");
        }
    }
}
