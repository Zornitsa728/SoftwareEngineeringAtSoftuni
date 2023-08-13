namespace P01.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            string letters = "xhcchoxu";
            int maxLen = 1;
            // search from the first letter to the end to find two identical, if they're not we continue with the second to the end and so on ... 
            for (int j = 0; j < letters.Length - 1; j++)
            {
                for (int k = 1; k < letters.Length - 1; k++)
                {
                    maxLen = Math.Max(maxLen, PalindromeLen(letters, j, k + 1));
                }
            }
            Console.WriteLine(maxLen);


        }

        static int PalindromeLen(string letters, int leftIndex, int rightIndex)
        {
            while (leftIndex >= 0 && rightIndex < letters.Length && letters[leftIndex] == letters[rightIndex])
            { // checking if we have two identical letters and if they're indexes are valid
                string substring = letters.Substring(leftIndex, rightIndex - leftIndex + 1);
                char[] reversing = substring.Reverse().ToArray(); 
                string reversed = string.Empty;
                // checking if the letters between the indexes are valid to be palindrome
                foreach (char c in reversing)
                {
                    reversed += c;
                }

                if (substring == reversed) // if we have palindrome we gets it's length
                {
                    return rightIndex - leftIndex + 1;
                }
                else // if it's not we get the min value for palindrome (just one letter) and countinue with the search
                {
                    return 1;
                }
            }

            return 1;
        }
    }
}