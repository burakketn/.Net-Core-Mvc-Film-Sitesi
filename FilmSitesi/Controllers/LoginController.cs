using FilmSitesi.Data;
using FilmSitesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmSitesi.Controllers
{
    public class LoginController : Controller
    {
        private readonly FilmDbContext _dbContext; //burda veritabanı çağrılıyor
        //ardından ctrl+nokta yapınca constractır ekliyoruz
        public LoginController(FilmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm]LoginModel model)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            if (user != null)
            {
                return RedirectToAction("Index","Film");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya şifre hatalı";
            }
            return View();
        }
    }
}
