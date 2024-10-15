namespace CinemaApp.Common
{
    using static CinemaApp.Common.EntityValidationConstants.Movie;
    public static class EntityValidationMessages
    {
        public static class Movie
        {
            public const string TitleRequiredMessage = "Movie title is required";

            public const string GenreRequiredMessage = "Genre is required";

            public const string ReleaseDateMessage = $"Release date is required in format {ReleaseDateFormat}";

            public const string DirectorRequiredMessage = "Director name is required";

            public const string DurationRequiredMessage = "Please specify movie duration.";
        }
    }
}
