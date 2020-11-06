using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Superhero.Controllers
{
    public class SuperheroController : Controller
    {
        public ApplicationDbContext context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
