using Microsoft.EntityFrameworkCore.Migrations;

namespace FamousPortal.Migrations
{
    public partial class FamousPortal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    mealId = table.Column<int>(nullable: false),
                    categoryId = table.Column<int>(nullable: false),
                    mealName = table.Column<string>(nullable: true),
                    mealPrice = table.Column<int>(nullable: false),
                    mealDescription = table.Column<string>(nullable: true),
                    nutritionValues = table.Column<string>(nullable: true),
                    available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meal");
        }
    }
}
