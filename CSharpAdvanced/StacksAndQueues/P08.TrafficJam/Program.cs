namespace P08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (cars.Count < n)
                    {
                        int carsCount = cars.Count;
                        for (int i = 0; i < carsCount; i++)
                        {
                            counter = PassedCar(cars, counter);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            counter = PassedCar(cars, counter);
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }

        private static int PassedCar(Queue<string> cars, int counter)
        {
            Console.WriteLine($"{cars.Dequeue()} passed!");
            counter++;
            return counter;
        }
    }
}