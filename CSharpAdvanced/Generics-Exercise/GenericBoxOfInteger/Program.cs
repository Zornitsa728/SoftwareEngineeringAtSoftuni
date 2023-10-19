namespace GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 1; i <= count; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(box.ToString());
        }
    }
}