using System;

namespace RecipeManager.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RecipeId { get; set; }
    public List<Recipe>? Recipes { get; set; } = default;
}
