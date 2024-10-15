using CinemaApp.Web.ViewModels.Movie;

namespace CinemaApp.Web.ViewModels.Cinema
{
    public class CinemaDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public string Location { get; set; } = null!;

        public IEnumerable<MovieProgramViewModel> Movies { get; set; } =
            new HashSet<MovieProgramViewModel>();
    }
}
