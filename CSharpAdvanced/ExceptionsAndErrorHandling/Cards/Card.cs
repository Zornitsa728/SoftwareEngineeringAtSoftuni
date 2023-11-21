using System.Net.Security;

namespace Cards
{
    public class Card
    {
        private string face;

        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get { return face; }
            set
            {
                if (value == "J" || value == "Q" || value == "K" || value == "A")
                {
                    face = value;
                }
                else if (!int.TryParse(value, out int id))
                {
                    throw new ArgumentException("Invalid card!");
                }

                for (int i = 2; i <= 10; i++)
                {
                    if (value == i.ToString())
                    {
                        face = value;
                    }
                }
            }
        }

        public string Suit
        {
            get { return suit; }
            set
            {
                if (value == "S")
                {
                    suit = "\u2660";
                }
                else if (value == "H")
                {
                    suit = "\u2665";
                }
                else if (value == "D")
                {
                    suit = "\u2666";
                }
                else if (value == "C")
                {
                    suit = "\u2663";
                }
                else
                {
                    throw new ArgumentException("Invalid card!");
                }
            }
        }
        public override string ToString()
        {
            return $"[{face}{suit}] ";
        }
    }
}

