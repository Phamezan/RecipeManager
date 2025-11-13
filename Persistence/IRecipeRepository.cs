using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeManager.Models;

namespace RecipeManager.Persistence
{
    public interface IRecipeRepository
    {
        void AddRecipe(Recipe recipe);
        Recipe GetRecipeById(int id);
        List<Recipe> GetAllRecipes();
        void UpdateRecipe(Recipe recipe);
        Task DeleteRecipe(int id);

    }
}