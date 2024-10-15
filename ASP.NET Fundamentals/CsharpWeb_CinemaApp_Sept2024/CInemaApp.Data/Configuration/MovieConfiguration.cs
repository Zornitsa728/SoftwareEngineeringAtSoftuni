using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static CinemaApp.Common.EntityValidationConstants.Movie;

namespace CInemaApp.Data.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder.Property(m => m.Genre)
                .IsRequired()
                .HasMaxLength(GenreMaxLength);

            builder.Property(m => m.Director)
                .IsRequired()
                .HasMaxLength(DirectorNameMaxLength);

            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            builder.HasData(this.SeedMovies());
        }

        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie()
                {
                    Title = "Harry Potter and the Goblet of Fire",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2005,11,01),
                    Director = "Mike Newel",
                    Duration = 157,
                    Description = "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister."
                },
                new Movie()
                {
                    Title = "Twilight",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2008,10,01),
                    Director = "Catherine Hardwicke",
                    Duration = 121,
                    Description = "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series."
                }
            };

            return movies;
        }
    }
}
