namespace P07.ParkngLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> carNumbers = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArgs[0];
                string number = cmdArgs[1];

                if (cmd == "IN")
                {
                    carNumbers.Add(number);
                }
                else
                {
                    carNumbers.Remove(number);
                }
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach (string carNumber in carNumbers)
            {
                Console.WriteLine(carNumber);
            }
        }
    }
}