using MyCookBookApi.Models;
using System.Collections.Generic;

namespace MyCookBookApi.Services
{
    public interface IRecipeService
    {
        // Retrieves all recipes from the repository
        List<Recipe> GetAllRecipes();

        // Retrieves a specific recipe by its ID
        Recipe GetRecipeById(string id);

        // Adds a new recipe to the repository
        void AddRecipe(Recipe recipe);

        // Updates an existing recipe in the repository
        bool UpdateRecipe(string id, Recipe recipe);

        // Deletes a recipe from the repository
        bool DeleteRecipe(string id);

        // Searches for recipes matching specific criteria
        List<Recipe> SearchRecipes(RecipeSearchRequest searchRequest);
    }
}
