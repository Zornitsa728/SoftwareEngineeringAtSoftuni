namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (typeOfTheGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.8;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }
                totalPrice = countPeople * price;

                if (countPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfTheGroup == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.9;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.6;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }

                if (countPeople >= 100)
                {
                    countPeople -= 10;
                    totalPrice = countPeople * price;
                }
                else
                {
                    totalPrice = countPeople * price;
                }
            }
            else if (typeOfTheGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.5;
                }
                totalPrice = countPeople * price;
                if (countPeople >= 10 && countPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}