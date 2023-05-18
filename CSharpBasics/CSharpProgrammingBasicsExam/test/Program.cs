using System;
using System.Runtime.Intrinsics.X86;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            int overnightStay = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
           double otherExpensePercent = double.Parse(Console.ReadLine())/100;
            if (overnightStay > 7)
            {
                pricePerNight = pricePerNight-(pricePerNight*0.05);
            }
            double totalPrice = overnightStay*pricePerNight+(budget*otherExpensePercent);
            if (budget>=totalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-totalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalPrice-budget:f2} leva needed.");
            }
        }
    }
}
