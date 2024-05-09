using FilmSitesi.Data;
using FilmSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmSitesi.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmDbContext _dbContext;

        public FilmController(FilmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var allFilms = await _dbContext.Films.ToListAsync();
            return View(allFilms);
        }

        [HttpPost]
        public async Task<int> Like([FromBody]LikeDislikeModel model) //gelen verileri karşılaması için
        {
            var film = await _dbContext.Films.FindAsync(model.FilmId);

            if (model.IsLike)
            {
                film.LikeCount++;
            }
            else
            {
                film.DislikeCount++;
            }
            await _dbContext.SaveChangesAsync();
            return 1;
        }

    }
}
