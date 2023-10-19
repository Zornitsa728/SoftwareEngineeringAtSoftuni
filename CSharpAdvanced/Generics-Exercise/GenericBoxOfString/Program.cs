namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 1; i <= count; i++)
            {
                box.Add(Console.ReadLine());
            }

            Console.WriteLine(box.ToString());
        }
    }
}