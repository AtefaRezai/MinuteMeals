using Microsoft.EntityFrameworkCore;
using MinuteMeals.Models;

namespace MinuteMeals.Core
{
    public class MinuteMealDbContext(DbContextOptions<MinuteMealDbContext> options) : DbContext(options)
    {
        public DbSet<Recipe> Recipes => Set<Recipe>();

        public void GenerateDemoData()
        {
            var recipe = new List<Recipe>
            {
            new () { Name = "Spaghetti Bolognese", CookingTimeInMinutes = 30, Ingredients = "Pasta, gehakt, tomatensaus", Steps = "Kook pasta, bak gehakt, meng saus" },
            new () { Name = "Pannenkoeken", CookingTimeInMinutes = 20, Ingredients = "Bloem, melk, eieren", Steps = "Meng alles, bak in pan" },
            new () { Name = "Omelet", CookingTimeInMinutes = 10, Ingredients = "Eieren, peper, zout", Steps = "Klop eieren, bak in pan" },
            new () { Name = "Caesar Salad", CookingTimeInMinutes = 15, Ingredients = "Sla, kip, croutons", Steps = "Meng ingrediënten" },
            new () { Name = "Chili con Carne", CookingTimeInMinutes = 40, Ingredients = "Bonen, gehakt, tomaten", Steps = "Bak, laat sudderen" },
            new () { Name = "Pizza Margherita", CookingTimeInMinutes = 25, Ingredients = "Deeg, tomatensaus, mozzarella", Steps = "Beleg en bak" },
            new () { Name = "Soep van de dag", CookingTimeInMinutes = 35, Ingredients = "Groenten, bouillon", Steps = "Kook alles samen" },
            new () { Name = "Wraps", CookingTimeInMinutes = 15, Ingredients = "Wraps, kip, groenten", Steps = "Vul wraps" },
            new () { Name = "Rijst met groenten", CookingTimeInMinutes = 25, Ingredients = "Rijst, groenten", Steps = "Kook rijst, bak groenten" },
            new () { Name = "Griekse salade", CookingTimeInMinutes = 10, Ingredients = "Tomaat, komkommer, feta", Steps = "Snij en meng" }
            };

          Recipes.AddRange(recipe);
            SaveChanges();
       
        
        }
    }
}
