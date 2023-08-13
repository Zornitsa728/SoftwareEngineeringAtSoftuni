namespace P03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = string.Empty;
            List<City> cities = new List<City>();

            while ((cmd = Console.ReadLine()) != "Sail")
            {
                string[] cmdArgs = cmd
                    .Split("||");
                string cityName = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);
                City city = new City(cityName, population, gold);

                if (cities.Any(x => x.cityName == cityName))
                {
                    City currCity = cities.First(x => x.cityName == cityName);
                    currCity.population += population;
                    currCity.gold += gold;
                }
                else
                {
                    cities.Add(city);
                }
            }

            while((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd
                    .Split("=>");
                string operation = cmdArgs[0];

                if (operation == "Plunder")
                {
                    string cityName = cmdArgs[1];
                    int population = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);
                    City currCity = cities.First(x => x.cityName == cityName);

                    if (currCity.population - population <= 0 || currCity.gold - gold <= 0)
                    {
                        if (currCity.population - population <= 0)
                        {
                            population = currCity.population;
                            currCity.population -= population;
                        }

                        if (currCity.gold - gold <= 0)
                        {
                            gold = currCity.gold;
                            currCity.gold -= gold;
                        }

                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");
                        Console.WriteLine($"{cityName} has been wiped off the map!");

                        cities.Remove(currCity);
                    }
                    else
                    {
                        currCity.population -= population;
                        currCity.gold -= gold;

                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");
                    }
                }
                else if (operation == "Prosper")
                {
                    string cityName = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    City currCity = cities.First(x => x.cityName == cityName);
                    currCity.gold += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {currCity.gold} gold.");
                }

            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (City city in cities)
                {
                    Console.WriteLine($"{city.cityName} -> Population: {city.population} citizens, Gold: {city.gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    public class City
    {
        public City(string cityName, int population, int gold)
        {
            this.cityName = cityName;
            this.population = population;
            this.gold = gold;
        }

        public string cityName { get; set; }
        public int population { get; set; }
        public int gold { get; set; }
    }

}