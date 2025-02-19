using MyCookBookApi.Models;
using MyCookBookApi.Repositories;
using System.Collections.Generic;

namespace MyCookBookApi.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        // Constructor that injects the repository interface
        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        // Retrieves all recipes from the repository
        public List<Recipe> GetAllRecipes()
        {
            return _recipeRepository.GetAllRecipes();
        }

        // Retrieves a specific recipe by its ID
        public Recipe GetRecipeById(string id)
        {
            return _recipeRepository.GetRecipeById(id);
        }

        // Adds a new recipe to the repository
        public void AddRecipe(Recipe recipe)
        {
            // You might include additional business logic here before adding the recipe
            if (recipe == null || string.IsNullOrWhiteSpace(recipe.Name))
            {
                throw new System.ArgumentException("Recipe data is invalid");
            }

            _recipeRepository.AddRecipe(recipe);
        }

        // Updates an existing recipe in the repository
        public bool UpdateRecipe(string id, Recipe recipe)
        {
            if (recipe == null || string.IsNullOrWhiteSpace(recipe.Name))
            {
                throw new System.ArgumentException("Recipe data is invalid");
            }

            return _recipeRepository.UpdateRecipe(id, recipe);
        }

        // Deletes a recipe from the repository
        public bool DeleteRecipe(string id)
        {
            return _recipeRepository.DeleteRecipe(id);
        }

        // Searches for recipes matching specific criteria
        public List<Recipe> SearchRecipes(RecipeSearchRequest searchRequest)
        {
            if (searchRequest == null || string.IsNullOrWhiteSpace(searchRequest.Keyword) && (searchRequest.Categories == null || searchRequest.Categories.Count == 0))
            {
                throw new System.ArgumentException("Search parameters are invalid");
            }

            return _recipeRepository.SearchRecipes(searchRequest);
        }
    }
}
