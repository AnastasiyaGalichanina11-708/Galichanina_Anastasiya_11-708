using Microsoft.EntityFrameworkCore.Migrations;

namespace Restorans.Migrations
{
    public partial class ReviewRecipeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Recipes");
        }
    }
}
