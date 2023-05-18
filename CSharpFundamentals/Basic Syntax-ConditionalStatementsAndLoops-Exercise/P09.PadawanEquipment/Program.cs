using System.Drawing;
using System.Reflection.Emit;

namespace P09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceForSaber = double.Parse(Console.ReadLine());
            double priceForRobe = double.Parse(Console.ReadLine());
            double priceForBelt = double.Parse(Console.ReadLine());

            double moreSabers = Math.Ceiling(students * 0.1);
            int beltsForPayment = students - (students / 6);

            double totalPrice = priceForSaber * (students + moreSabers) + priceForBelt * beltsForPayment + students * priceForRobe;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - budget:f2}lv more.");
            }
        }
    }
}