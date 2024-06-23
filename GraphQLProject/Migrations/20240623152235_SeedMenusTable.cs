using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQLProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedMenusTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A juicy chicken burger with lettuce and cheese", "Classic Burger", 8.99m },
                    { 2, "Tomato, mozzarella, and basil pizza", "Margherita Pizza", 10.50m },
                    { 3, "Fresh garden salad with grilled chicken", "Grilled Chicken Salad", 7.95m },
                    { 4, "Creamy Alfredo sauce with fettuccine pasta", "Pasta Alfredo", 12.75m },
                    { 5, "Warm chocolate brownie with ice cream and fudge", "Chocolate Brownie Sundae", 6.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
