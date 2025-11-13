using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Models;

namespace RecipeManager.Persistence
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeContext _context;
        public RecipeRepository(RecipeContext context)
        {
            _context = context;
        }
        public void AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public async Task DeleteRecipe(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
                await _context.SaveChangesAsync();
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            return _context.Recipes.Include(r => r.Category).ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.Include(r => r.Category).FirstOrDefault(r => r.RecipeId == id)!;
        }

        public void UpdateRecipe(Recipe recipe)
        {
            var recipeToUpdate = _context.Recipes.Find(recipe.RecipeId);
            if (recipeToUpdate == null)
            {
                throw new ArgumentException("Recipe not found");
            }
            _context.Recipes.Update(recipeToUpdate);
            _context.SaveChanges();
        }
    }
}
