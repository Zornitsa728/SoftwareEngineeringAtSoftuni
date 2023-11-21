using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IHeroFactory heroFactory;

        private readonly ICollection<BaseHero> heroes;
        public Engine(IReader reader, IWriter writer, IHeroFactory heroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroFactory = heroFactory;

            heroes = new List<BaseHero>();
        }
        public void Run()
        {
            int count = int.Parse(reader.ReadLine());

            for (int i = 0; i < count; i++)
            {
                try
                {
                    heroes.Add(CreateHero());
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                writer.WriteLine(hero.CastAbility());
            }

            if (heroes.Sum(h => h.Power) >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }

        private BaseHero CreateHero()
        {

            string heroName = reader.ReadLine();
            string heroType = reader.ReadLine();

            BaseHero hero = heroFactory.Create(heroType, heroName);

            return hero;
        }
    }
}
