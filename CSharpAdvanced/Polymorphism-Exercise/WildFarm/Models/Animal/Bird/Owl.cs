using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Bird
{
    public class Owl : Bird
    {
        private const double OwlWeightMultiPlier = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightMultiPlier => OwlWeightMultiPlier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes 
            => new HashSet<Type> {typeof(Meat) };

        public override string ProduceSound() 
        => "Hoot Hoot";
    }
}
