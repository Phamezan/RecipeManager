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

        public void DeleteRecipe(int id)
        {
            var recipe = _context.Recipes.Find(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
                _context.SaveChanges();
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
