namespace P06.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ");

                switch (commands[0])
                {
                    case "Collect":
                        ColectItem(collectingItems, commands);
                        break;
                    case "Drop":
                        DropItem(collectingItems, commands);
                        break;
                    case "Combine Items":
                        CombineItem(collectingItems, commands);
                        break;
                    case "Renew":
                        RenewItem(collectingItems, commands);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", collectingItems));
        }

        static void ColectItem(List<string> collectingItems, string[] commands)
        {
            string item = commands[1];
            if (collectingItems.Contains(item))
            {
                return;
            }
            else
            {
                collectingItems.Add(item);
            }
        }

        static void DropItem(List<string> collectingItems, string[] commands)
        {
            string item = commands[1];
            if (collectingItems.Contains(item))
            {
                collectingItems.Remove(item);
            }
        }

        static void CombineItem(List<string> collectingItems, string[] commands)
        {
            string[] items = commands[1].Split(":");
            string oldItem = items[0];
            string newItem = items[1];

            if (collectingItems.Contains(oldItem))
            {
                for (int i = 0; i < collectingItems.Count; i++)
                {
                    if (collectingItems[i] == oldItem)
                    {
                        collectingItems.Insert(i + 1, newItem);
                        break;
                    }
                }
            }
        }

        static void RenewItem(List<string> collectingItems, string[] commands)
        {
            string item = commands[1];
            if (collectingItems.Contains(item))
            {
                collectingItems.Remove(item);
                collectingItems.Add(item);
            }
        }
    }
}