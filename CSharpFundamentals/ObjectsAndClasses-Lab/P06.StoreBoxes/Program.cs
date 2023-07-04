namespace P06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                int serialNumber = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Item items = new Item(itemName, price);
                Box box = new Box(serialNumber, items, quantity);
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(int serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice => Item.Price * Quantity;
    }

}

