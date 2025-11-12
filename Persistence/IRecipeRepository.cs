using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeManager.Models;

namespace Persistence
{
    public interface IRecipeRepository
    {
        void AddRecipe(Recipe recipe);
        Recipe GetRecipeById(int id);
        List<Recipe> GetAllRecipes();
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);

    }
}