using System.Text;

namespace Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            string[] input = Console.ReadLine()
                .Split(", ");

            foreach (string inputItem in input)
            {
                try
                {
                    string[] currCard = inputItem.Split(" ");
                    Card card = new Card(currCard[0], currCard[1]);
                    cards.Add(card);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.OutputEncoding = Encoding.UTF8;

            foreach (Card card in cards)
            {
                Console.Write(card.ToString());
            }

        }
    }

}