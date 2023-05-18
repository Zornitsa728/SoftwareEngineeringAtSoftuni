using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int nylon = int.Parse(Console.ReadLine())+2;           
            double paint = double.Parse(Console.ReadLine());
            paint = paint + paint * 0.1;
            int paintThinner = int.Parse(Console.ReadLine());           
            int workingHours = int.Parse(Console.ReadLine());
            double sumMaterials = nylon * 1.50 + paint * 14.50 + paintThinner * 5 + 0.40;
            double workingPrice = sumMaterials * 0.3 * workingHours;
            double sum = sumMaterials + workingPrice;
            Console.WriteLine(sum);


        }
    }
}
