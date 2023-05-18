using System;

namespace P03.ChangeBuro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред – броят биткойни. Цяло число в интервала [0…20]
            double bitcoin = double.Parse(Console.ReadLine());
            //На втория ред – броят китайски юана.Реално число в интервала[0.00… 50 000.00]
            double chineseyuan = double.Parse(Console.ReadLine());
            //На третия ред – комисионната.Реално число в интервала[0.00... 5.00]
            double commission = double.Parse(Console.ReadLine())/100;
           
            bitcoin *= 1168;  //1 биткойн = 1168 лева.
            bitcoin /= 1.95;
            chineseyuan *= 0.15; //1 китайски юан = 0.15 долара.
            chineseyuan *= 1.76; //1 долар = 1.76 лева.
            chineseyuan /= 1.95; //1 евро = 1.95 лева.

            double totalSum = bitcoin + chineseyuan;
            totalSum -= totalSum * commission;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
