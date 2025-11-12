using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeManager.Models;
namespace RecipeManager.Persistence
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        List<Category> GetAllCategories();
        void UpdateCategory(Category category);
    }
}