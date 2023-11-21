using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;

        private readonly ICollection<IAnimal> animals;
        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;

            animals = new List<IAnimal>();
        }
        public void Run()
        {
            string cmd;
            while ((cmd = reader.ReadLine()) != "End")
            {
                IAnimal animal = null;

                try
                {
                    animal = CreateAnimal(cmd);
                    IFood food = CreateFood(reader.ReadLine());

                    writer.WriteLine(animal.ProduceSound());

                    animal.Eat(food);

                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }

                if (animal != null)
                {
                    animals.Add(animal);
                }
            }

            foreach (IAnimal animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }

        private IAnimal CreateAnimal(string cmd)
        {
            string[] animalTokens = cmd
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IAnimal animal = animalFactory.CreateAnimal(animalTokens);

            return animal;
        }

        private IFood CreateFood(string foodArgs)
        {
            string[] foodTokens = foodArgs
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IFood food = foodFactory.CreateFood(foodTokens);

            return food;
        }
    }
}
