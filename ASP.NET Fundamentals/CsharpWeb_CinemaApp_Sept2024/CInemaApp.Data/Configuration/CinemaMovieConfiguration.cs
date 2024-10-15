using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CInemaApp.Data.Configuration
{
    public class CinemaMovieConfiguration : IEntityTypeConfiguration<CinemaMovie>
    {
        public void Configure(EntityTypeBuilder<CinemaMovie> builder)
        {
            builder.HasKey(cm => new { cm.MovieId, cm.CinemaId });

            builder.Property(cm => cm.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(cm => cm.Cinema)
                .WithMany(c => c.CinemaMovies)
                .HasForeignKey(cm => cm.CinemaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(cm => cm.Movie)
                .WithMany(m => m.CinemaMovies)
                .HasForeignKey(cm => cm.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
