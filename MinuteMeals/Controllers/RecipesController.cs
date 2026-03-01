using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Core;

namespace MinuteMeals.Controllers
{
    public class RecipesController (MinuteMealDbContext dbContext): Controller
    {
        public IActionResult Index()
        {
            var recipes = dbContext.Recipes.ToList();
            return View(recipes);
        }
    }
}



