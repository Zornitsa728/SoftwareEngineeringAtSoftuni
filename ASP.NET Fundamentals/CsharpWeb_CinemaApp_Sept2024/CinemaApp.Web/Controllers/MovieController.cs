using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels.Cinema;
using CinemaApp.Web.ViewModels.Movie;
using CInemaApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static CinemaApp.Common.EntityValidationConstants.Movie;

namespace CinemaApp.Web.Controllers
{
    public class MovieController : BaseController
    {
        private readonly CinemaDbContext dbContext;

        public MovieController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> allMovies = await dbContext
                .Movies
                .ToArrayAsync();

            return View(allMovies);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddMovieInputModel inputModel)
        {

            bool isReleaseDateValid = DateTime.TryParseExact(inputModel.ReleaseDate, ReleaseDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);

            if (!isReleaseDateValid)
            {
                this.ModelState.AddModelError(nameof(inputModel.ReleaseDate), "The Release Date must be in the following format: MM/yyyy");
            }

            if (!this.ModelState.IsValid)
            {
                // Render the same form with user entered values + model errors
                return this.View(inputModel);
            }

            Movie movie = new Movie()
            {
                Title = inputModel.Title,
                Genre = inputModel.Genre,
                ReleaseDate = releaseDate,
                Director = inputModel.Director,
                Duration = inputModel.Duration,
                Description = inputModel.Description,
            };

            await dbContext.Movies.AddAsync(movie);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Guid movieGuid = Guid.Empty;
            bool isGuidValid = IsGuidValid(id, ref movieGuid);

            Movie movie = await dbContext.Movies.FirstOrDefaultAsync(m => m.Id == movieGuid);

            return movie == null ? NotFound() : View(movie);
        }

        [HttpGet]
        public async Task<IActionResult> AddToProgram(string? id)
        {
            Guid movieGuid = Guid.Empty;
            bool isGuidValid = IsGuidValid(id, ref movieGuid);

            if (!isGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Movie? movie = await dbContext
                .Movies
                .FirstOrDefaultAsync(m => m.Id == movieGuid);

            if (movie == null)
            {
                return RedirectToAction(nameof(Index));
            }

            AddMovieToCinemaInputModel viewModel = new AddMovieToCinemaInputModel()
            {
                Id = id!,
                MovieTitle = movie.Title,
                Cinemas = await this.dbContext
                .Cinemas
                .Include(c => c.CinemaMovies)
                .ThenInclude(cm => cm.Movie)
                .Select(c => new CinemaCheckBoxItemInputModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    Location = c.Location,
                    IsSelected = c.CinemaMovies
                    .Any(cm => cm.MovieId == movieGuid)
                })
                .ToArrayAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToProgram(AddMovieToCinemaInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Guid movieGuid = Guid.Empty;
            bool isGuidValid = IsGuidValid(model.Id, ref movieGuid);

            if (!isGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Movie? movie = await this.dbContext
                .Movies
                .FirstOrDefaultAsync(m => m.Id == movieGuid);

            if (movie == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Guid cinemaGuid = Guid.Empty;

            ICollection<CinemaMovie> entitiesToAdd = new List<CinemaMovie>();
            ICollection<CinemaMovie> entitiesToRemove = new List<CinemaMovie>();


            foreach (CinemaCheckBoxItemInputModel cinemaInputModel in model.Cinemas)
            {
                bool isCinemaGuidValid = IsGuidValid(cinemaInputModel.Id, ref cinemaGuid);

                if (!isCinemaGuidValid)
                {
                    this.ModelState.AddModelError(string.Empty, "Invalid cinema selected!");
                    return View(model);
                }

                Cinema? cinema = await dbContext
                    .Cinemas
                    .FirstOrDefaultAsync(c => c.Id == cinemaGuid);

                if (cinema == null)
                {
                    this.ModelState.AddModelError(string.Empty, "Invalid cinema selected!");
                    return View(model);
                }

                CinemaMovie? cinemaMovie = dbContext.CinemasMovies.FirstOrDefault(cm => cm.MovieId == movieGuid && cm.CinemaId == cinemaGuid);

                if (cinemaInputModel.IsSelected)
                {
                    if (cinemaMovie == null)
                    {
                        entitiesToAdd.Add(new CinemaMovie()
                        {
                            MovieId = movieGuid,
                            CinemaId = cinemaGuid,
                        });
                    }
                    else
                    {
                        cinemaMovie.IsDeleted = false;
                    }
                }
                else
                {
                    if (cinemaMovie != null)
                    {
                        cinemaMovie.IsDeleted = true;
                    }
                }
            }

            await this.dbContext.CinemasMovies.AddRangeAsync(entitiesToAdd);
            await this.dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index), "Cinema");
        }
    }
}
