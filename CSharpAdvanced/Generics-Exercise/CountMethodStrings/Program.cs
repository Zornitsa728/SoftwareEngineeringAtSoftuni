namespace CountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                box.Add(Console.ReadLine());
            }

            string itemToCompare = Console.ReadLine();

            int countLargerElements = box.Count(itemToCompare);

            Console.WriteLine(countLargerElements); 
        }
    }
}