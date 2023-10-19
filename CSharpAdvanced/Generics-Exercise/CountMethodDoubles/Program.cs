namespace CountMethodDoubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double number = double.Parse(Console.ReadLine());

                box.Add(number);
            }

            double numToCompare = double.Parse(Console.ReadLine());

            int countLargerElements = box.Count(numToCompare);

            Console.WriteLine(countLargerElements);
        }
    }
}