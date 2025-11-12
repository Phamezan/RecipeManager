using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeManager.Models;

public class Recipe
{
    public int RecipeId { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public Category? Category { get; set; }
    [Required]
    public string PrepTime { get; set; } = string.Empty;
    public int Servings { get; set; }
    public string? FilePath { get; set; }
    [Required]
    public string Description { get; set; } = string.Empty;
    public string Ingredients { get; set; } = string.Empty;
    [Required]
    public string Instructions { get; set; } = string.Empty;
}
