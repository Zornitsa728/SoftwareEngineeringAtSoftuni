namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personData = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] productData = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            List<Product> products = new List<Product>();

            try
            {
                for (int i = 0; i < personData.Length; i++)
                {
                    string[] currPerson = personData[i].Split("=");
                    string name = currPerson[0];
                    decimal money = decimal.Parse(currPerson[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }

                for (int i = 0; i < productData.Length; i++)
                {
                    string[] currProduct = productData[i].Split("=");
                    string name = currProduct[0];
                    decimal cost = decimal.Parse(currProduct[1]);
                    Product product = new Product(name, cost);
                    products.Add(product);
                }

                string input = string.Empty;

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personName = tokens[0];
                    string productName = tokens[1];

                    Person person = people.FirstOrDefault(p => p.Name == personName);
                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    person.AddProduct(person, product);
                }
                
                foreach (Person person in people)
                {
                    if (person.BagOfProducts.Any())
                    {
                       Console.WriteLine($"{person.Name} - {string.Join(", ",person.BagOfProducts)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}