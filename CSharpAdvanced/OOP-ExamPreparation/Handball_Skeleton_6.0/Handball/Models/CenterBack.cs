namespace Handball.Models
{
    public class CenterBack : Player
    {
        private const double InitialRating = 4;

        public CenterBack(string name) : base(name, InitialRating)
        {
        }

        public override void DecreaseRating()
        {
            Rating -= 1;
        }

        public override void IncreaseRating()
        {
            Rating += 1;
        }
    }
}
