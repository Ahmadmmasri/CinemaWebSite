using CinemaWebSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CinemasController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemass = await _dbContext.Cinemas.ToListAsync();
            return View(allCinemass);
        }
    }
}
