using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Superhero.Data;
using Superhero.Models;
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
            List<Superhero> superheroes = context.Superheroes.ToList();
            return View(superheroes);
        }
    }
}
