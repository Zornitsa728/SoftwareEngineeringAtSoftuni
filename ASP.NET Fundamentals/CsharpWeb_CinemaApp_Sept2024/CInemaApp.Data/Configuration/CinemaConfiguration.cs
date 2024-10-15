using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static CinemaApp.Common.EntityValidationConstants.Cinema;

namespace CInemaApp.Data.Configuration
{
    public class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(CinemaNameMaxLength);

            builder.Property(c => c.Location)
                .IsRequired()
                .HasMaxLength(LocationMaxLength);

            builder.HasData(this.GenerateCinemas());
        }

        private IEnumerable<Cinema> GenerateCinemas()
        {
            IEnumerable<Cinema> cinemas = new List<Cinema>()
            {
                new Cinema()
                {
                    Name = "Cinema City",
                    Location = "Ruse",
                    ImageUrl = "/images/cinema-ruse.jpg"

                },
                new Cinema()
                {
                    Name = "Cinema City",
                    Location = "Plovdiv",
                    ImageUrl = "/images/cinema-plovdiv.jpg"
                },
                new Cinema()
                {
                    Name = "CinemaMax",
                    Location = "Varna",
                    ImageUrl = "/images/cinema-varna.png"
                },
                new Cinema()
                {
                    Name = "Cinema",
                    Location = "Sofia",
                    ImageUrl = "/images/cinema-sofia.jpeg"
                }
            };

            return cinemas;
        }
    }
}
