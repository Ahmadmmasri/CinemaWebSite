using CinemaWebSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public MoviesController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _dbContext.Movies.Include(x=>x.Cinema).OrderBy(x=>x.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
