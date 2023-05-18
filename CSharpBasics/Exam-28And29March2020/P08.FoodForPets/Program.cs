using System;
using System.ComponentModel;

namespace P08.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой дни – цяло число в диапазона [1…30]
            int days = int.Parse(Console.ReadLine());
            //Общо количество храна – реално число в диапазона[0.00…10000.00]
            double food = double.Parse(Console.ReadLine());
            double dogFood = 0;
            double catFood = 0;
            double biscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogFoodPerDay = double.Parse(Console.ReadLine()); // изядена храна от кучето – цяло число в диапазона[10…500]
                double catFoodPerDay = double.Parse(Console.ReadLine()); // изядена храна от котката – цяло число в диапазона[10…500]
                //На всеки трети ден получават награда -бисквитки
               
                dogFood += dogFoodPerDay;
                catFood += catFoodPerDay;
                if (i % 3 == 0)
                { //Количеството на бисквитките е 10% от общо изядената храна за деня  
                    biscuits += (dogFoodPerDay + catFoodPerDay) * 0.1;
                }
                
            }

            double eatenFood = catFood + dogFood;
            food = eatenFood / food * 100;
            dogFood = dogFood / eatenFood * 100;
            catFood = catFood / eatenFood * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{food:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFood:f2}% eaten from the dog.");
            Console.WriteLine($"{catFood:f2}% eaten from the cat.");

        }
    }
}
