using System;

namespace P02.AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цената на багаж над 20кг - реално число в диапазона [10.0…80.0]
            double priceForLuggageOver20kg = double.Parse(Console.ReadLine());
            //Килограми на багажа – реално число в диапазона[1.0…32.0]
            double luggageWeight = double.Parse(Console.ReadLine());
            //Дни до пътуването – цяло число в диапазона[1…60]
            int daysTillTravel = int.Parse(Console.ReadLine());
            //Брой багажи – цяло число в диапазона[1…10]
            int numLuggages = int.Parse(Console.ReadLine());
            double priceForLuggage = 0;

            if (luggageWeight<10)
            {
                priceForLuggage = priceForLuggageOver20kg * 0.2; // 20 % от цената на багаж над 20кг
            }
            else if (luggageWeight<=20)
            {
                priceForLuggage = priceForLuggageOver20kg * 0.5; // 50 % от цената на багаж над 20кг.
            }
            else
            {
                priceForLuggage = priceForLuggageOver20kg;
            }

            if (daysTillTravel>30)
            {
                priceForLuggage += priceForLuggage * 0.1; //-цената на багажа се оскъпява с 10 %
            }
            else if (daysTillTravel>=7 && daysTillTravel<=30)
            {
                priceForLuggage += priceForLuggage * 0.15; // -цената на багажа се оскъпява с 15 %
            }
            else
            {
                priceForLuggage += priceForLuggage * 0.4; // -цената на багажа се оскъпява с 40 %
            }

            //Напишете програма, която пресмята колко ще трябва да заплати Мими, спрямо горните условия.
            Console.WriteLine($"The total price of bags is: {priceForLuggage*numLuggages:f2} lv. ");
        }
    }
}
