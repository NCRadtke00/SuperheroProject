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
            List<Superheros> superheroes = context.Superheroes.ToList();
            return View(superheroes);
        }
        public IActionResult Details(int id)
        {
            var superhero = context.Superheroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superhero);
        }
        public IActionResult Create()
        { }



    }
}
