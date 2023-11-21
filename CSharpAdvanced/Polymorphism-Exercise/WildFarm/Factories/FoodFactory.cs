using WildFarm.Factories.Interfaces;
using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string[] foodTokens)
        {
            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(foodQuantity);
                case "Fruit":
                    return new Fruit(foodQuantity);
                case "Meat":
                    return new Meat(foodQuantity);
                case "Seeds":
                    return new Seeds(foodQuantity);
                default:
                    throw new Exception("Invalid food type");
            }
        }
    }
}
