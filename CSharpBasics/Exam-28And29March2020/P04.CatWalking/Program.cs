using System;

namespace P04.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред - минути разходка - цяло число в интервала [1...50]
            int minutesWalking = int.Parse(Console.ReadLine());
            //На втория ред - броят на разходките дневно - цяло число в интервала[1…10]
            int countWalks = int.Parse(Console.ReadLine()); 
            //На третия ред - приетите от котката калории на ден – цяло число в интервала[100…4000]
            int calories = int.Parse(Console.ReadLine());

            //За всяка минута от разходката, котката гори по 5 калории.
            int burnedCalories = (countWalks * minutesWalking) * 5;
            //Разходката е достатъчна, ако котката изграря 50% от приетите калории.
            if (calories/2 <= burnedCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
