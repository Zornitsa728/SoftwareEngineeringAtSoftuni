namespace P07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfTheDay == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (typeOfTheDay == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (typeOfTheDay == "Holiday")
                {
                    ticketPrice = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfTheDay == "Weekday")
                {
                    ticketPrice = 18;
                }
                else if (typeOfTheDay == "Weekend")
                {
                    ticketPrice = 20;
                }
                else if (typeOfTheDay == "Holiday")
                {
                    ticketPrice = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfTheDay == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (typeOfTheDay == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (typeOfTheDay == "Holiday")
                {
                    ticketPrice = 10;
                }
            }

            if (age >= 0 && age <= 122)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}