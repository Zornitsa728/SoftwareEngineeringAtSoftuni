namespace P07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine()
                .Split(' ');
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(players);
            int tosses = 1;

            while (queue.Count != 1)
            {
                string currPlayer = queue.Dequeue();

                if (tosses < n)
                {
                    queue.Enqueue(currPlayer); 
                    tosses++;
                }
                else
                {
                    Console.WriteLine($"Removed {currPlayer}");
                    tosses = 1;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}