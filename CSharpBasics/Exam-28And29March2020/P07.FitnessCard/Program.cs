using System;

namespace P07.FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Сумата, с която разполагаме - реално число в интервала [10.00…1000.00]
           double budget = double.Parse(Console.ReadLine());
           //Пол - символ('m' за мъж и 'f' за жена)
           char sex = char.Parse(Console.ReadLine());
           //Възраст - цяло число в интервала[5…105]
           int age = int.Parse(Console.ReadLine());
           //Спорт - текст(една от възможностите в таблицата)
           string sport = Console.ReadLine();
            double sum = 0;

            if (sex == 'm')
            {
                if (sport == "Gym")
                {
                    sum = 42;
                }
                else if (sport == "Boxing")
                {
                    sum = 41;
                }
                else if (sport == "Yoga")
                {
                    sum = 45;
                }
                else if (sport == "Zumba")
                {
                    sum = 34;
                }
                else if (sport == "Dances")
                {
                    sum = 51;
                }
                else if (sport == "Pilates")
                {
                    sum = 39;
                }
            }
            else
            {
                if (sport == "Gym")
                {
                    sum = 35;
                }
                else if (sport == "Boxing")
                {
                    sum = 37;
                }
                else if (sport == "Yoga")
                {
                    sum = 42;
                }
                else if (sport == "Zumba")
                {
                    sum = 31;
                }
                else if (sport == "Dances")
                {
                    sum = 53;
                }
                else if (sport == "Pilates")
                {
                    sum = 37;
                }
            }
            //за ученици (възраст под 19 години вкл.) са с 20% намаление
            if (age <=19)
            {
                sum -= sum * 0.2;
            }

            if (budget>= sum) 
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${sum - budget:f2} more.");
            }
        }
    }
}
