namespace P04.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine()
                .Split("|")
                .ToList();
            string input;

            while ((input =Console.ReadLine()) != "Yohoho!")
            {
                string[] cmd = input.Split();

                switch (cmd[0])
                {
                    case "Loot":
                        Loot(treasure, cmd);
                        break;
                    case "Drop":
                        DropIndex(treasure, cmd);
                        break;
                    case "Steal":
                        Steal(treasure, cmd);
                        break;
                }
            }
            
            if (treasure.Count > 0)
            {
                averageTreasureGain(treasure);
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        static void Loot(List<string> treasure, string[] cmd)
        {
            for (int i = 1; i < cmd.Length; i++)
            {
                if (!treasure.Contains(cmd[i]))
                {
                    treasure.Insert(0, cmd[i]);
                }
            }
        }

        static void DropIndex(List<string> treasure, string[] cmd)
        {
            int index = int.Parse(cmd[1]);

            if (index >= 0 && index < treasure.Count)
            {
                string loot = treasure[index];
                treasure.RemoveAt(index);
                treasure.Add(loot);
            }
        }

        static void Steal(List<string> treasure, string[] cmd)
        {
            int count = int.Parse(cmd[1]);

            if (count < treasure.Count)
            {
                int lastCountitems = treasure.Count - count;
                Console.WriteLine(String.Join(", ", treasure.GetRange(lastCountitems, count))); 
                treasure.RemoveRange(lastCountitems, count);
            }
            else
            {
                Console.WriteLine(String.Join(", ", treasure.GetRange(0, treasure.Count)));
                treasure.RemoveRange(0, treasure.Count);
            }

            
        }

        static void averageTreasureGain(List<string> treasure)
        {
            double sum = 0;
            foreach (var item in treasure)
            {
                sum += item.Length;
            }

            double averageGain = sum / treasure.Count;
            Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
        }
    }
}