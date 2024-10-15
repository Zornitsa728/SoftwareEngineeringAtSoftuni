using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels.Cinema;
using CinemaApp.Web.ViewModels.Movie;
using CInemaApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Web.Controllers
{
    public class CinemaController : BaseController
    {
        private readonly CinemaDbContext dbContext;

        public CinemaController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<CinemaIndexViewModel> cinemas = this.dbContext
                .Cinemas
                .Select(c => new CinemaIndexViewModel()
                {
                    Id = c.Id.ToString(), //id to string cuz it's guid
                    Name = c.Name,
                    Location = c.Location,
                    ImageUrl = c.ImageUrl
                })
            .ToArray();

            return View(cinemas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CinemaCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Cinema cinema = new Cinema
            {
                Name = model.Name,
                Location = model.Location,
                ImageUrl = "/images/default-cinema.jpg"
            };

            dbContext.Cinemas.AddAsync(cinema);
            dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(string? id)
        {
            Guid cinemaGuid = Guid.Empty;
            bool isIdValid = this.IsGuidValid(id, ref cinemaGuid);

            if (!isIdValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Cinema? cinema = await this.dbContext
               .Cinemas
               .Include(c => c.CinemaMovies)
               .ThenInclude(cm => cm.Movie)
               .FirstOrDefaultAsync(c => c.Id == cinemaGuid);

            // Invalid(non-existing) GUID in the URL
            if (cinema == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            CinemaDetailsViewModel viewModel = new CinemaDetailsViewModel()
            {
                Name = cinema.Name,
                Location = cinema.Location,
                Movies = cinema.CinemaMovies
                    .Where(cm => cm.IsDeleted == false)
                    .Select(cm => new MovieProgramViewModel()
                    {
                        Title = cm.Movie.Title,
                        Duration = cm.Movie.Duration,
                    })
                    .ToArray()
            };

            return this.View(viewModel);
        }

    }

}




