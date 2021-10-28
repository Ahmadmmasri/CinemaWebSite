using CinemaWebSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ActorsController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Actors.ToList();
            return View(data);
        }
    }
}
