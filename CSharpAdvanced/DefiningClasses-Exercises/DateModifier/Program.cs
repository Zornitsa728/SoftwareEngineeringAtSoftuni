using DefiningClasses;
using System;
using System.Globalization;

public class StartUp
{
    public static void Main(string[] args)
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();

        Console.WriteLine(dateModifier.CalculateDaysDifference(firstDate, secondDate)); 
    }
}