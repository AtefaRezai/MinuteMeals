using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Core;
using MinuteMeals.Models;
using System.Diagnostics;

namespace MinuteMeals.Controllers
{
    public class HomeController(MinuteMealDbContext dbContext) : Controller
    {
        public IActionResult Index()
        {
            var recipe = dbContext.Recipes.ToList();
            
            return View(recipe);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var recipe = dbContext.Recipes.FirstOrDefault(r => r.Id == id);

            if (recipe == null)
                return NotFound();

            return View(recipe);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
