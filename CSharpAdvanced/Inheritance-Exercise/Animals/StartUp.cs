using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> listOfAnimals = new List<Animal>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string animalType = input.Trim();
                string[] animalInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (animalInfo.Length != 3)
                {
                    if (animalType != "Kitten" && animalType != "Tomcat")
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }

                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                                Dog dog = new Dog(name, age, animalInfo[2]);
                                listOfAnimals.Add(dog);
                            break;
                        case "Frog":
                                Frog frog = new Frog(name, age, animalInfo[2]);
                                listOfAnimals.Add(frog);
                            break;
                        case "Cat":
                                Cat cat = new Cat(name, age, animalInfo[2]);
                                listOfAnimals.Add(cat);
                            break;
                        case "Kitten":
                                Kitten kitten = new Kitten(name, age);
                                listOfAnimals.Add(kitten);
                            break;
                        case "Tomcat":
                                Tomcat tomcat = new Tomcat(name, age);
                                listOfAnimals.Add(tomcat);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            }

            foreach (Animal animal in listOfAnimals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
