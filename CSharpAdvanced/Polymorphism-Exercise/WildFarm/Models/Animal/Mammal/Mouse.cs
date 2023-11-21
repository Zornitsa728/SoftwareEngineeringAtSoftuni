using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Mammal
{
    public class Mouse : Mammal
    {
        private const double MouseWeightMultiPlier = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultiPlier
            => MouseWeightMultiPlier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes
            => new HashSet<Type> { typeof(Vegetable), typeof(Fruit) };

        public override string ProduceSound()
        => "Squeak";
    }
}
