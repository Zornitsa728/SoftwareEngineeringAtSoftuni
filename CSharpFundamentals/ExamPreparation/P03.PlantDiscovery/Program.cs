namespace P03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();
            Plant plant;

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine()
                    .Split("<->");
                string plantName = information[0];
                string rarity = information[1];
                plant = new Plant(plantName, rarity);
                plants.Add(plant);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = cmd
                    .Split(new char[] {':','-'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                string action = cmdArgs[0];
                string name = cmdArgs[1];

                if (action == "Rate")
                {
                    double rating = double.Parse(cmdArgs[2]);

                    if(IsPlantNameValid(plants, name))
                    {
                        Plant currPlant = plants.Find(x => x.Name == name);
                        currPlant.Ratings.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "Update")
                {
                    string newRarity = cmdArgs[2];
                    if (IsPlantNameValid(plants, name))
                    {
                        Plant currPlant = plants.Find(x => x.Name == name);
                        currPlant.Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "Reset")
                {

                    if (IsPlantNameValid(plants, name))
                    {
                        Plant currPlant = plants.Find(x => x.Name == name);
                        currPlant.Ratings.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (Plant currPlant in plants)
            {
                double averageRating = 0;
                if (currPlant.Ratings.Count != 0)
                {
                    foreach (var rating in currPlant.Ratings)
                    {
                        averageRating += rating;
                    }

                    averageRating /= currPlant.Ratings.Count;
                }
                
                Console.WriteLine($"- {currPlant.Name}; Rarity: {currPlant.Rarity}; Rating: {averageRating:f2}");
            }
        }

        private static bool IsPlantNameValid(List<Plant> plants, string plant)
        {
            if (plants.Any(x => x.Name == plant))
            {
                return true;
            }

            return false;
        }
    }

    class Plant
    {
        public Plant(string name, string rarity)
        {
            Name = name;
            Rarity = rarity;
            Ratings = new List<double>();
        }

        public string Name { get; set; }
        public string Rarity { get; set; }

        public List<double> Ratings { get; set; }
        
    }
}