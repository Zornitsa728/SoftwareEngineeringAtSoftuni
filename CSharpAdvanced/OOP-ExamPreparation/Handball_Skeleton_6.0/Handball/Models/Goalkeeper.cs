namespace Handball.Models
{
    public class Goalkeeper : Player
    {
        private const double InitialRating = 2.5;

        public Goalkeeper(string name) : base(name, InitialRating)
        {
        }

        public override void DecreaseRating()
        {
            Rating -= 1.25;
        }

        public override void IncreaseRating()
        {
            Rating += 0.75;
        }
    }
}
