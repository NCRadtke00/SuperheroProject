using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Superhero.Data;

namespace Superhero.Controllers
{
    public class SuperheroController : Controller
    {
        public ApplicationDbContext context;
        public SuperheroController(ApplicationDbContext db)
        {
            context = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
