using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Mammal
{
    public class Dog : Mammal
    {
        private const double DogWeightMultiPlier = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultiPlier
           => DogWeightMultiPlier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes
            => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound()
        => "Woof!";
    }
}
