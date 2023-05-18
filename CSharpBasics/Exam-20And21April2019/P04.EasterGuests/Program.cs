using System;

namespace P04.EasterGuests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред са броят на гостите – цяло число в интервала[0... 200000]
            int guests = int.Parse(Console.ReadLine());
            //На втория ред е бюджетът с който разполага Любо  – цяло число в интервала[0... 200000]
            int budget = int.Parse(Console.ReadLine());
            //един козунак стига за трима човека, като всеки гост ще получи и по 2 яйца
            double easterBread = Math.Ceiling((double)guests / 3) ; //Един козунак струва 4лв.
            double eggs = guests * 2 ; //Едно яйце струва 0.45лв.
            double totalPrice = easterBread * 4 + eggs * 0.45;
            //При изчисляването на броя козунаци, техният брой трябва да се закръгли към по-голямото цяло число
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Lyubo bought {easterBread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget-totalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice-budget:f2} lv. more.");
            }


        }
    }
}
