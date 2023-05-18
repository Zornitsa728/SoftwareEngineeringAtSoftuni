using System;

namespace P01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //брой на хората.Цяло число в интервала[1…100]
            double numberOfPeople = int.Parse(Console.ReadLine());
            //такса вход. Реално число в интервала[0.00…50.00]
            double entranceTax = double.Parse(Console.ReadLine());
            //цена един за шезлонг. Реално число в интервала[0.00…50.00]
            double priceForSunLounger = double.Parse(Console.ReadLine());
            //цена за един чадър. Реално число в интервала[0.00...50.00]
            double priceForUmbrella = double.Parse(Console.ReadLine());
            //Трябва да имате предвид, че един чадър стига за двама души. Знае се, че само 75% от екипа искат шезлонги. 
            double sunLoungersNum = Math.Ceiling(numberOfPeople / 2) * priceForUmbrella;
            double UmbrellasNum = Math.Ceiling(numberOfPeople * 0.75) * priceForSunLounger;
            double totalSum = numberOfPeople * entranceTax + sunLoungersNum + UmbrellasNum;
            Console.WriteLine($"{totalSum:f2} lv.");



        }
    }
}
