namespace P06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            string[] separators = {" -> ","," };

            for (int currColour = 0; currColour < count; currColour++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string colour = tokens[0];

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    if (!wardrobe[colour].ContainsKey(tokens[i]))
                    {
                        wardrobe[colour].Add(tokens[i], 0);
                    }

                    wardrobe[colour][tokens[i]]++;
                }
            }

            string[] wantedClothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string chosenColour = wantedClothes[0];
            string chosenClothing = wantedClothes[1];

            foreach (var clothes in wardrobe)
            {
                bool isThisTheItem = false;

                Console.WriteLine($"{clothes.Key} clothes:");

                if (clothes.Key == chosenColour)
                {
                    isThisTheItem = true;
                }

                foreach (var item in clothes.Value)
                {
                    if (isThisTheItem && chosenClothing == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }

        }
    }
}