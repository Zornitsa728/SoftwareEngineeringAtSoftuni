using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animal.Feline
{
    public abstract class Feline : Animal, IFeline
    {
        protected Feline(string name, double weight, string breed, string livingRegion) 
            : base(name, weight)
        {
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public string Breed { get; private set; }

        public string LivingRegion {get; private set;}

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
