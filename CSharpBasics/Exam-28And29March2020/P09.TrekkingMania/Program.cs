using System;

namespace P09.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
            int groups = int.Parse(Console.ReadLine());
            //За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            double allPeople = 0;

            for (int i = 1;i <= groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (people<=5)
                {
                    group1 += people;
                }
                else if (people <=12)
                {
                    group2 += people;
                }
                else if (people <= 25)
                {
                    group3 += people;
                }
                else if (people <=40)
                {
                    group4 += people;
                }
                else
                {
                    group5 += people;
                }
                allPeople += people;
            }

            Console.WriteLine($"{group1 / allPeople * 100:f2}%");
            Console.WriteLine($"{group2 / allPeople * 100:f2}%");
            Console.WriteLine($"{group3 / allPeople * 100:f2}%");
            Console.WriteLine($"{group4 / allPeople * 100:f2}%");
            Console.WriteLine($"{group5 / allPeople * 100:f2}%");

        }
    }
}
