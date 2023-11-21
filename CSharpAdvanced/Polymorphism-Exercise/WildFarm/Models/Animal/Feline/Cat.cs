using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Feline
{
    public class Cat : Feline
    {
        private const double CatWeightMultiPlier = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, breed, livingRegion)
        {
        }

        protected override double WeightMultiPlier
         => CatWeightMultiPlier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes
            => new HashSet<Type> { typeof(Vegetable), typeof(Meat) };

        public override string ProduceSound()
        => "Meow";
    }
}
