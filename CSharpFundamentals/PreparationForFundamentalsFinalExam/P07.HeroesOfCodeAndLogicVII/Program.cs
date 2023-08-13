namespace P07.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countHeroes = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < countHeroes; i++)
            {
                string[] hero = Console.ReadLine()
                    .Split(" ");
                string name = hero[0];
                int hitPoints = int.Parse(hero[1]);
                int manaPoints = int.Parse(hero[2]);
                Hero currHero = new Hero (name, hitPoints, manaPoints);
                heroes.Add(currHero);
            }

            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd.Split(" - ");
                string operation = cmdArgs[0];
                string heroName = cmdArgs[1];
                Hero currHero = heroes.First(x => x.Name == heroName);

                if (operation == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (currHero.ManaPoints - mpNeeded >= 0)
                    {
                        currHero.ManaPoints -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {currHero.ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (operation == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    currHero.HitPoints -= damage;

                    if (currHero.HitPoints > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currHero.HitPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(currHero);
                    }
                }
                else if (operation == "Recharge")
                {
                    int amountMP = int.Parse(cmdArgs[2]);

                    if (currHero.ManaPoints + amountMP > 200)
                    {
                        amountMP = 200 - currHero.ManaPoints;
                        currHero.ManaPoints = 200;
                    }
                    else
                    {
                        currHero.ManaPoints += amountMP;
                    }

                    Console.WriteLine($"{heroName} recharged for {amountMP} MP!");
                }
                else if(operation == "Heal")
                {
                    int amountHP = int.Parse(cmdArgs[2]);

                    if (currHero.HitPoints + amountHP > 100)
                    {
                        amountHP = 100 - currHero.HitPoints;
                        currHero.HitPoints = 100;
                    }
                    else
                    {
                        currHero.HitPoints += amountHP;
                    }

                    Console.WriteLine($"{heroName} healed for {amountHP} HP!");
                }
            }

            foreach (Hero hero in heroes)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }

    public class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }
}