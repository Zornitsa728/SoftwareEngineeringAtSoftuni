namespace P01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int number = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i <= number; i++)
            {
                int randomPhrase = random.Next(phrases.Length);
                int randomEvent = random.Next(events.Length);
                int randomAuthors = random.Next(authors.Length);
                int randomCities = random.Next(cities.Length);

                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomAuthors]} – {cities[randomCities]}.");
            }
        }
    }
}