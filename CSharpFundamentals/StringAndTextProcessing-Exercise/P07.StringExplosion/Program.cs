namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int leftPower = 0;
            int count = 0;

            for (int explosion = input.IndexOf('>'); explosion < input.Length;)
            {
                int explosionPower = (input[explosion + 1] - '0') + leftPower; // how many symbols should be removed
                count = 0;

                if (explosion + 1 < input.Length) // checks if there is something to explode furder
                {
                    int explosionDamage = explosion + explosionPower;

                    if (explosionDamage >= input.Length)// check if damage power is in range, if not we're making it till the last element
                    {
                        explosionDamage = input.Length - 1;
                        explosionPower = explosionDamage - explosion;
                    }

                    if (input.IndexOf('>', explosion + 1, explosionPower) != -1) // check if any element in the damage section may be another bomb 
                    { // if there is another bomb we stop there and calculate the left power so we can add it the next time
                        int oldExplPower = explosionPower;
                        explosionPower = input.IndexOf('>', explosion + 1) - (explosion + 1);
                        leftPower = oldExplPower - explosionPower;
                    }
                    
                    input = input.Remove(explosion + 1, explosionPower); 
                }

                explosion = input.IndexOf('>', explosion + 1); // finds the next bomb index

                if (explosion == -1) // checks if there is a bomb, if not gives -1
                {
                    break;
                }
            }

            Console.WriteLine(input);
        }
    }
}