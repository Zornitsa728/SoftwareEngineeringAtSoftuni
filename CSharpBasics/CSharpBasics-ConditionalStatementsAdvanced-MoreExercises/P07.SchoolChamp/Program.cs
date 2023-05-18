using System;

namespace P07.SchoolChamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сезонът – текст - “Winter”, “Spring” или “Summer”;
            string season = Console.ReadLine();
            //Видът на групата – текст - “boys”, “girls” или “mixed”;
            string typeOfGroup = Console.ReadLine();
            //Брой на учениците – цяло число в интервала[1 … 10000];
            int numberStudents = int.Parse(Console.ReadLine());
            //Брой на нощувките – цяло число в интервала[1 … 100].
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sports = string.Empty;
            double totalPrice = 0;

            if (typeOfGroup == "boys" || typeOfGroup == "girls")
            {
                if (season == "Winter")
                {
                    pricePerNight = 9.6;
                    if(typeOfGroup == "boys")
                    {
                        sports = "Judo";
                    }
                    else
                    {
                        sports = "Gymnastics";
                    } 
                }
                else if(season == "Spring")
                {
                    pricePerNight = 7.2;
                    if (typeOfGroup == "boys")
                    {
                        sports = "Tennis";
                    }
                    else
                    {
                        sports = "Athletics";
                    }
                }
                else
                {
                    pricePerNight = 15;
                    if (typeOfGroup == "boys")
                    {
                        sports = "Football";
                    }
                    else 
                    {
                        sports = "Volleyball";
                    }
                }
            }
            else
            {
                if (season == "Winter")
                {
                    pricePerNight = 10;
                    sports = "Ski";
                }
                else if (season == "Spring")
                {
                    pricePerNight = 9.5;
                    sports = "Cycling";
                }
                else
                {
                    pricePerNight = 20;
                    sports = "Swimming";
                    
                }
            }

                if (numberStudents >= 10 && numberStudents < 20)
                {
                    pricePerNight -= pricePerNight * 0.05;
                }
                else if (numberStudents>=20 && numberStudents < 50)
                {
                    pricePerNight -= pricePerNight * 0.15;
                }
                else if (numberStudents >= 50)
                {
                    pricePerNight -= pricePerNight * 0.5;
                }
            

            totalPrice = pricePerNight*nights*numberStudents;
            Console.WriteLine($"{sports} {totalPrice:f2} lv.");
        }
    }
}
