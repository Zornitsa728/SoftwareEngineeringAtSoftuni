using BorderControl.Interfaces;
using BorderControl.Models;
using Microsoft.VisualBasic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (info.Length == 4)
                {
                    int[] dateTokens = info[3]
                        .Split("/", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    int year = dateTokens[2];
                    int month = dateTokens[1];
                    int day = dateTokens[0];

                    DateOnly birthdate = new DateOnly(year, month, day);

                    IBuyer citizen = new Citizen(info[0], int.Parse(info[1]), info[2], birthdate);
                    buyers.Add(citizen);
                }
                else
                {
                    IBuyer rebel = new Rebel(info[0], int.Parse(info[1]), info[2]);
                    buyers.Add(rebel);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                buyers.FirstOrDefault(buyer => buyer.Name == input)?.BuyFood();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}