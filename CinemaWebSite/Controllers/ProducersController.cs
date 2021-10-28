using CinemaWebSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProducersController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _dbContext.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
