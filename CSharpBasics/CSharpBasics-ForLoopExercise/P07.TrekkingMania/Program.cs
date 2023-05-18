using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //броя на групите от катерачи – цяло число в интервала [1...1000]
            int groups = int.Parse(Console.ReadLine());
            // броя на хората в групата – цяло число в интервала[1...1000]
            int peopleInAGroup;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int allPeople = 0;

            for (int i = 1; i <= groups; i++)
            {
                peopleInAGroup = int.Parse(Console.ReadLine());
                if (peopleInAGroup<=5)
                {
                    p1 += peopleInAGroup;
                }
                else if (peopleInAGroup<=12)
                {
                    p2 += peopleInAGroup;
                }
                else if (peopleInAGroup<=25)
                {
                    p3 += peopleInAGroup;
                }
                else if (peopleInAGroup<=40)
                {
                    p4 += peopleInAGroup;
                }
                else
                {
                    p5 += peopleInAGroup;
                }
                allPeople += peopleInAGroup; //изчислява процента на катерачите изкачващи всеки връх.
            }

            Console.WriteLine($"{(double)p1 / allPeople * 100:f2}%");
            Console.WriteLine($"{(double)p2 / allPeople * 100:f2}%");
            Console.WriteLine($"{(double)p3 / allPeople * 100:f2}%");
            Console.WriteLine($"{(double)p4 / allPeople * 100:f2}%");
            Console.WriteLine($"{(double)p5 / allPeople * 100:f2}%");
        }
    }
}
