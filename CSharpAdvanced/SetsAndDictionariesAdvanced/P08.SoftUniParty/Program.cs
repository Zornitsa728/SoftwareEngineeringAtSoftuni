namespace P08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> reservationNumbers = new HashSet<string>();

            while (true)
            {
                input = Console.ReadLine();

                if (input == "PARTY" || input == "END")
                {
                    break;
                }

                reservationNumbers.Add(input);
            }

            if (input == "PARTY")
            {
                while (true)
                {
                    input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    reservationNumbers.Remove(input);
                }
            }

            Console.WriteLine(reservationNumbers.Count);

            foreach (string reservationNumber in reservationNumbers)
            {
                if (char.IsDigit(reservationNumber[0]))
                {
                    Console.WriteLine(reservationNumber);
                }
            }

            foreach (string reservationNumber in reservationNumbers)
            {
                if (char.IsLetter(reservationNumber[0]))
                {
                    Console.WriteLine(reservationNumber);
                }
            }
        }
    }
}