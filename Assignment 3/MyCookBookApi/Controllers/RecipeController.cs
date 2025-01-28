using Microsoft.AspNetCore.Mvc;
using MyCookBookApi.Models;

namespace MyCookBookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecipes()
        {
            var recipes = new List<Recipe>
            {
                new Recipe
                {
                    Name = "Spaghetti",
                    Ingredients = new List<string> { "Spaghetti", "Tomato Sauce", "Garlic" },
                    Steps = "Boil spaghetti. Heat sauce. Mix together."
                },
                new Recipe
                {
                    Name = "Grilled Cheese",
                    Ingredients = new List<string> { "Bread", "Cheese", "Butter" },
                    Steps = "Butter bread. Grill with cheese in between."
                }
            };

            return Ok(recipes);
        }

        [HttpPost("search")]
        public IActionResult Search([FromBody] RecipeSearchRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Query))
            {
                return BadRequest("Query cannot be empty.");
            }

            var recipes = new List<Recipe>
            {
                new Recipe
                {
                    Name = "Spaghetti",
                    Ingredients = new List<string> { "Spaghetti", "Tomato Sauce", "Garlic" },
                    Steps = "Boil spaghetti. Heat sauce. Mix together."
                },
                new Recipe
                {
                    Name = "Grilled Cheese",
                    Ingredients = new List<string> { "Bread", "Cheese", "Butter" },
                    Steps = "Butter bread. Grill with cheese in between."
                }
            };

            var results = recipes
                .Where(r => r.Name.Contains(request.Query, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(results);
        }
    }
}
