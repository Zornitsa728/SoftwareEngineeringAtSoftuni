using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Feline
{
    public class Tiger : Feline
    {
        private const double TigerWeightMultiPlier = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, breed, livingRegion)
        {
        }

        protected override double WeightMultiPlier
        => TigerWeightMultiPlier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes
            => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound()
        => "ROAR!!!";
    }
}
