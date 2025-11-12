using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeManager.Data;
using RecipeManager.Models;

namespace RecipeManager.Persistence
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RecipeContext _context;
        public CategoryRepository(RecipeContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}