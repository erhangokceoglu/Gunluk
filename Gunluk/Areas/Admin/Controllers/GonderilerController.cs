﻿using Gunluk.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Gunluk.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GonderilerController : Controller
    {
        private readonly UygulamaDbContext _db;

        public GonderilerController(UygulamaDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Gonderiler.Include(x=>x.Kategori).ToList());
        }
    }
}
