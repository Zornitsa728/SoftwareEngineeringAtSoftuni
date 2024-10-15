namespace CinemaApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Movie
        {
            public const int TitleMinLength = 1;

            public const int TitleMaxLength = 50;

            public const int GenreMinLength = 4;

            public const int GenreMaxLength = 50;

            public const int DirectorNameMinLength = 10;

            public const int DirectorNameMaxLength = 100;

            public const int DurationMinLength = 1;

            public const int DurationMaxLength = 999;

            public const int DescriptionMinLength = 50;

            public const int DescriptionMaxLength = 500;

            public const string ReleaseDateFormat = "MM/yyyy";
        }

        public static class Cinema
        {
            public const int CinemaNameMinLength = 3;

            public const int CinemaNameMaxLength = 100;

            public const int LocationMinLength = 3;

            public const int LocationMaxLength = 85;
        }

    }
}
