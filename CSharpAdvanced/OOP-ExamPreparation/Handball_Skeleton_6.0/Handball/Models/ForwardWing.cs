namespace Handball.Models
{
    public class ForwardWing : Player
    {
        private const double InitialRating = 5.5;

        public ForwardWing(string name) : base(name, InitialRating)
        {
        }

        public override void DecreaseRating()
        {
            Rating -= 0.75;
        }

        public override void IncreaseRating()
        {
            Rating += 1.25;
        }
    }
}
