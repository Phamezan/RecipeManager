using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipeManager.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrepTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name", "RecipeId" },
                values: new object[,]
                {
                    { 1, "Breakfast", 0 },
                    { 2, "Lunch", 0 },
                    { 3, "Dinner", 0 },
                    { 4, "Dessert", 0 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "Description", "FilePath", "Ingredients", "Instructions", "Name", "PrepTime", "Servings" },
                values: new object[,]
                {
                    { 1, 1, "Fluffy homemade pancakes.", null, "Flour, Eggs, Milk, Sugar, Baking Powder", "Mix ingredients, cook on skillet.", "Pancakes", "20 mins", 4 },
                    { 2, 1, "Classic cheese omelette.", null, "Eggs, Cheese, Salt, Pepper", "Beat eggs, cook with cheese.", "Omelette", "10 mins", 2 },
                    { 3, 2, "Golden grilled cheese sandwich.", null, "Bread, Cheese, Butter", "Butter bread, grill with cheese.", "Grilled Cheese Sandwich", "15 mins", 1 },
                    { 4, 2, "Fresh Caesar salad with dressing.", null, "Lettuce, Croutons, Caesar Dressing", "Mix lettuce, add dressing and croutons.", "Caesar Salad", "15 mins", 2 },
                    { 5, 3, "Classic Italian pasta dish.", null, "Spaghetti, Ground Beef, Tomato Sauce", "Cook pasta, prepare sauce, mix together.", "Spaghetti Bolognese", "45 mins", 4 },
                    { 6, 3, "Spicy chicken curry.", null, "Chicken, Curry Paste, Coconut Milk", "Cook chicken, add curry paste and coconut milk.", "Chicken Curry", "60 mins", 4 },
                    { 7, 4, "Rich chocolate cake.", null, "Flour, Cocoa Powder, Sugar, Eggs", "Mix ingredients, bake in oven.", "Chocolate Cake", "90 mins", 8 },
                    { 8, 4, "Healthy fruit salad.", null, "Apples, Bananas, Grapes, Oranges", "Chop fruits, mix together.", "Fruit Salad", "10 mins", 2 },
                    { 9, 3, "Mexican-style tacos.", null, "Tortillas, Beef, Lettuce, Cheese", "Cook beef, assemble tacos.", "Tacos", "30 mins", 3 },
                    { 10, 1, "Sweet French toast.", null, "Bread, Eggs, Milk, Cinnamon", "Dip bread in egg mixture, fry until golden.", "French Toast", "20 mins", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
