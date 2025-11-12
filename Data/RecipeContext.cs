using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Models;

namespace RecipeManager.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Category)
                .WithMany(c => c.Recipes);

            #region Seed Data
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Breakfast" },
                new Category { CategoryId = 2, Name = "Lunch" },
                new Category { CategoryId = 3, Name = "Dinner" },
                new Category { CategoryId = 4, Name = "Dessert" }
            );

            // Seed Recipes
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    RecipeId = 1,
                    Name = "Pancakes",
                    PrepTime = "20 mins",
                    Servings = 4,
                    FilePath = null,
                    Description = "Fluffy homemade pancakes.",
                    Ingredients = "Flour, Eggs, Milk, Sugar, Baking Powder",
                    Instructions = "Mix ingredients, cook on skillet.",
                    CategoryId = 1
                },
                new Recipe
                {
                    RecipeId = 2,
                    Name = "Omelette",
                    PrepTime = "10 mins",
                    Servings = 2,
                    FilePath = null,
                    Description = "Classic cheese omelette.",
                    Ingredients = "Eggs, Cheese, Salt, Pepper",
                    Instructions = "Beat eggs, cook with cheese.",
                    CategoryId = 1
                },
                new Recipe
                {
                    RecipeId = 3,
                    Name = "Grilled Cheese Sandwich",
                    PrepTime = "15 mins",
                    Servings = 1,
                    FilePath = null,
                    Description = "Golden grilled cheese sandwich.",
                    Ingredients = "Bread, Cheese, Butter",
                    Instructions = "Butter bread, grill with cheese.",
                    CategoryId = 2
                },
                new Recipe
                {
                    RecipeId = 4,
                    Name = "Caesar Salad",
                    PrepTime = "15 mins",
                    Servings = 2,
                    FilePath = null,
                    Description = "Fresh Caesar salad with dressing.",
                    Ingredients = "Lettuce, Croutons, Caesar Dressing",
                    Instructions = "Mix lettuce, add dressing and croutons.",
                    CategoryId = 2
                },
                new Recipe
                {
                    RecipeId = 5,
                    Name = "Spaghetti Bolognese",
                    PrepTime = "45 mins",
                    Servings = 4,
                    FilePath = null,
                    Description = "Classic Italian pasta dish.",
                    Ingredients = "Spaghetti, Ground Beef, Tomato Sauce",
                    Instructions = "Cook pasta, prepare sauce, mix together.",
                    CategoryId = 3
                },
                new Recipe
                {
                    RecipeId = 6,
                    Name = "Chicken Curry",
                    PrepTime = "60 mins",
                    Servings = 4,
                    FilePath = null,
                    Description = "Spicy chicken curry.",
                    Ingredients = "Chicken, Curry Paste, Coconut Milk",
                    Instructions = "Cook chicken, add curry paste and coconut milk.",
                    CategoryId = 3
                },
                new Recipe
                {
                    RecipeId = 7,
                    Name = "Chocolate Cake",
                    PrepTime = "90 mins",
                    Servings = 8,
                    FilePath = null,
                    Description = "Rich chocolate cake.",
                    Ingredients = "Flour, Cocoa Powder, Sugar, Eggs",
                    Instructions = "Mix ingredients, bake in oven.",
                    CategoryId = 4
                },
                new Recipe
                {
                    RecipeId = 8,
                    Name = "Fruit Salad",
                    PrepTime = "10 mins",
                    Servings = 2,
                    FilePath = null,
                    Description = "Healthy fruit salad.",
                    Ingredients = "Apples, Bananas, Grapes, Oranges",
                    Instructions = "Chop fruits, mix together.",
                    CategoryId = 4
                },
                new Recipe
                {
                    RecipeId = 9,
                    Name = "Tacos",
                    PrepTime = "30 mins",
                    Servings = 3,
                    FilePath = null,
                    Description = "Mexican-style tacos.",
                    Ingredients = "Tortillas, Beef, Lettuce, Cheese",
                    Instructions = "Cook beef, assemble tacos.",
                    CategoryId = 3
                },
                new Recipe
                {
                    RecipeId = 10,
                    Name = "French Toast",
                    PrepTime = "20 mins",
                    Servings = 2,
                    FilePath = null,
                    Description = "Sweet French toast.",
                    Ingredients = "Bread, Eggs, Milk, Cinnamon",
                    Instructions = "Dip bread in egg mixture, fry until golden.",
                    CategoryId = 1
                }
            );
            #endregion


            base.OnModelCreating(modelBuilder);
        }

    }
}