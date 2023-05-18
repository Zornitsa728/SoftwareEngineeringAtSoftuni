using System;

namespace P05.MovieRatings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countMovies = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            string maxRatingMovie = string.Empty;
            string minRatingMovie = string.Empty;
            double sumRating = 0;
            for (int i = 0; i < countMovies; i++)
            {
                string movieName = Console.ReadLine();  
                double rating = double.Parse(Console.ReadLine());

                if (rating > maxRating)
                {
                    maxRating = rating;
                    maxRatingMovie = movieName;
                }

                if (rating < minRating)
                {
                    minRating = rating;
                    minRatingMovie = movieName;
                }

                sumRating += rating;
            }

            Console.WriteLine($"{maxRatingMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRatingMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {sumRating/countMovies:f1}");
        }
    }
}
