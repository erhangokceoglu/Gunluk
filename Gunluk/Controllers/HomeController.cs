using Gunluk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gunluk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? KategoriId)
        {
            IQueryable<Gonderi> gonderiler = _db.Gonderiler;

            if (KategoriId != null)
            {
                gonderiler = gonderiler.Where(x => x.KategoriId == KategoriId);
                ViewBag.Baslik = _db.Kategoriler.Find(KategoriId)?.Ad;

            }

            return View(gonderiler.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}