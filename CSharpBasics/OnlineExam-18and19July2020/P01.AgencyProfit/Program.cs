using System;

namespace P01.AgencyProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Име на авиокомпанията - текст
            string companyName = Console.ReadLine();
            //Брой билети за възрастни – цяло число в диапазона[1…400]
            int numTicketsForAdults = int.Parse(Console.ReadLine());
            //Брой детски билети – цяло число в диапазона[25…120]
            int numTicketsForChildren = int.Parse(Console.ReadLine());
            //Нетна цена на билет за възрастен – реално число в диапазона[100.0…1600.0]
            double priceTicketsForAdults = double.Parse(Console.ReadLine()); //детският билет е със 70% по-евтин
            //Цената на такса обслужване - реално число в диапазона[10.0…50.0]
            double taxesForService = double.Parse(Console.ReadLine());

            double priceForChildTicket = priceTicketsForAdults - ( priceTicketsForAdults * 0.7);
            //такса обслужване
            priceTicketsForAdults += taxesForService;
            priceForChildTicket += taxesForService;
            priceTicketsForAdults *= numTicketsForAdults;
            priceForChildTicket *= numTicketsForChildren;
            double totalPrice = (priceForChildTicket + priceTicketsForAdults) * 0.2;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {totalPrice:f2} lv.");
        }
    }
}
